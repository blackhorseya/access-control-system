using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu.CV.UI;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;

using System.IO;
using System.Xml;
using System.Runtime.InteropServices;
using System.Threading;
using System.Security.Principal;
using Microsoft.Win32.SafeHandles;
using System.IO.Ports;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace Access_Control_System
{
    public partial class Form1 : Form
    {
        #region Variables
        //Camera
        public int tmp_x = 0, tmp_y = 0, count = 0, recog_count = 0;
        public Boolean found = true;
        public System.Timers.Timer t;

        //EMGU CV
        Image<Bgr, Byte> currentFrame;
        Image<Gray, byte> result, gray_frame = null;
        Capture grabber;
        public HaarCascade Face = new HaarCascade(Application.StartupPath + "/Cascades/haarcascade_frontalface_alt2.xml");
        MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_COMPLEX, 0.5, 0.5);
        string name;

        //MySQL
        public MySqlConnection conn;
        public Boolean mysqlopen = false;

        //Serial
        public SerialPort serialport = new SerialPort();
        public SerialPort Arduino_Serial = new SerialPort();
        public Boolean serialportopen = false, ArduinoOpen = false;
        public int center_X = 0, center_Y = 0, send_X = 90, send_Y = 90;

        //Card
        public string customer_image_path = Application.StartupPath + @"\image\customer_image\";
        public string tmp_path = string.Empty;
        public OpenFileDialog image_path = new OpenFileDialog();
        public string hexmsbuff = string.Empty, card_id = string.Empty;
        public Boolean admin_permission = false, manage_activity = false, only_read = false, not_stop_read = true, recognizer = true, TFnotopen = true;
        public string[] customer = new string[8];
        //0:account
        //1:password
        //2:name
        //3:card_id
        //4:permission
        //5:state
        //6:image
        //7:join_time

        //class
        setting setting;
        class_mysql mysql = new class_mysql();
        rfid_reader rfid_reader = new rfid_reader();
        Classifier_Train Eigen_Recog = new Classifier_Train();
        Training_Form TF;
        #endregion

        public Form1()
        {
            InitializeComponent();

            //delay 1s
            t = new System.Timers.Timer(1000);
            t.Elapsed += new System.Timers.ElapsedEventHandler(SearchFace);
            t.Enabled = true;

            //Load of previus trainned faces and labels for each image
            if (Eigen_Recog.IsTrained)
            {
                message_bar.Text = "Training Data Loaded";
            }
            else
            {
                message_bar.Text = "No training data found, please train program using Train menu option";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //掃描tabcontrol
            foreach (System.Windows.Forms.TabPage tabc in tabControl1.TabPages)
            {
                tabc.Show();
            }

            //開始背景執行緒
            if (this.backgroundWorker1.WorkerReportsProgress != true)
            {
                this.backgroundWorker1.WorkerReportsProgress = true;
                this.backgroundWorker1.RunWorkerAsync();
            }

            //Show setting
            setting = new setting(this);
            setting.Show();
        }

        #region Show (Card ID and Activity Log)

        //顯示卡片ID在setting裡
        private void show_card_id_for_setting()
        {
            if (setting.radioButton1_hex.Checked)
            {
                if (hexmsbuff != null)
                {
                    setting.AddText(setting.MsgType.User, "Length：16\r\n");
                    setting.AddText(setting.MsgType.User, hexmsbuff + "\r\n");
                }
            }
            else if (setting.radioButton2_char.Checked)
            {
                if (card_id != null)
                {
                    setting.AddText(setting.MsgType.User, "Length：10\r\n");
                    setting.AddText(setting.MsgType.User, "ID: ");
                    setting.AddText(setting.MsgType.User, card_id + "\r\n");
                }
            }
        }

        /// 開始執行
        private void StartThread()
        {
            Thread thread = new Thread(new ThreadStart(ThreadListView));
            thread.Start();
        }

        /// 解决listview多线程调用閃爍问题实例
        private void ThreadListView()
        {
            listView_customer.BeginUpdate();//防listview闪烁开始
            listView_customer = mysql.select_customer_activity(listView_customer);
            listView_customer.EndUpdate();//防listview闪烁结束
        }
        #endregion

        #region ToolStripMenuItem
        //離開
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //設定Serial和MySQL
        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setting.Show();
        }

        //Processing Standard
        private void singleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            parrellelToolStripMenuItem.Checked = false;
            singleToolStripMenuItem.Checked = true;
            Application.Idle -= new EventHandler(FrameGrabber_Parrellel);
            Application.Idle += new EventHandler(FrameGrabber_Standard);
        }

        //Processing Parrelle
        private void parrellelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            parrellelToolStripMenuItem.Checked = true;
            singleToolStripMenuItem.Checked = false;
            Application.Idle -= new EventHandler(FrameGrabber_Standard);
            Application.Idle += new EventHandler(FrameGrabber_Parrellel);
        }

        //Train
        private void trainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            found = true;
            stop_capture();
            rfid_reader.manage_read(this);
            TFnotopen = false;
            TF = new Training_Form(this);
            TF.Show();
        }

        //ReTrain
        public void retrain()
        {
            Eigen_Recog = new Classifier_Train();
            if (Eigen_Recog.IsTrained)
            {
                message_bar.Text = "Training Data loaded";
            }
            else
            {
                message_bar.Text = "No training data found, please train program using Train menu option";
            }
        }
        #endregion

        #region Card Data Update
        //查詢卡片資料
        private void select_swipe()
        {
            DataTable dt = new DataTable();
            dt.Clear();
            dt = mysql.select_customer_swipe(card_id);
            if (dt.Rows.Count != 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    for (int i = 0; i < customer.Length; i++)
                    {
                        customer[i] = dr[i + 1].ToString();
                    }
                }
            }
            else
            {
                customer[2] = "卡片無效";
                customer[3] = card_id;
                customer[4] = "0";
                customer[5] = "0";
                customer[6] = "Invalid.png";
                customer[7] = "Empty";
            }

            if (only_read)
            {

            }
            else if (manage_activity)
            {
                update_manage_data();
            }
            else
            {
                update_swipe();
            }
        }

        //更新Manage資料
        private void update_manage_data()
        {
            manage_customer_name.Text = customer[2];
            manage_customer_RFID_ID.Text = customer[3];
            manage_customer_permission.Text = customer[4];
            manage_customer_state.Text = (customer[5] == "1") ? "1(啟用)" : "0(禁用)";

            try
            {
                if (customer[6] == "Invalid.png")
                {
                    manage_customer_image.SizeMode = PictureBoxSizeMode.CenterImage;
                    FileStream fs = new FileStream(customer_image_path + "add.png", FileMode.Open);
                    Bitmap bitmap = new Bitmap(fs);
                    Bitmap tmp_bitmap = new Bitmap(bitmap);
                    fs.Close();
                    bitmap.Dispose();
                    manage_customer_image.Image = tmp_bitmap;
                }
                else
                {
                    manage_customer_image.SizeMode = PictureBoxSizeMode.Zoom;
                    tmp_path = customer_image_path + customer[6];
                    FileStream fs = new FileStream(tmp_path, FileMode.Open);
                    Bitmap bitmap = new Bitmap(fs);
                    Bitmap tmp_bitmap = new Bitmap(bitmap);
                    fs.Close();
                    bitmap.Dispose();
                    manage_customer_image.Image = tmp_bitmap;
                }
            }
            catch
            {
                manage_customer_image.SizeMode = PictureBoxSizeMode.CenterImage;
                FileStream fs = new FileStream(customer_image_path + "add.png", FileMode.Open);
                Bitmap bitmap = new Bitmap(fs);
                Bitmap tmp_bitmap = new Bitmap(bitmap);
                fs.Close();
                bitmap.Dispose();
                manage_customer_image.Image = tmp_bitmap;
            }

            if (TF != null)
            {
                TF.NAME_PERSON.Text = customer[3];
            }
        }

        //更新卡片資料
        private void update_swipe()
        {
            textBox_customer_name.Text = customer[2];
            textBox_customer_RFID_ID.Text = customer[3];
            admin_permission = (Convert.ToInt32(customer[4]) == 755) ? true : false;
            textBox_customer_state.Text = (customer[5] == "1") ? "啟用" : "禁用";
            textBox_customer_join_time.Text = customer[7];

            if (admin_permission && recognizer)
            {
                rfid_reader.open_admin(this);
            }
            else
            {
                rfid_reader.close_admin(this);
                rfid_reader.close_manage(this);
            }

            manage_customer_image.SizeMode = PictureBoxSizeMode.Zoom;
            try
            {
                tmp_path = customer_image_path + customer[6];
                FileStream fs = new FileStream(tmp_path, FileMode.Open);
                Bitmap bitmap = new Bitmap(fs);
                Bitmap tmp_bitmap = new Bitmap(bitmap);
                fs.Close();
                bitmap.Dispose();
                pictureBox_customer_image.Image = tmp_bitmap;
            }
            catch
            {
                tmp_path = customer_image_path + "Question.png";
                FileStream fs = new FileStream(tmp_path, FileMode.Open);
                Bitmap bitmap = new Bitmap(fs);
                Bitmap tmp_bitmap = new Bitmap(bitmap);
                fs.Close();
                bitmap.Dispose();
                pictureBox_customer_image.Image = tmp_bitmap;
            }
        }
        #endregion

        #region Manage(Added, Modify, Delete, Query, Activity)
        //新增卡片資料
        private void button_customer_added_Click(object sender, EventArgs e)
        {
            rfid_reader.close_manage(this);
            rfid_reader.open_manage(this);
            rfid_reader.manage_read(this);
            message_bar.Text = "Message:Added";
        }

        //修改卡片資料
        private void button_customer_modify_Click(object sender, EventArgs e)
        {
            rfid_reader.close_manage(this);
            rfid_reader.open_manage(this);
            rfid_reader.manage_read(this);
            message_bar.Text = "Message:Modify";
        }

        //刪除卡片資料
        private void button_customer_delete_Click(object sender, EventArgs e)
        {
            rfid_reader.close_manage(this);
            rfid_reader.open_manage(this);
            rfid_reader.manage_read(this);
            manage_customer_RFID_ID.Enabled = false;
            manage_customer_image.Enabled = false;
            manage_customer_name.Enabled = false;
            manage_customer_permission.Enabled = false;
            manage_customer_state.Enabled = false;
            message_bar.Text = "Message:Delete";
        }

        //顯示用戶資料
        private void button_customer_select_Click(object sender, EventArgs e)
        {
            mysql.select_customer(listView_customer);
            rfid_reader.close_manage(this);
            rfid_reader.original_read(this);
            listView_customer.Visible = true;
            message_bar.Text = "Message:Query";
        }

        //顯示活動紀錄
        private void button_customer_log_Click(object sender, EventArgs e)
        {
            ThreadListView();
            rfid_reader.close_manage(this);
            rfid_reader.original_read(this);
            listView_customer.Visible = true;
            message_bar.Text = "Message:Activity";
        }
        #endregion

        #region BackgroundWorker
        //Thread Sleep
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for (; ; )
            {
                if (backgroundWorker1.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    try
                    {
                        backgroundWorker1.ReportProgress(0);
                        System.Threading.Thread.Sleep(500);
                    }
                    catch (Exception)
                    {
                        e.Cancel = true;
                        break;
                    }
                }
            }
        }

        //背景處理程序
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                if (serialportopen)
                {
                    if (serialport.BytesToRead != 0)
                    {
                        byte[] bufferData = new byte[serialport.BytesToRead];
                        serialport.Read(bufferData, 0, bufferData.Length);

                        hexmsbuff = string.Empty;
                        card_id = string.Empty;

                        //Card ID 序列號
                        if (Convert.ToInt32(bufferData[0]) <= 175 && Convert.ToInt32(bufferData[0]) >= 160)
                        {
                            if (TFnotopen && !manage_activity)
                            {
                                found = false;
                                send_X = 10; send_Y = 110;
                                count = 0;
                                recognizer = false;
                            }

                            hexmsbuff = rfid_reader.byte_to_hex(bufferData);
                            card_id = rfid_reader.byte_to_char(bufferData);
                            card_id = card_id.Substring(0, card_id.Length - 2);

                            show_card_id_for_setting();
                            select_swipe();

                            rfid_reader.close_admin(this);
                            rfid_reader.close_manage(this);
                        }

                        //清buffer
                        serialport.DiscardInBuffer();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion

        #region Upload Image and Manage (OK and Cancel)
        //上傳照片
        private void manage_customer_image_Click(object sender, EventArgs e)
        {
            image_path.Title = "選擇圖片";
            image_path.InitialDirectory = ".\\";
            image_path.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|Png Image|*.png";
            if (image_path.ShowDialog() == DialogResult.OK)
            {
                manage_customer_image.SizeMode = PictureBoxSizeMode.Zoom;
                FileStream fs = new FileStream(image_path.FileName, FileMode.Open);
                Bitmap bitmap = new Bitmap(fs);
                Bitmap tmp_bitmap = new Bitmap(bitmap);
                fs.Close();
                bitmap.Dispose();
                manage_customer_image.Image = tmp_bitmap;
            }
        }

        //Manage OK(Verify->Added, mModify, Delete)
        private void manage_btn_ok_Click(object sender, EventArgs e)
        {
            switch (message_bar.Text)
            {
                case "Message:Added":
                    if (rfid_reader.check_whitespace(this, true))
                    {
                        rfid_reader.only_read(this);
                        rfid_reader.clear_card_data(this);
                        verify verify = new verify(this);

                        if (verify.ShowDialog() == DialogResult.OK)
                        {
                            if (verify.verify_success && mysql.select_customer_swipe(manage_customer_RFID_ID.Text).Rows.Count < 1)
                            {

                                try
                                {
                                    if (File.Exists(tmp_path))
                                    {
                                        File.Delete(tmp_path);
                                    }

                                    manage_customer_image.Image.Save(customer_image_path + manage_customer_RFID_ID.Text + ".jpg");

                                    mysql.insert_customer_added(manage_customer_name.Text, manage_customer_RFID_ID.Text,
                                                                Convert.ToInt32(manage_customer_permission.Text),
                                                                Convert.ToInt32(manage_customer_state.Text.Substring(0, 1)),
                                                                manage_customer_RFID_ID.Text);
                                    mysql.insert_customer_activity("Added",
                                                                    manage_customer_RFID_ID.Text,
                                                                    Convert.ToInt32(manage_customer_state.Text.Substring(0, 1)));
                                    MessageBox.Show("Added Success");
                                    rfid_reader.original_read(this);
                                    rfid_reader.close_manage(this);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Unknow Error");
                                }
                            }
                            else
                            {
                                rfid_reader.manage_read(this);
                                MessageBox.Show("Customer Repeat");
                            }
                        }
                    }
                    break;

                case "Message:Modify":
                    if (rfid_reader.check_whitespace(this, true))
                    {
                        rfid_reader.only_read(this);
                        rfid_reader.clear_card_data(this);
                        verify verify = new verify(this);

                        if (verify.ShowDialog() == DialogResult.OK)
                        {
                            if (verify.verify_success && mysql.select_customer_swipe(manage_customer_RFID_ID.Text).Rows.Count > 0)
                            {
                                try
                                {
                                    if (File.Exists(tmp_path))
                                    {
                                        File.Delete(tmp_path);
                                    }

                                    manage_customer_image.Image.Save(customer_image_path + manage_customer_RFID_ID.Text + ".jpg");
                                }
                                catch (Exception ex)
                                {
                                    //MessageBox.Show("Image No Change");
                                }

                                mysql.update_customer(manage_customer_name.Text,
                                                      manage_customer_RFID_ID.Text,
                                                      Convert.ToInt32(manage_customer_permission.Text),
                                                      Convert.ToInt32(manage_customer_state.Text.Substring(0, 1)),
                                                      manage_customer_RFID_ID.Text);
                                mysql.insert_customer_activity("Modify",
                                                                manage_customer_RFID_ID.Text,
                                                                Convert.ToInt32(manage_customer_state.Text.Substring(0, 1)));
                                MessageBox.Show("Modify Success");
                                rfid_reader.original_read(this);
                                rfid_reader.close_manage(this);
                            }
                            else
                            {
                                rfid_reader.manage_read(this);
                                MessageBox.Show("Unknow Customer");
                            }
                        }
                    }
                    break;

                case "Message:Delete":
                    if (rfid_reader.check_whitespace(this, false))
                    {
                        rfid_reader.only_read(this);
                        rfid_reader.clear_card_data(this);
                        verify verify = new verify(this);

                        if (verify.ShowDialog() == DialogResult.OK)
                        {
                            if (verify.verify_success && mysql.select_customer_swipe(manage_customer_RFID_ID.Text).Rows.Count > 0)
                            {
                                try
                                {
                                    mysql.delete_customer(manage_customer_RFID_ID.Text);
                                    mysql.insert_customer_activity("Delete",
                                                                    manage_customer_RFID_ID.Text,
                                                                    Convert.ToInt32(manage_customer_state.Text.Substring(0, 1)));

                                    MessageBox.Show("Delete Success");

                                    if (File.Exists(tmp_path))
                                    {
                                        File.Delete(tmp_path);
                                    }
                                    rfid_reader.original_read(this);
                                    rfid_reader.close_manage(this);
                                }
                                catch (Exception ex)
                                {
                                    //MessageBox.Show(ex.ToString());
                                }
                            }
                            else
                            {
                                rfid_reader.manage_read(this);
                                MessageBox.Show("Unknow Customer");
                            }
                        }
                    }
                    break;
            }
        }

        //Manage Cancel
        private void manage_btn_cancel_Click(object sender, EventArgs e)
        {
            rfid_reader.original_read(this);
            rfid_reader.close_manage(this);
        }
        #endregion

        #region Processing Frame
        //Process Frame
        void FrameGrabber_Standard(object sender, EventArgs e)
        {
            //Get the current frame form capture device
            currentFrame = grabber.QueryFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);

            //Convert it to Grayscale
            if (currentFrame != null)
            {
                gray_frame = currentFrame.Convert<Gray, Byte>();

                //Face Detector
                MCvAvgComp[][] facesDetected = gray_frame.DetectHaarCascade(Face, 1.2, 4, Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(50, 50));

                //Action for each element detected
                foreach (MCvAvgComp face_found in facesDetected[0])
                {
                    result = currentFrame.Copy(face_found.rect).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                    //draw the face detected in the 0th (gray) channel with blue color
                    currentFrame.Draw(face_found.rect, new Bgr(Color.Red), 2);
                    found = true;

                    //追蹤人臉
                    TrackinFace(face_found.rect.X, face_found.rect.Y, face_found.rect.Width, face_found.rect.Height);

                    if (Eigen_Recog.IsTrained)
                    {
                        name = Eigen_Recog.Recognise(result);
                        int match_value = (int)Eigen_Recog.Get_Eigen_Distance;

                        //Draw the label for each face detected and recognized
                        currentFrame.Draw(name + " ", ref font, new Point(face_found.rect.X - 2, face_found.rect.Y - 2), new Bgr(Color.LightGreen));
                    }

                    if (mysqlopen && not_stop_read && !recognizer && TFnotopen)
                    {
                        if (name == card_id)
                        {
                            recognizer = true;
                            mysql.insert_customer_activity("swipe", card_id, Convert.ToInt32(customer[5]));
                            MessageBox.Show(name + "，辨識成功");
                        }
                        else if (name != card_id)
                        {
                            recog_count++;
                            recognizer = true;
                            MessageBox.Show(card_id + "，身分不符");
                        }

                        select_swipe();
                    }
                }

                //Show the faces procesed and recognized
                image_PICBX.Image = currentFrame.ToBitmap();
            }
        }

        void FrameGrabber_Parrellel(object sender, EventArgs e)
        {
            //Get the current frame form capture device
            currentFrame = grabber.QueryFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);

            //Convert it to Grayscale
            //Clear_Faces_Found();

            if (currentFrame != null)
            {
                gray_frame = currentFrame.Convert<Gray, Byte>();

                //Face Detector
                MCvAvgComp[][] facesDetected = gray_frame.DetectHaarCascade(Face, 1.2, 4, Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(50, 50));

                //Action for each element detected
                Parallel.ForEach(facesDetected[0], face_found =>
                {
                    try
                    {
                        result = currentFrame.Copy(face_found.rect).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                        result._EqualizeHist();
                        //draw the face detected in the 0th (gray) channel with blue color
                        currentFrame.Draw(face_found.rect, new Bgr(Color.Red), 2);

                        if (Eigen_Recog.IsTrained)
                        {
                            string name = Eigen_Recog.Recognise(result);
                            int match_value = (int)Eigen_Recog.Get_Eigen_Distance;

                            //Draw the label for each face detected and recognized
                            currentFrame.Draw(name + " ", ref font, new Point(face_found.rect.X - 2, face_found.rect.Y - 2), new Bgr(Color.LightGreen));
                            //ADD_Face_Found(result, name, match_value);
                        }
                    }
                    catch
                    {
                        //do nothing as parrellel loop buggy
                        //No action as the error is useless, it is simply an error in 
                        //no data being there to process and this occurss sporadically 
                    }
                });
                //Show the faces procesed and recognized
                image_PICBX.Image = currentFrame.ToBitmap();
            }
        }
        #endregion

        #region Tacking and Search Face
        public void TrackinFace(int x, int y, int w, int h)
        {
            center_X = x + (w / 2);
            center_Y = y + (h / 2);

            if (ArduinoOpen)
            {
                if (Math.Abs(center_X - 160) > 20)
                {
                    if (center_X <= 160)
                    {
                        send_X = send_X + 2;
                    }
                    else
                    {
                        send_X = send_X - 2;
                    }
                }
                else
                {
                    send_X = send_X + 0;
                }

                if (Math.Abs(center_Y - 120) > 20)
                {
                    if (center_Y <= 120)
                    {
                        send_Y = send_Y + 2;
                    }
                    else
                    {
                        send_Y = send_Y - 2;
                    }
                }
                else
                {
                    send_Y = send_Y + 0;
                }

                if (send_Y > 150) send_Y = 150;
                if (send_Y < 30) send_Y = 30;

                Arduino_Serial.Write(send_X + "," + send_Y + "\r\n");
            }
        }

        public void SearchFace(object source, System.Timers.ElapsedEventArgs e)
        {
            if (ArduinoOpen && !found)
            {

                if (send_X >= 10 && send_X < 170)
                {
                    send_X += 45;
                }
                else
                {
                    count++;
                    send_X = 10;
                }

                if (count > 1)
                {
                    count = 0;
                }

                if (send_Y >= 70 && send_Y <= 110)
                {
                    send_Y = (1 - count) * 40 + 70;
                }
                else
                {
                    send_Y = 110;
                }

                Arduino_Serial.Write(send_X + "," + send_Y + "\r\n");
            }
        }
        #endregion

        #region Camera Start or Stop
        //Start
        public void initialise_capture()
        {
            try
            {
                grabber = new Capture(0);
                grabber.QueryFrame();
                //Initialize the FrameGraber event
                if (parrellelToolStripMenuItem.Checked)
                {
                    Application.Idle += new EventHandler(FrameGrabber_Parrellel);
                }
                else
                {
                    Application.Idle += new EventHandler(FrameGrabber_Standard);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Camera not found");
                //MessageBox.Show(ex.ToString());
            }
        }

        //Stop
        private void stop_capture()
        {
            if (parrellelToolStripMenuItem.Checked)
            {
                Application.Idle -= new EventHandler(FrameGrabber_Parrellel);
            }
            else
            {
                Application.Idle -= new EventHandler(FrameGrabber_Standard);
            }
            if (grabber != null)
            {
                grabber.Dispose();
            }
        }
        #endregion
    }
}

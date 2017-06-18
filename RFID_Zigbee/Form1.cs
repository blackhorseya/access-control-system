using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.PowerPacks;
using System.IO.Ports;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Threading;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;
using System.Security.Cryptography;


namespace RFID_Zigbee
{
    
    public partial class Form1 : Form
    {
        //變數宣告
        private Capture cap = null;
        SerialPort serialport = new SerialPort();
        Boolean serialportopen = false, mysqlopen = false;
        private Color[] MsgTypeColor = { Color.Blue, Color.Green, Color.Black, Color.Orange, Color.Red };
        public enum MsgType { System, User, Normal, Warning, Error };
        private customer_added customer_added;
        string hexmsbuff, card_id="";
        MySqlConnection conn;
        Image<Bgr, Byte> camera;
        class_mysql mysql = new class_mysql();
        class_view myview = new class_view();

        public Form1()
        {
            InitializeComponent();
            cap = new Capture(0);
        }
        void Application_Idle(object sender, EventArgs e)
        {
            camera = cap.QueryFrame();
            if (camera != null)
            {
                pictureBox_camera.Image = camera.ToBitmap();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //掃描tabcontrol
            foreach (System.Windows.Forms.TabPage tabc in tabControl1.TabPages)
            {
                tabc.Show();
            }

            comboBox1.Items.Clear();
            //找尋可用的串列埠
            foreach (string com in SerialPort.GetPortNames())
            {
                comboBox1.Items.Add(com);
            }
        }

        //F5 找尋可用的串列埠
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F5)
            {
                comboBox1.Items.Clear();
                //找尋可用的串列埠
                foreach (string com in SerialPort.GetPortNames())
                {
                    comboBox1.Items.Add(com);
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            //串列埠連線
            if (serialportopen == false && !serialport.IsOpen)
            {
                try
                {
                    //設定連接埠19200、n、8、1、n
                    serialport.PortName = comboBox1.Text;
                    serialport.BaudRate = 19200;
                    serialport.DataBits = 8;
                    serialport.Parity = Parity.None;
                    serialport.StopBits = StopBits.One;
                    serialport.Encoding = Encoding.ASCII;//傳輸編碼方式
                    serialport.Open();//串列埠開始連線
                    serialportopen = true;

                    //開始背景執行緒
                    if (this.backgroundWorker1.WorkerReportsProgress != true)
                    {
                        this.backgroundWorker1.WorkerReportsProgress = true;
                        this.backgroundWorker1.RunWorkerAsync();
                    }
                    btn_connect.Text = "中斷";

                    serialport.Write("0");

                    AddText(MsgType.System, "串列埠連線\r\n");
                }
                catch
                {
                    MessageBox.Show("請選擇COM Port！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //串列埠中斷
            else if (serialportopen == true && serialport.IsOpen)
            {
                try
                {
                    serialport.Close();
                    serialportopen = false;
                    this.backgroundWorker1.WorkerReportsProgress = false;
                    this.backgroundWorker1.CancelAsync();
                    this.backgroundWorker1.Dispose();
                    btn_connect.Text = "連線";

                    AddText(MsgType.System, "串列埠中斷\r\n");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        //文本
        private void AddText(MsgType msgtype, string msg)
        {
            richTextBox1.Invoke(new EventHandler(delegate
            {
                richTextBox1.SelectedText = string.Empty;
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Bold);
                richTextBox1.SelectionColor = MsgTypeColor[(int)msgtype];
                richTextBox1.AppendText(msg);
                richTextBox1.ScrollToCaret();
            }));
        }

        private void btn_end_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //接收Zigbee
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
                        System.Threading.Thread.Sleep(100);
                    }
                    catch (Exception)
                    {
                        e.Cancel = true;
                        break;
                    }
                }
            }
        }

        //接收Zigbee
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                if (serialport.BytesToRead != 0)
                {
                    //計算serialPort1中有多少位元組 
                    byte[] bufferData = new byte[serialport.BytesToRead];
                    //將讀取到的資料放到bufferData中，有需要後面就直接轉碼使用即可 
                    serialport.Read(bufferData, 0, bufferData.Length);
                    // serialPort1.Read(放置的位元陣列 , 從第幾個位置開始存放 , 共需存放多少位元)

                    hexmsbuff = string.Empty;
                    card_id = string.Empty;

                    //header A0~AF 
                    if (Convert.ToInt32(bufferData[0]) <= 175 && Convert.ToInt32(bufferData[0]) >= 160)
                    {
                        //byte[] to hex
                        if (bufferData != null)
                        {
                            StringBuilder strB = new StringBuilder();
                            for (int i = 0; i < bufferData.Length; i++)
                            {
                                strB.Append(bufferData[i].ToString("X2")).Append(" ");
                            }
                            hexmsbuff = strB.ToString();
                        }

                        //byte[] to ascii char (only card_id)
                        for (int i = 5; i < bufferData.Length - 1; i++)
                        {
                            card_id += Convert.ToChar(bufferData[i]);
                        }
                        //刪除字串最後一個字元
                        card_id = card_id.Substring(0, card_id.Length - 2);

                        if ((Convert.ToInt32(bufferData.Length) - 6) == Convert.ToInt32(bufferData[4]))
                        {
                            if (mysqlopen == true)
                            {
                                DataTable dt = new DataTable();
                                dt.Clear();
                                dt = mysql.select_customer_swipe(conn, card_id);
                                if (dt.Rows.Count != 0)
                                {
                                    //查詢客戶資料
                                    foreach (DataRow dr in dt.Rows)
                                    {
                                        textBox_customer_name.Text = dr[3].ToString();
                                        textBox_customer_RFID_ID.Text = dr[4].ToString();
                                        textBox1.Text = dr[5].ToString();
                                        if (dr[5].ToString() == "755")
                                        {
                                            button_customer_added.Enabled = true;
                                            button_customer_delete.Enabled = true;
                                            button_customer_modify.Enabled = true;
                                            button_customer_select.Enabled = true;
                                        }
                                        else
                                        {

                                            button_customer_added.Enabled = false;
                                            button_customer_delete.Enabled = false;
                                            button_customer_modify.Enabled = false;
                                            button_customer_select.Enabled = false;
                                        }
                                        if (dr[6].ToString() == "1")
                                        {
                                            textBox_customer_state.Text = "啟用";
                                        }
                                        else
                                        {
                                            textBox_customer_state.Text = "禁用";
                                        }
                                        textBox_customer_join_time.Text = dr[8].ToString();
                                        try
                                        {
                                            textBox_image_path.Text = dr[7].ToString();
                                            System.IO.FileStream fs = new System.IO.FileStream(@"..\..\image\" + dr[7].ToString(), System.IO.FileMode.Open);
                                            Bitmap bitmap = new Bitmap(fs); fs.Close();
                                            pictureBox_customer_image.Image = bitmap;
                                        }
                                        catch
                                        {
                                            System.IO.FileStream fs = new System.IO.FileStream(@"../../image/Question.png", System.IO.FileMode.Open);
                                            Bitmap bitmap = new Bitmap(fs); fs.Close();
                                            pictureBox_customer_image.Image = bitmap;
                                        }
                                            
                                        //新增客戶活動
                                        mysql.insert_customer_activity(conn, "swipe", card_id, Convert.ToInt32(dr[6]));
                                    }
                                }
                                else
                                {
                                    pictureBox_customer_image.Image = Image.FromFile(@"../../image/Invalid.png");
                                    mysql.insert_customer_activity(conn, "swipe", card_id, 99);
                                    textBox_customer_name.Text = "卡片無效!";
                                    textBox_customer_RFID_ID.Text = card_id;
                                }
                                ThreadListView();
                            }

                            if (radioButton1_hex.Checked)
                            {
                                if (hexmsbuff != null)
                                {
                                    AddText(MsgType.User, "Length：" + bufferData.Length.ToString() + "\r\n");
                                    AddText(MsgType.User, hexmsbuff + "\r\n");
                                }
                            }
                            else if (radioButton2_char.Checked)
                            {
                                if (card_id != null)
                                {
                                    AddText(MsgType.User, "Length：" + (Convert.ToInt32(bufferData.Length) - 6) + "\r\n");
                                    AddText(MsgType.User, "ID: ");
                                    AddText(MsgType.User, card_id + "\r\n");
                                }
                            }
                        }
                    }
                    serialport.DiscardInBuffer();
                }

                if (label_visible.Text == "verify")
                {
                    DataTable verify_dt = new DataTable();
                    verify_dt.Clear();
                    verify_dt = mysql.select_customer_swipe(conn, card_id);
                    foreach (DataRow dr in verify_dt.Rows)
                    {
                        SHA1 sha1 = new SHA1CryptoServiceProvider();
                        string input_password = textBox1.Text;
                        string resultSha1 = Convert.ToBase64String(sha1.ComputeHash(Encoding.Default.GetBytes(input_password)));
                        if (resultSha1 == dr[2].ToString())
                        {
                            label_visible.Text = "verify_OK";
                        }
                        else
                        {
                            label_visible.Text = "verify_ERROR";
                            MessageBox.Show("verify_error");
                        }
                    }
                }
                else if (label_visible.Text == "go_insert")
                {
                    if (mysql.select_customer_swipe(conn, customer_added.textBox_customer_RFID_ID.Text).Rows.Count < 1)
                    {
                        mysql.insert_customer_added(conn, customer_added.textBox_customer_name.Text, customer_added.textBox_customer_RFID_ID.Text, Convert.ToInt32(customer_added.textBox_customer_permission.Text), Convert.ToInt32(customer_added.comboBox_customer_state.Text.Substring(0, 1)), customer_added.textBox_customer_RFID_ID.Text);
                        mysql.insert_customer_activity(conn, "customer_added", customer_added.textBox_customer_RFID_ID.Text, Convert.ToInt32(customer_added.comboBox_customer_state.Text.Substring(0, 1)));
                        customer_added.pictureBox_customer_image.Image.Save(@"../../image/" + customer_added.textBox_customer_RFID_ID.Text + ".png");
                        label_visible.Text = "新增成功!";
                        MessageBox.Show("新增成功!");
                    }
                    else
                    {
                        label_visible.Text = "此卡已開通";
                        MessageBox.Show("此卡已開通");
                    }
                }
                else if (label_visible.Text == "go_modify")
                {
                    if (mysql.select_customer_swipe(conn, customer_added.textBox_customer_RFID_ID.Text).Rows.Count != 0)
                    {
                        mysql.update_customer(conn, customer_added.textBox_customer_name.Text, customer_added.textBox_customer_RFID_ID.Text, Convert.ToInt32(customer_added.textBox_customer_permission.Text), Convert.ToInt32(customer_added.comboBox_customer_state.Text.Substring(0, 1)), customer_added.textBox_customer_RFID_ID.Text);
                        mysql.insert_customer_activity(conn, "customer_modify", card_id, Convert.ToInt32(customer_added.comboBox_customer_state.Text.Substring(0, 1)));
                        try
                        {
                            customer_added.pictureBox_customer_image.Image.Save(@"../../image/" + customer_added.textBox_customer_RFID_ID.Text + ".png");
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                        
                        label_visible.Text = "修改成功!";
                        MessageBox.Show("修改成功!");
                    }
                    else
                    {
                        label_visible.Text = "modify";
                        MessageBox.Show("此卡未開通，請先新增");
                    }
                }
                else if (label_visible.Text == "go_delete")
                {
                    if (mysql.select_customer_swipe(conn, customer_added.textBox_customer_RFID_ID.Text).Rows.Count != 0)
                    {
                        mysql.delete_customer(conn, customer_added.textBox_customer_RFID_ID.Text);
                        mysql.insert_customer_activity(conn, "customer_delete", customer_added.textBox_customer_RFID_ID.Text, Convert.ToInt32(customer_added.comboBox_customer_state.Text.Substring(0, 1)));
                        label_visible.Text = "刪除成功!";
                        MessageBox.Show("刪除成功!");
                    }
                    else
                    {
                        label_visible.Text = "delete";
                        MessageBox.Show("此卡未開通");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void textbox_clear()
        {
            Application.Idle -= Application_Idle;
            pictureBox_camera.Image = null;
            textBox1.Text = "";
            button_customer_added.Enabled = false;
            button_customer_delete.Enabled = false;
            button_customer_select.Enabled = false;
            button_customer_modify.Enabled = false;
            pictureBox_customer_image.Image = null;
            textBox_customer_join_time.Clear();
            textBox_customer_name.Clear();
            textBox_customer_RFID_ID.Clear();
            textBox_customer_state.Clear();
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
            listView_customer_activity.BeginUpdate();//防listview闪烁开始
            listView_customer_activity = mysql.select_customer_activity(conn, listView_customer_activity);
            listView_customer_activity.EndUpdate();//防listview闪烁结束
        }

        //資料庫連線
        private void mysql_connect_Click(object sender, EventArgs e)
        {
            conn = mysql.Initialize(host.Text, database.Text, user.Text, pwd.Text);
            if (mysql.mysql_connect() == 1)
            {
                mysql_connect.Enabled = false;
                mysql_disconnect.Enabled = true;
                mysqlopen = true;

                ThreadListView();
                AddText(MsgType.System, "資料庫連線\r\n");
            }
            else
            {
                switch (mysql.mysql_connect())
                {
                    case 0:
                        AddText(MsgType.Warning, "無法連線到資料庫\r\n");
                        break;
                    case 1045:
                        AddText(MsgType.Warning, "使用者帳號或密碼錯誤\r\n");
                        break;
                    case 1042:
                        AddText(MsgType.Warning, "無效的主機名稱\r\n");
                        break;
                }
            }
        }

        //資料庫中斷
        private void mysql_disconnect_Click(object sender, EventArgs e)
        {
            if (mysql.mysql_disconnect() == "1")
            {
                mysqlopen = false;
                mysql_connect.Enabled = true;
                mysql_disconnect.Enabled = false;
                listView_customer_activity.Clear();
            }
            else
            {
                MessageBox.Show(mysql.mysql_disconnect());
            }
        }

        private void button_customer_added_Click(object sender, EventArgs e)
        {
            textbox_clear();
            label_visible.Text = "insert";
            customer_added = new customer_added();
            customer_added.FM1 = this;
            customer_added.ShowDialog();
        }

        private void button_camera_stop_Click(object sender, EventArgs e)
        {
            Application.Idle -= Application_Idle;
            pictureBox_camera.Image = null;
        }

        private void button_take_picture_Click(object sender, EventArgs e)
        {
            try
            {
                if (pictureBox_camera.Image == null)
                {
                    Application.Idle += Application_Idle;
                }
                else
                {
                    pictureBox_camera.Image.Save(@"../../image/" + card_id + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".png");
                }
            }
            catch
            {

            }
        }

        private void button_customer_delete_Click(object sender, EventArgs e)
        {
            textbox_clear();
            label_visible.Text = "delete";
            customer_added = new customer_added();
            customer_added.FM1 = this;
            customer_added.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SHA1 sha1 = new SHA1CryptoServiceProvider();
            string resultSha1 = Convert.ToBase64String(sha1.ComputeHash(Encoding.Default.GetBytes("admin")));
            string sql = "UPDATE oc_customer SET password = '" + resultSha1 + "' WHERE card_id = 'A45B37DF'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }

        private void button_customer_select_Click(object sender, EventArgs e)
        {
            try
            {
                mysql.select_customer(conn, listView_customer);
            }
            catch
            {

            }
        }

        private void button_customer_activity_refresh_Click(object sender, EventArgs e)
        {
            try
            {
                ThreadListView();
            }
            catch
            {

            }
        }

        private void button_customer_modify_Click(object sender, EventArgs e)
        {
            textbox_clear();
            label_visible.Text = "modify";
            customer_added = new customer_added();
            customer_added.FM1 = this;
            customer_added.ShowDialog();
            }
        }
    }


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace RFID_Zigbee
{
    public partial class customer_added : Form
    {
        int c;
        public customer_added()
        {
            InitializeComponent();
        }

        public Form1 FM1 = null;
        public OpenFileDialog image_path;

        private void customer_added_Load(object sender, EventArgs e)
        {
            comboBox_customer_state.SelectedIndex = 0;
            //開始背景執行緒
            if (this.backgroundWorker1.WorkerReportsProgress != true)
            {
                this.backgroundWorker1.WorkerReportsProgress = true;
                this.backgroundWorker1.RunWorkerAsync();
            }
        }

        private void button_customer_upload_image_Click(object sender, EventArgs e)
        {
            image_path = new OpenFileDialog();
            image_path.Title = "選擇圖片";
            image_path.InitialDirectory = ".\\";
            image_path.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|Png Image|*.png";
            if (image_path.ShowDialog() == DialogResult.OK)
            {
                pictureBox_customer_image.Image = Image.FromFile(image_path.FileName);
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            FM1.label_visible.Text = "";
            FM1.textBox1.Text = "";
            button_ok.Text = "新增";
            timer1.Enabled = false;
            this.Close();
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            FM1.textBox1.Text = "";
            c = 45;
            FM1.label_visible.Text = "";
            timer1.Enabled = true;
            button_ok.Visible = false;
            label1.Visible = true;
            label1.Text = "45秒內扣卡!";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //label1.Text = FM1.textBox1.Text;
            if (FM1.textBox1.Text == "755")
            {
                FM1.textBox1.Text = "";
                timer1.Enabled = false;
                label1.Visible = false;
                button_check_ok.Visible = false;
                button_cancel.Visible = true;
                button_ok.Visible = true;
                Form2 FM2 = new Form2();
                FM2.customer_added = this;
                FM2.ShowDialog();
                if (FM2.DialogResult == DialogResult.OK)
                {
                    FM1.textBox1.Text = FM2.textBox1.Text;
                    FM1.label_visible.Text = "verify";
                }
            }
            else
            {
                c--;
                if (c == 0)
                {
                    timer1.Enabled = false;
                    this.Close();
                }
                else
                {
                    label1.Text = c + "秒內扣卡!";
                }
            }
        }

        private void button_check_ok_Click(object sender, EventArgs e)
        {
            if (button_ok.Text == "新增")
            {
                FM1.label_visible.Text = "go_insert";
            }
            else if (button_ok.Text == "修改")
            {
                FM1.label_visible.Text = "go_modify";
            }
            else if(button_ok.Text == "刪除")
            {
                FM1.label_visible.Text = "go_delete";
            }
        }

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

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (FM1.label_visible.Text == "verify_OK")
            {
                if (button_ok.Text == "修改")
                {
                    button_check_ok.Visible = true;
                    button_ok.Visible = false;
                    label1.Visible = true;
                    textBox_customer_permission.Enabled = true;
                    textBox_customer_name.Enabled = true;
                    comboBox_customer_state.Enabled = true;
                    button_take_picture.Enabled = true;
                    button_customer_upload_image.Enabled = true;
                    label1.Text = "修改資料後，按確認";
                }
                else if (button_ok.Text == "新增")
                {
                    button_check_ok.Visible = true;
                    button_ok.Visible = false;
                    label1.Visible = true;
                    textBox_customer_permission.Enabled = true;
                    textBox_customer_name.Enabled = true;
                    comboBox_customer_state.Enabled = true;
                    button_take_picture.Enabled = true;
                    button_customer_upload_image.Enabled = true;
                    label1.Text = "刷入欲新增卡片後，按確認";
                }
                else if (button_ok.Text == "刪除")
                {
                    button_check_ok.Visible = true;
                    button_ok.Visible = false;
                    label1.Visible = true;
                    label1.Text = "確認刪除卡片，按確認";
                }
            }else if(FM1.label_visible.Text == "新增成功!"){
                this.Close();
            }
            else if (FM1.label_visible.Text == "修改成功!")
            {
                this.Close();
            }
            else if (FM1.label_visible.Text == "刪除成功!")
            {
                this.Close();
            }
            else if (FM1.label_visible.Text == "modify")
            {
                button_customer_upload_image.Enabled = false;
                button_take_picture.Enabled = false;
                textBox_customer_permission.Enabled = false;
                textBox_customer_name.Enabled = false;
                comboBox_customer_state.Enabled = false;
                button_ok.Text = "修改";
                label1.Visible = true;
                label1.Text = "刷入欲修改卡片";
                textBox_customer_permission.Text = FM1.textBox1.Text;
                textBox_customer_RFID_ID.Text = FM1.textBox_customer_RFID_ID.Text;
                if (FM1.textBox_customer_state.Text == "禁用")
                {
                    comboBox_customer_state.SelectedIndex = 0;
                }
                else if(FM1.textBox_customer_state.Text == "啟用")
                {
                    comboBox_customer_state.SelectedIndex = 1;
                }
                else
                {
                    comboBox_customer_state.SelectedIndex = -1;
                }
                textBox_customer_name.Text = FM1.textBox_customer_name.Text;
                pictureBox_customer_image.Image = FM1.pictureBox_customer_image.Image;
            }
            else if (FM1.label_visible.Text == "delete")
            {
                button_customer_upload_image.Enabled = false;
                button_take_picture.Enabled = false;
                textBox_customer_permission.Enabled = false;
                textBox_customer_name.Enabled = false;
                comboBox_customer_state.Enabled = false;
                button_ok.Text = "刪除";
                label1.Visible = true;
                label1.Text = "刷入欲刪除卡片";
                textBox_customer_permission.Text = FM1.textBox1.Text;
                textBox_customer_RFID_ID.Text = FM1.textBox_customer_RFID_ID.Text;
                if (FM1.textBox_customer_state.Text == "禁用")
                {
                    comboBox_customer_state.SelectedIndex = 0;
                }
                else if (FM1.textBox_customer_state.Text == "啟用")
                {
                    comboBox_customer_state.SelectedIndex = 1;
                }
                else
                {
                    comboBox_customer_state.SelectedIndex = -1;
                }
                textBox_customer_name.Text = FM1.textBox_customer_name.Text;
                pictureBox_customer_image.Image = FM1.pictureBox_customer_image.Image;
            }
            else if (FM1.label_visible.Text == "insert")
            {
                button_customer_upload_image.Enabled = false;
                button_take_picture.Enabled = false;
                textBox_customer_permission.Enabled = false;
                textBox_customer_name.Enabled = false;
                comboBox_customer_state.Enabled = false;
                button_ok.Text = "新增";
                label1.Visible = true;
                label1.Text = "刷入欲新增卡片";
                textBox_customer_permission.Text = FM1.textBox1.Text;
                textBox_customer_RFID_ID.Text = FM1.textBox_customer_RFID_ID.Text;
                textBox_customer_name.Text = FM1.textBox_customer_name.Text;
                pictureBox_customer_image.Image = FM1.pictureBox_customer_image.Image;
                if (FM1.textBox_customer_state.Text == "禁用")
                {
                    comboBox_customer_state.SelectedIndex = 0;
                }
                else if (FM1.textBox_customer_state.Text == "啟用")
                {
                    comboBox_customer_state.SelectedIndex = 1;
                }
                else
                {
                    comboBox_customer_state.SelectedIndex = -1;
                }
            }
        }
    }
}

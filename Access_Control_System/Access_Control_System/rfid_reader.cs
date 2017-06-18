using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Access_Control_System
{
    class rfid_reader
    {
        //byte[] to hex
        public string byte_to_hex(byte[] bufferData)
        {
            StringBuilder str = new StringBuilder();
            for (int i = 0; i < bufferData.Length; i++)
            {
                str.Append(bufferData[i].ToString("X2")).Append(" ");
            }
            return str.ToString();
        }

        //byte[] to ascii char
        public string byte_to_char(byte[] bufferData)
        {
            string card_id = string.Empty;
            for (int i = 5; i < bufferData.Length - 1; i++)
            {
                card_id += Convert.ToChar(bufferData[i]);
            }
            return card_id;
        }

        //Check whitespace
        public Boolean check_whitespace(Form1 fm1, Boolean check_image)
        {
            if (string.IsNullOrWhiteSpace(fm1.manage_customer_name.Text))
            {
                MessageBox.Show("請填入名字！");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(fm1.manage_customer_RFID_ID.Text))
            {
                MessageBox.Show("請刷入欲修改之卡片！");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(fm1.manage_customer_state.Text))
            {
                MessageBox.Show("請選擇狀態！");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(fm1.manage_customer_permission.Text))
            {
                MessageBox.Show("請填入權限！");
                return false;
            }
            else if (fm1.image_path.FileName == fm1.customer_image_path+"add.png" && check_image)
            {
                MessageBox.Show("請上傳照片！");
                return false;
            }
            else
            {
                return true;
            }
        }

        //清除卡片暫存資料
        public void clear_card_data(Form1 fm1)
        {
            for (int i = 0; i < fm1.customer.Length; i++)
            {
                fm1.customer[i] = string.Empty;
            }

            //fm1.pictureBox_customer_image.Image = null;
            //fm1.textBox_customer_join_time.Text = null;
            //fm1.textBox_customer_name.Text = null;
            //fm1.textBox_customer_RFID_ID.Text = null;
            //fm1.textBox_customer_state.Text = null;
        }

        #region
        //Original Read
        public void original_read(Form1 fm1)
        {
            fm1.not_stop_read = true;
            fm1.only_read = false;
            fm1.manage_activity = false;
        }

        //Manage Read
        public void manage_read(Form1 fm1)
        {
            fm1.not_stop_read = true;
            fm1.only_read = false;
            fm1.manage_activity = true;
        }

        //Only Read
        public void only_read(Form1 fm1)
        {
            fm1.not_stop_read = true;
            fm1.only_read = true;
            fm1.manage_activity = true;
        }

        //Stop Read
        public void stop_read(Form1 fm1)
        {
            fm1.not_stop_read = false;
            fm1.only_read = true;
            fm1.manage_activity = true;
        }

        #endregion

        //開啟admin
        public void open_admin(Form1 fm1)
        {
            fm1.trainToolStripMenuItem.Visible = true;
            fm1.button_customer_added.Enabled = true;
            fm1.button_customer_delete.Enabled = true;
            fm1.button_customer_modify.Enabled = true;
            fm1.button_customer_select.Enabled = true;
            fm1.button_customer_activity.Enabled = true;
        }

        //開啟manage
        public void open_manage(Form1 fm1)
        {
            fm1.TFnotopen = false;

            fm1.manage_customer_image.Image = Image.FromFile(Application.StartupPath + "/image/add.png");
            fm1.manage_customer_image.SizeMode = PictureBoxSizeMode.CenterImage;
            fm1.manage_customer_image.Enabled = true;
            fm1.manage_customer_name.Enabled = true;
            fm1.manage_customer_permission.Enabled = true;
            fm1.manage_customer_RFID_ID.Enabled = true;
            fm1.manage_customer_state.Enabled = true;
            fm1.manage_btn_cancel.Enabled = true;
            fm1.manage_btn_ok.Enabled = true;

            fm1.manage_train_btn.Visible = true;
            fm1.manage_customer_image.Visible = true;
            fm1.manage_customer_name.Visible = true;
            fm1.manage_customer_permission.Visible = true;
            fm1.manage_customer_RFID_ID.Visible = true;
            fm1.manage_customer_state.Visible = true;
            fm1.manage_btn_cancel.Visible = true;
            fm1.manage_btn_ok.Visible = true;
            fm1.label1.Visible = true;
            fm1.label2.Visible = true;
            fm1.label3.Visible = true;
            fm1.label4.Visible = true;
            fm1.tableLayoutPanel2.Visible = true;
            fm1.tableLayoutPanel3.Visible = true;
            fm1.listView_customer.Visible = false;
        }

        //關閉admin
        public void close_admin(Form1 fm1)
        {
            fm1.trainToolStripMenuItem.Visible = false;
            fm1.button_customer_added.Enabled = false;
            fm1.button_customer_delete.Enabled = false;
            fm1.button_customer_modify.Enabled = false;
            fm1.button_customer_select.Enabled = false;
            fm1.button_customer_activity.Enabled = false;
        }

        //關閉manage
        public void close_manage(Form1 fm1)
        {
            fm1.TFnotopen = true;

            fm1.manage_train_btn.Enabled = true;
            fm1.manage_customer_image.Image = null;
            fm1.manage_customer_image.Enabled = false;
            fm1.manage_customer_name.Text = null;
            fm1.manage_customer_name.Enabled = false;
            fm1.manage_customer_permission.Text = null;
            fm1.manage_customer_permission.Enabled = false;
            fm1.manage_customer_RFID_ID.Text = null;
            fm1.manage_customer_RFID_ID.Enabled = false;
            fm1.manage_customer_state.Text = null;
            fm1.manage_customer_state.Enabled = false;
            fm1.manage_btn_cancel.Enabled = false;
            fm1.manage_btn_ok.Enabled = false;

            fm1.manage_train_btn.Visible = false;
            fm1.manage_customer_image.Visible = false;
            fm1.manage_customer_name.Visible = false;
            fm1.manage_customer_permission.Visible = false;
            fm1.manage_customer_RFID_ID.Visible = false;
            fm1.manage_customer_state.Visible = false;
            fm1.manage_btn_cancel.Visible = false;
            fm1.manage_btn_ok.Visible = false;
            fm1.label1.Visible = false;
            fm1.label2.Visible = false;
            fm1.label3.Visible = false;
            fm1.label4.Visible = false;
            fm1.tableLayoutPanel2.Visible = false;
            fm1.tableLayoutPanel3.Visible = false;
            fm1.listView_customer.Visible = false;

            fm1.message_bar.Text = "Message:";
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Access_Control_System
{
    public partial class verify : Form
    {
        Form1 Parent;
        rfid_reader rfid_reader = new rfid_reader();
        class_mysql mysql = new class_mysql();

        int count = 30, i = 0;
        public Boolean verify_success = false;

        public verify(Form1 _Parent)
        {
            InitializeComponent();
            Parent = _Parent;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i < 10)
            {
                i++;
            }
            else
            {
                i = 0;
                count -= 1;
            }

            if (count == 0)
            {
                rfid_reader.manage_read(Parent);
                this.Dispose();
            }

            label1.Text = count + "秒內刷入管理者卡片！";

            if (!string.IsNullOrWhiteSpace(Parent.customer[4]))
            {
                if (Convert.ToInt32(Parent.customer[4]) >= 755)
                {
                    timer1.Enabled = false;
                    label1.Text = "密碼：";
                    textBox1.Visible = true;
                    this.ActiveControl = this.textBox1;
                    textBox1.Focus();
                    btn_cancel.Visible = true;
                    btn_ok.Visible = true;
                    tabel_btn.Visible = true;
                    rfid_reader.stop_read(Parent);
                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            rfid_reader.manage_read(Parent);
            this.Dispose();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            SHA1 sha1 = new SHA1CryptoServiceProvider();
            string input_password = textBox1.Text;
            string resultSha1 = Convert.ToBase64String(sha1.ComputeHash(Encoding.Default.GetBytes(input_password)));

            if (resultSha1 == Parent.customer[1])
            {
                verify_success = true;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                verify_success = false;
                textBox1.Text = string.Empty;
                MessageBox.Show("密碼錯誤");
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                btn_ok_Click(this, null);
            }
            else if (keyData == Keys.Escape)
            {
                btn_cancel_Click(this, null);
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}

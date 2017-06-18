using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Access_Control_System
{
    public partial class setting : Form
    {
        #region Variables
        Form1 Parent;

        public Boolean serialportopen = false, mysqlopen = false, ArduinoOpen = false;
        public string hexmsbuff = string.Empty, card_id = string.Empty;

        public enum MsgType { System, User, Normal, Warning, Error };
        public Color[] MsgTypeColor = { Color.Blue, Color.Green, Color.Black, Color.Orange, Color.Red };

        class_mysql mysql = new class_mysql();
        #endregion

        public setting(Form1 _Parent)
        {
            InitializeComponent();
            Parent = _Parent;

            mysql.Initialize(host.Text, database.Text, user.Text, pwd.Text);
            search_serial();

            btn_connect.Text = (Parent.serialport.IsOpen) ? "中斷" : "連線";
            mysql_connect.Enabled = (mysqlopen == true) ? false : true;
            mysql_disconnect.Enabled = (mysqlopen == true) ? true : false;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F5)
            {
                search_serial();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        void search_serial()
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            //找尋可用的串列埠
            foreach (string com in SerialPort.GetPortNames())
            {
                comboBox1.Items.Add(com);
            }

            //找尋可用的串列埠
            foreach (string com in SerialPort.GetPortNames())
            {
                comboBox2.Items.Add(com);
            }
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            //串列埠連線
            if (Parent.serialportopen == false && Parent.serialport.IsOpen == false)
            {
                try
                {
                    //設定連接埠19200、n、8、1、n
                    Parent.serialport.PortName = comboBox1.Text;
                    Parent.serialport.BaudRate = 19200;
                    Parent.serialport.DataBits = 8;
                    Parent.serialport.Parity = Parity.None;
                    Parent.serialport.StopBits = StopBits.One;
                    Parent.serialport.Encoding = Encoding.ASCII;//傳輸編碼方式
                    Parent.serialport.Open();//串列埠開始連線
                    Parent.serialportopen = true;

                    //設定連接埠115200、n、8、1、n
                    Parent.Arduino_Serial.PortName = comboBox2.Text;
                    Parent.Arduino_Serial.BaudRate = 115200;
                    Parent.Arduino_Serial.DataBits = 8;
                    Parent.Arduino_Serial.Parity = Parity.None;
                    Parent.Arduino_Serial.StopBits = StopBits.One;
                    Parent.Arduino_Serial.Encoding = Encoding.ASCII;//傳輸編碼方式
                    Parent.Arduino_Serial.Open();//串列埠開始連線
                    Parent.ArduinoOpen = true;

                    btn_connect.Text = "中斷";

                    AddText(MsgType.System, "串列埠連線\r\n");
                }
                catch
                {
                    MessageBox.Show("請選擇COM Port！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //串列埠中斷
            else if(Parent.serialportopen == true && Parent.serialport.IsOpen == true)
            {
                try
                {
                    Parent.serialport.Close();
                    Parent.Arduino_Serial.Close();
                    Parent.serialportopen = false;
                    Parent.ArduinoOpen = false;
                    btn_connect.Text = "連線";

                    AddText(MsgType.System, "串列埠中斷\r\n");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        public void AddText(MsgType msgtype, string msg)
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

        private void mysql_connect_Click(object sender, EventArgs e)
        {
            mysql.Initialize(host.Text, database.Text, user.Text, pwd.Text);
            if (mysql.mysql_connect() == 1)
            {
                mysql_connect.Enabled = false;
                mysql_disconnect.Enabled = true;
                Parent.mysqlopen = true;

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

        private void mysql_disconnect_Click(object sender, EventArgs e)
        {
            if (mysql.mysql_disconnect() == "1")
            {
                Parent.mysqlopen = false;
                mysql_connect.Enabled = true;
                mysql_disconnect.Enabled = false;

                AddText(MsgType.System, "資料庫中斷\r\n");
            }
            else
            {
                MessageBox.Show(mysql.mysql_disconnect());
            }
        }

        private void btn_end_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void camera_btn_Click(object sender, EventArgs e)
        {
            Parent.initialise_capture();
        }
    }
}

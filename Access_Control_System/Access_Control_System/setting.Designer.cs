namespace Access_Control_System
{
    partial class setting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_connect = new System.Windows.Forms.Button();
            this.btn_end = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton2_char = new System.Windows.Forms.RadioButton();
            this.radioButton1_hex = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.database = new System.Windows.Forms.TextBox();
            this.label_database = new System.Windows.Forms.Label();
            this.mysql_connect = new System.Windows.Forms.Button();
            this.pwd = new System.Windows.Forms.TextBox();
            this.host = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.mysql_disconnect = new System.Windows.Forms.Button();
            this.user = new System.Windows.Forms.TextBox();
            this.label_host = new System.Windows.Forms.Label();
            this.Label_user = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label_com = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.camera_btn = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_connect
            // 
            this.btn_connect.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_connect.Location = new System.Drawing.Point(12, 60);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(75, 23);
            this.btn_connect.TabIndex = 44;
            this.btn_connect.Text = "連線";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // btn_end
            // 
            this.btn_end.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_end.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_end.Location = new System.Drawing.Point(14, 144);
            this.btn_end.Name = "btn_end";
            this.btn_end.Size = new System.Drawing.Size(185, 23);
            this.btn_end.TabIndex = 43;
            this.btn_end.Text = "結束";
            this.btn_end.UseVisualStyleBackColor = true;
            this.btn_end.Click += new System.EventHandler(this.btn_end_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton2_char);
            this.groupBox2.Controls.Add(this.radioButton1_hex);
            this.groupBox2.Location = new System.Drawing.Point(14, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(185, 41);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "資料格式";
            // 
            // radioButton2_char
            // 
            this.radioButton2_char.AutoSize = true;
            this.radioButton2_char.Checked = true;
            this.radioButton2_char.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radioButton2_char.Location = new System.Drawing.Point(110, 21);
            this.radioButton2_char.Name = "radioButton2_char";
            this.radioButton2_char.Size = new System.Drawing.Size(46, 16);
            this.radioButton2_char.TabIndex = 31;
            this.radioButton2_char.TabStop = true;
            this.radioButton2_char.Text = "Char";
            this.radioButton2_char.UseVisualStyleBackColor = true;
            // 
            // radioButton1_hex
            // 
            this.radioButton1_hex.AutoSize = true;
            this.radioButton1_hex.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radioButton1_hex.Location = new System.Drawing.Point(29, 21);
            this.radioButton1_hex.Name = "radioButton1_hex";
            this.radioButton1_hex.Size = new System.Drawing.Size(46, 16);
            this.radioButton1_hex.TabIndex = 30;
            this.radioButton1_hex.Text = "HEX";
            this.radioButton1_hex.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.database);
            this.groupBox1.Controls.Add(this.label_database);
            this.groupBox1.Controls.Add(this.mysql_connect);
            this.groupBox1.Controls.Add(this.pwd);
            this.groupBox1.Controls.Add(this.host);
            this.groupBox1.Controls.Add(this.label_password);
            this.groupBox1.Controls.Add(this.mysql_disconnect);
            this.groupBox1.Controls.Add(this.user);
            this.groupBox1.Controls.Add(this.label_host);
            this.groupBox1.Controls.Add(this.Label_user);
            this.groupBox1.Location = new System.Drawing.Point(205, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 158);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MySQL";
            // 
            // database
            // 
            this.database.Location = new System.Drawing.Point(8, 88);
            this.database.Name = "database";
            this.database.Size = new System.Drawing.Size(100, 22);
            this.database.TabIndex = 25;
            this.database.Text = "rfid";
            // 
            // label_database
            // 
            this.label_database.AutoSize = true;
            this.label_database.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_database.Location = new System.Drawing.Point(6, 73);
            this.label_database.Name = "label_database";
            this.label_database.Size = new System.Drawing.Size(49, 12);
            this.label_database.TabIndex = 24;
            this.label_database.Text = "Database:";
            // 
            // mysql_connect
            // 
            this.mysql_connect.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.mysql_connect.Location = new System.Drawing.Point(6, 116);
            this.mysql_connect.Name = "mysql_connect";
            this.mysql_connect.Size = new System.Drawing.Size(75, 23);
            this.mysql_connect.TabIndex = 16;
            this.mysql_connect.Text = "連接MySQL";
            this.mysql_connect.UseVisualStyleBackColor = true;
            this.mysql_connect.Click += new System.EventHandler(this.mysql_connect_Click);
            // 
            // pwd
            // 
            this.pwd.Location = new System.Drawing.Point(136, 88);
            this.pwd.Name = "pwd";
            this.pwd.PasswordChar = '*';
            this.pwd.Size = new System.Drawing.Size(100, 22);
            this.pwd.TabIndex = 23;
            this.pwd.Text = "csie2108";
            // 
            // host
            // 
            this.host.Location = new System.Drawing.Point(8, 48);
            this.host.Name = "host";
            this.host.Size = new System.Drawing.Size(100, 22);
            this.host.TabIndex = 17;
            this.host.Text = "163.17.136.253";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_password.Location = new System.Drawing.Point(136, 73);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(57, 12);
            this.label_password.TabIndex = 22;
            this.label_password.Text = "Password : ";
            // 
            // mysql_disconnect
            // 
            this.mysql_disconnect.Enabled = false;
            this.mysql_disconnect.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.mysql_disconnect.Location = new System.Drawing.Point(136, 116);
            this.mysql_disconnect.Name = "mysql_disconnect";
            this.mysql_disconnect.Size = new System.Drawing.Size(75, 23);
            this.mysql_disconnect.TabIndex = 18;
            this.mysql_disconnect.Text = "中斷MySQL";
            this.mysql_disconnect.UseVisualStyleBackColor = true;
            this.mysql_disconnect.Click += new System.EventHandler(this.mysql_disconnect_Click);
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(138, 48);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(100, 22);
            this.user.TabIndex = 21;
            this.user.Text = "root";
            // 
            // label_host
            // 
            this.label_host.AutoSize = true;
            this.label_host.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_host.Location = new System.Drawing.Point(6, 33);
            this.label_host.Name = "label_host";
            this.label_host.Size = new System.Drawing.Size(35, 12);
            this.label_host.TabIndex = 19;
            this.label_host.Text = "Host : ";
            // 
            // Label_user
            // 
            this.Label_user.AutoSize = true;
            this.Label_user.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label_user.Location = new System.Drawing.Point(136, 33);
            this.Label_user.Name = "Label_user";
            this.Label_user.Size = new System.Drawing.Size(32, 12);
            this.Label_user.TabIndex = 20;
            this.Label_user.Text = "User :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(87, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(112, 20);
            this.comboBox1.TabIndex = 40;
            // 
            // label_com
            // 
            this.label_com.AutoSize = true;
            this.label_com.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_com.Location = new System.Drawing.Point(12, 9);
            this.label_com.Name = "label_com";
            this.label_com.Size = new System.Drawing.Size(75, 12);
            this.label_com.TabIndex = 41;
            this.label_com.Text = "Zigbee COM : ";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 173);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(442, 96);
            this.richTextBox1.TabIndex = 46;
            this.richTextBox1.Text = "";
            // 
            // camera_btn
            // 
            this.camera_btn.Location = new System.Drawing.Point(124, 60);
            this.camera_btn.Name = "camera_btn";
            this.camera_btn.Size = new System.Drawing.Size(75, 23);
            this.camera_btn.TabIndex = 47;
            this.camera_btn.Text = "開啟相機";
            this.camera_btn.UseVisualStyleBackColor = true;
            this.camera_btn.Click += new System.EventHandler(this.camera_btn_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(87, 35);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(112, 20);
            this.comboBox2.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(5, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 12);
            this.label1.TabIndex = 49;
            this.label1.Text = "Arudino COM : ";
            // 
            // setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.CancelButton = this.btn_end;
            this.ClientSize = new System.Drawing.Size(466, 281);
            this.ControlBox = false;
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.camera_btn);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.btn_end);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label_com);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "setting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "setting";
            this.TopMost = true;
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Button btn_end;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox database;
        private System.Windows.Forms.Label label_database;
        private System.Windows.Forms.Button mysql_connect;
        private System.Windows.Forms.TextBox pwd;
        private System.Windows.Forms.TextBox host;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Button mysql_disconnect;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.Label label_host;
        private System.Windows.Forms.Label Label_user;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label_com;
        public System.Windows.Forms.RadioButton radioButton2_char;
        public System.Windows.Forms.RadioButton radioButton1_hex;
        public System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button camera_btn;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
    }
}
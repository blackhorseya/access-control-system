namespace RFID_Zigbee
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button_customer_activity_refresh = new System.Windows.Forms.Button();
            this.listView_customer_activity = new System.Windows.Forms.ListView();
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label_com = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button_customer_select = new System.Windows.Forms.Button();
            this.button_customer_modify = new System.Windows.Forms.Button();
            this.button_camera_stop = new System.Windows.Forms.Button();
            this.button_take_picture = new System.Windows.Forms.Button();
            this.pictureBox_camera = new System.Windows.Forms.PictureBox();
            this.button_customer_delete = new System.Windows.Forms.Button();
            this.button_customer_added = new System.Windows.Forms.Button();
            this.customer_information = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_customer_join_time = new System.Windows.Forms.TextBox();
            this.textBox_customer_state = new System.Windows.Forms.TextBox();
            this.textBox_customer_name = new System.Windows.Forms.TextBox();
            this.labe_customer_name = new System.Windows.Forms.Label();
            this.labe_customer_RFID_ID = new System.Windows.Forms.Label();
            this.labe_customer_state = new System.Windows.Forms.Label();
            this.labe_customer_join_time = new System.Windows.Forms.Label();
            this.textBox_customer_RFID_ID = new System.Windows.Forms.TextBox();
            this.listView_customer = new System.Windows.Forms.ListView();
            this.pictureBox_customer_image = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_visible = new System.Windows.Forms.Label();
            this.textBox_image_path = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_camera)).BeginInit();
            this.customer_information.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_customer_image)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Controls.Add(this.button_customer_activity_refresh);
            this.tabPage1.Controls.Add(this.listView_customer_activity);
            this.tabPage1.Controls.Add(this.btn_connect);
            this.tabPage1.Controls.Add(this.btn_end);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.label_com);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button_customer_activity_refresh
            // 
            resources.ApplyResources(this.button_customer_activity_refresh, "button_customer_activity_refresh");
            this.button_customer_activity_refresh.Name = "button_customer_activity_refresh";
            this.button_customer_activity_refresh.UseVisualStyleBackColor = true;
            this.button_customer_activity_refresh.Click += new System.EventHandler(this.button_customer_activity_refresh_Click);
            // 
            // listView_customer_activity
            // 
            resources.ApplyResources(this.listView_customer_activity, "listView_customer_activity");
            this.listView_customer_activity.GridLines = true;
            this.listView_customer_activity.MultiSelect = false;
            this.listView_customer_activity.Name = "listView_customer_activity";
            this.listView_customer_activity.UseCompatibleStateImageBehavior = false;
            this.listView_customer_activity.View = System.Windows.Forms.View.Details;
            // 
            // btn_connect
            // 
            resources.ApplyResources(this.btn_connect, "btn_connect");
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // btn_end
            // 
            resources.ApplyResources(this.btn_end, "btn_end");
            this.btn_end.Name = "btn_end";
            this.btn_end.UseVisualStyleBackColor = true;
            this.btn_end.Click += new System.EventHandler(this.btn_end_Click);
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.radioButton2_char);
            this.groupBox2.Controls.Add(this.radioButton1_hex);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // radioButton2_char
            // 
            resources.ApplyResources(this.radioButton2_char, "radioButton2_char");
            this.radioButton2_char.Checked = true;
            this.radioButton2_char.Name = "radioButton2_char";
            this.radioButton2_char.TabStop = true;
            this.radioButton2_char.UseVisualStyleBackColor = true;
            // 
            // radioButton1_hex
            // 
            resources.ApplyResources(this.radioButton1_hex, "radioButton1_hex");
            this.radioButton1_hex.Name = "radioButton1_hex";
            this.radioButton1_hex.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
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
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // database
            // 
            resources.ApplyResources(this.database, "database");
            this.database.Name = "database";
            // 
            // label_database
            // 
            resources.ApplyResources(this.label_database, "label_database");
            this.label_database.Name = "label_database";
            // 
            // mysql_connect
            // 
            resources.ApplyResources(this.mysql_connect, "mysql_connect");
            this.mysql_connect.Name = "mysql_connect";
            this.mysql_connect.UseVisualStyleBackColor = true;
            this.mysql_connect.Click += new System.EventHandler(this.mysql_connect_Click);
            // 
            // pwd
            // 
            resources.ApplyResources(this.pwd, "pwd");
            this.pwd.Name = "pwd";
            // 
            // host
            // 
            resources.ApplyResources(this.host, "host");
            this.host.Name = "host";
            // 
            // label_password
            // 
            resources.ApplyResources(this.label_password, "label_password");
            this.label_password.Name = "label_password";
            // 
            // mysql_disconnect
            // 
            resources.ApplyResources(this.mysql_disconnect, "mysql_disconnect");
            this.mysql_disconnect.Name = "mysql_disconnect";
            this.mysql_disconnect.UseVisualStyleBackColor = true;
            this.mysql_disconnect.Click += new System.EventHandler(this.mysql_disconnect_Click);
            // 
            // user
            // 
            resources.ApplyResources(this.user, "user");
            this.user.Name = "user";
            // 
            // label_host
            // 
            resources.ApplyResources(this.label_host, "label_host");
            this.label_host.Name = "label_host";
            // 
            // Label_user
            // 
            resources.ApplyResources(this.Label_user, "Label_user");
            this.Label_user.Name = "Label_user";
            // 
            // richTextBox1
            // 
            resources.ApplyResources(this.richTextBox1, "richTextBox1");
            this.richTextBox1.Name = "richTextBox1";
            // 
            // comboBox1
            // 
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Name = "comboBox1";
            // 
            // label_com
            // 
            resources.ApplyResources(this.label_com, "label_com");
            this.label_com.Name = "label_com";
            // 
            // tabPage2
            // 
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Controls.Add(this.button_customer_select);
            this.tabPage2.Controls.Add(this.button_customer_modify);
            this.tabPage2.Controls.Add(this.button_camera_stop);
            this.tabPage2.Controls.Add(this.button_take_picture);
            this.tabPage2.Controls.Add(this.pictureBox_camera);
            this.tabPage2.Controls.Add(this.button_customer_delete);
            this.tabPage2.Controls.Add(this.button_customer_added);
            this.tabPage2.Controls.Add(this.customer_information);
            this.tabPage2.Controls.Add(this.listView_customer);
            this.tabPage2.Controls.Add(this.pictureBox_customer_image);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button_customer_select
            // 
            resources.ApplyResources(this.button_customer_select, "button_customer_select");
            this.button_customer_select.Name = "button_customer_select";
            this.button_customer_select.UseVisualStyleBackColor = true;
            this.button_customer_select.Click += new System.EventHandler(this.button_customer_select_Click);
            // 
            // button_customer_modify
            // 
            resources.ApplyResources(this.button_customer_modify, "button_customer_modify");
            this.button_customer_modify.Name = "button_customer_modify";
            this.button_customer_modify.UseVisualStyleBackColor = true;
            this.button_customer_modify.Click += new System.EventHandler(this.button_customer_modify_Click);
            // 
            // button_camera_stop
            // 
            resources.ApplyResources(this.button_camera_stop, "button_camera_stop");
            this.button_camera_stop.Name = "button_camera_stop";
            this.button_camera_stop.UseVisualStyleBackColor = true;
            this.button_camera_stop.Click += new System.EventHandler(this.button_camera_stop_Click);
            // 
            // button_take_picture
            // 
            resources.ApplyResources(this.button_take_picture, "button_take_picture");
            this.button_take_picture.Name = "button_take_picture";
            this.button_take_picture.UseVisualStyleBackColor = true;
            this.button_take_picture.Click += new System.EventHandler(this.button_take_picture_Click);
            // 
            // pictureBox_camera
            // 
            resources.ApplyResources(this.pictureBox_camera, "pictureBox_camera");
            this.pictureBox_camera.Name = "pictureBox_camera";
            this.pictureBox_camera.TabStop = false;
            // 
            // button_customer_delete
            // 
            resources.ApplyResources(this.button_customer_delete, "button_customer_delete");
            this.button_customer_delete.Name = "button_customer_delete";
            this.button_customer_delete.UseVisualStyleBackColor = true;
            this.button_customer_delete.Click += new System.EventHandler(this.button_customer_delete_Click);
            // 
            // button_customer_added
            // 
            resources.ApplyResources(this.button_customer_added, "button_customer_added");
            this.button_customer_added.Name = "button_customer_added";
            this.button_customer_added.UseVisualStyleBackColor = true;
            this.button_customer_added.Click += new System.EventHandler(this.button_customer_added_Click);
            // 
            // customer_information
            // 
            resources.ApplyResources(this.customer_information, "customer_information");
            this.customer_information.Controls.Add(this.textBox_customer_join_time, 1, 3);
            this.customer_information.Controls.Add(this.textBox_customer_state, 1, 2);
            this.customer_information.Controls.Add(this.textBox_customer_name, 1, 0);
            this.customer_information.Controls.Add(this.labe_customer_name, 0, 0);
            this.customer_information.Controls.Add(this.labe_customer_RFID_ID, 0, 1);
            this.customer_information.Controls.Add(this.labe_customer_state, 0, 2);
            this.customer_information.Controls.Add(this.labe_customer_join_time, 0, 3);
            this.customer_information.Controls.Add(this.textBox_customer_RFID_ID, 1, 1);
            this.customer_information.Name = "customer_information";
            // 
            // textBox_customer_join_time
            // 
            resources.ApplyResources(this.textBox_customer_join_time, "textBox_customer_join_time");
            this.textBox_customer_join_time.Name = "textBox_customer_join_time";
            this.textBox_customer_join_time.ReadOnly = true;
            // 
            // textBox_customer_state
            // 
            resources.ApplyResources(this.textBox_customer_state, "textBox_customer_state");
            this.textBox_customer_state.Name = "textBox_customer_state";
            this.textBox_customer_state.ReadOnly = true;
            // 
            // textBox_customer_name
            // 
            resources.ApplyResources(this.textBox_customer_name, "textBox_customer_name");
            this.textBox_customer_name.Name = "textBox_customer_name";
            this.textBox_customer_name.ReadOnly = true;
            // 
            // labe_customer_name
            // 
            resources.ApplyResources(this.labe_customer_name, "labe_customer_name");
            this.labe_customer_name.Name = "labe_customer_name";
            // 
            // labe_customer_RFID_ID
            // 
            resources.ApplyResources(this.labe_customer_RFID_ID, "labe_customer_RFID_ID");
            this.labe_customer_RFID_ID.Name = "labe_customer_RFID_ID";
            // 
            // labe_customer_state
            // 
            resources.ApplyResources(this.labe_customer_state, "labe_customer_state");
            this.labe_customer_state.Name = "labe_customer_state";
            // 
            // labe_customer_join_time
            // 
            resources.ApplyResources(this.labe_customer_join_time, "labe_customer_join_time");
            this.labe_customer_join_time.Name = "labe_customer_join_time";
            // 
            // textBox_customer_RFID_ID
            // 
            resources.ApplyResources(this.textBox_customer_RFID_ID, "textBox_customer_RFID_ID");
            this.textBox_customer_RFID_ID.Name = "textBox_customer_RFID_ID";
            this.textBox_customer_RFID_ID.ReadOnly = true;
            // 
            // listView_customer
            // 
            resources.ApplyResources(this.listView_customer, "listView_customer");
            this.listView_customer.GridLines = true;
            this.listView_customer.Name = "listView_customer";
            this.listView_customer.UseCompatibleStateImageBehavior = false;
            this.listView_customer.View = System.Windows.Forms.View.Details;
            // 
            // pictureBox_customer_image
            // 
            resources.ApplyResources(this.pictureBox_customer_image, "pictureBox_customer_image");
            this.pictureBox_customer_image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_customer_image.Name = "pictureBox_customer_image";
            this.pictureBox_customer_image.TabStop = false;
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // label_visible
            // 
            resources.ApplyResources(this.label_visible, "label_visible");
            this.label_visible.Name = "label_visible";
            // 
            // textBox_image_path
            // 
            resources.ApplyResources(this.textBox_image_path, "textBox_image_path");
            this.textBox_image_path.Name = "textBox_image_path";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox_image_path);
            this.Controls.Add(this.label_visible);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_camera)).EndInit();
            this.customer_information.ResumeLayout(false);
            this.customer_information.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_customer_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView listView_customer_activity;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Button btn_end;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton2_char;
        private System.Windows.Forms.RadioButton radioButton1_hex;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button mysql_connect;
        private System.Windows.Forms.TextBox pwd;
        private System.Windows.Forms.TextBox host;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Button mysql_disconnect;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.Label label_host;
        private System.Windows.Forms.Label Label_user;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label_com;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox database;
        private System.Windows.Forms.Label label_database;
        private System.Windows.Forms.TableLayoutPanel customer_information;
        private System.Windows.Forms.Label labe_customer_name;
        private System.Windows.Forms.Label labe_customer_RFID_ID;
        private System.Windows.Forms.Label labe_customer_state;
        private System.Windows.Forms.Label labe_customer_join_time;
        private System.Windows.Forms.Button button_customer_delete;
        private System.Windows.Forms.Button button_customer_added;
        private System.Windows.Forms.Button button_camera_stop;
        private System.Windows.Forms.Button button_take_picture;
        private System.Windows.Forms.Button button1;
        internal System.Windows.Forms.TextBox textBox1;
        internal System.Windows.Forms.Label label_visible;
        private System.Windows.Forms.Button button_customer_modify;
        private System.Windows.Forms.Button button_customer_select;
        private System.Windows.Forms.Button button_customer_activity_refresh;
        internal System.Windows.Forms.ListView listView_customer;
        internal System.Windows.Forms.TextBox textBox_customer_name;
        internal System.Windows.Forms.TextBox textBox_customer_join_time;
        internal System.Windows.Forms.TextBox textBox_customer_state;
        internal System.Windows.Forms.TextBox textBox_customer_RFID_ID;
        internal System.Windows.Forms.PictureBox pictureBox_camera;
        internal System.Windows.Forms.PictureBox pictureBox_customer_image;
        internal System.Windows.Forms.TextBox textBox_image_path;


    }
}


namespace RFID_Zigbee
{
    partial class customer_added
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
            this.components = new System.ComponentModel.Container();
            this.customer_information = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_customer_permission = new System.Windows.Forms.TextBox();
            this.textBox_customer_name = new System.Windows.Forms.TextBox();
            this.labe_customer_name = new System.Windows.Forms.Label();
            this.labe_customer_RFID_ID = new System.Windows.Forms.Label();
            this.labe_customer_state = new System.Windows.Forms.Label();
            this.labe_customer_permission = new System.Windows.Forms.Label();
            this.textBox_customer_RFID_ID = new System.Windows.Forms.TextBox();
            this.comboBox_customer_state = new System.Windows.Forms.ComboBox();
            this.pictureBox_customer_image = new System.Windows.Forms.PictureBox();
            this.button_customer_upload_image = new System.Windows.Forms.Button();
            this.button_ok = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button_check_ok = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button_take_picture = new System.Windows.Forms.Button();
            this.customer_information.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_customer_image)).BeginInit();
            this.SuspendLayout();
            // 
            // customer_information
            // 
            this.customer_information.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.customer_information.ColumnCount = 2;
            this.customer_information.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.93785F));
            this.customer_information.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.06215F));
            this.customer_information.Controls.Add(this.textBox_customer_permission, 1, 3);
            this.customer_information.Controls.Add(this.textBox_customer_name, 1, 0);
            this.customer_information.Controls.Add(this.labe_customer_name, 0, 0);
            this.customer_information.Controls.Add(this.labe_customer_RFID_ID, 0, 1);
            this.customer_information.Controls.Add(this.labe_customer_state, 0, 2);
            this.customer_information.Controls.Add(this.labe_customer_permission, 0, 3);
            this.customer_information.Controls.Add(this.textBox_customer_RFID_ID, 1, 1);
            this.customer_information.Controls.Add(this.comboBox_customer_state, 1, 2);
            this.customer_information.Location = new System.Drawing.Point(161, 12);
            this.customer_information.Name = "customer_information";
            this.customer_information.RowCount = 4;
            this.customer_information.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.customer_information.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.customer_information.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.customer_information.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.customer_information.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.customer_information.Size = new System.Drawing.Size(178, 211);
            this.customer_information.TabIndex = 7;
            // 
            // textBox_customer_permission
            // 
            this.textBox_customer_permission.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_customer_permission.Location = new System.Drawing.Point(80, 172);
            this.textBox_customer_permission.Name = "textBox_customer_permission";
            this.textBox_customer_permission.Size = new System.Drawing.Size(94, 22);
            this.textBox_customer_permission.TabIndex = 10;
            // 
            // textBox_customer_name
            // 
            this.textBox_customer_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_customer_name.Location = new System.Drawing.Point(80, 15);
            this.textBox_customer_name.Name = "textBox_customer_name";
            this.textBox_customer_name.Size = new System.Drawing.Size(94, 22);
            this.textBox_customer_name.TabIndex = 7;
            // 
            // labe_customer_name
            // 
            this.labe_customer_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labe_customer_name.AutoSize = true;
            this.labe_customer_name.Location = new System.Drawing.Point(4, 20);
            this.labe_customer_name.Name = "labe_customer_name";
            this.labe_customer_name.Size = new System.Drawing.Size(69, 12);
            this.labe_customer_name.TabIndex = 2;
            this.labe_customer_name.Text = "名字：";
            // 
            // labe_customer_RFID_ID
            // 
            this.labe_customer_RFID_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labe_customer_RFID_ID.AutoSize = true;
            this.labe_customer_RFID_ID.Location = new System.Drawing.Point(4, 72);
            this.labe_customer_RFID_ID.Name = "labe_customer_RFID_ID";
            this.labe_customer_RFID_ID.Size = new System.Drawing.Size(69, 12);
            this.labe_customer_RFID_ID.TabIndex = 3;
            this.labe_customer_RFID_ID.Text = "RFID_ID：";
            // 
            // labe_customer_state
            // 
            this.labe_customer_state.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labe_customer_state.AutoSize = true;
            this.labe_customer_state.Location = new System.Drawing.Point(4, 124);
            this.labe_customer_state.Name = "labe_customer_state";
            this.labe_customer_state.Size = new System.Drawing.Size(69, 12);
            this.labe_customer_state.TabIndex = 4;
            this.labe_customer_state.Text = "狀態：";
            // 
            // labe_customer_permission
            // 
            this.labe_customer_permission.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labe_customer_permission.AutoSize = true;
            this.labe_customer_permission.Location = new System.Drawing.Point(4, 177);
            this.labe_customer_permission.Name = "labe_customer_permission";
            this.labe_customer_permission.Size = new System.Drawing.Size(69, 12);
            this.labe_customer_permission.TabIndex = 5;
            this.labe_customer_permission.Text = "權限：";
            // 
            // textBox_customer_RFID_ID
            // 
            this.textBox_customer_RFID_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_customer_RFID_ID.Location = new System.Drawing.Point(80, 67);
            this.textBox_customer_RFID_ID.Name = "textBox_customer_RFID_ID";
            this.textBox_customer_RFID_ID.ReadOnly = true;
            this.textBox_customer_RFID_ID.Size = new System.Drawing.Size(94, 22);
            this.textBox_customer_RFID_ID.TabIndex = 8;
            // 
            // comboBox_customer_state
            // 
            this.comboBox_customer_state.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_customer_state.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_customer_state.FormattingEnabled = true;
            this.comboBox_customer_state.Items.AddRange(new object[] {
            "0(禁用)",
            "1(啟用)"});
            this.comboBox_customer_state.Location = new System.Drawing.Point(80, 120);
            this.comboBox_customer_state.Name = "comboBox_customer_state";
            this.comboBox_customer_state.Size = new System.Drawing.Size(94, 20);
            this.comboBox_customer_state.TabIndex = 9;
            // 
            // pictureBox_customer_image
            // 
            this.pictureBox_customer_image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_customer_image.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_customer_image.Name = "pictureBox_customer_image";
            this.pictureBox_customer_image.Size = new System.Drawing.Size(143, 182);
            this.pictureBox_customer_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_customer_image.TabIndex = 8;
            this.pictureBox_customer_image.TabStop = false;
            // 
            // button_customer_upload_image
            // 
            this.button_customer_upload_image.Location = new System.Drawing.Point(92, 200);
            this.button_customer_upload_image.Name = "button_customer_upload_image";
            this.button_customer_upload_image.Size = new System.Drawing.Size(63, 23);
            this.button_customer_upload_image.TabIndex = 9;
            this.button_customer_upload_image.Text = "上傳照片";
            this.button_customer_upload_image.UseVisualStyleBackColor = true;
            this.button_customer_upload_image.Click += new System.EventHandler(this.button_customer_upload_image_Click);
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(126, 302);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(75, 23);
            this.button_ok.TabIndex = 10;
            this.button_ok.Text = "新增";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(207, 302);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 11;
            this.button_cancel.Text = "取消";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 21);
            this.label1.TabIndex = 12;
            // 
            // button_check_ok
            // 
            this.button_check_ok.Location = new System.Drawing.Point(45, 302);
            this.button_check_ok.Name = "button_check_ok";
            this.button_check_ok.Size = new System.Drawing.Size(75, 23);
            this.button_check_ok.TabIndex = 13;
            this.button_check_ok.Text = "確認";
            this.button_check_ok.UseVisualStyleBackColor = true;
            this.button_check_ok.Visible = false;
            this.button_check_ok.Click += new System.EventHandler(this.button_check_ok_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // button_take_picture
            // 
            this.button_take_picture.Location = new System.Drawing.Point(12, 200);
            this.button_take_picture.Name = "button_take_picture";
            this.button_take_picture.Size = new System.Drawing.Size(63, 23);
            this.button_take_picture.TabIndex = 14;
            this.button_take_picture.Text = "拍照";
            this.button_take_picture.UseVisualStyleBackColor = true;
            // 
            // customer_added
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 344);
            this.Controls.Add(this.button_take_picture);
            this.Controls.Add(this.button_check_ok);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.button_customer_upload_image);
            this.Controls.Add(this.customer_information);
            this.Controls.Add(this.pictureBox_customer_image);
            this.Name = "customer_added";
            this.Text = "customer_added";
            this.Load += new System.EventHandler(this.customer_added_Load);
            this.customer_information.ResumeLayout(false);
            this.customer_information.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_customer_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel customer_information;
        private System.Windows.Forms.Label labe_customer_name;
        private System.Windows.Forms.Label labe_customer_RFID_ID;
        private System.Windows.Forms.Label labe_customer_state;
        private System.Windows.Forms.Label labe_customer_permission;
        private System.Windows.Forms.Button button_customer_upload_image;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox textBox_customer_name;
        internal System.Windows.Forms.TextBox textBox_customer_RFID_ID;
        internal System.Windows.Forms.ComboBox comboBox_customer_state;
        internal System.Windows.Forms.TextBox textBox_customer_permission;
        private System.Windows.Forms.Button button_check_ok;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        internal System.Windows.Forms.PictureBox pictureBox_customer_image;
        private System.Windows.Forms.Button button_take_picture;
    }
}
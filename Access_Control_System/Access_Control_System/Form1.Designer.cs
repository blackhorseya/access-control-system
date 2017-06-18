namespace Access_Control_System
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.trainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.singleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parrellelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.user_tabPage = new System.Windows.Forms.TabPage();
            this.image_PICBX = new System.Windows.Forms.PictureBox();
            this.customer_information = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_customer_join_time = new System.Windows.Forms.TextBox();
            this.textBox_customer_state = new System.Windows.Forms.TextBox();
            this.textBox_customer_name = new System.Windows.Forms.TextBox();
            this.labe_customer_name = new System.Windows.Forms.Label();
            this.labe_customer_RFID_ID = new System.Windows.Forms.Label();
            this.labe_customer_state = new System.Windows.Forms.Label();
            this.labe_customer_join_time = new System.Windows.Forms.Label();
            this.textBox_customer_RFID_ID = new System.Windows.Forms.TextBox();
            this.pictureBox_customer_image = new System.Windows.Forms.PictureBox();
            this.admin_tabPage = new System.Windows.Forms.TabPage();
            this.manage_train_btn = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.manage_btn_cancel = new System.Windows.Forms.Button();
            this.manage_btn_ok = new System.Windows.Forms.Button();
            this.manage_customer_image = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.manage_customer_permission = new System.Windows.Forms.TextBox();
            this.manage_customer_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.manage_customer_RFID_ID = new System.Windows.Forms.TextBox();
            this.manage_customer_state = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button_customer_select = new System.Windows.Forms.Button();
            this.button_customer_added = new System.Windows.Forms.Button();
            this.button_customer_delete = new System.Windows.Forms.Button();
            this.button_customer_modify = new System.Windows.Forms.Button();
            this.button_customer_activity = new System.Windows.Forms.Button();
            this.listView_customer = new System.Windows.Forms.ListView();
            this.message_bar = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Eigne_threshold_txtbx = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.user_tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image_PICBX)).BeginInit();
            this.customer_information.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_customer_image)).BeginInit();
            this.admin_tabPage.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manage_customer_image)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trainToolStripMenuItem,
            this.processingToolStripMenuItem,
            this.settingToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(781, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // trainToolStripMenuItem
            // 
            this.trainToolStripMenuItem.Name = "trainToolStripMenuItem";
            this.trainToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.trainToolStripMenuItem.Text = "&Train";
            this.trainToolStripMenuItem.Visible = false;
            this.trainToolStripMenuItem.Click += new System.EventHandler(this.trainToolStripMenuItem_Click);
            // 
            // processingToolStripMenuItem
            // 
            this.processingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.singleToolStripMenuItem,
            this.parrellelToolStripMenuItem});
            this.processingToolStripMenuItem.Name = "processingToolStripMenuItem";
            this.processingToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.processingToolStripMenuItem.Text = "&Processing";
            // 
            // singleToolStripMenuItem
            // 
            this.singleToolStripMenuItem.Checked = true;
            this.singleToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.singleToolStripMenuItem.Name = "singleToolStripMenuItem";
            this.singleToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.singleToolStripMenuItem.Text = "Standard";
            this.singleToolStripMenuItem.Click += new System.EventHandler(this.singleToolStripMenuItem_Click);
            // 
            // parrellelToolStripMenuItem
            // 
            this.parrellelToolStripMenuItem.Name = "parrellelToolStripMenuItem";
            this.parrellelToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.parrellelToolStripMenuItem.Text = "Parallel";
            this.parrellelToolStripMenuItem.Click += new System.EventHandler(this.parrellelToolStripMenuItem_Click);
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.settingToolStripMenuItem.Text = "&Setting";
            this.settingToolStripMenuItem.Click += new System.EventHandler(this.settingToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.user_tabPage);
            this.tabControl1.Controls.Add(this.admin_tabPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(757, 435);
            this.tabControl1.TabIndex = 1;
            // 
            // user_tabPage
            // 
            this.user_tabPage.Controls.Add(this.image_PICBX);
            this.user_tabPage.Controls.Add(this.customer_information);
            this.user_tabPage.Controls.Add(this.pictureBox_customer_image);
            this.user_tabPage.Location = new System.Drawing.Point(4, 22);
            this.user_tabPage.Name = "user_tabPage";
            this.user_tabPage.Size = new System.Drawing.Size(749, 409);
            this.user_tabPage.TabIndex = 2;
            this.user_tabPage.Text = "門禁系統";
            this.user_tabPage.UseVisualStyleBackColor = true;
            // 
            // image_PICBX
            // 
            this.image_PICBX.Location = new System.Drawing.Point(215, 13);
            this.image_PICBX.Name = "image_PICBX";
            this.image_PICBX.Size = new System.Drawing.Size(512, 384);
            this.image_PICBX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.image_PICBX.TabIndex = 11;
            this.image_PICBX.TabStop = false;
            // 
            // customer_information
            // 
            this.customer_information.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.customer_information.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.customer_information.ColumnCount = 2;
            this.customer_information.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.93785F));
            this.customer_information.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.06215F));
            this.customer_information.Controls.Add(this.textBox_customer_join_time, 1, 3);
            this.customer_information.Controls.Add(this.textBox_customer_state, 1, 2);
            this.customer_information.Controls.Add(this.textBox_customer_name, 1, 0);
            this.customer_information.Controls.Add(this.labe_customer_name, 0, 0);
            this.customer_information.Controls.Add(this.labe_customer_RFID_ID, 0, 1);
            this.customer_information.Controls.Add(this.labe_customer_state, 0, 2);
            this.customer_information.Controls.Add(this.labe_customer_join_time, 0, 3);
            this.customer_information.Controls.Add(this.textBox_customer_RFID_ID, 1, 1);
            this.customer_information.Location = new System.Drawing.Point(3, 262);
            this.customer_information.Name = "customer_information";
            this.customer_information.RowCount = 4;
            this.customer_information.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.customer_information.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.customer_information.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.customer_information.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.customer_information.Size = new System.Drawing.Size(189, 144);
            this.customer_information.TabIndex = 9;
            // 
            // textBox_customer_join_time
            // 
            this.textBox_customer_join_time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_customer_join_time.Location = new System.Drawing.Point(84, 113);
            this.textBox_customer_join_time.Name = "textBox_customer_join_time";
            this.textBox_customer_join_time.ReadOnly = true;
            this.textBox_customer_join_time.Size = new System.Drawing.Size(101, 22);
            this.textBox_customer_join_time.TabIndex = 10;
            // 
            // textBox_customer_state
            // 
            this.textBox_customer_state.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_customer_state.Location = new System.Drawing.Point(84, 77);
            this.textBox_customer_state.Name = "textBox_customer_state";
            this.textBox_customer_state.ReadOnly = true;
            this.textBox_customer_state.Size = new System.Drawing.Size(101, 22);
            this.textBox_customer_state.TabIndex = 9;
            // 
            // textBox_customer_name
            // 
            this.textBox_customer_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_customer_name.Location = new System.Drawing.Point(84, 7);
            this.textBox_customer_name.Name = "textBox_customer_name";
            this.textBox_customer_name.ReadOnly = true;
            this.textBox_customer_name.Size = new System.Drawing.Size(101, 22);
            this.textBox_customer_name.TabIndex = 7;
            // 
            // labe_customer_name
            // 
            this.labe_customer_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labe_customer_name.AutoSize = true;
            this.labe_customer_name.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labe_customer_name.Location = new System.Drawing.Point(4, 12);
            this.labe_customer_name.Name = "labe_customer_name";
            this.labe_customer_name.Size = new System.Drawing.Size(73, 12);
            this.labe_customer_name.TabIndex = 2;
            this.labe_customer_name.Text = "名字：";
            // 
            // labe_customer_RFID_ID
            // 
            this.labe_customer_RFID_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labe_customer_RFID_ID.AutoSize = true;
            this.labe_customer_RFID_ID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labe_customer_RFID_ID.Location = new System.Drawing.Point(4, 47);
            this.labe_customer_RFID_ID.Name = "labe_customer_RFID_ID";
            this.labe_customer_RFID_ID.Size = new System.Drawing.Size(73, 12);
            this.labe_customer_RFID_ID.TabIndex = 3;
            this.labe_customer_RFID_ID.Text = "RFID_ID：";
            // 
            // labe_customer_state
            // 
            this.labe_customer_state.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labe_customer_state.AutoSize = true;
            this.labe_customer_state.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labe_customer_state.Location = new System.Drawing.Point(4, 82);
            this.labe_customer_state.Name = "labe_customer_state";
            this.labe_customer_state.Size = new System.Drawing.Size(73, 12);
            this.labe_customer_state.TabIndex = 4;
            this.labe_customer_state.Text = "狀態：";
            // 
            // labe_customer_join_time
            // 
            this.labe_customer_join_time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labe_customer_join_time.AutoSize = true;
            this.labe_customer_join_time.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labe_customer_join_time.Location = new System.Drawing.Point(4, 118);
            this.labe_customer_join_time.Name = "labe_customer_join_time";
            this.labe_customer_join_time.Size = new System.Drawing.Size(73, 12);
            this.labe_customer_join_time.TabIndex = 5;
            this.labe_customer_join_time.Text = "加入時間：";
            // 
            // textBox_customer_RFID_ID
            // 
            this.textBox_customer_RFID_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_customer_RFID_ID.Location = new System.Drawing.Point(84, 42);
            this.textBox_customer_RFID_ID.Name = "textBox_customer_RFID_ID";
            this.textBox_customer_RFID_ID.ReadOnly = true;
            this.textBox_customer_RFID_ID.Size = new System.Drawing.Size(101, 22);
            this.textBox_customer_RFID_ID.TabIndex = 8;
            // 
            // pictureBox_customer_image
            // 
            this.pictureBox_customer_image.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_customer_image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_customer_image.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox_customer_image.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_customer_image.Name = "pictureBox_customer_image";
            this.pictureBox_customer_image.Size = new System.Drawing.Size(192, 256);
            this.pictureBox_customer_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_customer_image.TabIndex = 10;
            this.pictureBox_customer_image.TabStop = false;
            // 
            // admin_tabPage
            // 
            this.admin_tabPage.Controls.Add(this.manage_train_btn);
            this.admin_tabPage.Controls.Add(this.tableLayoutPanel3);
            this.admin_tabPage.Controls.Add(this.manage_customer_image);
            this.admin_tabPage.Controls.Add(this.tableLayoutPanel2);
            this.admin_tabPage.Controls.Add(this.tableLayoutPanel1);
            this.admin_tabPage.Controls.Add(this.listView_customer);
            this.admin_tabPage.Location = new System.Drawing.Point(4, 22);
            this.admin_tabPage.Name = "admin_tabPage";
            this.admin_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.admin_tabPage.Size = new System.Drawing.Size(749, 409);
            this.admin_tabPage.TabIndex = 0;
            this.admin_tabPage.Text = "管理系統";
            this.admin_tabPage.UseVisualStyleBackColor = true;
            // 
            // manage_train_btn
            // 
            this.manage_train_btn.Enabled = false;
            this.manage_train_btn.Location = new System.Drawing.Point(6, 375);
            this.manage_train_btn.Name = "manage_train_btn";
            this.manage_train_btn.Size = new System.Drawing.Size(240, 23);
            this.manage_train_btn.TabIndex = 15;
            this.manage_train_btn.Text = "訓練人臉辨識";
            this.manage_train_btn.UseVisualStyleBackColor = true;
            this.manage_train_btn.Visible = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.manage_btn_cancel, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.manage_btn_ok, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(252, 375);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(223, 31);
            this.tableLayoutPanel3.TabIndex = 13;
            this.tableLayoutPanel3.Visible = false;
            // 
            // manage_btn_cancel
            // 
            this.manage_btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.manage_btn_cancel.Enabled = false;
            this.manage_btn_cancel.FlatAppearance.BorderSize = 0;
            this.manage_btn_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.manage_btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manage_btn_cancel.Image = global::Access_Control_System.Properties.Resources.cancel;
            this.manage_btn_cancel.Location = new System.Drawing.Point(114, 3);
            this.manage_btn_cancel.Name = "manage_btn_cancel";
            this.manage_btn_cancel.Size = new System.Drawing.Size(106, 25);
            this.manage_btn_cancel.TabIndex = 13;
            this.manage_btn_cancel.UseVisualStyleBackColor = true;
            this.manage_btn_cancel.Visible = false;
            this.manage_btn_cancel.Click += new System.EventHandler(this.manage_btn_cancel_Click);
            // 
            // manage_btn_ok
            // 
            this.manage_btn_ok.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.manage_btn_ok.Enabled = false;
            this.manage_btn_ok.FlatAppearance.BorderSize = 0;
            this.manage_btn_ok.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.manage_btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manage_btn_ok.Image = global::Access_Control_System.Properties.Resources.ok;
            this.manage_btn_ok.Location = new System.Drawing.Point(3, 3);
            this.manage_btn_ok.Name = "manage_btn_ok";
            this.manage_btn_ok.Size = new System.Drawing.Size(105, 25);
            this.manage_btn_ok.TabIndex = 12;
            this.manage_btn_ok.UseVisualStyleBackColor = true;
            this.manage_btn_ok.Visible = false;
            this.manage_btn_ok.Click += new System.EventHandler(this.manage_btn_ok_Click);
            // 
            // manage_customer_image
            // 
            this.manage_customer_image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.manage_customer_image.Enabled = false;
            this.manage_customer_image.Location = new System.Drawing.Point(6, 49);
            this.manage_customer_image.Name = "manage_customer_image";
            this.manage_customer_image.Size = new System.Drawing.Size(240, 320);
            this.manage_customer_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.manage_customer_image.TabIndex = 11;
            this.manage_customer_image.TabStop = false;
            this.manage_customer_image.Visible = false;
            this.manage_customer_image.Click += new System.EventHandler(this.manage_customer_image_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.93785F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.06215F));
            this.tableLayoutPanel2.Controls.Add(this.manage_customer_permission, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.manage_customer_name, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.manage_customer_RFID_ID, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.manage_customer_state, 1, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(252, 49);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(240, 320);
            this.tableLayoutPanel2.TabIndex = 10;
            this.tableLayoutPanel2.Visible = false;
            // 
            // manage_customer_permission
            // 
            this.manage_customer_permission.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.manage_customer_permission.Enabled = false;
            this.manage_customer_permission.Location = new System.Drawing.Point(106, 267);
            this.manage_customer_permission.Name = "manage_customer_permission";
            this.manage_customer_permission.Size = new System.Drawing.Size(130, 22);
            this.manage_customer_permission.TabIndex = 10;
            this.manage_customer_permission.Visible = false;
            // 
            // manage_customer_name
            // 
            this.manage_customer_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.manage_customer_name.Enabled = false;
            this.manage_customer_name.Location = new System.Drawing.Point(106, 29);
            this.manage_customer_name.Name = "manage_customer_name";
            this.manage_customer_name.Size = new System.Drawing.Size(130, 22);
            this.manage_customer_name.TabIndex = 7;
            this.manage_customer_name.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "名字：";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "RFID_ID：";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "狀態：";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "權限：";
            this.label4.Visible = false;
            // 
            // manage_customer_RFID_ID
            // 
            this.manage_customer_RFID_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.manage_customer_RFID_ID.Enabled = false;
            this.manage_customer_RFID_ID.Location = new System.Drawing.Point(106, 108);
            this.manage_customer_RFID_ID.Name = "manage_customer_RFID_ID";
            this.manage_customer_RFID_ID.ReadOnly = true;
            this.manage_customer_RFID_ID.Size = new System.Drawing.Size(130, 22);
            this.manage_customer_RFID_ID.TabIndex = 8;
            this.manage_customer_RFID_ID.Visible = false;
            // 
            // manage_customer_state
            // 
            this.manage_customer_state.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.manage_customer_state.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.manage_customer_state.Enabled = false;
            this.manage_customer_state.FormattingEnabled = true;
            this.manage_customer_state.Items.AddRange(new object[] {
            "0(禁用)",
            "1(啟用)"});
            this.manage_customer_state.Location = new System.Drawing.Point(106, 188);
            this.manage_customer_state.Name = "manage_customer_state";
            this.manage_customer_state.Size = new System.Drawing.Size(130, 20);
            this.manage_customer_state.TabIndex = 9;
            this.manage_customer_state.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.button_customer_select, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_customer_added, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_customer_delete, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_customer_modify, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_customer_activity, 4, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(737, 40);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button_customer_select
            // 
            this.button_customer_select.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button_customer_select.Enabled = false;
            this.button_customer_select.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_customer_select.Location = new System.Drawing.Point(444, 8);
            this.button_customer_select.Name = "button_customer_select";
            this.button_customer_select.Size = new System.Drawing.Size(141, 23);
            this.button_customer_select.TabIndex = 17;
            this.button_customer_select.Text = "用戶資料";
            this.button_customer_select.UseVisualStyleBackColor = true;
            this.button_customer_select.Click += new System.EventHandler(this.button_customer_select_Click);
            // 
            // button_customer_added
            // 
            this.button_customer_added.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button_customer_added.Enabled = false;
            this.button_customer_added.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_customer_added.Location = new System.Drawing.Point(3, 8);
            this.button_customer_added.Name = "button_customer_added";
            this.button_customer_added.Size = new System.Drawing.Size(141, 23);
            this.button_customer_added.TabIndex = 14;
            this.button_customer_added.Text = "新增";
            this.button_customer_added.UseVisualStyleBackColor = true;
            this.button_customer_added.Click += new System.EventHandler(this.button_customer_added_Click);
            // 
            // button_customer_delete
            // 
            this.button_customer_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button_customer_delete.Enabled = false;
            this.button_customer_delete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_customer_delete.Location = new System.Drawing.Point(297, 8);
            this.button_customer_delete.Name = "button_customer_delete";
            this.button_customer_delete.Size = new System.Drawing.Size(141, 23);
            this.button_customer_delete.TabIndex = 15;
            this.button_customer_delete.Text = "刪除";
            this.button_customer_delete.UseVisualStyleBackColor = true;
            this.button_customer_delete.Click += new System.EventHandler(this.button_customer_delete_Click);
            // 
            // button_customer_modify
            // 
            this.button_customer_modify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button_customer_modify.Enabled = false;
            this.button_customer_modify.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_customer_modify.Location = new System.Drawing.Point(150, 8);
            this.button_customer_modify.Name = "button_customer_modify";
            this.button_customer_modify.Size = new System.Drawing.Size(141, 23);
            this.button_customer_modify.TabIndex = 16;
            this.button_customer_modify.Text = "修改";
            this.button_customer_modify.UseVisualStyleBackColor = true;
            this.button_customer_modify.Click += new System.EventHandler(this.button_customer_modify_Click);
            // 
            // button_customer_activity
            // 
            this.button_customer_activity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button_customer_activity.Enabled = false;
            this.button_customer_activity.Location = new System.Drawing.Point(591, 8);
            this.button_customer_activity.Name = "button_customer_activity";
            this.button_customer_activity.Size = new System.Drawing.Size(143, 23);
            this.button_customer_activity.TabIndex = 18;
            this.button_customer_activity.Text = "活動紀錄";
            this.button_customer_activity.UseVisualStyleBackColor = true;
            this.button_customer_activity.Click += new System.EventHandler(this.button_customer_log_Click);
            // 
            // listView_customer
            // 
            this.listView_customer.GridLines = true;
            this.listView_customer.Location = new System.Drawing.Point(6, 49);
            this.listView_customer.Name = "listView_customer";
            this.listView_customer.Size = new System.Drawing.Size(737, 357);
            this.listView_customer.TabIndex = 14;
            this.listView_customer.UseCompatibleStateImageBehavior = false;
            this.listView_customer.View = System.Windows.Forms.View.Details;
            this.listView_customer.Visible = false;
            // 
            // message_bar
            // 
            this.message_bar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.message_bar.AutoSize = true;
            this.message_bar.Location = new System.Drawing.Point(12, 465);
            this.message_bar.Name = "message_bar";
            this.message_bar.Size = new System.Drawing.Size(47, 12);
            this.message_bar.TabIndex = 7;
            this.message_bar.Text = "Message:";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // Eigne_threshold_txtbx
            // 
            this.Eigne_threshold_txtbx.Location = new System.Drawing.Point(669, 462);
            this.Eigne_threshold_txtbx.Name = "Eigne_threshold_txtbx";
            this.Eigne_threshold_txtbx.Size = new System.Drawing.Size(100, 22);
            this.Eigne_threshold_txtbx.TabIndex = 12;
            this.Eigne_threshold_txtbx.Text = "3000";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(781, 484);
            this.Controls.Add(this.Eigne_threshold_txtbx);
            this.Controls.Add(this.message_bar);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.user_tabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.image_PICBX)).EndInit();
            this.customer_information.ResumeLayout(false);
            this.customer_information.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_customer_image)).EndInit();
            this.admin_tabPage.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.manage_customer_image)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem processingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem singleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parrellelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel customer_information;
        internal System.Windows.Forms.TextBox textBox_customer_join_time;
        internal System.Windows.Forms.TextBox textBox_customer_state;
        internal System.Windows.Forms.TextBox textBox_customer_name;
        private System.Windows.Forms.Label labe_customer_name;
        private System.Windows.Forms.Label labe_customer_RFID_ID;
        private System.Windows.Forms.Label labe_customer_state;
        private System.Windows.Forms.Label labe_customer_join_time;
        internal System.Windows.Forms.TextBox textBox_customer_RFID_ID;
        internal System.Windows.Forms.PictureBox pictureBox_customer_image;
        public System.Windows.Forms.Button button_customer_select;
        public System.Windows.Forms.Button button_customer_added;
        public System.Windows.Forms.Button button_customer_delete;
        public System.Windows.Forms.Button button_customer_modify;
        public System.Windows.Forms.TextBox manage_customer_permission;
        public System.Windows.Forms.TextBox manage_customer_name;
        public System.Windows.Forms.TextBox manage_customer_RFID_ID;
        public System.Windows.Forms.ComboBox manage_customer_state;
        public System.Windows.Forms.PictureBox manage_customer_image;
        public System.Windows.Forms.Button manage_btn_ok;
        public System.Windows.Forms.Button manage_btn_cancel;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.ListView listView_customer;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        public System.Windows.Forms.Label message_bar;
        public System.Windows.Forms.Button button_customer_activity;
        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.TabPage admin_tabPage;
        public System.Windows.Forms.TabPage user_tabPage;
        public System.Windows.Forms.PictureBox image_PICBX;
        public System.Windows.Forms.ToolStripMenuItem trainToolStripMenuItem;
        public System.Windows.Forms.Button manage_train_btn;
        private System.Windows.Forms.TextBox Eigne_threshold_txtbx;
    }
}


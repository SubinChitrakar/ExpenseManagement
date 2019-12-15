namespace ExpenseManagement.View_and_Controller
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.RecurringBackground = new System.ComponentModel.BackgroundWorker();
            this.headingPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblUserName = new System.Windows.Forms.Label();
            this.MenuPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnContacts = new System.Windows.Forms.Button();
            this.PanelTransaction = new System.Windows.Forms.Panel();
            this.BtnRecurringTransaction = new System.Windows.Forms.Button();
            this.BtnNormalTransaction = new System.Windows.Forms.Button();
            this.BtnTransactionMain = new System.Windows.Forms.Button();
            this.PanelEvent = new System.Windows.Forms.Panel();
            this.BtnRecurringEvents = new System.Windows.Forms.Button();
            this.BtnNormalEvents = new System.Windows.Forms.Button();
            this.BtnEventMain = new System.Windows.Forms.Button();
            this.BtnReport = new System.Windows.Forms.Button();
            this.BtnPrediction = new System.Windows.Forms.Button();
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.BtnChangePassword = new System.Windows.Forms.Button();
            this.BtnSettings = new System.Windows.Forms.Button();
            this.TimerTransaction = new System.Windows.Forms.Timer(this.components);
            this.TimerEvents = new System.Windows.Forms.Timer(this.components);
            this.TimerSettings = new System.Windows.Forms.Timer(this.components);
            this.DPickerSelectDate = new System.Windows.Forms.MonthCalendar();
            this.panel4 = new System.Windows.Forms.Panel();
            this.LblExpenseValue = new System.Windows.Forms.Label();
            this.LblTotalExpense = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.LblIncomeValue = new System.Windows.Forms.Label();
            this.LblTotalIncome = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.LblEventsValue = new System.Windows.Forms.Label();
            this.LblNoOfEvents = new System.Windows.Forms.Label();
            this.EventPanel = new System.Windows.Forms.Panel();
            this.headingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MenuPanel.SuspendLayout();
            this.PanelTransaction.SuspendLayout();
            this.PanelEvent.SuspendLayout();
            this.SettingsPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // RecurringBackground
            // 
            this.RecurringBackground.WorkerReportsProgress = true;
            this.RecurringBackground.WorkerSupportsCancellation = true;
            this.RecurringBackground.DoWork += new System.ComponentModel.DoWorkEventHandler(this._backgroundActivityForRecurring);
            this.RecurringBackground.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.RecurringBackground_ProgressChanged);
            // 
            // headingPanel
            // 
            this.headingPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headingPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.headingPanel.Controls.Add(this.pictureBox1);
            this.headingPanel.Controls.Add(this.label1);
            this.headingPanel.Controls.Add(this.label2);
            this.headingPanel.Controls.Add(this.LblUserName);
            this.headingPanel.Location = new System.Drawing.Point(-1, 34);
            this.headingPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.headingPanel.Name = "headingPanel";
            this.headingPanel.Size = new System.Drawing.Size(1242, 129);
            this.headingPanel.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ExpenseManagement.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(13, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(203, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 39);
            this.label1.TabIndex = 14;
            this.label1.Text = "Management";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(117, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 57);
            this.label2.TabIndex = 15;
            this.label2.Text = "Expense";
            // 
            // LblUserName
            // 
            this.LblUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblUserName.AutoSize = true;
            this.LblUserName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserName.ForeColor = System.Drawing.Color.Transparent;
            this.LblUserName.Location = new System.Drawing.Point(1111, 49);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(108, 27);
            this.LblUserName.TabIndex = 1;
            this.LblUserName.Text = "Username";
            this.LblUserName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.MenuPanel.Controls.Add(this.panel1);
            this.MenuPanel.Controls.Add(this.btnContacts);
            this.MenuPanel.Controls.Add(this.PanelTransaction);
            this.MenuPanel.Controls.Add(this.PanelEvent);
            this.MenuPanel.Controls.Add(this.BtnReport);
            this.MenuPanel.Controls.Add(this.BtnPrediction);
            this.MenuPanel.Controls.Add(this.SettingsPanel);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Margin = new System.Windows.Forms.Padding(4);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(242, 828);
            this.MenuPanel.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 160);
            this.panel1.TabIndex = 19;
            // 
            // btnContacts
            // 
            this.btnContacts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnContacts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContacts.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContacts.ForeColor = System.Drawing.Color.White;
            this.btnContacts.Image = global::ExpenseManagement.Properties.Resources.Contacts;
            this.btnContacts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContacts.Location = new System.Drawing.Point(4, 172);
            this.btnContacts.Margin = new System.Windows.Forms.Padding(4);
            this.btnContacts.Name = "btnContacts";
            this.btnContacts.Size = new System.Drawing.Size(234, 70);
            this.btnContacts.TabIndex = 18;
            this.btnContacts.Text = "Contacts";
            this.btnContacts.UseVisualStyleBackColor = false;
            this.btnContacts.Click += new System.EventHandler(this.BtnContacts_Click);
            // 
            // PanelTransaction
            // 
            this.PanelTransaction.Controls.Add(this.BtnRecurringTransaction);
            this.PanelTransaction.Controls.Add(this.BtnNormalTransaction);
            this.PanelTransaction.Controls.Add(this.BtnTransactionMain);
            this.PanelTransaction.Location = new System.Drawing.Point(3, 249);
            this.PanelTransaction.MaximumSize = new System.Drawing.Size(235, 161);
            this.PanelTransaction.MinimumSize = new System.Drawing.Size(235, 70);
            this.PanelTransaction.Name = "PanelTransaction";
            this.PanelTransaction.Size = new System.Drawing.Size(235, 71);
            this.PanelTransaction.TabIndex = 18;
            // 
            // BtnRecurringTransaction
            // 
            this.BtnRecurringTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.BtnRecurringTransaction.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnRecurringTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRecurringTransaction.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRecurringTransaction.ForeColor = System.Drawing.Color.White;
            this.BtnRecurringTransaction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRecurringTransaction.Location = new System.Drawing.Point(0, 115);
            this.BtnRecurringTransaction.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRecurringTransaction.Name = "BtnRecurringTransaction";
            this.BtnRecurringTransaction.Size = new System.Drawing.Size(235, 45);
            this.BtnRecurringTransaction.TabIndex = 22;
            this.BtnRecurringTransaction.Text = "Recurring Transactions";
            this.BtnRecurringTransaction.UseVisualStyleBackColor = false;
            this.BtnRecurringTransaction.Click += new System.EventHandler(this.BtnRecurringTransaction_Click);
            // 
            // BtnNormalTransaction
            // 
            this.BtnNormalTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.BtnNormalTransaction.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnNormalTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNormalTransaction.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNormalTransaction.ForeColor = System.Drawing.Color.White;
            this.BtnNormalTransaction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNormalTransaction.Location = new System.Drawing.Point(0, 70);
            this.BtnNormalTransaction.Margin = new System.Windows.Forms.Padding(4);
            this.BtnNormalTransaction.Name = "BtnNormalTransaction";
            this.BtnNormalTransaction.Size = new System.Drawing.Size(235, 45);
            this.BtnNormalTransaction.TabIndex = 21;
            this.BtnNormalTransaction.Text = "Normal Transactions";
            this.BtnNormalTransaction.UseVisualStyleBackColor = false;
            this.BtnNormalTransaction.Click += new System.EventHandler(this.BtnNormalTransaction_Click);
            // 
            // BtnTransactionMain
            // 
            this.BtnTransactionMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.BtnTransactionMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnTransactionMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTransactionMain.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTransactionMain.ForeColor = System.Drawing.Color.White;
            this.BtnTransactionMain.Image = global::ExpenseManagement.Properties.Resources.transaction;
            this.BtnTransactionMain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTransactionMain.Location = new System.Drawing.Point(0, 0);
            this.BtnTransactionMain.Margin = new System.Windows.Forms.Padding(4);
            this.BtnTransactionMain.Name = "BtnTransactionMain";
            this.BtnTransactionMain.Size = new System.Drawing.Size(235, 70);
            this.BtnTransactionMain.TabIndex = 20;
            this.BtnTransactionMain.Text = "Transactions";
            this.BtnTransactionMain.UseVisualStyleBackColor = false;
            this.BtnTransactionMain.Click += new System.EventHandler(this.BtnTransactionMain_Click);
            // 
            // PanelEvent
            // 
            this.PanelEvent.Controls.Add(this.BtnRecurringEvents);
            this.PanelEvent.Controls.Add(this.BtnNormalEvents);
            this.PanelEvent.Controls.Add(this.BtnEventMain);
            this.PanelEvent.Location = new System.Drawing.Point(3, 326);
            this.PanelEvent.MaximumSize = new System.Drawing.Size(235, 161);
            this.PanelEvent.MinimumSize = new System.Drawing.Size(235, 70);
            this.PanelEvent.Name = "PanelEvent";
            this.PanelEvent.Size = new System.Drawing.Size(235, 71);
            this.PanelEvent.TabIndex = 23;
            // 
            // BtnRecurringEvents
            // 
            this.BtnRecurringEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.BtnRecurringEvents.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnRecurringEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRecurringEvents.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRecurringEvents.ForeColor = System.Drawing.Color.White;
            this.BtnRecurringEvents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRecurringEvents.Location = new System.Drawing.Point(0, 115);
            this.BtnRecurringEvents.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRecurringEvents.Name = "BtnRecurringEvents";
            this.BtnRecurringEvents.Size = new System.Drawing.Size(235, 45);
            this.BtnRecurringEvents.TabIndex = 22;
            this.BtnRecurringEvents.Text = "Recurring Events";
            this.BtnRecurringEvents.UseVisualStyleBackColor = false;
            this.BtnRecurringEvents.Click += new System.EventHandler(this.BtnRecurringEvents_Click);
            // 
            // BtnNormalEvents
            // 
            this.BtnNormalEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.BtnNormalEvents.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnNormalEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNormalEvents.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNormalEvents.ForeColor = System.Drawing.Color.White;
            this.BtnNormalEvents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNormalEvents.Location = new System.Drawing.Point(0, 70);
            this.BtnNormalEvents.Margin = new System.Windows.Forms.Padding(4);
            this.BtnNormalEvents.Name = "BtnNormalEvents";
            this.BtnNormalEvents.Size = new System.Drawing.Size(235, 45);
            this.BtnNormalEvents.TabIndex = 21;
            this.BtnNormalEvents.Text = "Normal Events";
            this.BtnNormalEvents.UseVisualStyleBackColor = false;
            this.BtnNormalEvents.Click += new System.EventHandler(this.BtnNormalEvents_Click);
            // 
            // BtnEventMain
            // 
            this.BtnEventMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.BtnEventMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnEventMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEventMain.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEventMain.ForeColor = System.Drawing.Color.White;
            this.BtnEventMain.Image = global::ExpenseManagement.Properties.Resources.Events;
            this.BtnEventMain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEventMain.Location = new System.Drawing.Point(0, 0);
            this.BtnEventMain.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEventMain.Name = "BtnEventMain";
            this.BtnEventMain.Size = new System.Drawing.Size(235, 70);
            this.BtnEventMain.TabIndex = 20;
            this.BtnEventMain.Text = "Events";
            this.BtnEventMain.UseVisualStyleBackColor = false;
            this.BtnEventMain.Click += new System.EventHandler(this.BtnEventMain_Click);
            // 
            // BtnReport
            // 
            this.BtnReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.BtnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReport.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReport.ForeColor = System.Drawing.Color.White;
            this.BtnReport.Image = global::ExpenseManagement.Properties.Resources.Report;
            this.BtnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReport.Location = new System.Drawing.Point(4, 404);
            this.BtnReport.Margin = new System.Windows.Forms.Padding(4);
            this.BtnReport.Name = "BtnReport";
            this.BtnReport.Size = new System.Drawing.Size(234, 70);
            this.BtnReport.TabIndex = 19;
            this.BtnReport.Text = "Reports";
            this.BtnReport.UseVisualStyleBackColor = false;
            this.BtnReport.Click += new System.EventHandler(this.BtnReport_Click);
            // 
            // BtnPrediction
            // 
            this.BtnPrediction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.BtnPrediction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPrediction.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrediction.ForeColor = System.Drawing.Color.White;
            this.BtnPrediction.Image = global::ExpenseManagement.Properties.Resources.Prediction;
            this.BtnPrediction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPrediction.Location = new System.Drawing.Point(4, 482);
            this.BtnPrediction.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPrediction.Name = "BtnPrediction";
            this.BtnPrediction.Size = new System.Drawing.Size(234, 70);
            this.BtnPrediction.TabIndex = 24;
            this.BtnPrediction.Text = "Prediction";
            this.BtnPrediction.UseVisualStyleBackColor = false;
            this.BtnPrediction.Click += new System.EventHandler(this.BtnPrediction_Click);
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.Controls.Add(this.BtnChangePassword);
            this.SettingsPanel.Controls.Add(this.BtnSettings);
            this.SettingsPanel.Location = new System.Drawing.Point(3, 559);
            this.SettingsPanel.MaximumSize = new System.Drawing.Size(235, 115);
            this.SettingsPanel.MinimumSize = new System.Drawing.Size(235, 70);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(235, 70);
            this.SettingsPanel.TabIndex = 18;
            // 
            // BtnChangePassword
            // 
            this.BtnChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.BtnChangePassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnChangePassword.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnChangePassword.ForeColor = System.Drawing.Color.White;
            this.BtnChangePassword.Image = global::ExpenseManagement.Properties.Resources.Password;
            this.BtnChangePassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnChangePassword.Location = new System.Drawing.Point(0, 70);
            this.BtnChangePassword.Margin = new System.Windows.Forms.Padding(4);
            this.BtnChangePassword.Name = "BtnChangePassword";
            this.BtnChangePassword.Size = new System.Drawing.Size(235, 45);
            this.BtnChangePassword.TabIndex = 26;
            this.BtnChangePassword.Text = "Change Password";
            this.BtnChangePassword.UseVisualStyleBackColor = false;
            this.BtnChangePassword.Click += new System.EventHandler(this.BtnChangePassword_Click);
            // 
            // BtnSettings
            // 
            this.BtnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.BtnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSettings.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSettings.ForeColor = System.Drawing.Color.White;
            this.BtnSettings.Image = global::ExpenseManagement.Properties.Resources.Settings;
            this.BtnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSettings.Location = new System.Drawing.Point(0, 0);
            this.BtnSettings.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Size = new System.Drawing.Size(235, 70);
            this.BtnSettings.TabIndex = 25;
            this.BtnSettings.Text = "Settings";
            this.BtnSettings.UseVisualStyleBackColor = false;
            this.BtnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // TimerTransaction
            // 
            this.TimerTransaction.Interval = 20;
            this.TimerTransaction.Tick += new System.EventHandler(this.TimerTransaction_Tick);
            // 
            // TimerEvents
            // 
            this.TimerEvents.Interval = 20;
            this.TimerEvents.Tick += new System.EventHandler(this.TimerEvents_Tick);
            // 
            // TimerSettings
            // 
            this.TimerSettings.Interval = 20;
            this.TimerSettings.Tick += new System.EventHandler(this.TimerSettings_Tick);
            // 
            // DPickerSelectDate
            // 
            this.DPickerSelectDate.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DPickerSelectDate.Location = new System.Drawing.Point(255, 174);
            this.DPickerSelectDate.MaxSelectionCount = 1;
            this.DPickerSelectDate.Name = "DPickerSelectDate";
            this.DPickerSelectDate.TabIndex = 18;
            this.DPickerSelectDate.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.DPickerSelectDate_DateSelected);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel4.Controls.Add(this.LblExpenseValue);
            this.panel4.Controls.Add(this.LblTotalExpense);
            this.panel4.Location = new System.Drawing.Point(255, 396);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(298, 57);
            this.panel4.TabIndex = 21;
            // 
            // LblExpenseValue
            // 
            this.LblExpenseValue.AutoSize = true;
            this.LblExpenseValue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblExpenseValue.ForeColor = System.Drawing.Color.Red;
            this.LblExpenseValue.Location = new System.Drawing.Point(221, 18);
            this.LblExpenseValue.Name = "LblExpenseValue";
            this.LblExpenseValue.Size = new System.Drawing.Size(60, 22);
            this.LblExpenseValue.TabIndex = 1;
            this.LblExpenseValue.Text = "label3";
            // 
            // LblTotalExpense
            // 
            this.LblTotalExpense.AutoSize = true;
            this.LblTotalExpense.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalExpense.ForeColor = System.Drawing.Color.Black;
            this.LblTotalExpense.Location = new System.Drawing.Point(33, 19);
            this.LblTotalExpense.Name = "LblTotalExpense";
            this.LblTotalExpense.Size = new System.Drawing.Size(116, 21);
            this.LblTotalExpense.TabIndex = 0;
            this.LblTotalExpense.Text = "Total Expense";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel5.Controls.Add(this.LblIncomeValue);
            this.panel5.Controls.Add(this.LblTotalIncome);
            this.panel5.Location = new System.Drawing.Point(255, 459);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(298, 57);
            this.panel5.TabIndex = 22;
            // 
            // LblIncomeValue
            // 
            this.LblIncomeValue.AutoSize = true;
            this.LblIncomeValue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIncomeValue.ForeColor = System.Drawing.Color.ForestGreen;
            this.LblIncomeValue.Location = new System.Drawing.Point(221, 18);
            this.LblIncomeValue.Name = "LblIncomeValue";
            this.LblIncomeValue.Size = new System.Drawing.Size(60, 22);
            this.LblIncomeValue.TabIndex = 2;
            this.LblIncomeValue.Text = "label3";
            // 
            // LblTotalIncome
            // 
            this.LblTotalIncome.AutoSize = true;
            this.LblTotalIncome.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalIncome.ForeColor = System.Drawing.Color.Black;
            this.LblTotalIncome.Location = new System.Drawing.Point(33, 19);
            this.LblTotalIncome.Name = "LblTotalIncome";
            this.LblTotalIncome.Size = new System.Drawing.Size(109, 21);
            this.LblTotalIncome.TabIndex = 1;
            this.LblTotalIncome.Text = "Total Income";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel6.Controls.Add(this.LblEventsValue);
            this.panel6.Controls.Add(this.LblNoOfEvents);
            this.panel6.Location = new System.Drawing.Point(255, 522);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(298, 57);
            this.panel6.TabIndex = 23;
            // 
            // LblEventsValue
            // 
            this.LblEventsValue.AutoSize = true;
            this.LblEventsValue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEventsValue.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblEventsValue.Location = new System.Drawing.Point(221, 18);
            this.LblEventsValue.Name = "LblEventsValue";
            this.LblEventsValue.Size = new System.Drawing.Size(60, 22);
            this.LblEventsValue.TabIndex = 3;
            this.LblEventsValue.Text = "label4";
            // 
            // LblNoOfEvents
            // 
            this.LblNoOfEvents.AutoSize = true;
            this.LblNoOfEvents.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNoOfEvents.ForeColor = System.Drawing.Color.Black;
            this.LblNoOfEvents.Location = new System.Drawing.Point(33, 19);
            this.LblNoOfEvents.Name = "LblNoOfEvents";
            this.LblNoOfEvents.Size = new System.Drawing.Size(114, 21);
            this.LblNoOfEvents.TabIndex = 1;
            this.LblNoOfEvents.Text = "No. of Events";
            // 
            // EventPanel
            // 
            this.EventPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EventPanel.AutoScroll = true;
            this.EventPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.EventPanel.Location = new System.Drawing.Point(990, 174);
            this.EventPanel.Name = "EventPanel";
            this.EventPanel.Size = new System.Drawing.Size(240, 635);
            this.EventPanel.TabIndex = 24;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 828);
            this.Controls.Add(this.EventPanel);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.DPickerSelectDate);
            this.Controls.Add(this.headingPanel);
            this.Controls.Add(this.MenuPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Activated += new System.EventHandler(this.Dashboard_Activated);
            this.SizeChanged += new System.EventHandler(this.DashboardForm_SizeChanged);
            this.headingPanel.ResumeLayout(false);
            this.headingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MenuPanel.ResumeLayout(false);
            this.PanelTransaction.ResumeLayout(false);
            this.PanelEvent.ResumeLayout(false);
            this.SettingsPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker RecurringBackground;
        private System.Windows.Forms.Panel headingPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblUserName;
        private System.Windows.Forms.FlowLayoutPanel MenuPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnContacts;
        private System.Windows.Forms.Panel PanelTransaction;
        private System.Windows.Forms.Button BtnRecurringTransaction;
        private System.Windows.Forms.Button BtnNormalTransaction;
        private System.Windows.Forms.Button BtnTransactionMain;
        private System.Windows.Forms.Timer TimerTransaction;
        private System.Windows.Forms.Panel PanelEvent;
        private System.Windows.Forms.Button BtnRecurringEvents;
        private System.Windows.Forms.Button BtnNormalEvents;
        private System.Windows.Forms.Button BtnEventMain;
        private System.Windows.Forms.Timer TimerEvents;
        private System.Windows.Forms.Button BtnReport;
        private System.Windows.Forms.Button BtnPrediction;
        private System.Windows.Forms.Timer TimerSettings;
        private System.Windows.Forms.Panel SettingsPanel;
        private System.Windows.Forms.Button BtnChangePassword;
        private System.Windows.Forms.Button BtnSettings;
        private System.Windows.Forms.MonthCalendar DPickerSelectDate;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label LblTotalExpense;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label LblTotalIncome;
        private System.Windows.Forms.Label LblExpenseValue;
        private System.Windows.Forms.Label LblIncomeValue;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label LblEventsValue;
        private System.Windows.Forms.Label LblNoOfEvents;
        private System.Windows.Forms.Panel EventPanel;
    }
}
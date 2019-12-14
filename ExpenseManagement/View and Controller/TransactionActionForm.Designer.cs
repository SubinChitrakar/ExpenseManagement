namespace ExpenseManagement.View_and_Controller
{
    partial class TransactionActionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionActionForm));
            this.headingPanel = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.lblHeading = new System.Windows.Forms.Label();
            this.TxtTransactionName = new System.Windows.Forms.TextBox();
            this.LblTransactionName = new System.Windows.Forms.Label();
            this.CmbType = new System.Windows.Forms.ComboBox();
            this.LblType = new System.Windows.Forms.Label();
            this.LblAmount = new System.Windows.Forms.Label();
            this.NumUpDownAmount = new System.Windows.Forms.NumericUpDown();
            this.CmbContact = new System.Windows.Forms.ComboBox();
            this.LblContact = new System.Windows.Forms.Label();
            this.LblDateAndTime = new System.Windows.Forms.Label();
            this.DPickerDate = new System.Windows.Forms.DateTimePicker();
            this.TxtNote = new System.Windows.Forms.RichTextBox();
            this.LblNote = new System.Windows.Forms.Label();
            this.BtnDeleteTransaction = new MaterialSkin.Controls.MaterialFlatButton();
            this.BtnAction = new MaterialSkin.Controls.MaterialFlatButton();
            this.ChkRecurring = new System.Windows.Forms.CheckBox();
            this.GrpRecurring = new System.Windows.Forms.GroupBox();
            this.ChkEndingStatus = new System.Windows.Forms.CheckBox();
            this.CmbStatus = new System.Windows.Forms.ComboBox();
            this.LblEndTime = new System.Windows.Forms.Label();
            this.DPickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.LblEventStatus = new System.Windows.Forms.Label();
            this.headingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownAmount)).BeginInit();
            this.GrpRecurring.SuspendLayout();
            this.SuspendLayout();
            // 
            // headingPanel
            // 
            this.headingPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headingPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.headingPanel.Controls.Add(this.btnBack);
            this.headingPanel.Controls.Add(this.lblHeading);
            this.headingPanel.Location = new System.Drawing.Point(-1, -13);
            this.headingPanel.Name = "headingPanel";
            this.headingPanel.Size = new System.Drawing.Size(595, 94);
            this.headingPanel.TabIndex = 4;
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Image = global::ExpenseManagement.Properties.Resources.Back;
            this.btnBack.Location = new System.Drawing.Point(12, 25);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(50, 50);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBack.TabIndex = 1;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.White;
            this.lblHeading.Location = new System.Drawing.Point(57, 32);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(198, 37);
            this.lblHeading.TabIndex = 2;
            this.lblHeading.Text = "Transactions";
            // 
            // TxtTransactionName
            // 
            this.TxtTransactionName.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.TxtTransactionName.Location = new System.Drawing.Point(23, 119);
            this.TxtTransactionName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtTransactionName.Name = "TxtTransactionName";
            this.TxtTransactionName.Size = new System.Drawing.Size(545, 29);
            this.TxtTransactionName.TabIndex = 30;
            // 
            // LblTransactionName
            // 
            this.LblTransactionName.AutoSize = true;
            this.LblTransactionName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTransactionName.Location = new System.Drawing.Point(22, 94);
            this.LblTransactionName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTransactionName.Name = "LblTransactionName";
            this.LblTransactionName.Size = new System.Drawing.Size(153, 22);
            this.LblTransactionName.TabIndex = 29;
            this.LblTransactionName.Text = "Transaction Name";
            // 
            // CmbType
            // 
            this.CmbType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbType.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CmbType.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbType.FormattingEnabled = true;
            this.CmbType.Items.AddRange(new object[] {
            "Expense",
            "Income"});
            this.CmbType.Location = new System.Drawing.Point(23, 194);
            this.CmbType.Name = "CmbType";
            this.CmbType.Size = new System.Drawing.Size(237, 28);
            this.CmbType.TabIndex = 34;
            this.CmbType.Text = "Expense";
            // 
            // LblType
            // 
            this.LblType.AutoSize = true;
            this.LblType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblType.Location = new System.Drawing.Point(19, 169);
            this.LblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblType.Name = "LblType";
            this.LblType.Size = new System.Drawing.Size(146, 22);
            this.LblType.TabIndex = 33;
            this.LblType.Text = "Transaction Type";
            // 
            // LblAmount
            // 
            this.LblAmount.AutoSize = true;
            this.LblAmount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAmount.Location = new System.Drawing.Point(290, 169);
            this.LblAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblAmount.Name = "LblAmount";
            this.LblAmount.Size = new System.Drawing.Size(71, 22);
            this.LblAmount.TabIndex = 35;
            this.LblAmount.Text = "Amount";
            // 
            // NumUpDownAmount
            // 
            this.NumUpDownAmount.DecimalPlaces = 2;
            this.NumUpDownAmount.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumUpDownAmount.Location = new System.Drawing.Point(294, 194);
            this.NumUpDownAmount.Name = "NumUpDownAmount";
            this.NumUpDownAmount.Size = new System.Drawing.Size(274, 28);
            this.NumUpDownAmount.TabIndex = 36;
            this.NumUpDownAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CmbContact
            // 
            this.CmbContact.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.CmbContact.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbContact.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CmbContact.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbContact.FormattingEnabled = true;
            this.CmbContact.Location = new System.Drawing.Point(23, 269);
            this.CmbContact.Name = "CmbContact";
            this.CmbContact.Size = new System.Drawing.Size(545, 28);
            this.CmbContact.TabIndex = 38;
            this.CmbContact.Text = "--Select a Contact--";
            // 
            // LblContact
            // 
            this.LblContact.AutoSize = true;
            this.LblContact.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContact.Location = new System.Drawing.Point(19, 244);
            this.LblContact.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblContact.Name = "LblContact";
            this.LblContact.Size = new System.Drawing.Size(167, 22);
            this.LblContact.TabIndex = 37;
            this.LblContact.Text = "Transaction Contact";
            // 
            // LblDateAndTime
            // 
            this.LblDateAndTime.AutoSize = true;
            this.LblDateAndTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDateAndTime.Location = new System.Drawing.Point(19, 309);
            this.LblDateAndTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDateAndTime.Name = "LblDateAndTime";
            this.LblDateAndTime.Size = new System.Drawing.Size(222, 22);
            this.LblDateAndTime.TabIndex = 39;
            this.LblDateAndTime.Text = "Transaction Date and Time";
            // 
            // DPickerDate
            // 
            this.DPickerDate.CalendarFont = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DPickerDate.CustomFormat = "dddd, dd MMMM yyyy HH:mm";
            this.DPickerDate.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DPickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DPickerDate.Location = new System.Drawing.Point(23, 334);
            this.DPickerDate.Name = "DPickerDate";
            this.DPickerDate.Size = new System.Drawing.Size(548, 28);
            this.DPickerDate.TabIndex = 40;
            this.DPickerDate.Value = new System.DateTime(2019, 12, 11, 22, 11, 32, 0);
            // 
            // TxtNote
            // 
            this.TxtNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNote.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNote.Location = new System.Drawing.Point(23, 409);
            this.TxtNote.Name = "TxtNote";
            this.TxtNote.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.TxtNote.Size = new System.Drawing.Size(548, 92);
            this.TxtNote.TabIndex = 42;
            this.TxtNote.Text = "";
            // 
            // LblNote
            // 
            this.LblNote.AutoSize = true;
            this.LblNote.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNote.Location = new System.Drawing.Point(22, 384);
            this.LblNote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNote.Name = "LblNote";
            this.LblNote.Size = new System.Drawing.Size(48, 22);
            this.LblNote.TabIndex = 41;
            this.LblNote.Text = "Note";
            // 
            // BtnDeleteTransaction
            // 
            this.BtnDeleteTransaction.AutoSize = true;
            this.BtnDeleteTransaction.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnDeleteTransaction.Depth = 0;
            this.BtnDeleteTransaction.Icon = null;
            this.BtnDeleteTransaction.Location = new System.Drawing.Point(133, 529);
            this.BtnDeleteTransaction.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnDeleteTransaction.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnDeleteTransaction.Name = "BtnDeleteTransaction";
            this.BtnDeleteTransaction.Primary = false;
            this.BtnDeleteTransaction.Size = new System.Drawing.Size(203, 36);
            this.BtnDeleteTransaction.TabIndex = 53;
            this.BtnDeleteTransaction.Text = "Delete Transaction";
            this.BtnDeleteTransaction.UseVisualStyleBackColor = true;
            this.BtnDeleteTransaction.Click += new System.EventHandler(this.BtnDeleteTransaction_Click);
            // 
            // BtnAction
            // 
            this.BtnAction.AutoSize = true;
            this.BtnAction.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnAction.Depth = 0;
            this.BtnAction.Icon = null;
            this.BtnAction.Location = new System.Drawing.Point(369, 529);
            this.BtnAction.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnAction.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnAction.Name = "BtnAction";
            this.BtnAction.Primary = false;
            this.BtnAction.Size = new System.Drawing.Size(177, 36);
            this.BtnAction.TabIndex = 52;
            this.BtnAction.Text = "Add Transaction";
            this.BtnAction.UseVisualStyleBackColor = true;
            this.BtnAction.Click += new System.EventHandler(this.BtnAction_Click);
            // 
            // ChkRecurring
            // 
            this.ChkRecurring.AutoSize = true;
            this.ChkRecurring.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkRecurring.Location = new System.Drawing.Point(23, 520);
            this.ChkRecurring.Name = "ChkRecurring";
            this.ChkRecurring.Size = new System.Drawing.Size(197, 25);
            this.ChkRecurring.TabIndex = 54;
            this.ChkRecurring.Text = "Recurring Transaction";
            this.ChkRecurring.UseVisualStyleBackColor = true;
            this.ChkRecurring.CheckedChanged += new System.EventHandler(this.ChkRecurring_CheckedChanged);
            // 
            // GrpRecurring
            // 
            this.GrpRecurring.Controls.Add(this.ChkEndingStatus);
            this.GrpRecurring.Controls.Add(this.CmbStatus);
            this.GrpRecurring.Controls.Add(this.LblEndTime);
            this.GrpRecurring.Controls.Add(this.DPickerEndDate);
            this.GrpRecurring.Controls.Add(this.LblEventStatus);
            this.GrpRecurring.Location = new System.Drawing.Point(26, 555);
            this.GrpRecurring.Name = "GrpRecurring";
            this.GrpRecurring.Size = new System.Drawing.Size(545, 200);
            this.GrpRecurring.TabIndex = 55;
            this.GrpRecurring.TabStop = false;
            this.GrpRecurring.Visible = false;
            // 
            // ChkEndingStatus
            // 
            this.ChkEndingStatus.AutoSize = true;
            this.ChkEndingStatus.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkEndingStatus.Location = new System.Drawing.Point(11, 145);
            this.ChkEndingStatus.Name = "ChkEndingStatus";
            this.ChkEndingStatus.Size = new System.Drawing.Size(133, 25);
            this.ChkEndingStatus.TabIndex = 45;
            this.ChkEndingStatus.Text = "Never Ending";
            this.ChkEndingStatus.UseVisualStyleBackColor = true;
            this.ChkEndingStatus.CheckedChanged += new System.EventHandler(this.ChkEndingStatus_CheckedChanged);
            // 
            // CmbStatus
            // 
            this.CmbStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbStatus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CmbStatus.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbStatus.FormattingEnabled = true;
            this.CmbStatus.Items.AddRange(new object[] {
            "Daily",
            "Weekly",
            "Monthly",
            "Yearly"});
            this.CmbStatus.Location = new System.Drawing.Point(11, 43);
            this.CmbStatus.Name = "CmbStatus";
            this.CmbStatus.Size = new System.Drawing.Size(202, 28);
            this.CmbStatus.TabIndex = 42;
            this.CmbStatus.Text = "Daily";
            // 
            // LblEndTime
            // 
            this.LblEndTime.AutoSize = true;
            this.LblEndTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEndTime.Location = new System.Drawing.Point(7, 86);
            this.LblEndTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblEndTime.Name = "LblEndTime";
            this.LblEndTime.Size = new System.Drawing.Size(161, 22);
            this.LblEndTime.TabIndex = 44;
            this.LblEndTime.Text = "End Date and Time";
            // 
            // DPickerEndDate
            // 
            this.DPickerEndDate.CalendarFont = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DPickerEndDate.CustomFormat = "dddd, dd MMMM yyyy HH:mm";
            this.DPickerEndDate.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DPickerEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DPickerEndDate.Location = new System.Drawing.Point(11, 111);
            this.DPickerEndDate.Name = "DPickerEndDate";
            this.DPickerEndDate.Size = new System.Drawing.Size(518, 28);
            this.DPickerEndDate.TabIndex = 43;
            this.DPickerEndDate.Value = new System.DateTime(2019, 12, 11, 22, 13, 43, 0);
            // 
            // LblEventStatus
            // 
            this.LblEventStatus.AutoSize = true;
            this.LblEventStatus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEventStatus.Location = new System.Drawing.Point(7, 18);
            this.LblEventStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblEventStatus.Name = "LblEventStatus";
            this.LblEventStatus.Size = new System.Drawing.Size(154, 22);
            this.LblEventStatus.TabIndex = 33;
            this.LblEventStatus.Text = "Transaction Status";
            // 
            // TransactionActionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 595);
            this.Controls.Add(this.ChkRecurring);
            this.Controls.Add(this.BtnDeleteTransaction);
            this.Controls.Add(this.BtnAction);
            this.Controls.Add(this.TxtNote);
            this.Controls.Add(this.LblNote);
            this.Controls.Add(this.LblDateAndTime);
            this.Controls.Add(this.DPickerDate);
            this.Controls.Add(this.CmbContact);
            this.Controls.Add(this.LblContact);
            this.Controls.Add(this.NumUpDownAmount);
            this.Controls.Add(this.LblAmount);
            this.Controls.Add(this.CmbType);
            this.Controls.Add(this.LblType);
            this.Controls.Add(this.TxtTransactionName);
            this.Controls.Add(this.LblTransactionName);
            this.Controls.Add(this.headingPanel);
            this.Controls.Add(this.GrpRecurring);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TransactionActionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NormalTransactionActionForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TransactionActionForm_FormClosing);
            this.Load += new System.EventHandler(this.TransactionActionForm_Load);
            this.headingPanel.ResumeLayout(false);
            this.headingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownAmount)).EndInit();
            this.GrpRecurring.ResumeLayout(false);
            this.GrpRecurring.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel headingPanel;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.TextBox TxtTransactionName;
        private System.Windows.Forms.Label LblTransactionName;
        private System.Windows.Forms.ComboBox CmbType;
        private System.Windows.Forms.Label LblType;
        private System.Windows.Forms.Label LblAmount;
        private System.Windows.Forms.NumericUpDown NumUpDownAmount;
        private System.Windows.Forms.ComboBox CmbContact;
        private System.Windows.Forms.Label LblContact;
        private System.Windows.Forms.Label LblDateAndTime;
        private System.Windows.Forms.DateTimePicker DPickerDate;
        private System.Windows.Forms.RichTextBox TxtNote;
        private System.Windows.Forms.Label LblNote;
        private MaterialSkin.Controls.MaterialFlatButton BtnDeleteTransaction;
        private MaterialSkin.Controls.MaterialFlatButton BtnAction;
        private System.Windows.Forms.CheckBox ChkRecurring;
        private System.Windows.Forms.GroupBox GrpRecurring;
        private System.Windows.Forms.CheckBox ChkEndingStatus;
        private System.Windows.Forms.ComboBox CmbStatus;
        private System.Windows.Forms.Label LblEndTime;
        private System.Windows.Forms.DateTimePicker DPickerEndDate;
        private System.Windows.Forms.Label LblEventStatus;
    }
}
namespace ExpenseManagement.View_and_Controller
{
    partial class EventActionForm
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
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.LblHeading = new System.Windows.Forms.Label();
            this.headingPanel = new System.Windows.Forms.Panel();
            this.TxtEventName = new System.Windows.Forms.TextBox();
            this.LblEventName = new System.Windows.Forms.Label();
            this.LblEventLocation = new System.Windows.Forms.Label();
            this.LblType = new System.Windows.Forms.Label();
            this.CmbType = new System.Windows.Forms.ComboBox();
            this.CmbContact = new System.Windows.Forms.ComboBox();
            this.LblContact = new System.Windows.Forms.Label();
            this.DPickerDate = new System.Windows.Forms.DateTimePicker();
            this.LblDateAndTime = new System.Windows.Forms.Label();
            this.TxtNote = new System.Windows.Forms.RichTextBox();
            this.LblNote = new System.Windows.Forms.Label();
            this.GrpRecurring = new System.Windows.Forms.GroupBox();
            this.ChkEndingStatus = new System.Windows.Forms.CheckBox();
            this.CmbStatus = new System.Windows.Forms.ComboBox();
            this.LblEndTime = new System.Windows.Forms.Label();
            this.DPickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.LblEventStatus = new System.Windows.Forms.Label();
            this.ChkRecurring = new System.Windows.Forms.CheckBox();
            this.TxtLocation = new System.Windows.Forms.TextBox();
            this.BtnAction = new MaterialSkin.Controls.MaterialFlatButton();
            this.BtnDeleteEvent = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.headingPanel.SuspendLayout();
            this.GrpRecurring.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Image = global::ExpenseManagement.Properties.Resources.Back;
            this.btnBack.Location = new System.Drawing.Point(8, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(50, 50);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBack.TabIndex = 1;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // LblHeading
            // 
            this.LblHeading.AutoSize = true;
            this.LblHeading.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHeading.ForeColor = System.Drawing.Color.White;
            this.LblHeading.Location = new System.Drawing.Point(75, 16);
            this.LblHeading.Name = "LblHeading";
            this.LblHeading.Size = new System.Drawing.Size(113, 37);
            this.LblHeading.TabIndex = 2;
            this.LblHeading.Text = "Events";
            // 
            // headingPanel
            // 
            this.headingPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headingPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.headingPanel.Controls.Add(this.btnBack);
            this.headingPanel.Controls.Add(this.LblHeading);
            this.headingPanel.Location = new System.Drawing.Point(-1, 2);
            this.headingPanel.Name = "headingPanel";
            this.headingPanel.Size = new System.Drawing.Size(614, 79);
            this.headingPanel.TabIndex = 8;
            // 
            // TxtEventName
            // 
            this.TxtEventName.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.TxtEventName.Location = new System.Drawing.Point(20, 123);
            this.TxtEventName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtEventName.Name = "TxtEventName";
            this.TxtEventName.Size = new System.Drawing.Size(545, 29);
            this.TxtEventName.TabIndex = 28;
            // 
            // LblEventName
            // 
            this.LblEventName.AutoSize = true;
            this.LblEventName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEventName.Location = new System.Drawing.Point(19, 98);
            this.LblEventName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblEventName.Name = "LblEventName";
            this.LblEventName.Size = new System.Drawing.Size(106, 22);
            this.LblEventName.TabIndex = 27;
            this.LblEventName.Text = "Event Name";
            // 
            // LblEventLocation
            // 
            this.LblEventLocation.AutoSize = true;
            this.LblEventLocation.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEventLocation.Location = new System.Drawing.Point(19, 175);
            this.LblEventLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblEventLocation.Name = "LblEventLocation";
            this.LblEventLocation.Size = new System.Drawing.Size(129, 22);
            this.LblEventLocation.TabIndex = 29;
            this.LblEventLocation.Text = "Event Location";
            // 
            // LblType
            // 
            this.LblType.AutoSize = true;
            this.LblType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblType.Location = new System.Drawing.Point(16, 248);
            this.LblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblType.Name = "LblType";
            this.LblType.Size = new System.Drawing.Size(99, 22);
            this.LblType.TabIndex = 31;
            this.LblType.Text = "Event Type";
            // 
            // CmbType
            // 
            this.CmbType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbType.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CmbType.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbType.FormattingEnabled = true;
            this.CmbType.Items.AddRange(new object[] {
            "Task",
            "Appointment"});
            this.CmbType.Location = new System.Drawing.Point(20, 273);
            this.CmbType.Name = "CmbType";
            this.CmbType.Size = new System.Drawing.Size(202, 28);
            this.CmbType.TabIndex = 32;
            this.CmbType.Text = "Task";
            // 
            // CmbContact
            // 
            this.CmbContact.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.CmbContact.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbContact.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CmbContact.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbContact.FormattingEnabled = true;
            this.CmbContact.Location = new System.Drawing.Point(262, 273);
            this.CmbContact.Name = "CmbContact";
            this.CmbContact.Size = new System.Drawing.Size(303, 28);
            this.CmbContact.TabIndex = 34;
            this.CmbContact.Text = "--Select a Contact--";
            // 
            // LblContact
            // 
            this.LblContact.AutoSize = true;
            this.LblContact.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContact.Location = new System.Drawing.Point(258, 248);
            this.LblContact.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblContact.Name = "LblContact";
            this.LblContact.Size = new System.Drawing.Size(120, 22);
            this.LblContact.TabIndex = 33;
            this.LblContact.Text = "Event Contact";
            // 
            // DPickerDate
            // 
            this.DPickerDate.CalendarFont = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DPickerDate.CustomFormat = "dddd, dd MMMM yyyy HH:mm";
            this.DPickerDate.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DPickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DPickerDate.Location = new System.Drawing.Point(17, 347);
            this.DPickerDate.Name = "DPickerDate";
            this.DPickerDate.Size = new System.Drawing.Size(548, 28);
            this.DPickerDate.TabIndex = 36;
            this.DPickerDate.Value = new System.DateTime(2019, 12, 11, 22, 11, 32, 0);
            // 
            // LblDateAndTime
            // 
            this.LblDateAndTime.AutoSize = true;
            this.LblDateAndTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDateAndTime.Location = new System.Drawing.Point(13, 322);
            this.LblDateAndTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDateAndTime.Name = "LblDateAndTime";
            this.LblDateAndTime.Size = new System.Drawing.Size(175, 22);
            this.LblDateAndTime.TabIndex = 35;
            this.LblDateAndTime.Text = "Event Date and Time";
            // 
            // TxtNote
            // 
            this.TxtNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNote.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNote.Location = new System.Drawing.Point(17, 421);
            this.TxtNote.Name = "TxtNote";
            this.TxtNote.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.TxtNote.Size = new System.Drawing.Size(548, 92);
            this.TxtNote.TabIndex = 39;
            this.TxtNote.Text = "";
            // 
            // LblNote
            // 
            this.LblNote.AutoSize = true;
            this.LblNote.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNote.Location = new System.Drawing.Point(16, 396);
            this.LblNote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNote.Name = "LblNote";
            this.LblNote.Size = new System.Drawing.Size(48, 22);
            this.LblNote.TabIndex = 38;
            this.LblNote.Text = "Note";
            // 
            // GrpRecurring
            // 
            this.GrpRecurring.Controls.Add(this.ChkEndingStatus);
            this.GrpRecurring.Controls.Add(this.CmbStatus);
            this.GrpRecurring.Controls.Add(this.LblEndTime);
            this.GrpRecurring.Controls.Add(this.DPickerEndDate);
            this.GrpRecurring.Controls.Add(this.LblEventStatus);
            this.GrpRecurring.Location = new System.Drawing.Point(17, 577);
            this.GrpRecurring.Name = "GrpRecurring";
            this.GrpRecurring.Size = new System.Drawing.Size(545, 200);
            this.GrpRecurring.TabIndex = 41;
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
            this.LblEventStatus.Size = new System.Drawing.Size(107, 22);
            this.LblEventStatus.TabIndex = 33;
            this.LblEventStatus.Text = "Event Status";
            // 
            // ChkRecurring
            // 
            this.ChkRecurring.AutoSize = true;
            this.ChkRecurring.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkRecurring.Location = new System.Drawing.Point(17, 533);
            this.ChkRecurring.Name = "ChkRecurring";
            this.ChkRecurring.Size = new System.Drawing.Size(152, 25);
            this.ChkRecurring.TabIndex = 40;
            this.ChkRecurring.Text = "Recurring Event";
            this.ChkRecurring.UseVisualStyleBackColor = true;
            this.ChkRecurring.CheckedChanged += new System.EventHandler(this.ChkRecurring_CheckedChanged);
            // 
            // TxtLocation
            // 
            this.TxtLocation.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.TxtLocation.Location = new System.Drawing.Point(20, 200);
            this.TxtLocation.Margin = new System.Windows.Forms.Padding(4);
            this.TxtLocation.Name = "TxtLocation";
            this.TxtLocation.Size = new System.Drawing.Size(545, 29);
            this.TxtLocation.TabIndex = 30;
            // 
            // BtnAction
            // 
            this.BtnAction.AutoSize = true;
            this.BtnAction.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnAction.Depth = 0;
            this.BtnAction.Icon = null;
            this.BtnAction.Location = new System.Drawing.Point(449, 532);
            this.BtnAction.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnAction.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnAction.Name = "BtnAction";
            this.BtnAction.Primary = false;
            this.BtnAction.Size = new System.Drawing.Size(113, 36);
            this.BtnAction.TabIndex = 50;
            this.BtnAction.Text = "Add Event";
            this.BtnAction.UseVisualStyleBackColor = true;
            this.BtnAction.Click += new System.EventHandler(this.BtnAction_Click);
            // 
            // BtnDeleteEvent
            // 
            this.BtnDeleteEvent.AutoSize = true;
            this.BtnDeleteEvent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnDeleteEvent.Depth = 0;
            this.BtnDeleteEvent.Icon = null;
            this.BtnDeleteEvent.Location = new System.Drawing.Point(218, 532);
            this.BtnDeleteEvent.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnDeleteEvent.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnDeleteEvent.Name = "BtnDeleteEvent";
            this.BtnDeleteEvent.Primary = false;
            this.BtnDeleteEvent.Size = new System.Drawing.Size(140, 36);
            this.BtnDeleteEvent.TabIndex = 51;
            this.BtnDeleteEvent.Text = "Delete Event";
            this.BtnDeleteEvent.UseVisualStyleBackColor = true;
            this.BtnDeleteEvent.Click += new System.EventHandler(this.BtnDeleteEvent_Click);
            // 
            // EventActionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 595);
            this.Controls.Add(this.BtnDeleteEvent);
            this.Controls.Add(this.BtnAction);
            this.Controls.Add(this.TxtLocation);
            this.Controls.Add(this.ChkRecurring);
            this.Controls.Add(this.GrpRecurring);
            this.Controls.Add(this.TxtNote);
            this.Controls.Add(this.LblNote);
            this.Controls.Add(this.LblDateAndTime);
            this.Controls.Add(this.DPickerDate);
            this.Controls.Add(this.CmbContact);
            this.Controls.Add(this.LblContact);
            this.Controls.Add(this.CmbType);
            this.Controls.Add(this.LblType);
            this.Controls.Add(this.LblEventLocation);
            this.Controls.Add(this.TxtEventName);
            this.Controls.Add(this.headingPanel);
            this.Controls.Add(this.LblEventName);
            this.Name = "EventActionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EventActionForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EventActionForm_FormClosed);
            this.Load += new System.EventHandler(this.EventActionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.headingPanel.ResumeLayout(false);
            this.headingPanel.PerformLayout();
            this.GrpRecurring.ResumeLayout(false);
            this.GrpRecurring.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.Label LblHeading;
        private System.Windows.Forms.Panel headingPanel;
        private System.Windows.Forms.TextBox TxtEventName;
        private System.Windows.Forms.Label LblEventName;
        private System.Windows.Forms.Label LblEventLocation;
        private System.Windows.Forms.Label LblType;
        private System.Windows.Forms.ComboBox CmbType;
        private System.Windows.Forms.ComboBox CmbContact;
        private System.Windows.Forms.Label LblContact;
        private System.Windows.Forms.DateTimePicker DPickerDate;
        private System.Windows.Forms.Label LblDateAndTime;
        private System.Windows.Forms.RichTextBox TxtNote;
        private System.Windows.Forms.Label LblNote;
        private System.Windows.Forms.GroupBox GrpRecurring;
        private System.Windows.Forms.CheckBox ChkEndingStatus;
        private System.Windows.Forms.ComboBox CmbStatus;
        private System.Windows.Forms.Label LblEndTime;
        private System.Windows.Forms.DateTimePicker DPickerEndDate;
        private System.Windows.Forms.Label LblEventStatus;
        private System.Windows.Forms.CheckBox ChkRecurring;
        private System.Windows.Forms.TextBox TxtLocation;
        private MaterialSkin.Controls.MaterialFlatButton BtnAction;
        private MaterialSkin.Controls.MaterialFlatButton BtnDeleteEvent;
    }
}
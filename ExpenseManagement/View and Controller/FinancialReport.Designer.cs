namespace ExpenseManagement.View_and_Controller
{
    partial class FinancialReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinancialReport));
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.lblHeading = new System.Windows.Forms.Label();
            this.headingPanel = new System.Windows.Forms.Panel();
            this.LblUserName = new System.Windows.Forms.Label();
            this.ReportTabs = new MaterialSkin.Controls.MaterialTabControl();
            this.dailyReport = new System.Windows.Forms.TabPage();
            this.ListViewToday = new MaterialSkin.Controls.MaterialListView();
            this.materialListView2 = new MaterialSkin.Controls.MaterialListView();
            this.WeeklyReport = new System.Windows.Forms.TabPage();
            this.MonthlyReport = new System.Windows.Forms.TabPage();
            this.SelectedDate = new System.Windows.Forms.TabPage();
            this.reportSelector = new MaterialSkin.Controls.MaterialTabSelector();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.headingPanel.SuspendLayout();
            this.ReportTabs.SuspendLayout();
            this.dailyReport.SuspendLayout();
            this.SuspendLayout();
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
            this.lblHeading.Size = new System.Drawing.Size(255, 37);
            this.lblHeading.TabIndex = 2;
            this.lblHeading.Text = "Financial Report";
            // 
            // headingPanel
            // 
            this.headingPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headingPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.headingPanel.Controls.Add(this.btnBack);
            this.headingPanel.Controls.Add(this.lblHeading);
            this.headingPanel.Controls.Add(this.LblUserName);
            this.headingPanel.Location = new System.Drawing.Point(-1, 32);
            this.headingPanel.Name = "headingPanel";
            this.headingPanel.Size = new System.Drawing.Size(1003, 94);
            this.headingPanel.TabIndex = 4;
            // 
            // LblUserName
            // 
            this.LblUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblUserName.AutoSize = true;
            this.LblUserName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserName.ForeColor = System.Drawing.Color.Transparent;
            this.LblUserName.Location = new System.Drawing.Point(892, 42);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(108, 27);
            this.LblUserName.TabIndex = 1;
            this.LblUserName.Text = "Username";
            this.LblUserName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ReportTabs
            // 
            this.ReportTabs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReportTabs.Controls.Add(this.dailyReport);
            this.ReportTabs.Controls.Add(this.WeeklyReport);
            this.ReportTabs.Controls.Add(this.MonthlyReport);
            this.ReportTabs.Controls.Add(this.SelectedDate);
            this.ReportTabs.Depth = 0;
            this.ReportTabs.Location = new System.Drawing.Point(12, 193);
            this.ReportTabs.MouseState = MaterialSkin.MouseState.HOVER;
            this.ReportTabs.Name = "ReportTabs";
            this.ReportTabs.SelectedIndex = 0;
            this.ReportTabs.Size = new System.Drawing.Size(965, 660);
            this.ReportTabs.TabIndex = 5;
            this.ReportTabs.SelectedIndexChanged += new System.EventHandler(this.ReportTabs_SelectedIndexChanged);
            // 
            // dailyReport
            // 
            this.dailyReport.Controls.Add(this.ListViewToday);
            this.dailyReport.Controls.Add(this.materialListView2);
            this.dailyReport.Location = new System.Drawing.Point(4, 25);
            this.dailyReport.Name = "dailyReport";
            this.dailyReport.Padding = new System.Windows.Forms.Padding(3);
            this.dailyReport.Size = new System.Drawing.Size(957, 631);
            this.dailyReport.TabIndex = 0;
            this.dailyReport.Text = "Today\'s Report";
            this.dailyReport.UseVisualStyleBackColor = true;
            // 
            // ListViewToday
            // 
            this.ListViewToday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListViewToday.Depth = 0;
            this.ListViewToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.ListViewToday.FullRowSelect = true;
            this.ListViewToday.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ListViewToday.HideSelection = false;
            this.ListViewToday.Location = new System.Drawing.Point(25, 22);
            this.ListViewToday.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ListViewToday.MouseState = MaterialSkin.MouseState.OUT;
            this.ListViewToday.Name = "ListViewToday";
            this.ListViewToday.OwnerDraw = true;
            this.ListViewToday.Size = new System.Drawing.Size(907, 580);
            this.ListViewToday.TabIndex = 2;
            this.ListViewToday.UseCompatibleStateImageBehavior = false;
            this.ListViewToday.View = System.Windows.Forms.View.Details;
            // 
            // materialListView2
            // 
            this.materialListView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView2.Depth = 0;
            this.materialListView2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.materialListView2.FullRowSelect = true;
            this.materialListView2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.materialListView2.HideSelection = false;
            this.materialListView2.Location = new System.Drawing.Point(735, 380);
            this.materialListView2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView2.Name = "materialListView2";
            this.materialListView2.OwnerDraw = true;
            this.materialListView2.Size = new System.Drawing.Size(121, 97);
            this.materialListView2.TabIndex = 1;
            this.materialListView2.UseCompatibleStateImageBehavior = false;
            this.materialListView2.View = System.Windows.Forms.View.Details;
            // 
            // WeeklyReport
            // 
            this.WeeklyReport.Location = new System.Drawing.Point(4, 25);
            this.WeeklyReport.Name = "WeeklyReport";
            this.WeeklyReport.Padding = new System.Windows.Forms.Padding(3);
            this.WeeklyReport.Size = new System.Drawing.Size(957, 631);
            this.WeeklyReport.TabIndex = 1;
            this.WeeklyReport.Text = "Week\'s Report";
            this.WeeklyReport.UseVisualStyleBackColor = true;
            // 
            // MonthlyReport
            // 
            this.MonthlyReport.Location = new System.Drawing.Point(4, 25);
            this.MonthlyReport.Name = "MonthlyReport";
            this.MonthlyReport.Padding = new System.Windows.Forms.Padding(3);
            this.MonthlyReport.Size = new System.Drawing.Size(957, 631);
            this.MonthlyReport.TabIndex = 2;
            this.MonthlyReport.Text = "Month\'s Report";
            this.MonthlyReport.UseVisualStyleBackColor = true;
            // 
            // SelectedDate
            // 
            this.SelectedDate.Location = new System.Drawing.Point(4, 25);
            this.SelectedDate.Name = "SelectedDate";
            this.SelectedDate.Padding = new System.Windows.Forms.Padding(3);
            this.SelectedDate.Size = new System.Drawing.Size(957, 631);
            this.SelectedDate.TabIndex = 3;
            this.SelectedDate.Text = "Selected Dates";
            this.SelectedDate.UseVisualStyleBackColor = true;
            // 
            // reportSelector
            // 
            this.reportSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportSelector.BaseTabControl = this.ReportTabs;
            this.reportSelector.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reportSelector.Depth = 0;
            this.reportSelector.Location = new System.Drawing.Point(-1, 122);
            this.reportSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.reportSelector.Name = "reportSelector";
            this.reportSelector.Size = new System.Drawing.Size(1003, 65);
            this.reportSelector.TabIndex = 6;
            this.reportSelector.Text = "reportSelector";
            // 
            // FinancialReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 874);
            this.Controls.Add(this.reportSelector);
            this.Controls.Add(this.ReportTabs);
            this.Controls.Add(this.headingPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FinancialReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FinancialReport";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FinancialReport_FormClosed);
            this.Load += new System.EventHandler(this.FinancialReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.headingPanel.ResumeLayout(false);
            this.headingPanel.PerformLayout();
            this.ReportTabs.ResumeLayout(false);
            this.dailyReport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Panel headingPanel;
        private System.Windows.Forms.Label LblUserName;
        private MaterialSkin.Controls.MaterialTabControl ReportTabs;
        private System.Windows.Forms.TabPage dailyReport;
        private System.Windows.Forms.TabPage WeeklyReport;
        private System.Windows.Forms.TabPage MonthlyReport;
        private System.Windows.Forms.TabPage SelectedDate;
        private MaterialSkin.Controls.MaterialTabSelector reportSelector;
        private MaterialSkin.Controls.MaterialListView materialListView2;
        private MaterialSkin.Controls.MaterialListView ListViewToday;
    }
}
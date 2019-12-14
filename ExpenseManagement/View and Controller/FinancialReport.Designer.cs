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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.WeeklyChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.MonthlyReport = new System.Windows.Forms.TabPage();
            this.MonthlyChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.SelectedDate = new System.Windows.Forms.TabPage();
            this.ListViewSelectedDate = new MaterialSkin.Controls.MaterialListView();
            this.DPickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.BtnGenerateReport = new MaterialSkin.Controls.MaterialFlatButton();
            this.LblEndDate = new System.Windows.Forms.Label();
            this.LblStartDate = new System.Windows.Forms.Label();
            this.DPickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.reportSelector = new MaterialSkin.Controls.MaterialTabSelector();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.headingPanel.SuspendLayout();
            this.ReportTabs.SuspendLayout();
            this.dailyReport.SuspendLayout();
            this.WeeklyReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WeeklyChart)).BeginInit();
            this.MonthlyReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MonthlyChart)).BeginInit();
            this.SelectedDate.SuspendLayout();
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
            this.ReportTabs.Location = new System.Drawing.Point(11, 175);
            this.ReportTabs.MouseState = MaterialSkin.MouseState.HOVER;
            this.ReportTabs.Name = "ReportTabs";
            this.ReportTabs.SelectedIndex = 0;
            this.ReportTabs.Size = new System.Drawing.Size(965, 701);
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
            this.dailyReport.Size = new System.Drawing.Size(957, 672);
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
            this.WeeklyReport.Controls.Add(this.WeeklyChart);
            this.WeeklyReport.Location = new System.Drawing.Point(4, 25);
            this.WeeklyReport.Name = "WeeklyReport";
            this.WeeklyReport.Padding = new System.Windows.Forms.Padding(3);
            this.WeeklyReport.Size = new System.Drawing.Size(957, 672);
            this.WeeklyReport.TabIndex = 1;
            this.WeeklyReport.Text = "Week\'s Report";
            this.WeeklyReport.UseVisualStyleBackColor = true;
            // 
            // WeeklyChart
            // 
            this.WeeklyChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.WeeklyChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.WeeklyChart.Legends.Add(legend1);
            this.WeeklyChart.Location = new System.Drawing.Point(20, 19);
            this.WeeklyChart.Name = "WeeklyChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.WeeklyChart.Series.Add(series1);
            this.WeeklyChart.Size = new System.Drawing.Size(912, 667);
            this.WeeklyChart.TabIndex = 0;
            this.WeeklyChart.Text = "WeeklyReport";
            // 
            // MonthlyReport
            // 
            this.MonthlyReport.Controls.Add(this.MonthlyChart);
            this.MonthlyReport.Location = new System.Drawing.Point(4, 25);
            this.MonthlyReport.Name = "MonthlyReport";
            this.MonthlyReport.Padding = new System.Windows.Forms.Padding(3);
            this.MonthlyReport.Size = new System.Drawing.Size(957, 672);
            this.MonthlyReport.TabIndex = 2;
            this.MonthlyReport.Text = "Month\'s Report";
            this.MonthlyReport.UseVisualStyleBackColor = true;
            // 
            // MonthlyChart
            // 
            this.MonthlyChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.MonthlyChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.MonthlyChart.Legends.Add(legend2);
            this.MonthlyChart.Location = new System.Drawing.Point(22, 17);
            this.MonthlyChart.Name = "MonthlyChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.MonthlyChart.Series.Add(series2);
            this.MonthlyChart.Size = new System.Drawing.Size(912, 659);
            this.MonthlyChart.TabIndex = 1;
            this.MonthlyChart.Text = "MonthlyChart";
            // 
            // SelectedDate
            // 
            this.SelectedDate.Controls.Add(this.ListViewSelectedDate);
            this.SelectedDate.Controls.Add(this.DPickerEndDate);
            this.SelectedDate.Controls.Add(this.BtnGenerateReport);
            this.SelectedDate.Controls.Add(this.LblEndDate);
            this.SelectedDate.Controls.Add(this.LblStartDate);
            this.SelectedDate.Controls.Add(this.DPickerStartDate);
            this.SelectedDate.Location = new System.Drawing.Point(4, 25);
            this.SelectedDate.Name = "SelectedDate";
            this.SelectedDate.Padding = new System.Windows.Forms.Padding(3);
            this.SelectedDate.Size = new System.Drawing.Size(957, 631);
            this.SelectedDate.TabIndex = 3;
            this.SelectedDate.Text = "Selected Dates";
            this.SelectedDate.UseVisualStyleBackColor = true;
            // 
            // ListViewSelectedDate
            // 
            this.ListViewSelectedDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ListViewSelectedDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListViewSelectedDate.Depth = 0;
            this.ListViewSelectedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.ListViewSelectedDate.FullRowSelect = true;
            this.ListViewSelectedDate.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ListViewSelectedDate.HideSelection = false;
            this.ListViewSelectedDate.Location = new System.Drawing.Point(25, 104);
            this.ListViewSelectedDate.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ListViewSelectedDate.MouseState = MaterialSkin.MouseState.OUT;
            this.ListViewSelectedDate.Name = "ListViewSelectedDate";
            this.ListViewSelectedDate.OwnerDraw = true;
            this.ListViewSelectedDate.Size = new System.Drawing.Size(907, 501);
            this.ListViewSelectedDate.TabIndex = 47;
            this.ListViewSelectedDate.UseCompatibleStateImageBehavior = false;
            this.ListViewSelectedDate.View = System.Windows.Forms.View.Details;
            // 
            // DPickerEndDate
            // 
            this.DPickerEndDate.CalendarFont = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DPickerEndDate.CustomFormat = "dddd, dd MMMM yyyy HH:mm";
            this.DPickerEndDate.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DPickerEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DPickerEndDate.Location = new System.Drawing.Point(353, 50);
            this.DPickerEndDate.Name = "DPickerEndDate";
            this.DPickerEndDate.Size = new System.Drawing.Size(294, 28);
            this.DPickerEndDate.TabIndex = 46;
            this.DPickerEndDate.Value = new System.DateTime(2019, 12, 11, 22, 11, 32, 0);
            // 
            // BtnGenerateReport
            // 
            this.BtnGenerateReport.AutoSize = true;
            this.BtnGenerateReport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnGenerateReport.Depth = 0;
            this.BtnGenerateReport.Icon = null;
            this.BtnGenerateReport.Location = new System.Drawing.Point(739, 42);
            this.BtnGenerateReport.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnGenerateReport.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnGenerateReport.Name = "BtnGenerateReport";
            this.BtnGenerateReport.Primary = false;
            this.BtnGenerateReport.Size = new System.Drawing.Size(176, 36);
            this.BtnGenerateReport.TabIndex = 45;
            this.BtnGenerateReport.Text = "Generate Report";
            this.BtnGenerateReport.UseVisualStyleBackColor = true;
            this.BtnGenerateReport.Click += new System.EventHandler(this.BtnGenerateReport_Click);
            // 
            // LblEndDate
            // 
            this.LblEndDate.AutoSize = true;
            this.LblEndDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEndDate.Location = new System.Drawing.Point(349, 25);
            this.LblEndDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblEndDate.Name = "LblEndDate";
            this.LblEndDate.Size = new System.Drawing.Size(83, 22);
            this.LblEndDate.TabIndex = 44;
            this.LblEndDate.Text = "End Date";
            // 
            // LblStartDate
            // 
            this.LblStartDate.AutoSize = true;
            this.LblStartDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStartDate.Location = new System.Drawing.Point(25, 25);
            this.LblStartDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblStartDate.Name = "LblStartDate";
            this.LblStartDate.Size = new System.Drawing.Size(89, 22);
            this.LblStartDate.TabIndex = 42;
            this.LblStartDate.Text = "Start Date";
            // 
            // DPickerStartDate
            // 
            this.DPickerStartDate.CalendarFont = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DPickerStartDate.CustomFormat = "dddd, dd MMMM yyyy HH:mm";
            this.DPickerStartDate.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DPickerStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DPickerStartDate.Location = new System.Drawing.Point(29, 50);
            this.DPickerStartDate.Name = "DPickerStartDate";
            this.DPickerStartDate.Size = new System.Drawing.Size(294, 28);
            this.DPickerStartDate.TabIndex = 41;
            this.DPickerStartDate.Value = new System.DateTime(2019, 12, 11, 22, 11, 32, 0);
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
            this.WeeklyReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WeeklyChart)).EndInit();
            this.MonthlyReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MonthlyChart)).EndInit();
            this.SelectedDate.ResumeLayout(false);
            this.SelectedDate.PerformLayout();
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
        private System.Windows.Forms.DateTimePicker DPickerStartDate;
        private System.Windows.Forms.Label LblStartDate;
        private System.Windows.Forms.Label LblEndDate;
        private System.Windows.Forms.DateTimePicker DPickerEndDate;
        private MaterialSkin.Controls.MaterialFlatButton BtnGenerateReport;
        private MaterialSkin.Controls.MaterialListView ListViewSelectedDate;
        private System.Windows.Forms.DataVisualization.Charting.Chart WeeklyChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart MonthlyChart;
    }
}
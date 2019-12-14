namespace ExpenseManagement.View_and_Controller
{
    partial class GraphForm
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
            this.BehaviorChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.lblHeading = new System.Windows.Forms.Label();
            this.headingPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.BehaviorChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.headingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BehaviorChart
            // 
            this.BehaviorChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.BehaviorChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.BehaviorChart.Legends.Add(legend1);
            this.BehaviorChart.Location = new System.Drawing.Point(47, 131);
            this.BehaviorChart.Name = "BehaviorChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.BehaviorChart.Series.Add(series1);
            this.BehaviorChart.Size = new System.Drawing.Size(700, 500);
            this.BehaviorChart.TabIndex = 1;
            this.BehaviorChart.Text = "WeeklyReport";
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Image = global::ExpenseManagement.Properties.Resources.Back;
            this.btnBack.Location = new System.Drawing.Point(27, 18);
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
            this.lblHeading.Location = new System.Drawing.Point(85, 25);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(271, 37);
            this.lblHeading.TabIndex = 2;
            this.lblHeading.Text = "Expense Behavior";
            // 
            // headingPanel
            // 
            this.headingPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headingPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.headingPanel.Controls.Add(this.btnBack);
            this.headingPanel.Controls.Add(this.lblHeading);
            this.headingPanel.Location = new System.Drawing.Point(-4, 1);
            this.headingPanel.Name = "headingPanel";
            this.headingPanel.Size = new System.Drawing.Size(806, 94);
            this.headingPanel.TabIndex = 5;
            // 
            // GraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 656);
            this.Controls.Add(this.headingPanel);
            this.Controls.Add(this.BehaviorChart);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GraphForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GraphForm";
            ((System.ComponentModel.ISupportInitialize)(this.BehaviorChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.headingPanel.ResumeLayout(false);
            this.headingPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart BehaviorChart;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Panel headingPanel;
    }
}
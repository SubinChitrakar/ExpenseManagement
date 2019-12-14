namespace ExpenseManagement.View_and_Controller
{
    partial class PredictionForm
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
            this.LblHeading = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.LblDate = new System.Windows.Forms.Label();
            this.DPickerDate = new System.Windows.Forms.DateTimePicker();
            this.BtnPredict = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // LblHeading
            // 
            this.LblHeading.AutoSize = true;
            this.LblHeading.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHeading.ForeColor = System.Drawing.Color.White;
            this.LblHeading.Location = new System.Drawing.Point(73, 46);
            this.LblHeading.Name = "LblHeading";
            this.LblHeading.Size = new System.Drawing.Size(163, 37);
            this.LblHeading.TabIndex = 4;
            this.LblHeading.Text = "Prediction";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.LblHeading);
            this.panel1.Location = new System.Drawing.Point(-10, -18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 114);
            this.panel1.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Image = global::ExpenseManagement.Properties.Resources.Back;
            this.btnBack.Location = new System.Drawing.Point(21, 40);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(46, 47);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBack.TabIndex = 3;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDate.Location = new System.Drawing.Point(22, 128);
            this.LblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(47, 22);
            this.LblDate.TabIndex = 37;
            this.LblDate.Text = "Date";
            // 
            // DPickerDate
            // 
            this.DPickerDate.CalendarFont = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DPickerDate.CustomFormat = "dddd, dd MMMM yyyy";
            this.DPickerDate.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DPickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DPickerDate.Location = new System.Drawing.Point(26, 153);
            this.DPickerDate.Name = "DPickerDate";
            this.DPickerDate.Size = new System.Drawing.Size(324, 28);
            this.DPickerDate.TabIndex = 38;
            this.DPickerDate.Value = new System.DateTime(2019, 12, 11, 0, 0, 0, 0);
            // 
            // BtnPredict
            // 
            this.BtnPredict.AutoSize = true;
            this.BtnPredict.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnPredict.Depth = 0;
            this.BtnPredict.Icon = null;
            this.BtnPredict.Location = new System.Drawing.Point(357, 145);
            this.BtnPredict.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnPredict.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnPredict.Name = "BtnPredict";
            this.BtnPredict.Primary = false;
            this.BtnPredict.Size = new System.Drawing.Size(91, 36);
            this.BtnPredict.TabIndex = 39;
            this.BtnPredict.Text = "Predict";
            this.BtnPredict.UseVisualStyleBackColor = true;
            this.BtnPredict.Click += new System.EventHandler(this.BtnPredict_Click);
            // 
            // PredictionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 239);
            this.Controls.Add(this.BtnPredict);
            this.Controls.Add(this.LblDate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DPickerDate);
            this.Name = "PredictionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PredictionForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblHeading;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.DateTimePicker DPickerDate;
        private MaterialSkin.Controls.MaterialFlatButton BtnPredict;
    }
}
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.btnContact = new System.Windows.Forms.Button();
            this.BtnTransaction = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.RecurringBackground = new System.ComponentModel.BackgroundWorker();
            this.Prediction = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnContact
            // 
            this.btnContact.Location = new System.Drawing.Point(100, 276);
            this.btnContact.Name = "btnContact";
            this.btnContact.Size = new System.Drawing.Size(75, 23);
            this.btnContact.TabIndex = 0;
            this.btnContact.Text = "Contact";
            this.btnContact.UseVisualStyleBackColor = true;
            this.btnContact.Click += new System.EventHandler(this.BtnContact_Click);
            // 
            // BtnTransaction
            // 
            this.BtnTransaction.Location = new System.Drawing.Point(12, 376);
            this.BtnTransaction.Name = "BtnTransaction";
            this.BtnTransaction.Size = new System.Drawing.Size(140, 23);
            this.BtnTransaction.TabIndex = 1;
            this.BtnTransaction.Text = "Transaction";
            this.BtnTransaction.UseVisualStyleBackColor = true;
            this.BtnTransaction.Click += new System.EventHandler(this.BtnTransaction_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Events";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 43);
            this.button2.TabIndex = 3;
            this.button2.Text = "RecurringEvent";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(239, 366);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(193, 43);
            this.button3.TabIndex = 4;
            this.button3.Text = "RecurringTransaction";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(440, 242);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(171, 57);
            this.button4.TabIndex = 5;
            this.button4.Text = "Generate Report";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // RecurringBackground
            // 
            this.RecurringBackground.WorkerReportsProgress = true;
            this.RecurringBackground.WorkerSupportsCancellation = true;
            this.RecurringBackground.DoWork += new System.ComponentModel.DoWorkEventHandler(this._backgroundActivityForRecurring);
            this.RecurringBackground.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.RecurringBackground_ProgressChanged);
            // 
            // Prediction
            // 
            this.Prediction.Location = new System.Drawing.Point(454, 179);
            this.Prediction.Name = "Prediction";
            this.Prediction.Size = new System.Drawing.Size(168, 29);
            this.Prediction.TabIndex = 6;
            this.Prediction.Text = "Prediction";
            this.Prediction.UseVisualStyleBackColor = true;
            this.Prediction.Click += new System.EventHandler(this.Prediction_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(747, 78);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(146, 57);
            this.button5.TabIndex = 7;
            this.button5.Text = "Notification";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 544);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Prediction);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnTransaction);
            this.Controls.Add(this.btnContact);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Activated += new System.EventHandler(this.Dashboard_Activated);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnContact;
        private System.Windows.Forms.Button BtnTransaction;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.ComponentModel.BackgroundWorker RecurringBackground;
        private System.Windows.Forms.Button Prediction;
        private System.Windows.Forms.Button button5;
    }
}
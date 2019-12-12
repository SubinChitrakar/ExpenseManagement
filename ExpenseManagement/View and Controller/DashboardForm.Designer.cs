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
            this.SuspendLayout();
            // 
            // btnContact
            // 
            this.btnContact.Location = new System.Drawing.Point(12, 22);
            this.btnContact.Name = "btnContact";
            this.btnContact.Size = new System.Drawing.Size(75, 23);
            this.btnContact.TabIndex = 0;
            this.btnContact.Text = "Contact";
            this.btnContact.UseVisualStyleBackColor = true;
            this.btnContact.Click += new System.EventHandler(this.BtnContact_Click);
            // 
            // BtnTransaction
            // 
            this.BtnTransaction.Location = new System.Drawing.Point(12, 70);
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
            this.button3.Location = new System.Drawing.Point(186, 60);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(193, 43);
            this.button3.TabIndex = 4;
            this.button3.Text = "RecurringTransaction";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 544);
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
    }
}
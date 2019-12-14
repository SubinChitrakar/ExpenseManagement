namespace ExpenseManagement.View_and_Controller
{
    partial class NotificationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotificationForm));
            this.NotificationBackground = new System.ComponentModel.BackgroundWorker();
            this.LblMessage = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // NotificationBackground
            // 
            this.NotificationBackground.DoWork += new System.ComponentModel.DoWorkEventHandler(this.WaitDoWork);
            this.NotificationBackground.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.WaitCompleted);
            // 
            // LblMessage
            // 
            this.LblMessage.AutoSize = true;
            this.LblMessage.Depth = 0;
            this.LblMessage.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblMessage.Location = new System.Drawing.Point(12, 28);
            this.LblMessage.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblMessage.Name = "LblMessage";
            this.LblMessage.Size = new System.Drawing.Size(88, 24);
            this.LblMessage.TabIndex = 0;
            this.LblMessage.Text = "Message";
            // 
            // NotificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 88);
            this.Controls.Add(this.LblMessage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NotificationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Notification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker NotificationBackground;
        private MaterialSkin.Controls.MaterialLabel LblMessage;
    }
}
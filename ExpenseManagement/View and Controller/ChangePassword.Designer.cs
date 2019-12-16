namespace ExpenseManagement.View_and_Controller
{
    partial class ChangePassword
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.LblHeading = new System.Windows.Forms.Label();
            this.TxtOldPassword = new System.Windows.Forms.TextBox();
            this.lblPasswordLogin = new System.Windows.Forms.Label();
            this.TxtNewPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtConfirmPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnChangePassword = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.LblHeading);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 114);
            this.panel1.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Image = global::ExpenseManagement.Properties.Resources.Back;
            this.btnBack.Location = new System.Drawing.Point(21, 36);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(46, 47);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBack.TabIndex = 3;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // LblHeading
            // 
            this.LblHeading.AutoSize = true;
            this.LblHeading.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHeading.ForeColor = System.Drawing.Color.White;
            this.LblHeading.Location = new System.Drawing.Point(73, 42);
            this.LblHeading.Name = "LblHeading";
            this.LblHeading.Size = new System.Drawing.Size(267, 37);
            this.LblHeading.TabIndex = 4;
            this.LblHeading.Text = "Change Password";
            // 
            // TxtOldPassword
            // 
            this.TxtOldPassword.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.TxtOldPassword.Location = new System.Drawing.Point(20, 169);
            this.TxtOldPassword.Margin = new System.Windows.Forms.Padding(4);
            this.TxtOldPassword.Name = "TxtOldPassword";
            this.TxtOldPassword.PasswordChar = '*';
            this.TxtOldPassword.Size = new System.Drawing.Size(435, 29);
            this.TxtOldPassword.TabIndex = 16;
            // 
            // lblPasswordLogin
            // 
            this.lblPasswordLogin.AutoSize = true;
            this.lblPasswordLogin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordLogin.Location = new System.Drawing.Point(18, 143);
            this.lblPasswordLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPasswordLogin.Name = "lblPasswordLogin";
            this.lblPasswordLogin.Size = new System.Drawing.Size(123, 22);
            this.lblPasswordLogin.TabIndex = 15;
            this.lblPasswordLogin.Text = "Old Password";
            // 
            // TxtNewPassword
            // 
            this.TxtNewPassword.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.TxtNewPassword.Location = new System.Drawing.Point(20, 238);
            this.TxtNewPassword.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNewPassword.Name = "TxtNewPassword";
            this.TxtNewPassword.PasswordChar = '*';
            this.TxtNewPassword.Size = new System.Drawing.Size(435, 29);
            this.TxtNewPassword.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 212);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 22);
            this.label1.TabIndex = 17;
            this.label1.Text = "New Password";
            // 
            // TxtConfirmPassword
            // 
            this.TxtConfirmPassword.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.TxtConfirmPassword.Location = new System.Drawing.Point(22, 309);
            this.TxtConfirmPassword.Margin = new System.Windows.Forms.Padding(4);
            this.TxtConfirmPassword.Name = "TxtConfirmPassword";
            this.TxtConfirmPassword.PasswordChar = '*';
            this.TxtConfirmPassword.Size = new System.Drawing.Size(433, 29);
            this.TxtConfirmPassword.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 284);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 22);
            this.label2.TabIndex = 19;
            this.label2.Text = "Confirm Password";
            // 
            // BtnChangePassword
            // 
            this.BtnChangePassword.AutoSize = true;
            this.BtnChangePassword.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnChangePassword.Depth = 0;
            this.BtnChangePassword.Icon = null;
            this.BtnChangePassword.Location = new System.Drawing.Point(268, 366);
            this.BtnChangePassword.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnChangePassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnChangePassword.Name = "BtnChangePassword";
            this.BtnChangePassword.Primary = false;
            this.BtnChangePassword.Size = new System.Drawing.Size(187, 36);
            this.BtnChangePassword.TabIndex = 21;
            this.BtnChangePassword.Text = "Change Password";
            this.BtnChangePassword.UseVisualStyleBackColor = true;
            this.BtnChangePassword.Click += new System.EventHandler(this.BtnChangePassword_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 436);
            this.Controls.Add(this.BtnChangePassword);
            this.Controls.Add(this.TxtConfirmPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtNewPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtOldPassword);
            this.Controls.Add(this.lblPasswordLogin);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePassword";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.Label LblHeading;
        private System.Windows.Forms.TextBox TxtOldPassword;
        private System.Windows.Forms.Label lblPasswordLogin;
        private System.Windows.Forms.TextBox TxtNewPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtConfirmPassword;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialFlatButton BtnChangePassword;
    }
}
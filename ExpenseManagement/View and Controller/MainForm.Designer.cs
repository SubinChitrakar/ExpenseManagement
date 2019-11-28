namespace ExpenseManagement
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabLogin = new System.Windows.Forms.TabControl();
            this.Login = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPasswordLogin = new System.Windows.Forms.TextBox();
            this.lblPasswordLogin = new System.Windows.Forms.Label();
            this.txtUsernameLogin = new System.Windows.Forms.TextBox();
            this.lblUsernameLogin = new System.Windows.Forms.Label();
            this.lblTitleManagement = new System.Windows.Forms.Label();
            this.txtTitleExpense = new System.Windows.Forms.Label();
            this.imgLogoLogin = new System.Windows.Forms.PictureBox();
            this.tabRegister = new System.Windows.Forms.TabPage();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblRegisterManagement = new System.Windows.Forms.Label();
            this.lblRegisterExpense = new System.Windows.Forms.Label();
            this.imgLogoRegister = new System.Windows.Forms.PictureBox();
            this.tabLogin.SuspendLayout();
            this.Login.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoLogin)).BeginInit();
            this.tabRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoRegister)).BeginInit();
            this.SuspendLayout();
            // 
            // tabLogin
            // 
            this.tabLogin.Controls.Add(this.Login);
            this.tabLogin.Controls.Add(this.tabRegister);
            this.tabLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabLogin.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabLogin.Location = new System.Drawing.Point(11, 11);
            this.tabLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.Padding = new System.Drawing.Point(10, 6);
            this.tabLogin.SelectedIndex = 0;
            this.tabLogin.Size = new System.Drawing.Size(360, 490);
            this.tabLogin.TabIndex = 0;
            // 
            // Login
            // 
            this.Login.Controls.Add(this.panel1);
            this.Login.Cursor = System.Windows.Forms.Cursors.Default;
            this.Login.Location = new System.Drawing.Point(4, 30);
            this.Login.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Login.Name = "Login";
            this.Login.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Login.Size = new System.Drawing.Size(352, 426);
            this.Login.TabIndex = 0;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.txtPasswordLogin);
            this.panel1.Controls.Add(this.lblPasswordLogin);
            this.panel1.Controls.Add(this.txtUsernameLogin);
            this.panel1.Controls.Add(this.lblUsernameLogin);
            this.panel1.Controls.Add(this.lblTitleManagement);
            this.panel1.Controls.Add(this.txtTitleExpense);
            this.panel1.Controls.Add(this.imgLogoLogin);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 383);
            this.panel1.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(234, 310);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(103, 34);
            this.btnLogin.TabIndex = 11;
            this.btnLogin.Text = "Log In";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // txtPasswordLogin
            // 
            this.txtPasswordLogin.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.txtPasswordLogin.Location = new System.Drawing.Point(23, 263);
            this.txtPasswordLogin.Name = "txtPasswordLogin";
            this.txtPasswordLogin.PasswordChar = '*';
            this.txtPasswordLogin.Size = new System.Drawing.Size(314, 24);
            this.txtPasswordLogin.TabIndex = 10;
            // 
            // lblPasswordLogin
            // 
            this.lblPasswordLogin.AutoSize = true;
            this.lblPasswordLogin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordLogin.Location = new System.Drawing.Point(19, 241);
            this.lblPasswordLogin.Name = "lblPasswordLogin";
            this.lblPasswordLogin.Size = new System.Drawing.Size(69, 19);
            this.lblPasswordLogin.TabIndex = 9;
            this.lblPasswordLogin.Text = "Password";
            // 
            // txtUsernameLogin
            // 
            this.txtUsernameLogin.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.txtUsernameLogin.Location = new System.Drawing.Point(23, 202);
            this.txtUsernameLogin.Name = "txtUsernameLogin";
            this.txtUsernameLogin.Size = new System.Drawing.Size(314, 24);
            this.txtUsernameLogin.TabIndex = 8;
            // 
            // lblUsernameLogin
            // 
            this.lblUsernameLogin.AutoSize = true;
            this.lblUsernameLogin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameLogin.Location = new System.Drawing.Point(19, 180);
            this.lblUsernameLogin.Name = "lblUsernameLogin";
            this.lblUsernameLogin.Size = new System.Drawing.Size(70, 19);
            this.lblUsernameLogin.TabIndex = 1;
            this.lblUsernameLogin.Text = "Username";
            // 
            // lblTitleManagement
            // 
            this.lblTitleManagement.AutoSize = true;
            this.lblTitleManagement.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleManagement.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTitleManagement.Location = new System.Drawing.Point(178, 85);
            this.lblTitleManagement.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitleManagement.Name = "lblTitleManagement";
            this.lblTitleManagement.Size = new System.Drawing.Size(163, 31);
            this.lblTitleManagement.TabIndex = 6;
            this.lblTitleManagement.Text = "Management";
            // 
            // txtTitleExpense
            // 
            this.txtTitleExpense.AutoSize = true;
            this.txtTitleExpense.BackColor = System.Drawing.Color.Transparent;
            this.txtTitleExpense.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitleExpense.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtTitleExpense.Location = new System.Drawing.Point(114, 49);
            this.txtTitleExpense.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtTitleExpense.Name = "txtTitleExpense";
            this.txtTitleExpense.Size = new System.Drawing.Size(162, 45);
            this.txtTitleExpense.TabIndex = 7;
            this.txtTitleExpense.Text = "Expense";
            // 
            // imgLogoLogin
            // 
            this.imgLogoLogin.Image = ((System.Drawing.Image)(resources.GetObject("imgLogoLogin.Image")));
            this.imgLogoLogin.Location = new System.Drawing.Point(15, 35);
            this.imgLogoLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.imgLogoLogin.Name = "imgLogoLogin";
            this.imgLogoLogin.Size = new System.Drawing.Size(108, 100);
            this.imgLogoLogin.TabIndex = 5;
            this.imgLogoLogin.TabStop = false;
            // 
            // tabRegister
            // 
            this.tabRegister.Controls.Add(this.btnRegister);
            this.tabRegister.Controls.Add(this.txtConfirmPassword);
            this.tabRegister.Controls.Add(this.lblConfirmPassword);
            this.tabRegister.Controls.Add(this.txtPassword);
            this.tabRegister.Controls.Add(this.lblPassword);
            this.tabRegister.Controls.Add(this.txtUsername);
            this.tabRegister.Controls.Add(this.lblUsername);
            this.tabRegister.Controls.Add(this.txtLastName);
            this.tabRegister.Controls.Add(this.lblLastName);
            this.tabRegister.Controls.Add(this.txtFirstName);
            this.tabRegister.Controls.Add(this.lblFirstName);
            this.tabRegister.Controls.Add(this.lblRegisterManagement);
            this.tabRegister.Controls.Add(this.lblRegisterExpense);
            this.tabRegister.Controls.Add(this.imgLogoRegister);
            this.tabRegister.Location = new System.Drawing.Point(4, 30);
            this.tabRegister.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabRegister.Name = "tabRegister";
            this.tabRegister.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabRegister.Size = new System.Drawing.Size(352, 456);
            this.tabRegister.TabIndex = 1;
            this.tabRegister.Text = "Register";
            this.tabRegister.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(234, 387);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(103, 34);
            this.btnRegister.TabIndex = 22;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.txtConfirmPassword.Location = new System.Drawing.Point(15, 332);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(322, 24);
            this.txtConfirmPassword.TabIndex = 21;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.Location = new System.Drawing.Point(11, 310);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(122, 19);
            this.lblConfirmPassword.TabIndex = 20;
            this.lblConfirmPassword.Text = "Confirm Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.txtPassword.Location = new System.Drawing.Point(15, 283);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(322, 24);
            this.txtPassword.TabIndex = 19;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(11, 261);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(69, 19);
            this.lblPassword.TabIndex = 18;
            this.lblPassword.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.txtUsername.Location = new System.Drawing.Point(15, 234);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(322, 24);
            this.txtUsername.TabIndex = 17;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(11, 212);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(70, 19);
            this.lblUsername.TabIndex = 16;
            this.lblUsername.Text = "Username";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.txtLastName.Location = new System.Drawing.Point(184, 185);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(153, 24);
            this.txtLastName.TabIndex = 15;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(180, 163);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(76, 19);
            this.lblLastName.TabIndex = 14;
            this.lblLastName.Text = "Last Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.txtFirstName.Location = new System.Drawing.Point(15, 185);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(153, 24);
            this.txtFirstName.TabIndex = 13;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(11, 163);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(77, 19);
            this.lblFirstName.TabIndex = 9;
            this.lblFirstName.Text = "First Name";
            // 
            // lblRegisterManagement
            // 
            this.lblRegisterManagement.AutoSize = true;
            this.lblRegisterManagement.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterManagement.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblRegisterManagement.Location = new System.Drawing.Point(178, 85);
            this.lblRegisterManagement.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegisterManagement.Name = "lblRegisterManagement";
            this.lblRegisterManagement.Size = new System.Drawing.Size(163, 31);
            this.lblRegisterManagement.TabIndex = 11;
            this.lblRegisterManagement.Text = "Management";
            // 
            // lblRegisterExpense
            // 
            this.lblRegisterExpense.AutoSize = true;
            this.lblRegisterExpense.BackColor = System.Drawing.Color.Transparent;
            this.lblRegisterExpense.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterExpense.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblRegisterExpense.Location = new System.Drawing.Point(114, 49);
            this.lblRegisterExpense.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegisterExpense.Name = "lblRegisterExpense";
            this.lblRegisterExpense.Size = new System.Drawing.Size(162, 45);
            this.lblRegisterExpense.TabIndex = 12;
            this.lblRegisterExpense.Text = "Expense";
            // 
            // imgLogoRegister
            // 
            this.imgLogoRegister.Image = ((System.Drawing.Image)(resources.GetObject("imgLogoRegister.Image")));
            this.imgLogoRegister.Location = new System.Drawing.Point(15, 35);
            this.imgLogoRegister.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.imgLogoRegister.Name = "imgLogoRegister";
            this.imgLogoRegister.Size = new System.Drawing.Size(108, 100);
            this.imgLogoRegister.TabIndex = 10;
            this.imgLogoRegister.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 511);
            this.Controls.Add(this.tabLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expense Management";
            this.tabLogin.ResumeLayout(false);
            this.Login.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoLogin)).EndInit();
            this.tabRegister.ResumeLayout(false);
            this.tabRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoRegister)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabLogin;
        private System.Windows.Forms.TabPage Login;
        private System.Windows.Forms.TabPage tabRegister;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitleManagement;
        private System.Windows.Forms.Label txtTitleExpense;
        private System.Windows.Forms.PictureBox imgLogoLogin;
        private System.Windows.Forms.TextBox txtUsernameLogin;
        private System.Windows.Forms.Label lblUsernameLogin;
        private System.Windows.Forms.TextBox txtPasswordLogin;
        private System.Windows.Forms.Label lblPasswordLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblRegisterManagement;
        private System.Windows.Forms.Label lblRegisterExpense;
        private System.Windows.Forms.PictureBox imgLogoRegister;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Button btnRegister;
    }
}


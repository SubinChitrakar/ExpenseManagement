namespace ExpenseManagement
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TabRegister = new System.Windows.Forms.TabPage();
            this.btnRegister = new MaterialSkin.Controls.MaterialFlatButton();
            this.TxtConfirmPassword = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.TabLogin = new System.Windows.Forms.TabPage();
            this.btnLogin = new MaterialSkin.Controls.MaterialFlatButton();
            this.TxtPasswordLogin = new System.Windows.Forms.TextBox();
            this.TxtUsernameLogin = new System.Windows.Forms.TextBox();
            this.lblPasswordLogin = new System.Windows.Forms.Label();
            this.lblUsernameLogin = new System.Windows.Forms.Label();
            this.StartUpTab = new MaterialSkin.Controls.MaterialTabControl();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TabRegister.SuspendLayout();
            this.TabLogin.SuspendLayout();
            this.StartUpTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 160);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(276, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 39);
            this.label1.TabIndex = 12;
            this.label1.Text = "Management";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(191, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 57);
            this.label2.TabIndex = 13;
            this.label2.Text = "Expense";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ExpenseManagement.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(55, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // TabRegister
            // 
            this.TabRegister.Controls.Add(this.btnRegister);
            this.TabRegister.Controls.Add(this.TxtConfirmPassword);
            this.TabRegister.Controls.Add(this.TxtPassword);
            this.TabRegister.Controls.Add(this.TxtUsername);
            this.TabRegister.Controls.Add(this.TxtLastName);
            this.TabRegister.Controls.Add(this.TxtFirstName);
            this.TabRegister.Controls.Add(this.lblConfirmPassword);
            this.TabRegister.Controls.Add(this.lblPassword);
            this.TabRegister.Controls.Add(this.lblUsername);
            this.TabRegister.Controls.Add(this.lblLastName);
            this.TabRegister.Controls.Add(this.lblFirstName);
            this.TabRegister.Location = new System.Drawing.Point(4, 25);
            this.TabRegister.Name = "TabRegister";
            this.TabRegister.Padding = new System.Windows.Forms.Padding(3);
            this.TabRegister.Size = new System.Drawing.Size(472, 574);
            this.TabRegister.TabIndex = 1;
            this.TabRegister.Text = "Register";
            this.TabRegister.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            this.btnRegister.AutoSize = true;
            this.btnRegister.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.Depth = 0;
            this.btnRegister.Icon = null;
            this.btnRegister.Location = new System.Drawing.Point(363, 356);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRegister.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Primary = false;
            this.btnRegister.Size = new System.Drawing.Size(100, 36);
            this.btnRegister.TabIndex = 39;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // TxtConfirmPassword
            // 
            this.TxtConfirmPassword.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.TxtConfirmPassword.Location = new System.Drawing.Point(26, 295);
            this.TxtConfirmPassword.Margin = new System.Windows.Forms.Padding(4);
            this.TxtConfirmPassword.Name = "TxtConfirmPassword";
            this.TxtConfirmPassword.PasswordChar = '*';
            this.TxtConfirmPassword.Size = new System.Drawing.Size(428, 29);
            this.TxtConfirmPassword.TabIndex = 34;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.TxtPassword.Location = new System.Drawing.Point(26, 210);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.Size = new System.Drawing.Size(422, 29);
            this.TxtPassword.TabIndex = 32;
            // 
            // TxtUsername
            // 
            this.TxtUsername.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.TxtUsername.Location = new System.Drawing.Point(26, 135);
            this.TxtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(422, 29);
            this.TxtUsername.TabIndex = 30;
            // 
            // TxtLastName
            // 
            this.TxtLastName.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.TxtLastName.Location = new System.Drawing.Point(245, 60);
            this.TxtLastName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(203, 29);
            this.TxtLastName.TabIndex = 28;
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.TxtFirstName.Location = new System.Drawing.Point(20, 60);
            this.TxtFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(203, 29);
            this.TxtFirstName.TabIndex = 26;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.Location = new System.Drawing.Point(26, 270);
            this.lblConfirmPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(158, 22);
            this.lblConfirmPassword.TabIndex = 33;
            this.lblConfirmPassword.Text = "Confirm Password";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(26, 185);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(88, 22);
            this.lblPassword.TabIndex = 31;
            this.lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(20, 110);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(88, 22);
            this.lblUsername.TabIndex = 29;
            this.lblUsername.Text = "Username";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(245, 35);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(94, 22);
            this.lblLastName.TabIndex = 27;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(20, 35);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(98, 22);
            this.lblFirstName.TabIndex = 23;
            this.lblFirstName.Text = "First Name";
            // 
            // TabLogin
            // 
            this.TabLogin.Controls.Add(this.btnLogin);
            this.TabLogin.Controls.Add(this.TxtPasswordLogin);
            this.TabLogin.Controls.Add(this.TxtUsernameLogin);
            this.TabLogin.Controls.Add(this.lblPasswordLogin);
            this.TabLogin.Controls.Add(this.lblUsernameLogin);
            this.TabLogin.Location = new System.Drawing.Point(4, 25);
            this.TabLogin.Name = "TabLogin";
            this.TabLogin.Padding = new System.Windows.Forms.Padding(3);
            this.TabLogin.Size = new System.Drawing.Size(472, 574);
            this.TabLogin.TabIndex = 0;
            this.TabLogin.Text = "Login";
            this.TabLogin.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.AutoSize = true;
            this.btnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Depth = 0;
            this.btnLogin.Icon = null;
            this.btnLogin.Location = new System.Drawing.Point(380, 199);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Primary = false;
            this.btnLogin.Size = new System.Drawing.Size(72, 36);
            this.btnLogin.TabIndex = 15;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // TxtPasswordLogin
            // 
            this.TxtPasswordLogin.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.TxtPasswordLogin.Location = new System.Drawing.Point(26, 135);
            this.TxtPasswordLogin.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPasswordLogin.Name = "TxtPasswordLogin";
            this.TxtPasswordLogin.PasswordChar = '*';
            this.TxtPasswordLogin.Size = new System.Drawing.Size(417, 29);
            this.TxtPasswordLogin.TabIndex = 14;
            // 
            // TxtUsernameLogin
            // 
            this.TxtUsernameLogin.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.TxtUsernameLogin.Location = new System.Drawing.Point(26, 60);
            this.TxtUsernameLogin.Margin = new System.Windows.Forms.Padding(4);
            this.TxtUsernameLogin.Name = "TxtUsernameLogin";
            this.TxtUsernameLogin.Size = new System.Drawing.Size(417, 29);
            this.TxtUsernameLogin.TabIndex = 12;
            // 
            // lblPasswordLogin
            // 
            this.lblPasswordLogin.AutoSize = true;
            this.lblPasswordLogin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordLogin.Location = new System.Drawing.Point(20, 110);
            this.lblPasswordLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPasswordLogin.Name = "lblPasswordLogin";
            this.lblPasswordLogin.Size = new System.Drawing.Size(88, 22);
            this.lblPasswordLogin.TabIndex = 13;
            this.lblPasswordLogin.Text = "Password";
            // 
            // lblUsernameLogin
            // 
            this.lblUsernameLogin.AutoSize = true;
            this.lblUsernameLogin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameLogin.Location = new System.Drawing.Point(20, 35);
            this.lblUsernameLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsernameLogin.Name = "lblUsernameLogin";
            this.lblUsernameLogin.Size = new System.Drawing.Size(88, 22);
            this.lblUsernameLogin.TabIndex = 11;
            this.lblUsernameLogin.Text = "Username";
            // 
            // StartUpTab
            // 
            this.StartUpTab.Controls.Add(this.TabLogin);
            this.StartUpTab.Controls.Add(this.TabRegister);
            this.StartUpTab.Depth = 0;
            this.StartUpTab.Location = new System.Drawing.Point(32, 244);
            this.StartUpTab.MouseState = MaterialSkin.MouseState.HOVER;
            this.StartUpTab.Name = "StartUpTab";
            this.StartUpTab.SelectedIndex = 0;
            this.StartUpTab.Size = new System.Drawing.Size(480, 603);
            this.StartUpTab.TabIndex = 1;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.StartUpTab;
            this.materialTabSelector1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 183);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(550, 69);
            this.materialTabSelector1.TabIndex = 2;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(547, 753);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.StartUpTab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(547, 753);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(547, 753);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TabRegister.ResumeLayout(false);
            this.TabRegister.PerformLayout();
            this.TabLogin.ResumeLayout(false);
            this.TabLogin.PerformLayout();
            this.StartUpTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialTabControl StartUpTab;
        private System.Windows.Forms.TabPage TabLogin;
        private MaterialSkin.Controls.MaterialFlatButton btnLogin;
        private System.Windows.Forms.TextBox TxtPasswordLogin;
        private System.Windows.Forms.TextBox TxtUsernameLogin;
        private System.Windows.Forms.Label lblPasswordLogin;
        private System.Windows.Forms.Label lblUsernameLogin;
        private System.Windows.Forms.TabPage TabRegister;
        private MaterialSkin.Controls.MaterialFlatButton btnRegister;
        private System.Windows.Forms.TextBox TxtConfirmPassword;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.TextBox TxtLastName;
        private System.Windows.Forms.TextBox TxtFirstName;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
    }
}


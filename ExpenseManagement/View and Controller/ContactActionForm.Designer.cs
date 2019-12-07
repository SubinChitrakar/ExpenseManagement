namespace ExpenseManagement.View_and_Controller
{
    partial class ContactActionForm
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
            this.TxtContactName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.BtnContactAction = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.LblHeading);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 114);
            this.panel1.TabIndex = 0;
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
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // lblHeading
            // 
            this.LblHeading.AutoSize = true;
            this.LblHeading.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHeading.ForeColor = System.Drawing.Color.White;
            this.LblHeading.Location = new System.Drawing.Point(73, 42);
            this.LblHeading.Name = "lblHeading";
            this.LblHeading.Size = new System.Drawing.Size(142, 37);
            this.LblHeading.TabIndex = 4;
            this.LblHeading.Text = "Contacts";
            // 
            // txtContactName
            // 
            this.TxtContactName.Depth = 0;
            this.TxtContactName.Hint = "";
            this.TxtContactName.Location = new System.Drawing.Point(21, 188);
            this.TxtContactName.MaxLength = 32767;
            this.TxtContactName.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtContactName.Name = "txtContactName";
            this.TxtContactName.PasswordChar = '\0';
            this.TxtContactName.SelectedText = "";
            this.TxtContactName.SelectionLength = 0;
            this.TxtContactName.SelectionStart = 0;
            this.TxtContactName.Size = new System.Drawing.Size(373, 28);
            this.TxtContactName.TabIndex = 1;
            this.TxtContactName.TabStop = false;
            this.TxtContactName.Text = "Contact Name";
            this.TxtContactName.UseSystemPasswordChar = false;
            // 
            // btnContactAction
            // 
            this.BtnContactAction.AutoSize = true;
            this.BtnContactAction.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnContactAction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnContactAction.Depth = 0;
            this.BtnContactAction.Icon = null;
            this.BtnContactAction.Location = new System.Drawing.Point(332, 181);
            this.BtnContactAction.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnContactAction.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnContactAction.Name = "btnContactAction";
            this.BtnContactAction.Primary = false;
            this.BtnContactAction.Size = new System.Drawing.Size(84, 36);
            this.BtnContactAction.TabIndex = 2;
            this.BtnContactAction.Text = "Action";
            this.BtnContactAction.UseVisualStyleBackColor = true;
            this.BtnContactAction.Click += new System.EventHandler(this.BtnContactAction_Click);
            // 
            // ContactActionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.BtnContactAction);
            this.Controls.Add(this.TxtContactName);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(500, 300);
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "ContactActionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContactActionForm";
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
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtContactName;
        private MaterialSkin.Controls.MaterialFlatButton BtnContactAction;
    }
}
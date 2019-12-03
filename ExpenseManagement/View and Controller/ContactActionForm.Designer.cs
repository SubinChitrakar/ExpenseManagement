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
            this.lblHeading = new System.Windows.Forms.Label();
            this.txtContactName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnContactAction = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.lblHeading);
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
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.White;
            this.lblHeading.Location = new System.Drawing.Point(73, 42);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(142, 37);
            this.lblHeading.TabIndex = 4;
            this.lblHeading.Text = "Contacts";
            // 
            // txtContactName
            // 
            this.txtContactName.Depth = 0;
            this.txtContactName.Hint = "";
            this.txtContactName.Location = new System.Drawing.Point(21, 188);
            this.txtContactName.MaxLength = 32767;
            this.txtContactName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtContactName.Name = "txtContactName";
            this.txtContactName.PasswordChar = '\0';
            this.txtContactName.SelectedText = "";
            this.txtContactName.SelectionLength = 0;
            this.txtContactName.SelectionStart = 0;
            this.txtContactName.Size = new System.Drawing.Size(373, 28);
            this.txtContactName.TabIndex = 1;
            this.txtContactName.TabStop = false;
            this.txtContactName.Text = "Contact Name";
            this.txtContactName.UseSystemPasswordChar = false;
            // 
            // btnContactAction
            // 
            this.btnContactAction.AutoSize = true;
            this.btnContactAction.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnContactAction.Depth = 0;
            this.btnContactAction.Icon = null;
            this.btnContactAction.Location = new System.Drawing.Point(332, 181);
            this.btnContactAction.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnContactAction.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnContactAction.Name = "btnContactAction";
            this.btnContactAction.Primary = false;
            this.btnContactAction.Size = new System.Drawing.Size(139, 36);
            this.btnContactAction.TabIndex = 2;
            this.btnContactAction.Text = "Add Contact";
            this.btnContactAction.UseVisualStyleBackColor = true;
            this.btnContactAction.Click += new System.EventHandler(this.btnContactAction_Click);
            // 
            // ContactActionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.btnContactAction);
            this.Controls.Add(this.txtContactName);
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
        private System.Windows.Forms.Label lblHeading;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtContactName;
        private MaterialSkin.Controls.MaterialFlatButton btnContactAction;
    }
}
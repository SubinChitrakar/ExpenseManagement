namespace ExpenseManagement.View_and_Controller
{
    partial class ContactListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactListForm));
            this.headingPanel = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.lblHeading = new System.Windows.Forms.Label();
            this.LblUserName = new System.Windows.Forms.Label();
            this.btnAddContact = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnEditContact = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnDeleteContact = new MaterialSkin.Controls.MaterialFlatButton();
            this.ContactsListView = new MaterialSkin.Controls.MaterialListView();
            this.clmHeadContactName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // headingPanel
            // 
            this.headingPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.headingPanel.Controls.Add(this.btnBack);
            this.headingPanel.Controls.Add(this.lblHeading);
            this.headingPanel.Controls.Add(this.LblUserName);
            this.headingPanel.Location = new System.Drawing.Point(0, 30);
            this.headingPanel.Name = "headingPanel";
            this.headingPanel.Size = new System.Drawing.Size(687, 94);
            this.headingPanel.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Image = global::ExpenseManagement.Properties.Resources.Back;
            this.btnBack.Location = new System.Drawing.Point(12, 21);
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
            this.lblHeading.Location = new System.Drawing.Point(57, 28);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(142, 37);
            this.lblHeading.TabIndex = 2;
            this.lblHeading.Text = "Contacts";
            // 
            // LblUserName
            // 
            this.LblUserName.AutoSize = true;
            this.LblUserName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserName.ForeColor = System.Drawing.Color.Transparent;
            this.LblUserName.Location = new System.Drawing.Point(571, 38);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(108, 27);
            this.LblUserName.TabIndex = 1;
            this.LblUserName.Text = "Username";
            this.LblUserName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnAddContact
            // 
            this.btnAddContact.AutoSize = true;
            this.btnAddContact.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddContact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddContact.Depth = 0;
            this.btnAddContact.Icon = null;
            this.btnAddContact.Location = new System.Drawing.Point(514, 154);
            this.btnAddContact.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddContact.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddContact.Name = "btnAddContact";
            this.btnAddContact.Primary = false;
            this.btnAddContact.Size = new System.Drawing.Size(139, 36);
            this.btnAddContact.TabIndex = 3;
            this.btnAddContact.Text = "Add Contact";
            this.btnAddContact.UseVisualStyleBackColor = true;
            this.btnAddContact.Click += new System.EventHandler(this.BtnAddContact_Click);
            // 
            // btnEditContact
            // 
            this.btnEditContact.AutoSize = true;
            this.btnEditContact.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditContact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditContact.Depth = 0;
            this.btnEditContact.Icon = null;
            this.btnEditContact.Location = new System.Drawing.Point(514, 202);
            this.btnEditContact.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEditContact.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditContact.Name = "btnEditContact";
            this.btnEditContact.Primary = false;
            this.btnEditContact.Size = new System.Drawing.Size(141, 36);
            this.btnEditContact.TabIndex = 4;
            this.btnEditContact.Text = "Edit Contact";
            this.btnEditContact.UseVisualStyleBackColor = true;
            this.btnEditContact.Click += new System.EventHandler(this.BtnEditContact_Click);
            // 
            // btnDeleteContact
            // 
            this.btnDeleteContact.AutoSize = true;
            this.btnDeleteContact.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteContact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteContact.Depth = 0;
            this.btnDeleteContact.Icon = null;
            this.btnDeleteContact.Location = new System.Drawing.Point(514, 250);
            this.btnDeleteContact.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeleteContact.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteContact.Name = "btnDeleteContact";
            this.btnDeleteContact.Primary = false;
            this.btnDeleteContact.Size = new System.Drawing.Size(165, 36);
            this.btnDeleteContact.TabIndex = 5;
            this.btnDeleteContact.Text = "Delete Contact";
            this.btnDeleteContact.UseVisualStyleBackColor = true;
            this.btnDeleteContact.Click += new System.EventHandler(this.BtnDeleteContact_Click);
            // 
            // ContactsListView
            // 
            this.ContactsListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ContactsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmHeadContactName});
            this.ContactsListView.Depth = 0;
            this.ContactsListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.ContactsListView.FullRowSelect = true;
            this.ContactsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ContactsListView.HoverSelection = true;
            this.ContactsListView.Location = new System.Drawing.Point(51, 154);
            this.ContactsListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ContactsListView.MouseState = MaterialSkin.MouseState.OUT;
            this.ContactsListView.MultiSelect = false;
            this.ContactsListView.Name = "ContactsListView";
            this.ContactsListView.OwnerDraw = true;
            this.ContactsListView.Size = new System.Drawing.Size(431, 506);
            this.ContactsListView.TabIndex = 6;
            this.ContactsListView.UseCompatibleStateImageBehavior = false;
            this.ContactsListView.View = System.Windows.Forms.View.Details;
            // 
            // clmHeadContactName
            // 
            this.clmHeadContactName.Text = "Contact Name";
            this.clmHeadContactName.Width = 420;
            // 
            // ContactListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(684, 706);
            this.Controls.Add(this.ContactsListView);
            this.Controls.Add(this.btnDeleteContact);
            this.Controls.Add(this.btnEditContact);
            this.Controls.Add(this.btnAddContact);
            this.Controls.Add(this.headingPanel);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(684, 706);
            this.MinimumSize = new System.Drawing.Size(684, 706);
            this.Name = "ContactListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContactsForm";
            this.Activated += new System.EventHandler(this.ContactsForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ContactsForm_FormClosed);
            this.headingPanel.ResumeLayout(false);
            this.headingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel headingPanel;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label LblUserName;
        private System.Windows.Forms.PictureBox btnBack;
        private MaterialSkin.Controls.MaterialFlatButton btnAddContact;
        private MaterialSkin.Controls.MaterialFlatButton btnEditContact;
        private MaterialSkin.Controls.MaterialFlatButton btnDeleteContact;
        private MaterialSkin.Controls.MaterialListView ContactsListView;
        private System.Windows.Forms.ColumnHeader clmHeadContactName;
    }
}
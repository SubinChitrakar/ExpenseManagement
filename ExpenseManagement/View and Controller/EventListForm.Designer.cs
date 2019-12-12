namespace ExpenseManagement.View_and_Controller
{
    partial class EventListForm
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
            this.EventListView = new MaterialSkin.Controls.MaterialListView();
            this.clmHeadName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmHeadType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmHeadEventDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headingPanel = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.lblHeading = new System.Windows.Forms.Label();
            this.LblUserName = new System.Windows.Forms.Label();
            this.BtnViewEvent = new MaterialSkin.Controls.MaterialFlatButton();
            this.BtnAddEvent = new MaterialSkin.Controls.MaterialFlatButton();
            this.headingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // EventListView
            // 
            this.EventListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EventListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmHeadName,
            this.clmHeadType,
            this.clmHeadEventDate});
            this.EventListView.Depth = 0;
            this.EventListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.EventListView.FullRowSelect = true;
            this.EventListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.EventListView.HoverSelection = true;
            this.EventListView.Location = new System.Drawing.Point(15, 163);
            this.EventListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.EventListView.MouseState = MaterialSkin.MouseState.OUT;
            this.EventListView.Name = "EventListView";
            this.EventListView.OwnerDraw = true;
            this.EventListView.Size = new System.Drawing.Size(688, 677);
            this.EventListView.TabIndex = 4;
            this.EventListView.UseCompatibleStateImageBehavior = false;
            this.EventListView.View = System.Windows.Forms.View.Details;
            // 
            // clmHeadName
            // 
            this.clmHeadName.Text = "Name";
            this.clmHeadName.Width = 150;
            // 
            // clmHeadType
            // 
            this.clmHeadType.Text = "Type";
            this.clmHeadType.Width = 150;
            // 
            // clmHeadEventDate
            // 
            this.clmHeadEventDate.Text = "Date";
            this.clmHeadEventDate.Width = 200;
            // 
            // headingPanel
            // 
            this.headingPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headingPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.headingPanel.Controls.Add(this.btnBack);
            this.headingPanel.Controls.Add(this.lblHeading);
            this.headingPanel.Controls.Add(this.LblUserName);
            this.headingPanel.Location = new System.Drawing.Point(0, 34);
            this.headingPanel.Name = "headingPanel";
            this.headingPanel.Size = new System.Drawing.Size(1010, 94);
            this.headingPanel.TabIndex = 7;
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Image = global::ExpenseManagement.Properties.Resources.Back;
            this.btnBack.Location = new System.Drawing.Point(12, 25);
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
            this.lblHeading.Location = new System.Drawing.Point(57, 32);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(113, 37);
            this.lblHeading.TabIndex = 2;
            this.lblHeading.Text = "Events";
            // 
            // LblUserName
            // 
            this.LblUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblUserName.AutoSize = true;
            this.LblUserName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserName.ForeColor = System.Drawing.Color.Transparent;
            this.LblUserName.Location = new System.Drawing.Point(899, 42);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(108, 27);
            this.LblUserName.TabIndex = 1;
            this.LblUserName.Text = "Username";
            this.LblUserName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // BtnViewEvent
            // 
            this.BtnViewEvent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnViewEvent.AutoSize = true;
            this.BtnViewEvent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnViewEvent.Depth = 0;
            this.BtnViewEvent.Icon = null;
            this.BtnViewEvent.Location = new System.Drawing.Point(828, 234);
            this.BtnViewEvent.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnViewEvent.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnViewEvent.Name = "BtnViewEvent";
            this.BtnViewEvent.Primary = false;
            this.BtnViewEvent.Size = new System.Drawing.Size(192, 36);
            this.BtnViewEvent.TabIndex = 6;
            this.BtnViewEvent.Text = "View Event Details";
            this.BtnViewEvent.UseVisualStyleBackColor = true;
            this.BtnViewEvent.Click += new System.EventHandler(this.BtnViewEvent_Click);
            // 
            // BtnAddEvent
            // 
            this.BtnAddEvent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddEvent.AutoSize = true;
            this.BtnAddEvent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnAddEvent.Depth = 0;
            this.BtnAddEvent.Icon = null;
            this.BtnAddEvent.Location = new System.Drawing.Point(828, 163);
            this.BtnAddEvent.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnAddEvent.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnAddEvent.Name = "BtnAddEvent";
            this.BtnAddEvent.Primary = false;
            this.BtnAddEvent.Size = new System.Drawing.Size(155, 36);
            this.BtnAddEvent.TabIndex = 5;
            this.BtnAddEvent.Text = "Add New Event";
            this.BtnAddEvent.UseVisualStyleBackColor = true;
            this.BtnAddEvent.Click += new System.EventHandler(this.BtnAddEvent_Click);
            // 
            // EventListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 874);
            this.Controls.Add(this.EventListView);
            this.Controls.Add(this.headingPanel);
            this.Controls.Add(this.BtnViewEvent);
            this.Controls.Add(this.BtnAddEvent);
            this.Name = "EventListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EventListForm";
            this.Activated += new System.EventHandler(this.EventListForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EventListForm_FormClosed);
            this.headingPanel.ResumeLayout(false);
            this.headingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView EventListView;
        private System.Windows.Forms.ColumnHeader clmHeadName;
        private System.Windows.Forms.ColumnHeader clmHeadType;
        private System.Windows.Forms.ColumnHeader clmHeadEventDate;
        private System.Windows.Forms.Panel headingPanel;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label LblUserName;
        private MaterialSkin.Controls.MaterialFlatButton BtnViewEvent;
        private MaterialSkin.Controls.MaterialFlatButton BtnAddEvent;
    }
}
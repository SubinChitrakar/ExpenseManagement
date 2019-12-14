namespace ExpenseManagement.View_and_Controller
{
    partial class TransactionListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionListForm));
            this.TransactionListView = new MaterialSkin.Controls.MaterialListView();
            this.clmHeadName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmHeadType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmHeadAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmHeadTransactionDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnAddTransaction = new MaterialSkin.Controls.MaterialFlatButton();
            this.BtnViewTransaction = new MaterialSkin.Controls.MaterialFlatButton();
            this.headingPanel = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.lblHeading = new System.Windows.Forms.Label();
            this.LblUserName = new System.Windows.Forms.Label();
            this.headingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // TransactionListView
            // 
            this.TransactionListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TransactionListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TransactionListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmHeadName,
            this.clmHeadType,
            this.clmHeadAmount,
            this.clmHeadTransactionDate});
            this.TransactionListView.Depth = 0;
            this.TransactionListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.TransactionListView.FullRowSelect = true;
            this.TransactionListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.TransactionListView.HideSelection = false;
            this.TransactionListView.HoverSelection = true;
            this.TransactionListView.Location = new System.Drawing.Point(26, 163);
            this.TransactionListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.TransactionListView.MouseState = MaterialSkin.MouseState.OUT;
            this.TransactionListView.Name = "TransactionListView";
            this.TransactionListView.OwnerDraw = true;
            this.TransactionListView.Size = new System.Drawing.Size(651, 677);
            this.TransactionListView.TabIndex = 0;
            this.TransactionListView.UseCompatibleStateImageBehavior = false;
            this.TransactionListView.View = System.Windows.Forms.View.Details;
            this.TransactionListView.SizeChanged += new System.EventHandler(this.TransactionListView_SizeChanged);
            // 
            // clmHeadName
            // 
            this.clmHeadName.Text = "Name";
            this.clmHeadName.Width = 80;
            // 
            // clmHeadType
            // 
            this.clmHeadType.Text = "Type";
            this.clmHeadType.Width = 100;
            // 
            // clmHeadAmount
            // 
            this.clmHeadAmount.Text = "Amount";
            this.clmHeadAmount.Width = 80;
            // 
            // clmHeadTransactionDate
            // 
            this.clmHeadTransactionDate.Text = "Date";
            this.clmHeadTransactionDate.Width = 200;
            // 
            // BtnAddTransaction
            // 
            this.BtnAddTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddTransaction.AutoSize = true;
            this.BtnAddTransaction.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnAddTransaction.Depth = 0;
            this.BtnAddTransaction.Icon = null;
            this.BtnAddTransaction.Location = new System.Drawing.Point(766, 163);
            this.BtnAddTransaction.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnAddTransaction.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnAddTransaction.Name = "BtnAddTransaction";
            this.BtnAddTransaction.Primary = false;
            this.BtnAddTransaction.Size = new System.Drawing.Size(218, 36);
            this.BtnAddTransaction.TabIndex = 1;
            this.BtnAddTransaction.Text = "Add New Transaction";
            this.BtnAddTransaction.UseVisualStyleBackColor = true;
            this.BtnAddTransaction.Click += new System.EventHandler(this.BtnAddTransaction_Click);
            // 
            // BtnViewTransaction
            // 
            this.BtnViewTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnViewTransaction.AutoSize = true;
            this.BtnViewTransaction.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnViewTransaction.Depth = 0;
            this.BtnViewTransaction.Icon = null;
            this.BtnViewTransaction.Location = new System.Drawing.Point(766, 233);
            this.BtnViewTransaction.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnViewTransaction.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnViewTransaction.Name = "BtnViewTransaction";
            this.BtnViewTransaction.Primary = false;
            this.BtnViewTransaction.Size = new System.Drawing.Size(256, 36);
            this.BtnViewTransaction.TabIndex = 2;
            this.BtnViewTransaction.Text = "View Transaction Details";
            this.BtnViewTransaction.UseVisualStyleBackColor = true;
            this.BtnViewTransaction.Click += new System.EventHandler(this.BtnViewTransaction_Click);
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
            this.headingPanel.Size = new System.Drawing.Size(1003, 94);
            this.headingPanel.TabIndex = 3;
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
            this.lblHeading.Size = new System.Drawing.Size(198, 37);
            this.lblHeading.TabIndex = 2;
            this.lblHeading.Text = "Transactions";
            // 
            // LblUserName
            // 
            this.LblUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblUserName.AutoSize = true;
            this.LblUserName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserName.ForeColor = System.Drawing.Color.Transparent;
            this.LblUserName.Location = new System.Drawing.Point(892, 42);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(108, 27);
            this.LblUserName.TabIndex = 1;
            this.LblUserName.Text = "Username";
            this.LblUserName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TransactionListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 874);
            this.Controls.Add(this.headingPanel);
            this.Controls.Add(this.BtnViewTransaction);
            this.Controls.Add(this.BtnAddTransaction);
            this.Controls.Add(this.TransactionListView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TransactionListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TransactionListForm";
            this.Activated += new System.EventHandler(this.TransactionListForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TransactionListForm_FormClosed);
            this.headingPanel.ResumeLayout(false);
            this.headingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView TransactionListView;
        private System.Windows.Forms.ColumnHeader clmHeadName;
        private System.Windows.Forms.ColumnHeader clmHeadType;
        private System.Windows.Forms.ColumnHeader clmHeadAmount;
        private System.Windows.Forms.ColumnHeader clmHeadTransactionDate;
        private MaterialSkin.Controls.MaterialFlatButton BtnAddTransaction;
        private MaterialSkin.Controls.MaterialFlatButton BtnViewTransaction;
        private System.Windows.Forms.Panel headingPanel;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label LblUserName;
    }
}
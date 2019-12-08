﻿namespace ExpenseManagement.View_and_Controller
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
            this.NormalTransactionListView = new MaterialSkin.Controls.MaterialListView();
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
            // NormalTransactionListView
            // 
            this.NormalTransactionListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NormalTransactionListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmHeadName,
            this.clmHeadType,
            this.clmHeadAmount,
            this.clmHeadTransactionDate});
            this.NormalTransactionListView.Depth = 0;
            this.NormalTransactionListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.NormalTransactionListView.FullRowSelect = true;
            this.NormalTransactionListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.NormalTransactionListView.HoverSelection = true;
            this.NormalTransactionListView.Location = new System.Drawing.Point(26, 163);
            this.NormalTransactionListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.NormalTransactionListView.MouseState = MaterialSkin.MouseState.OUT;
            this.NormalTransactionListView.Name = "NormalTransactionListView";
            this.NormalTransactionListView.OwnerDraw = true;
            this.NormalTransactionListView.Size = new System.Drawing.Size(688, 677);
            this.NormalTransactionListView.TabIndex = 0;
            this.NormalTransactionListView.UseCompatibleStateImageBehavior = false;
            this.NormalTransactionListView.View = System.Windows.Forms.View.Details;
            // 
            // clmHeadName
            // 
            this.clmHeadName.Text = "Name";
            this.clmHeadName.Width = 100;
            // 
            // clmHeadType
            // 
            this.clmHeadType.Text = "Type";
            this.clmHeadType.Width = 100;
            // 
            // clmHeadAmount
            // 
            this.clmHeadAmount.Text = "Amount";
            this.clmHeadAmount.Width = 100;
            // 
            // clmHeadTransactionDate
            // 
            this.clmHeadTransactionDate.Text = "Date";
            this.clmHeadTransactionDate.Width = 150;
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
            this.Controls.Add(this.NormalTransactionListView);
            this.Name = "TransactionListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NormalTransactionListForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TransactionListForm_FormClosed);
            this.Load += new System.EventHandler(this.NormalTransactionListForm_Load);
            this.headingPanel.ResumeLayout(false);
            this.headingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView NormalTransactionListView;
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
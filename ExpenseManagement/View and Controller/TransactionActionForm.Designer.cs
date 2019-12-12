namespace ExpenseManagement.View_and_Controller
{
    partial class TransactionActionForm
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
            this.headingPanel = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.lblHeading = new System.Windows.Forms.Label();
            this.LblUserName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NumUpDownNoOfTransaction = new System.Windows.Forms.NumericUpDown();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.headingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownNoOfTransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // headingPanel
            // 
            this.headingPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headingPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.headingPanel.Controls.Add(this.btnBack);
            this.headingPanel.Controls.Add(this.lblHeading);
            this.headingPanel.Controls.Add(this.LblUserName);
            this.headingPanel.Location = new System.Drawing.Point(-1, 34);
            this.headingPanel.Name = "headingPanel";
            this.headingPanel.Size = new System.Drawing.Size(1004, 94);
            this.headingPanel.TabIndex = 4;
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
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(30, 240);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(941, 610);
            this.panel1.TabIndex = 5;
            // 
            // NumUpDownNoOfTransaction
            // 
            this.NumUpDownNoOfTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NumUpDownNoOfTransaction.Location = new System.Drawing.Point(595, 181);
            this.NumUpDownNoOfTransaction.Name = "NumUpDownNoOfTransaction";
            this.NumUpDownNoOfTransaction.Size = new System.Drawing.Size(115, 22);
            this.NumUpDownNoOfTransaction.TabIndex = 6;
            this.NumUpDownNoOfTransaction.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(781, 173);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(207, 36);
            this.materialFlatButton1.TabIndex = 7;
            this.materialFlatButton1.Text = "Create Transaction";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            // 
            // TransactionActionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 874);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.NumUpDownNoOfTransaction);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.headingPanel);
            this.Name = "TransactionActionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NormalTransactionActionForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TransactionActionForm_FormClosing);
            this.headingPanel.ResumeLayout(false);
            this.headingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownNoOfTransaction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel headingPanel;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label LblUserName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown NumUpDownNoOfTransaction;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
    }
}
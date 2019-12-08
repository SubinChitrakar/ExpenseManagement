using ExpenseManagement.Model;
using ExpenseManagement.Repository;
using ExpenseManagement.Utilities;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseManagement.View_and_Controller
{
    public partial class TransactionActionForm : MaterialForm
    {
        private readonly MaterialSkinManager _materialSkinManager;

        public TransactionActionForm()
        {
            InitializeComponent();
            _materialSkinManager = DesignSettings.GetDesign();
            _materialSkinManager.AddFormToManage(this);

            LblUserName.Text = UserSession.UserData.UserName;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void TransactionActionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            UserSession.ParentForm.Dispose();
        }
    }
}

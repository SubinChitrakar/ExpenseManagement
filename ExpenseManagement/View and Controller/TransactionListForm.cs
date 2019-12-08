using ExpenseManagement.Model;
using ExpenseManagement.Repository;
using ExpenseManagement.Utilities;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseManagement.View_and_Controller
{
    public partial class TransactionListForm : MaterialForm
    {
        private readonly MaterialSkinManager _materialSkinManager;
        private NormalTransactionRepository _normalTransactionRepository;
        private MessageStatus _messageStatus;

        public TransactionListForm()
        {
            InitializeComponent();
            _materialSkinManager = DesignSettings.GetDesign();
            _materialSkinManager.AddFormToManage(this);

            UserSession.ParentForm.Hide();
            _normalTransactionRepository = new NormalTransactionRepository();
            _messageStatus = new MessageStatus();
        }
        
        private async void NormalTransactionListForm_Load(object sender, EventArgs e)
        {
            LblUserName.Text = UserSession.UserData.UserName;

            List<NormalTransaction> listOfNormalTransaction = await Task.Run(() => _normalTransactionRepository.GetTransactions(UserSession.UserData.Id));
            NormalTransactionListView.Items.Clear();
            foreach (NormalTransaction normalTransaction in listOfNormalTransaction)
            {
                ListViewItem listView = new ListViewItem(new string[] {normalTransaction.Name, normalTransaction.Type, normalTransaction.Amount.ToString(), normalTransaction.TransactionDate.ToString()})
                {
                    Tag = normalTransaction
                };
                NormalTransactionListView.Items.Add(listView);
            }
        }

        private void TransactionListForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            UserSession.ParentForm.Dispose();
        }

        private void BtnAddTransaction_Click(object sender, EventArgs e)
        {
            TransactionActionForm transactionActionForm = new TransactionActionForm();
            transactionActionForm.Activate();
            transactionActionForm.Show();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            UserSession.ParentForm.Show();
        }
    }
}

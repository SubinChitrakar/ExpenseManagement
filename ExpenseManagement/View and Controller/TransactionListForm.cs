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
        private MessageStatus _messageStatus;

        private bool _recurringTransactionStatus;

        public TransactionListForm(bool recurringTransactionStatus)
        {
            InitializeComponent();
            _materialSkinManager = DesignSettings.GetDesign();
            _materialSkinManager.AddFormToManage(this);

            UserSession.ParentForm.Hide();
            _messageStatus = new MessageStatus();

            _recurringTransactionStatus = recurringTransactionStatus;
            TransactionListView.HideSelection = true;
        }
        
        private void TransactionListForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            UserSession.ParentForm.Dispose();
        }

        private void TransactionListForm_Activated(object sender, EventArgs e)
        {
            LblUserName.Text = UserSession.UserData.UserName;
            if (_recurringTransactionStatus)
            {
                _getRecurringTransactions();
            }
            else
            {
                _getNormalTransactions();
            }

        }

        private async void _getNormalTransactions()
        {
            lblHeading.Text = "Normal Transaction";
            NormalTransactionRepository normalTransactionRepository = new NormalTransactionRepository();
            List<Transaction> listOfNormalTransaction = await Task.Run(() => normalTransactionRepository.GetTransactions(UserSession.UserData.Id));
            TransactionListView.Items.Clear();
            foreach (Transaction normalTransaction in listOfNormalTransaction)
            {
                ListViewItem listView = new ListViewItem(new string[] { normalTransaction.Name, normalTransaction.Type, normalTransaction.Amount.ToString("£0.00"), normalTransaction.TransactionDate.ToString() })
                {
                    Tag = normalTransaction
                };
                TransactionListView.Items.Add(listView);
            }
        }

        private async void _getRecurringTransactions()
        {
            RecurringTransactionRepository recurringTransactionRepository = new RecurringTransactionRepository();
            List<RecurringTransaction> listOfRecurringTransaction = await Task.Run(() => recurringTransactionRepository.GetTransactions(UserSession.UserData.Id));
            TransactionListView.Items.Clear();
            foreach (RecurringTransaction recurringTransaction in listOfRecurringTransaction)
            {
                ListViewItem listView = new ListViewItem(new string[] { recurringTransaction.Name, recurringTransaction.Type, recurringTransaction.Amount.ToString("£0.00"), recurringTransaction.TransactionDate.ToString() })
                {
                    Tag = recurringTransaction
                };
                TransactionListView.Items.Add(listView);
            }
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

        private void BtnViewTransaction_Click(object sender, EventArgs e)
        {
            if (TransactionListView.SelectedItems.Count > 0)
            {
                Transaction transaction = (Transaction)TransactionListView.SelectedItems[0].Tag;
                TransactionActionForm eventActionForm = new TransactionActionForm(transaction);
                eventActionForm.Activate();
                eventActionForm.Show();
            }
            else
            {
                MessageBox.Show("Select a TRANSACTION", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TransactionListView_SizeChanged(object sender, EventArgs e)
        {
            int totalWidth = TransactionListView.Width - 20;
            int noOfColumn = TransactionListView.Columns.Count;
            int sizeOfAColumn = totalWidth / noOfColumn - 20;
            int lastColumn = totalWidth - (sizeOfAColumn * (noOfColumn - 1));
            for (int i = 0; i < noOfColumn; i++)
            {
                if (i == noOfColumn - 1)
                {
                    TransactionListView.Columns[i].Width = lastColumn;
                }
                else
                {
                    TransactionListView.Columns[i].Width = sizeOfAColumn;
                }
            }
        }
    }
}

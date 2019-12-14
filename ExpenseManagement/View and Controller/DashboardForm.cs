using ExpenseManagement.Model;
using ExpenseManagement.Repository;
using ExpenseManagement.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace ExpenseManagement.View_and_Controller
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {

            InitializeComponent();
            UserSession.ParentForm = this;
        }

        private void Dashboard_Activated(object sender, EventArgs e)
        {
            UserSession.UserData = new User
            {
                Id = 1,
                FirstName = "Subin",
                LastName = "Chitrakar",
                UserName = "Subin",
                Password = "QtklAYAHoSY="
            }; 

            if (UserSession.UserData == null)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Activate();
                loginForm.Show();
            }

            if (!RecurringBackground.IsBusy) RecurringBackground.RunWorkerAsync();
        }

        private void _backgroundActivityForRecurring(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker backgroundWorker  = (BackgroundWorker)sender;
            while (!backgroundWorker.CancellationPending)
            {
                _checkRecurringTransaction();
                UserSession.UserData.LastAccessDate = DateTime.Now;
            }
        }

        public void _checkRecurringTransaction()
        {
            NormalTransactionRepository normalTransactionRepository = new NormalTransactionRepository();
            RecurringTransactionRepository recurringTransactionRepository = new RecurringTransactionRepository();

            List<RecurringTransaction> recurringTransactionList = recurringTransactionRepository.GetTransactions(UserSession.UserData.Id);

            foreach(RecurringTransaction recurringTransaction in recurringTransactionList)
            {

            }

        }


        private void BtnContact_Click(object sender, EventArgs e)
        {
            ContactListForm contactListForm = new ContactListForm();
            contactListForm.Activate();
            contactListForm.Show();
        }

        private void BtnTransaction_Click(object sender, EventArgs e)
        {
            TransactionListForm transactionListForm = new TransactionListForm(false);
            transactionListForm.Activate();
            transactionListForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EventListForm eventListForm = new EventListForm(false);
            eventListForm.Activate();
            eventListForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EventListForm eventListForm = new EventListForm(true);
            eventListForm.Activate();
            eventListForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TransactionListForm transactionListForm = new TransactionListForm(true);
            transactionListForm.Activate();
            transactionListForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FinancialReport financialReport = new FinancialReport();
            financialReport.Activate();
            financialReport.Show();
        }
    }
}

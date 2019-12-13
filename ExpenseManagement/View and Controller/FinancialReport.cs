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
    public partial class FinancialReport : MaterialForm
    {
        private readonly MaterialSkinManager _materialSkinManager;
        private NormalTransactionRepository normalTransactionRepository;

        public FinancialReport()
        {
            InitializeComponent();
            _materialSkinManager = DesignSettings.GetDesign();
            _materialSkinManager.AddFormToManage(this);

            UserSession.ParentForm.Hide();
            LblUserName.Text = UserSession.UserData.UserName;
            normalTransactionRepository = new NormalTransactionRepository();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            UserSession.ParentForm.Show();
        }

        private void FinancialReport_FormClosed(object sender, FormClosedEventArgs e)
        {
            UserSession.ParentForm.Dispose();
        }

        private void FinancialReport_Load(object sender, EventArgs e)
        {
            _loadTodaysReport();
        }

        private void ReportTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ReportTabs.SelectedIndex == 0)
            {
                _loadTodaysReport();
            }
            else if(ReportTabs.SelectedIndex == 1)
            {
                _loadWeeksReport();
            }
        }

        private async void _loadTodaysReport()
        {
            ListViewToday.Clear();
            List<Transaction> transactionList = await Task.Run(() => normalTransactionRepository.GetTodaysTransaction(UserSession.UserData.Id));
            ListViewToday.HideSelection = true;
            double income = 0;
            double expense = 0;
            ListViewToday.Columns.Add("Date", 200);
            ListViewToday.Columns.Add("Name", 137);
            ListViewToday.Columns.Add("Contact", 137);
            ListViewToday.Columns.Add("Credit", 100);
            ListViewToday.Columns.Add("Debit", 100);

            foreach (Transaction transaction in transactionList)
            {
                ListViewItem todaysTransaction = new ListViewItem(new string[]
                {
                            transaction.TransactionDate.ToString(),
                            transaction.Name,
                            transaction.ContactName,
                });

                if(transaction.Type == "Income")
                {
                    todaysTransaction.SubItems.Add("£" + transaction.Amount);
                    income += transaction.Amount;
                    todaysTransaction.SubItems.Add("");
                }
                else
                {
                    todaysTransaction.SubItems.Add("");
                    todaysTransaction.SubItems.Add("£" + transaction.Amount);
                    expense += transaction.Amount;
                }

                ListViewToday.Items.Add(todaysTransaction);
            }
            ListViewItem total = new ListViewItem(new string[]
                {
                            "",
                            "",
                            "Total",
                            "£" +income,
                            "£" +expense
                });
            ListViewToday.Items.Add(total);
        }

        private async void _loadWeeksReport()
        {
            DateTime startDate = DateTime.Now.AddDays(-7);

            List<Transaction> transactionList = await Task.Run(() => normalTransactionRepository.GetTransactionsFromDates(UserSession.UserData.Id, startDate, DateTime.Now));
            
            if(transactionList.Count > 0)
            {
                List<ReportDetails> detailsOfThisWeek = _generateDetails(transactionList);

            }
            else
            {
                MessageBox.Show("THERE WERE NO TRANSACTIONS THIS WEEK", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private List<ReportDetails> _generateDetails(List<Transaction> transactionList)
        {
            List<ReportDetails> detailsOfThisWeek = new List<ReportDetails>();
            ReportDetails reportDetail = new ReportDetails
            {
                Date = transactionList[0].TransactionDate,
                Amount = transactionList[0].Amount
            };
            detailsOfThisWeek.Add(reportDetail);

            for (int i = 0; i < transactionList.Count - 1; i++)
            {
                if (transactionList[i].TransactionDate.ToShortDateString().Equals(transactionList[i + 1].TransactionDate.ToShortDateString()))
                {
                    reportDetail.Amount += transactionList[i + 1].Amount;
                }
                else
                {
                    reportDetail = new ReportDetails
                    {
                        Date = transactionList[i + 1].TransactionDate,
                        Amount = transactionList[i + 1].Amount
                    };

                    detailsOfThisWeek.Add(reportDetail);
                }
            }
            return detailsOfThisWeek;
        }
    }
}

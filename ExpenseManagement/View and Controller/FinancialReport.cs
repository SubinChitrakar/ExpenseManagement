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
using System.Windows.Forms.DataVisualization.Charting;

namespace ExpenseManagement.View_and_Controller
{
    public partial class FinancialReport : MaterialForm
    {
        private readonly MaterialSkinManager _materialSkinManager;
        private NormalTransactionRepository normalTransactionRepository;
        List<Transaction> _transactionList;

        public FinancialReport()
        {
            InitializeComponent();
            _materialSkinManager = DesignSettings.GetDesign();
            _materialSkinManager.AddFormToManage(this);

            UserSession.ParentForm.Hide();
            LblUserName.Text = UserSession.UserData.UserName;
            normalTransactionRepository = new NormalTransactionRepository();

            _transactionList = new List<Transaction>();

            DPickerStartDate.Value = DateTime.Now.AddDays(-1);
            DPickerEndDate.Value = DateTime.Now;
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
            if (ReportTabs.SelectedIndex == 0)
            {
                _loadTodaysReport();
            }
            else if (ReportTabs.SelectedIndex == 1)
            {
                _loadWeekReport();
            }
            else if (ReportTabs.SelectedIndex == 2)
            {
                _loadMonthReport();
            }
            else
            {
                ListViewSelectedDate.Clear();
            }
        }

        private async void _loadTodaysReport()
        {
            _transactionList = await Task.Run(() => normalTransactionRepository.GetTransactionFromDate(DateTime.Now, UserSession.UserData.Id));
            _loadData(ListViewToday, _transactionList);
        }

        private async void _loadWeekReport()
        {
            _transactionList = await Task.Run(() => normalTransactionRepository.GetTransactionsFromDates(UserSession.UserData.Id, DateTime.Now.AddDays(-7), DateTime.Now));
            if (_transactionList.Count > 0)
            {
                _loadData(ListViewWeekly, _transactionList);
            }
            else
            {
                MessageBox.Show("THERE WERE NO TRANSACTIONS THIS WEEK", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void _loadMonthReport()
        {
            _transactionList = await Task.Run(() => normalTransactionRepository.GetTransactionsFromDates(UserSession.UserData.Id, DateTime.Now.AddDays(-30), DateTime.Now));
            if (_transactionList.Count > 0)
            {
                _loadData(ListViewMonthly, _transactionList);
            }
            else
            {
                MessageBox.Show("THERE WERE NO TRANSACTIONS THIS WEEK", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void BtnGenerateReport_Click(object sender, EventArgs e)
        {
            if (DPickerEndDate.Value < DPickerStartDate.Value)
            {
                MessageBox.Show("START DATE cannot be greater than END DATE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _transactionList = await Task.Run(() => normalTransactionRepository.GetTransactionsFromDates(UserSession.UserData.Id, DPickerStartDate.Value, DPickerEndDate.Value));
            _loadData(ListViewSelectedDate, _transactionList);
        }

        public void _loadData(ListView listView, List<Transaction> transactionList)
        {
            listView.Clear();
            listView.HideSelection = true;
            double income = 0;
            double expense = 0;
            listView.Columns.Add("Date", 200);
            listView.Columns.Add("Name", 137);
            listView.Columns.Add("Contact", 137);
            listView.Columns.Add("Credit", 100);
            listView.Columns.Add("Debit", 100);

            foreach (Transaction transaction in transactionList)
            {
                ListViewItem listViewItem = new ListViewItem(new string[]
                {
                            transaction.TransactionDate.ToString(),
                            transaction.Name,
                            transaction.ContactName,
                });

                if (transaction.Type == "Income")
                {
                    listViewItem.SubItems.Add("£" + transaction.Amount);
                    income += transaction.Amount;
                    listViewItem.SubItems.Add("");
                }
                else
                {
                    listViewItem.SubItems.Add("");
                    listViewItem.SubItems.Add("£" + transaction.Amount);
                    expense += transaction.Amount;
                }

                listView.Items.Add(listViewItem);
            }
            ListViewItem total = new ListViewItem(new string[]
                {
                            "",
                            "",
                            "Total",
                            "£" +income,
                            "£" +expense
                });
            listView.Items.Add(total);
        }

        private void BtnShowWeekGraph_Click(object sender, EventArgs e)
        {
            GraphForm graphForm = new GraphForm(_generateDetails(_transactionList), 7);
            graphForm.Activate();
            graphForm.Show();
        }

        private void BtnShowMonthGraph_Click(object sender, EventArgs e)
        {
            GraphForm graphForm = new GraphForm(_generateDetails(_transactionList), 30);
            graphForm.Activate();
            graphForm.Show();
        }

        private List<ReportDetails> _generateDetails(List<Transaction> transactionList)
        {
            List<ReportDetails> detailsFromTransaction = new List<ReportDetails>();
            ReportDetails reportDetail = new ReportDetails
            {
                Date = transactionList[0].TransactionDate.Date,
                Amount = transactionList[0].Amount
            };
            detailsFromTransaction.Add(reportDetail);

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
                        Date = transactionList[i + 1].TransactionDate.Date,
                        Amount = transactionList[i + 1].Amount
                    };

                    detailsFromTransaction.Add(reportDetail);
                }
            }

            return detailsFromTransaction;
        }

        private void _changeSizeOfColumn(ListView listView)
        {
            if (listView.Columns.Count > 0)
            {
                int totalWidth = listView.Width - 20;
                int noOfColumn = listView.Columns.Count;
                int sizeOfAColumn = totalWidth / noOfColumn - 20;
                int first = totalWidth - (sizeOfAColumn * (noOfColumn - 1));
                for (int i = 0; i < noOfColumn; i++)
                {
                    if (i == 0)
                    {
                        listView.Columns[i].Width = first;
                    }
                    else
                    {
                        listView.Columns[i].Width = sizeOfAColumn;
                    }
                }
            }
        }

        private void ListViewToday_SizeChanged(object sender, EventArgs e)
        {
            _changeSizeOfColumn(ListViewToday);
        }

        private void ListViewWeekly_SizeChanged(object sender, EventArgs e)
        {
            _changeSizeOfColumn(ListViewWeekly);
        }

        private void ListViewMonthly_SizeChanged(object sender, EventArgs e)
        {
            _changeSizeOfColumn(ListViewMonthly);
        }

        private void ListViewSelectedDate_SizeChanged(object sender, EventArgs e)
        {
            _changeSizeOfColumn(ListViewSelectedDate);
        }
    }
}

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

        public FinancialReport()
        {
            InitializeComponent();
            _materialSkinManager = DesignSettings.GetDesign();
            _materialSkinManager.AddFormToManage(this);

            UserSession.ParentForm.Hide();
            LblUserName.Text = UserSession.UserData.UserName;
            normalTransactionRepository = new NormalTransactionRepository();

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
            if(ReportTabs.SelectedIndex == 0)
            {
                _loadTodaysReport();
            }
            else if(ReportTabs.SelectedIndex == 1)
            {
                _loadWeekReport();
            }
            else if (ReportTabs.SelectedIndex == 3)
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

        private async void _loadWeekReport()
        {
            List<Transaction> transactionList = await Task.Run(() => normalTransactionRepository.GetTransactionsFromDates(UserSession.UserData.Id, DateTime.Now.AddDays(-7), DateTime.Now));
            
            if(transactionList.Count > 0)
            {
                List<ReportDetails> detailsOfThisWeek = _generateDetails(transactionList);
                _generateGraph(WeeklyChart, detailsOfThisWeek, 7);
            }
            else
            {
                MessageBox.Show("THERE WERE NO TRANSACTIONS THIS WEEK", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void _loadMonthReport()
        {
            List<Transaction> transactionList = await Task.Run(() => normalTransactionRepository.GetTransactionsFromDates(UserSession.UserData.Id, DateTime.Now.AddDays(-30), DateTime.Now));
            if (transactionList.Count > 0)
            {
                List<ReportDetails> detailsOfThisMonth = _generateDetails(transactionList);
                _generateGraph(MonthlyChart, detailsOfThisMonth, 30);
            }
            else
            {
                MessageBox.Show("THERE WERE NO TRANSACTIONS THIS MONTH", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void _generateGraph(Chart chart, List<ReportDetails> reportDetailList, int numberOfDays)
        {
            chart.Series[0].XValueType = ChartValueType.DateTime;

            var chartDetails = chart.ChartAreas[0];
            chartDetails.AxisX.LabelStyle.Format = "MM/dd/yyyy";
            chartDetails.AxisX.Interval = (int)numberOfDays/7;
            chartDetails.AxisX.IntervalType = DateTimeIntervalType.Days;
            chartDetails.AxisX.IntervalOffset = (int)numberOfDays / 7;
            chartDetails.AxisX.MajorGrid.Enabled = false;
            chartDetails.AxisX.MinorGrid.Enabled = false;
            chartDetails.AxisX.Minimum = DateTime.Now.AddDays(-numberOfDays).ToOADate();
            chartDetails.AxisX.Maximum = DateTime.Now.ToOADate();

            chartDetails.AxisY.LabelStyle.Format = "";
            chartDetails.AxisY.MajorGrid.Enabled = false;
            chartDetails.AxisY.MinorGrid.Enabled = false;
            chartDetails.AxisY.Minimum = 0;

            chart.Series.Clear();
            chart.Series.Add("Expense");
            chart.Series["Expense"].ChartType = SeriesChartType.Spline;
            chart.Series["Expense"].Color = Color.Red;

            int maxAmount = 0;

            foreach(ReportDetails reportDetails in reportDetailList)
            {
                chart.Series["Expense"].Points.AddXY(reportDetails.Date, reportDetails.Amount);

                if (maxAmount < reportDetails.Amount)
                {
                    maxAmount = (int)reportDetails.Amount + 1;
                }
                
            }

            chartDetails.AxisY.Maximum = maxAmount;
            chartDetails.AxisY.Interval = (int) maxAmount/10;
        }

        private async void BtnGenerateReport_Click(object sender, EventArgs e)
        {
            if(DPickerEndDate.Value < DPickerStartDate.Value)
            {
                MessageBox.Show("START DATE cannot be greater than END DATE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<Transaction> transactionList = await Task.Run(() => normalTransactionRepository.GetTransactionDetailsFromDates(UserSession.UserData.Id, DPickerStartDate.Value, DPickerEndDate.Value));
            ListViewToday.HideSelection = true;
            
            double income = 0;
            double expense = 0;
            ListViewSelectedDate.Columns.Add("Date", 200);
            ListViewSelectedDate.Columns.Add("Name", 137);
            ListViewSelectedDate.Columns.Add("Contact", 137);
            ListViewSelectedDate.Columns.Add("Credit", 100);
            ListViewSelectedDate.Columns.Add("Debit", 100);

            foreach (Transaction transaction in transactionList)
            {
                ListViewItem transactionDetail = new ListViewItem(new string[]
                {
                            transaction.TransactionDate.ToString(),
                            transaction.Name,
                            transaction.ContactName,
                });

                if (transaction.Type == "Income")
                {
                    transactionDetail.SubItems.Add("£" + transaction.Amount);
                    income += transaction.Amount;
                    transactionDetail.SubItems.Add("");
                }
                else
                {
                    transactionDetail.SubItems.Add("");
                    transactionDetail.SubItems.Add("£" + transaction.Amount);
                    expense += transaction.Amount;
                }

                ListViewSelectedDate.Items.Add(transactionDetail);
            }
            ListViewItem total = new ListViewItem(new string[]
                {
                            "",
                            "",
                            "Total",
                            "£" +income,
                            "£" +expense
                });
            ListViewSelectedDate.Items.Add(total);
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
    }
}

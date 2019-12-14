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
using System.Transactions;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ExpenseManagement.View_and_Controller
{
    public partial class GraphForm : MaterialForm
    {
        private readonly MaterialSkinManager _materialSkinManager;

        public GraphForm(List<ReportDetails> reportDetailList, int numberOfDays)
        {
            InitializeComponent();
            _materialSkinManager = DesignSettings.GetDesign();
            _materialSkinManager.AddFormToManage(this);

            if(numberOfDays == 7)
            {
                lblHeading.Text += " for the Week"; 
            }
            else
            {
                lblHeading.Text += " for the Month";
            }

            _generateGraph(reportDetailList, numberOfDays);
        }


        private void _generateGraph(List<ReportDetails> reportDetailList, int numberOfDays)
        {
            BehaviorChart.Series[0].XValueType = ChartValueType.DateTime;

            var chartDetails = BehaviorChart.ChartAreas[0];
            chartDetails.AxisX.LabelStyle.Format = "MM/dd/yyyy";
            chartDetails.AxisX.Interval = (int)numberOfDays / 7;
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

            BehaviorChart.Series.Clear();
            BehaviorChart.Series.Add("Expense");
            BehaviorChart.Series["Expense"].ChartType = SeriesChartType.Spline;
            BehaviorChart.Series["Expense"].Color = Color.Red;

            int maxAmount = 0;

            foreach (ReportDetails reportDetails in reportDetailList)
            {
                BehaviorChart.Series["Expense"].Points.AddXY(reportDetails.Date, reportDetails.Amount);

                if (maxAmount < reportDetails.Amount)
                {
                    maxAmount = (int)reportDetails.Amount + 1;
                }

            }

            chartDetails.AxisY.Maximum = maxAmount;
            chartDetails.AxisY.Interval = (int)maxAmount / 10;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

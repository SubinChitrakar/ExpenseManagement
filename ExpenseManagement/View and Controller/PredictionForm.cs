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
    public partial class PredictionForm : MaterialForm
    {
        private MaterialSkinManager _materialSkinManager;
       
        public PredictionForm()
        {
            InitializeComponent();
            _materialSkinManager = DesignSettings.GetDesign();
            _materialSkinManager.AddFormToManage(this);
            
            DPickerDate.MinDate = DateTime.Now.AddDays(1);
        }


        private async void BtnPredict_Click(object sender, EventArgs e)
        {
            NormalTransactionRepository normalTransactionRepository = new NormalTransactionRepository();
            RecurringTransactionRepository recurringTransactionRepository = new RecurringTransactionRepository();
            List<Transaction> transactionList = await Task.Run(() => normalTransactionRepository.GetExpenseTransactions(UserSession.UserData.Id));
            List<RecurringTransaction> recurringTransaction = await Task.Run(() => recurringTransactionRepository.GetExpenseTransactions(UserSession.UserData.Id));

            double averageOfTransaction = _getAverage(transactionList);
            double totalOfRecurringTransaction = _getRecurringTransactionAmount(recurringTransaction);
            double prediction = 0;

            if(averageOfTransaction > totalOfRecurringTransaction)
            {
                prediction = averageOfTransaction;
            }
            else
            {
                prediction = totalOfRecurringTransaction;
            }
            MessageBox.Show("Predicted Expense for "+ DPickerDate.Value.ToShortDateString() + " : £" + prediction, "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private double _getAverage(List<Transaction> transactionList)
        {
            double averageAmount = 0;
            double totalAverageAmount = 0;
            double totalForWeekDay = 0;
            double totalForMonthDay = 0;
            double totalFor30Days = 0;

            int noOfWeekDay = 0;
            int noOfMonthDay = 0;
            int noOf30Days = 0;

            DateTime predictionDate = DPickerDate.Value.Date;
            DateTime lastMonth = predictionDate.AddMonths(-1);

            foreach (Transaction transaction in transactionList)
            {
                if (transaction.TransactionDate.DayOfWeek == predictionDate.DayOfWeek)
                {
                    totalForWeekDay += transaction.Amount;
                    noOfWeekDay++;
                }

                if (transaction.TransactionDate.Day == predictionDate.Day)
                {
                    totalForMonthDay += transaction.Amount;
                    noOfMonthDay++;
                }

                if (transaction.TransactionDate >= lastMonth)
                {
                    totalFor30Days += transaction.Amount;
                    noOf30Days++;
                }
            }

            int num = 0;
            if (noOfWeekDay > 0)
            {
                num++;
                totalAverageAmount += totalForWeekDay / noOfWeekDay;
            }

            if (noOfMonthDay > 0)
            {
                num++;
                totalAverageAmount += totalForMonthDay / noOfMonthDay;
            }

            if (noOf30Days > 0)
            {
                num++;
                totalAverageAmount += totalFor30Days / noOf30Days;
            }

            if (num > 0)
            {
                averageAmount = totalAverageAmount / num;
            }

            return averageAmount;
        }
        
        private double _getRecurringTransactionAmount(List<RecurringTransaction> recurringTransactionList)
        {
            double totalAmount = 0;
            DateTime predictDate = DPickerDate.Value.Date;
            foreach (RecurringTransaction recurringTransaction in recurringTransactionList)
            {
                string transactionDate = recurringTransaction.TransactionDate.ToString("dd/MM");
                string predictionDate = predictDate.ToString("dd/MM");

                if (recurringTransaction.Status.Equals("Yearly"))
                {
                    if (transactionDate.Equals(predictDate))
                    {
                        totalAmount += recurringTransaction.Amount;
                    }

                }

                if (recurringTransaction.Status.Equals("Monthly"))
                {
                    if (recurringTransaction.TransactionDate.Day == predictDate.Day)
                    {
                        totalAmount += recurringTransaction.Amount;
                    }
                }

                if (recurringTransaction.Status.Equals("Weekly"))
                {
                    if (recurringTransaction.TransactionDate.DayOfWeek == predictDate.DayOfWeek)
                    {
                        totalAmount += recurringTransaction.Amount;
                    }
                }

                if (recurringTransaction.Status.Equals("Daily"))
                {
                    totalAmount += recurringTransaction.Amount;
                }
            }

            return totalAmount;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

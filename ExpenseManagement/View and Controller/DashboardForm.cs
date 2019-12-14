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
                _checkRecurringEvent();
                UserSession.UserData.LastAccessDate = DateTime.Now;
                new UserRepository().UpdateUserAccessDate(UserSession.UserData);
            }
        }

        public void _checkRecurringTransaction()
        {
            NormalTransactionRepository normalTransactionRepository = new NormalTransactionRepository();
            RecurringTransactionRepository recurringTransactionRepository = new RecurringTransactionRepository();

            List<RecurringTransaction> recurringTransactionList = recurringTransactionRepository.GetTransactions(UserSession.UserData.Id);

            foreach(RecurringTransaction recurringTransaction in recurringTransactionList)
            {
                int noOfDays = (DateTime.Now - UserSession.UserData.LastAccessDate).Days;

                DateTime recurringTime = UserSession.UserData.LastAccessDate;
                TimeSpan timeSpan = new TimeSpan(recurringTransaction.TransactionDate.Hour, recurringTransaction.TransactionDate.Minute, recurringTransaction.TransactionDate.Second);
                recurringTime = recurringTime + timeSpan;

                for(int i =0; i<=noOfDays; i++)
                {
                    if(recurringTransaction.Status.Equals("Weekly"))
                    {
                        if(recurringTime.DayOfWeek != recurringTransaction.TransactionDate.DayOfWeek)
                        {
                            recurringTime = recurringTime.AddDays(1);
                            continue;
                        }
                    }

                    if (recurringTransaction.Status.Equals("Monthly"))
                    {
                        if (recurringTime.Day != recurringTransaction.TransactionDate.Day)
                        {
                            recurringTime = recurringTime.AddDays(1);
                            continue;
                        }
                    }

                    if (recurringTransaction.Status.Equals("Yearly"))
                    {
                        string recurringTimeString = recurringTime.ToString("dd/MM");
                        string createdDateString = recurringTransaction.TransactionDate.ToString("dd/MM");
                        if (!recurringTimeString.Equals(createdDateString))
                        {
                            recurringTime = recurringTime.AddDays(1);
                            continue;
                        }
                    }

                    if(recurringTime > UserSession.UserData.LastAccessDate && recurringTime <= DateTime.Now && recurringTime > recurringTransaction.TransactionDate)
                    {
                        Transaction transaction = new Transaction
                        {
                            Name = recurringTransaction.Name,
                            Amount = recurringTransaction.Amount,
                            Type = recurringTransaction.Type,
                            TransactionDate = recurringTransaction.TransactionDate,
                            Note = recurringTransaction.Note,
                            ContactId = recurringTransaction.ContactId,
                            UserId = recurringTransaction.UserId
                        };
                        normalTransactionRepository.AddNormalTransaction(transaction);
                    }
                    recurringTime = recurringTime.AddDays(1);
                }
            }
        }

        public void _checkRecurringEvent()
        {
            EventRepository eventRepository = new EventRepository();
            RecurringEventRepository recurringEventRepository = new RecurringEventRepository();

            List<RecurringEvent> recurringEventList = recurringEventRepository.GetEvents(UserSession.UserData.Id);

            foreach (RecurringEvent recurringEvent in recurringEventList)
            {
                int noOfDays = (DateTime.Now - UserSession.UserData.LastAccessDate).Days;

                DateTime recurringTime = UserSession.UserData.LastAccessDate;
                TimeSpan timeSpan = new TimeSpan(recurringEvent.EventDate.Hour, recurringEvent.EventDate.Minute, recurringEvent.EventDate.Second);
                recurringTime = recurringTime + timeSpan;

                for (int i = 0; i <= noOfDays; i++)
                {
                    if (recurringEvent.Status.Equals("Weekly"))
                    {
                        if (recurringTime.DayOfWeek != recurringEvent.EventDate.DayOfWeek)
                        {
                            recurringTime = recurringTime.AddDays(1);
                            continue;
                        }
                    }

                    if (recurringEvent.Status.Equals("Monthly"))
                    {
                        if (recurringTime.Day != recurringEvent.EventDate.Day)
                        {
                            recurringTime = recurringTime.AddDays(1);
                            continue;
                        }
                    }

                    if (recurringEvent.Status.Equals("Yearly"))
                    {
                        string recurringTimeString = recurringTime.ToString("dd/MM");
                        string createdDateString = recurringEvent.EventDate.ToString("dd/MM");
                        if (!recurringTimeString.Equals(createdDateString))
                        {
                            recurringTime = recurringTime.AddDays(1);
                            continue;
                        }
                    }

                    if (recurringTime > UserSession.UserData.LastAccessDate && recurringTime <= DateTime.Now && recurringTime > recurringEvent.EventDate)
                    {
                        Event newEvent = new Event
                        {
                            Name = recurringEvent.Name,
                            Location = recurringEvent.Location,
                            Type = recurringEvent.Type,
                            EventDate = recurringEvent.EventDate,
                            Note = recurringEvent.Note,
                            ContactId = recurringEvent.ContactId,
                            UserId = recurringEvent.UserId
                        };
                        eventRepository.AddEvent(newEvent);
                    }
                    recurringTime = recurringTime.AddDays(1);
                }
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

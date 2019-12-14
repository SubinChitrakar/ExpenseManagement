using ExpenseManagement.Model;
using ExpenseManagement.Repository;
using ExpenseManagement.Utilities;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseManagement.View_and_Controller
{
    public partial class DashboardForm : MaterialForm
    {
        private MaterialSkinManager _materialSkinManager;
        private bool _previouslyAdded = false;
        private MessageStatus _messageStatus;
       
        public DashboardForm()
        {
            InitializeComponent();
            _materialSkinManager = DesignSettings.GetDesign();
            _materialSkinManager.AddFormToManage(this);

            UserSession.ParentForm = this;
            _messageStatus = new MessageStatus();
        }

        private void Dashboard_Activated(object sender, EventArgs e)
        {
            if (UserSession.UserData == null)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Activate();
                loginForm.Show();
            }
            else
            {
                if (!RecurringBackground.IsBusy)
                    RecurringBackground.RunWorkerAsync();
                _createDesign();
            }
            
        }

        private void _backgroundActivityForRecurring(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker backgroundWorker  = (BackgroundWorker)sender;
            while (!backgroundWorker.CancellationPending)
            {
                _checkRecurringTransaction();
                _checkRecurringEvent();
                if (!_previouslyAdded) _previouslyAdded = true;
                UserSession.UserData.LastAccessDate = DateTime.Now;
                new UserRepository().UpdateUserAccessDate(UserSession.UserData);
            }
        }

        public async void _checkRecurringTransaction()
        {
            NormalTransactionRepository normalTransactionRepository = new NormalTransactionRepository();
            RecurringTransactionRepository recurringTransactionRepository = new RecurringTransactionRepository();

            List<RecurringTransaction> recurringTransactionList = recurringTransactionRepository.GetTransactions(UserSession.UserData.Id);

            foreach(RecurringTransaction recurringTransaction in recurringTransactionList)
            {
                int noOfDays = (DateTime.Now - UserSession.UserData.LastAccessDate).Days;

                DateTime recurringTime = UserSession.UserData.LastAccessDate;
                TimeSpan timeSpan = new TimeSpan(recurringTransaction.TransactionDate.Hour, recurringTransaction.TransactionDate.Minute, recurringTransaction.TransactionDate.Second);
                recurringTime = recurringTime.Date + timeSpan;

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
                        _messageStatus = await Task.Run(()=>normalTransactionRepository.AddNormalTransaction(new Transaction
                        {
                            Name = recurringTransaction.Name,
                            Amount = recurringTransaction.Amount,
                            Type = recurringTransaction.Type,
                            TransactionDate = recurringTime,
                            Note = recurringTransaction.Note,
                            ContactId = recurringTransaction.ContactId,
                            UserId = recurringTransaction.UserId
                        }));
                        RecurringBackground.ReportProgress(1, "New Transaction has been Added");
                    }
                    recurringTime = recurringTime.AddDays(1);
                }
            }
        }

        public async void _checkRecurringEvent()
        {
            EventRepository _eventRepository = new EventRepository();
            RecurringEventRepository _recurringEventRepository = new RecurringEventRepository();
            List<RecurringEvent> recurringEventList = _recurringEventRepository.GetEvents(UserSession.UserData.Id);

            foreach (RecurringEvent recurringEvent in recurringEventList)
            {
                int noOfDays = (DateTime.Now - UserSession.UserData.LastAccessDate).Days;

                DateTime recurringTime = UserSession.UserData.LastAccessDate;
                TimeSpan timeSpan = new TimeSpan(recurringEvent.EventDate.Hour, recurringEvent.EventDate.Minute, recurringEvent.EventDate.Second);
                recurringTime = recurringTime.Date + timeSpan;

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
                        _messageStatus = await Task.Run(() => _eventRepository.AddEvent(new Event
                        {
                            Name = recurringEvent.Name,
                            Location = recurringEvent.Location,
                            Type = recurringEvent.Type,
                            EventDate = recurringTime,
                            Note = recurringEvent.Note,
                            ContactId = recurringEvent.ContactId,
                            UserId = recurringEvent.UserId
                        }));
                        RecurringBackground.ReportProgress(1, "New Event has been Added");
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

        private void Prediction_Click(object sender, EventArgs e)
        {
            PredictionForm predictionForm = new PredictionForm();
            predictionForm.Activate();
            predictionForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NotificationForm notificationForm = new NotificationForm("New Transaction Added");
            notificationForm.Activate();
            notificationForm.Show();
        }

        private void RecurringBackground_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if(_previouslyAdded)
            {
                string message = (string)e.UserState;
                new NotificationForm(message).Show();
            }
        }

        private async void _getTransactionForDate(DateTime selectedDate)
        {
            NormalTransactionRepository normalTransactionRepository = new NormalTransactionRepository();
            List<Transaction> transactionList = await Task.Run(() => normalTransactionRepository.GetTransactionFromDate(selectedDate, UserSession.UserData.Id));
        }

        private void _createDesign()
        {
            Panel mainPanel = new Panel();
            mainPanel.BackColor = Color.Black;
            mainPanel.Size = new Size(500,500);
            mainPanel.Location = new Point(300,300);
            mainPanel.AutoScroll = true;
            this.Controls.Add(mainPanel);

            Panel insidePanel = new Panel();
            insidePanel.BackColor = Color.Red;
            insidePanel.Size = new Size(100, 100);
            insidePanel.Location = new Point(0, 0);
            insidePanel.AutoScroll = true;
            mainPanel.Controls.Add(insidePanel);
        }
    }
}

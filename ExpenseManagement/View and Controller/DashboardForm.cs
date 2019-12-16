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
        private bool _transactionCollapse = true;
        private bool _eventCollapse = true;
        private bool _settingsCollapse = true;
        private Panel _transactionPanel = new Panel();
        private int _height;
        private int _width;
        private double _totalExpense;
        private double _totalIncome;

        public DashboardForm()
        {
            InitializeComponent();

            _setMenuItems();
            _materialSkinManager = DesignSettings.GetDesign();
            _materialSkinManager.AddFormToManage(this);

            UserSession.ParentForm = this;
            _messageStatus = new MessageStatus();

            _totalExpense = 0;
            _totalIncome = 0;
        }

        private void Dashboard_Activated(object sender, EventArgs e)
        {
            if (UserSession.signIn)
            {
                _createEvents(DateTime.Now);
                _createTransactions(DateTime.Now);
                LblUserName.Text = UserSession.UserData.UserName;
                if (!RecurringBackground.IsBusy)
                    RecurringBackground.RunWorkerAsync();

            }
            else
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Activate();
                loginForm.Show();
            }
        }

        private void _backgroundActivityForRecurring(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker backgroundWorker = (BackgroundWorker)sender;
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

            foreach (RecurringTransaction recurringTransaction in recurringTransactionList)
            {
                int noOfDays = (DateTime.Now - UserSession.UserData.LastAccessDate).Days;

                DateTime recurringTime = UserSession.UserData.LastAccessDate;
                TimeSpan timeSpan = new TimeSpan(recurringTransaction.TransactionDate.Hour, recurringTransaction.TransactionDate.Minute, recurringTransaction.TransactionDate.Second);
                recurringTime = recurringTime.Date + timeSpan;

                for (int i = 0; i <= noOfDays; i++)
                {
                    if (recurringTransaction.Status.Equals("Weekly"))
                    {
                        if (recurringTime.DayOfWeek != recurringTransaction.TransactionDate.DayOfWeek)
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

                    if (recurringTime > UserSession.UserData.LastAccessDate && recurringTime <= DateTime.Now && recurringTime > recurringTransaction.TransactionDate)
                    {
                        _messageStatus = await Task.Run(() => normalTransactionRepository.AddNormalTransaction(new Transaction
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

        private void RecurringBackground_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (_previouslyAdded)
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

        private void BtnContacts_Click(object sender, EventArgs e)
        {
            ContactListForm contactListForm = new ContactListForm();
            contactListForm.Activate();
            contactListForm.Show();
        }

        public void _setMenuItems()
        {
            btnContacts.TabStop = false;
            btnContacts.FlatStyle = FlatStyle.Flat;
            btnContacts.FlatAppearance.BorderSize = 0;

            BtnTransactionMain.TabStop = false;
            BtnTransactionMain.FlatStyle = FlatStyle.Flat;
            BtnTransactionMain.FlatAppearance.BorderSize = 0;

            BtnNormalTransaction.TabStop = false;
            BtnNormalTransaction.FlatStyle = FlatStyle.Flat;
            BtnNormalTransaction.FlatAppearance.BorderSize = 0;

            BtnRecurringTransaction.TabStop = false;
            BtnRecurringTransaction.FlatStyle = FlatStyle.Flat;
            BtnRecurringTransaction.FlatAppearance.BorderSize = 0;

            BtnEventMain.TabStop = false;
            BtnEventMain.FlatStyle = FlatStyle.Flat;
            BtnEventMain.FlatAppearance.BorderSize = 0;

            BtnNormalEvents.TabStop = false;
            BtnNormalEvents.FlatStyle = FlatStyle.Flat;
            BtnNormalEvents.FlatAppearance.BorderSize = 0;

            BtnRecurringEvents.TabStop = false;
            BtnRecurringEvents.FlatStyle = FlatStyle.Flat;
            BtnRecurringEvents.FlatAppearance.BorderSize = 0;

            BtnReport.TabStop = false;
            BtnReport.FlatStyle = FlatStyle.Flat;
            BtnReport.FlatAppearance.BorderSize = 0;

            BtnPrediction.TabStop = false;
            BtnPrediction.FlatStyle = FlatStyle.Flat;
            BtnPrediction.FlatAppearance.BorderSize = 0;

            BtnSettings.TabStop = false;
            BtnSettings.FlatStyle = FlatStyle.Flat;
            BtnSettings.FlatAppearance.BorderSize = 0;

            BtnChangePassword.TabStop = false;
            BtnChangePassword.FlatStyle = FlatStyle.Flat;
            BtnChangePassword.FlatAppearance.BorderSize = 0;
        }

        private void TimerTransaction_Tick(object sender, EventArgs e)
        {
            if (_transactionCollapse)
            {
                PanelTransaction.Height += 10;
                if (PanelTransaction.Size == PanelTransaction.MaximumSize)
                {
                    TimerTransaction.Stop();
                    _transactionCollapse = false;
                }
            }
            else
            {
                PanelTransaction.Height -= 10;
                if (PanelTransaction.Size == PanelTransaction.MinimumSize)
                {
                    TimerTransaction.Stop();
                    _transactionCollapse = true;
                }
            }
        }

        private void BtnTransactionMain_Click(object sender, EventArgs e)
        {
            TimerTransaction.Start();
        }

        private void BtnNormalTransaction_Click(object sender, EventArgs e)
        {
            TransactionListForm transactionListForm = new TransactionListForm(false);
            transactionListForm.Activate();
            transactionListForm.Show();
        }

        private void BtnRecurringTransaction_Click(object sender, EventArgs e)
        {
            TransactionListForm transactionListForm = new TransactionListForm(true);
            transactionListForm.Activate();
            transactionListForm.Show();
        }

        private void TimerEvents_Tick(object sender, EventArgs e)
        {
            if (_eventCollapse)
            {
                PanelEvent.Height += 10;
                if (PanelEvent.Size == PanelEvent.MaximumSize)
                {
                    TimerEvents.Stop();
                    _eventCollapse = false;
                }
            }
            else
            {
                PanelEvent.Height -= 10;
                if (PanelEvent.Size == PanelEvent.MinimumSize)
                {
                    TimerEvents.Stop();
                    _eventCollapse = true;
                }
            }
        }

        private void BtnEventMain_Click(object sender, EventArgs e)
        {
            TimerEvents.Start();
        }

        private void BtnNormalEvents_Click(object sender, EventArgs e)
        {
            EventListForm eventListForm = new EventListForm(false);
            eventListForm.Activate();
            eventListForm.Show();
        }

        private void BtnRecurringEvents_Click(object sender, EventArgs e)
        {
            EventListForm eventListForm = new EventListForm(true);
            eventListForm.Activate();
            eventListForm.Show();
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            FinancialReport financialReport = new FinancialReport();
            financialReport.Activate();
            financialReport.Show();
        }

        private void BtnPrediction_Click(object sender, EventArgs e)
        {
            PredictionForm predictionForm = new PredictionForm();
            predictionForm.Activate();
            predictionForm.Show();
        }

        private void TimerSettings_Tick(object sender, EventArgs e)
        {
            if (_settingsCollapse)
            {
                SettingsPanel.Height += 10;
                if (SettingsPanel.Size == SettingsPanel.MaximumSize)
                {
                    TimerSettings.Stop();
                    _settingsCollapse = false;
                }
            }
            else
            {
                SettingsPanel.Height -= 10;
                if (SettingsPanel.Size == SettingsPanel.MinimumSize)
                {
                    TimerSettings.Stop();
                    _settingsCollapse = true;
                }
            }
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            TimerSettings.Start();
        }

        private void BtnChangePassword_Click(object sender, EventArgs e)
        {

        }

        private async void _createTransactions(DateTime selectedTime)
        {
            NormalTransactionRepository normalTransactionRepository = new NormalTransactionRepository();
            List<Transaction> listOfTransaction = await Task.Run(() => normalTransactionRepository.GetTransactionFromDate(selectedTime, UserSession.UserData.Id));

            _totalIncome = 0;
            _totalExpense = 0;

            _transactionPanel.BackColor = SystemColors.ControlLight;
            _transactionPanel.Location = new Point(430, 140);
            _transactionPanel.Name = "transactionPanel";
            _transactionPanel.Size = new Size(_width, _height);
            _transactionPanel.AutoScroll = true;
            this.Controls.Add(_transactionPanel);

            _transactionPanel.Controls.Clear();

            Label lblTrasactionHeading = new Label
            {
                AutoSize = true,
                BackColor = Color.Transparent,
                Font = new Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                Location = new Point(10, 10),
                Size = new Size(155, 33),
                Text = "Transactions"
            };
            _transactionPanel.Controls.Add(lblTrasactionHeading);

            Panel line = new Panel
            {
                BackColor = Color.Black,
                Location = new Point(10, 40),
                Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top,
                Size = new Size(_transactionPanel.Width - 20, 2)
            };
            _transactionPanel.Controls.Add(line);

            int count = 1;
            foreach (Transaction transaction in listOfTransaction)
            {
                Panel eachTransaction = new Panel
                {
                    Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
                    BackColor = Color.White,
                    Size = new Size(290, 80),
                    Location = new Point(10, count * 55)
                };
                _transactionPanel.Controls.Add(eachTransaction);

                Label lblTransactionName = new Label
                {
                    Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                    AutoSize = true,
                    Anchor = AnchorStyles.Left | AnchorStyles.Top,
                    Location = new Point(5, 20),
                    Size = new Size(100, 100),
                    Text = transaction.Name
                };
                eachTransaction.Controls.Add(lblTransactionName);

                Label lblTransactionType = new Label
                {
                    Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                    AutoSize = true,
                    Anchor = AnchorStyles.Left | AnchorStyles.Top,
                    Location = new Point(10, 50),
                    Size = new Size(100, 100),
                    Text = transaction.Type
                };
                eachTransaction.Controls.Add(lblTransactionType);

                Label lblAmount = new Label
                {
                    Font = new Font("Times New Roman", 22F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                    AutoSize = true,
                    Anchor = AnchorStyles.Right | AnchorStyles.Top,
                    Location = new Point(200, 25),
                    Size = new Size(100, 100),
                    Text = "£" + transaction.Amount
                };
                eachTransaction.Controls.Add(lblAmount);


                if (transaction.Type.Equals("Expense"))
                {
                    _totalExpense += transaction.Amount;
                    lblAmount.ForeColor = Color.FromArgb(244, 67, 54);
                    lblTransactionType.ForeColor = Color.FromArgb(244, 67, 54);
                }
                else
                {
                    _totalIncome += transaction.Amount;
                    lblAmount.ForeColor = Color.FromArgb(0, 121, 107);
                    lblTransactionType.ForeColor = Color.FromArgb(0, 121, 107);
                }
                LblTotalExpense.Text = "£" + _totalExpense;
                LblTotalIncome.Text = "£" + _totalIncome;
                count++;
            }
        }

        private void DashboardForm_SizeChanged(object sender, EventArgs e)
        {
            _height = Convert.ToInt32(this.Height / 1.3);

            if (this.Width > 1200)
            {
                _width = Convert.ToInt32(this.Width / 1.7);
            }
            else if (this.Width > 1020 && this.Width < 1200)
            {
                _width = Convert.ToInt32(this.Width / 2.6);
            }
            else
            {
                _width = Convert.ToInt32(this.Width / 3);
            }

            _transactionPanel.Size = new System.Drawing.Size(_width, _height);

        }

        private void DPickerSelectDate_DateSelected(object sender, DateRangeEventArgs e)
        {
            _createEvents(DPickerSelectDate.SelectionEnd);
            _createTransactions(DPickerSelectDate.SelectionEnd);
        }

        private async void _createEvents(DateTime selectedTime)
        {
            EventRepository eventRepository = new EventRepository();
            List<Event> listOfEvent = await Task.Run(() => eventRepository.GetEvents(selectedTime, UserSession.UserData.Id));

            LblNoOfEvents.Text = Convert.ToString(listOfEvent.Count);
            EventPanel.Controls.Clear();

            Label lblEventHeading = new Label
            {
                Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                ForeColor = Color.White,
                Location = new Point(16, 12),
                Name = "LblEventHeading",
                Size = new Size(63, 22),
                TabIndex = 0,
                Text = "Events"
            };
            EventPanel.Controls.Add(lblEventHeading);

            Panel line = new Panel
            {
                BackColor = Color.White,
                Location = new Point(10, 36),
                Size = new Size(160, 2)
            };

            EventPanel.Controls.Add(line);

            int count = 1;
            foreach (Event dateEvent in listOfEvent)
            {
                Panel eachEvent = new Panel
                {
                    Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
                    BackColor = Color.White,
                    Size = new Size(160, 50),
                    Location = new Point(10, count * 55)
                };
                EventPanel.Controls.Add(eachEvent);

                Label lblEventName = new Label
                {
                    Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                    AutoSize = true,
                    Location = new Point(10, 18),
                    Size = new Size(100, 17),
                    Text = dateEvent.Name
                };
                eachEvent.Controls.Add(lblEventName);
                count++;
            }
        }
    }
}

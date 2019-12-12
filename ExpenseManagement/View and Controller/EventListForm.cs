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
    public partial class EventListForm : MaterialForm
    {
        private readonly MaterialSkinManager _materialSkinManager;
        private MessageStatus _messageStatus;
        private bool _recurringEventStatus;

        public EventListForm(bool recurringStatus)
        {
            InitializeComponent();
            _materialSkinManager = DesignSettings.GetDesign();
            _materialSkinManager.AddFormToManage(this);

            UserSession.ParentForm.Hide();
            
            _messageStatus = new MessageStatus();
            _recurringEventStatus = recurringStatus;
        }

        private void EventListForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            UserSession.ParentForm.Dispose();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            UserSession.ParentForm.Show();
        }

        private void EventListForm_Activated(object sender, EventArgs e)
        {
            LblUserName.Text = UserSession.UserData.UserName;

            if(_recurringEventStatus)
            {
                _getRecurringEvents();
            }
            else
            {
                _getNormalEvents();
            }
        }

        private async void _getNormalEvents()
        {
            EventRepository eventRepository = new EventRepository();
            List<Event> listOfNormalEvent = await Task.Run(() => eventRepository.GetEvents(UserSession.UserData.Id));
            EventListView.Items.Clear();
            foreach (Event normalEvent in listOfNormalEvent)
            {
                ListViewItem listView = new ListViewItem(new string[] { normalEvent.Name, normalEvent.Type, normalEvent.EventDate.ToString() })
                {
                    Tag = normalEvent
                };
                EventListView.Items.Add(listView);
            }
        }

        private async void _getRecurringEvents()
        {
            RecurringEventRepository recurringEventRepository = new RecurringEventRepository();
            List<RecurringEvent> listOfRecurringEvent = await Task.Run(() => recurringEventRepository.GetEvents(UserSession.UserData.Id));
            EventListView.Items.Clear();
            foreach (RecurringEvent recurringEvent in listOfRecurringEvent)
            {
                ListViewItem listView = new ListViewItem(new string[] { recurringEvent.Name, recurringEvent.Type, recurringEvent.EventDate.ToString() })
                {
                    Tag = recurringEvent
                };
                EventListView.Items.Add(listView);
            }
        }

        private void BtnAddEvent_Click(object sender, EventArgs e)
        {
            EventActionForm eventActionForm = new EventActionForm();
            eventActionForm.Activate();
            eventActionForm.Show();
        }

        private void BtnViewEvent_Click(object sender, EventArgs e)
        {
            if (EventListView.SelectedItems.Count > 0)
            {
                Event selectedEvent = (Event)EventListView.SelectedItems[0].Tag;
                EventActionForm eventActionForm = new EventActionForm(selectedEvent);
                eventActionForm.Activate();
                eventActionForm.Show();
            }
            else
            {
                MessageBox.Show("Select a EVENT", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

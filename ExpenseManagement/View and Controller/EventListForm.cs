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
        private EventRepository _eventRepository;
        private MessageStatus _messageStatus;
        private bool _recurringEventStatus;

        public EventListForm(bool recurringStatus)
        {
            InitializeComponent();
            _materialSkinManager = DesignSettings.GetDesign();
            _materialSkinManager.AddFormToManage(this);

            UserSession.ParentForm.Hide();
            _eventRepository = new EventRepository();
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

            }
            else
            {
                _getNormalEvents();
            }
        }

        private async void _getNormalEvents()
        {
            List<Event> listOfNormalEvent = await Task.Run(() => _eventRepository.GetEvents(UserSession.UserData.Id));
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

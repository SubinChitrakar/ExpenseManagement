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
    public partial class EventActionForm : MaterialForm
    {
        private readonly MaterialSkinManager _materialSkinManager;
        private MessageStatus _messageStatus;

        private EventRepository _eventRepository;

        private Event _eventInfo;
        private RecurringEvent _recurringEvent;

        private bool _recurringStatus;
        private bool _editingStatus;

        public EventActionForm()
        {            
            InitializeComponent();
            DPickerDate.Value = DateTime.Now;

            _materialSkinManager = DesignSettings.GetDesign();
            _materialSkinManager.AddFormToManage(this);

            _recurringStatus = false;
            UserSession.ParentForm.Hide();
            LblHeading.Text = "ADD EVENT";

            BtnDeleteEvent.Visible = false;
            _eventInfo = new Event();
            _recurringEvent = new RecurringEvent();
        }

        public EventActionForm(Event selectedEvent)
        {
            InitializeComponent();
            _materialSkinManager = DesignSettings.GetDesign();
            _materialSkinManager.AddFormToManage(this);

            UserSession.ParentForm.Hide();
            _eventInfo = selectedEvent;
            _recurringStatus = false;
            _setPropertiesForEditEvent();
        }

        private async void EventActionForm_Load(object sender, EventArgs e)
        {
            ContactRepository contactRepository = new ContactRepository();

            List<Contact> contactList = await Task.Run(() => contactRepository.GetContacts(UserSession.UserData.Id));
            CmbContact.DataSource = contactList;
            CmbContact.DisplayMember = "Name";

            if (_recurringStatus)
            {
                _setContactForEvent(contactList, _recurringEvent);
            }
            else
            {
                _setContactForEvent(contactList, _eventInfo);
            }
        }

        private void _setContactForEvent(List<Contact> contactList, Event eventInfo)
        {
            if (eventInfo.Id > 0)
            {
                if (eventInfo.ContactId == 0)
                {
                    CmbContact.Text = "";
                }
                else
                {
                    for (int i = 0; i < contactList.Count; i++)
                    {
                        if (eventInfo.ContactId == contactList[i].Id)
                        {
                            CmbContact.SelectedItem = CmbContact.Items[i];
                        }
                    }
                }
            }
        }

        private void BtnAction_Click(object sender, EventArgs e)
        {
            if (_eventInfo.Id == 0)
            {
                _checkInfoForEvent(_eventInfo);
            }
            else if(_eventInfo.Id > 1)
            {
                if(_editingStatus)
                {
                    _checkInfoForEvent(_eventInfo);
                }
                else
                {
                    _activatePropertiesForEditEvent();
                }
            }
        }

        /*
         * Add Event
         */
        private void _checkInfoForEvent(Event eventInfo)
        {
            _eventRepository = new EventRepository();
            if(string.IsNullOrWhiteSpace(TxtEventName.Text))
            {
                MessageBox.Show("Please enter EVENT NAME", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            eventInfo.Name = TxtEventName.Text;
            eventInfo.Location = TxtLocation.Text;
            eventInfo.Type = CmbType.Text;
            eventInfo.Note = TxtNote.Text;
            eventInfo.EventDate = DPickerDate.Value;
            eventInfo.UserId = UserSession.UserData.Id;
            
            Contact selectedContact = (Contact)CmbContact.SelectedItem;
            if(selectedContact == null)
            {
                if (string.IsNullOrWhiteSpace(CmbContact.Text))
                {
                    eventInfo.ContactId = 0;
                }
                else
                {
                    ContactRepository contactRepository = new ContactRepository();
                    eventInfo.ContactId = contactRepository.AddContact(new Contact { Name = CmbContact.Text, UserId = UserSession.UserData.Id });
                }
            }
            else
            {
                eventInfo.ContactId = selectedContact.Id;
            }
            
            if(eventInfo.Id>0)
            {
                _updateEventInDatabase(eventInfo);
            }
            else
            {
                _addEventToDatabase(eventInfo);
            }
        }

        private async void _addEventToDatabase(Event newEvent)
        {
            _messageStatus = await Task.Run(() => _eventRepository.AddEvent(newEvent));
            if (_messageStatus.ErrorStatus)
            {
                DialogResult result = MessageBox.Show(_messageStatus.Message, "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Cancel)
                {
                    this.Dispose();
                }
            }
            else
            {
                MessageBox.Show(_messageStatus.Message, "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
        }

        /*
         * Edit Event
         */
        private void _setPropertiesForEditEvent()
        {
            LblHeading.Text = "VIEW EVENT";
            BtnAction.Text = "EDIT INFORMATION";
            BtnAction.Left -= 50;

            TxtEventName.Text = _eventInfo.Name;
            TxtLocation.Text = _eventInfo.Location;
            TxtNote.Text = _eventInfo.Note;
            CmbType.Text = _eventInfo.Type;
            DPickerDate.Value = _eventInfo.EventDate;

            TxtEventName.Enabled = false;
            TxtLocation.Enabled = false;
            TxtNote.Enabled = false;
            CmbType.Enabled = false;
            CmbContact.Enabled = false;
            DPickerDate.Enabled = false;

            BtnDeleteEvent.Visible = true;
            ChkRecurring.Visible = false;
            _editingStatus = false;
        }

        private void _activatePropertiesForEditEvent()
        {
            LblHeading.Text = "EDIT EVENT";

            TxtEventName.Enabled = true;
            TxtLocation.Enabled = true;
            TxtNote.Enabled = true;
            CmbType.Enabled = true;
            CmbContact.Enabled = true;
            DPickerDate.Enabled = true;

            BtnDeleteEvent.Visible = false;
            BtnAction.Text = "Save Event";
            BtnAction.Left += 40;
            _editingStatus = true;
        }

        private async void _updateEventInDatabase(Event updateEvent)
        {
            _messageStatus = await Task.Run(() => _eventRepository.UpdateEvent(updateEvent));
            if (_messageStatus.ErrorStatus)
            {
                DialogResult result = MessageBox.Show(_messageStatus.Message, "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Cancel)
                {
                    this.Dispose();
                }
            }
            else
            {
                MessageBox.Show(_messageStatus.Message, "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _setPropertiesForEditEvent();
            }
        }

        /*
         * Deleting Event
         */
        private void BtnDeleteEvent_Click(object sender, EventArgs e)
        {
            if(_recurringStatus)
            {

            }
            else
            {
                _deleteEvent();
            }
        }

        private async void _deleteEvent()
        {           
            DialogResult result = MessageBox.Show("Are you sure you want to DELETE?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                _messageStatus = await Task.Run(() => _eventRepository.DeleteEvent(_eventInfo));

                if (_messageStatus.ErrorStatus)
                {
                    MessageBox.Show(_messageStatus.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(_messageStatus.Message, "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
            }
        }

        private void ChkRecurring_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkRecurring.Checked)
            {
                GrpRecurring.Visible = true;
                DPickerEndDate.Value = DateTime.Now;
                this.Top -= 100;
                this.Height += 200;
                BtnAction.Top += 200;
                BtnDeleteEvent.Top += 200;
            }
            else
            {
                GrpRecurring.Visible = false;
                this.Top += 100;
                this.Height -= 200;
                BtnAction.Top -= 200;
                BtnDeleteEvent.Top -= 200;
            }
        }

        private void ChkEndingStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkEndingStatus.Checked)
                DPickerEndDate.Enabled = false;
            else
                DPickerEndDate.Enabled = true;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void EventActionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            UserSession.ParentForm.Close();
        }
    }
}

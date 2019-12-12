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
        private RecurringEventRepository _recurringEventRepository;

        private Event _eventInfo;
        private RecurringEvent _recurringEvent;

        private bool _recurringStatus;
        private bool _editingStatus;
        private bool _recurringPropertySet = false;

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
            
            if(selectedEvent is RecurringEvent tempRecurringEvent)
            {
                _recurringEvent = tempRecurringEvent;
                _recurringStatus = true;
                _setPropertiesForEditEvent(_recurringEvent);
            }
            else
            {
                _eventInfo = selectedEvent;
                _recurringStatus = false;
                _setPropertiesForEditEvent(_eventInfo);
            }
        }

        private async void EventActionForm_Load(object sender, EventArgs e)
        {
            ContactRepository contactRepository = new ContactRepository();
            _eventRepository = new EventRepository();
            _recurringEventRepository = new RecurringEventRepository();

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
            if (_recurringStatus)
            {
                if (_recurringEvent.Id == 0)
                    _checkInfoForRecurringEvent(_recurringEvent);
                else
                {
                    if(_editingStatus)
                    {
                        _checkInfoForRecurringEvent(_recurringEvent);
                    }
                    else
                    {
                        _activatePropertiesForEditEvent();
                    }
                }
            }
            else 
            {
                if (_eventInfo.Id == 0)
                    _checkInfoForEvent(_eventInfo);
                else
                {
                    if (_editingStatus)
                    {
                        _checkInfoForEvent(_eventInfo);
                    }
                    else
                    {
                        _activatePropertiesForEditEvent();
                    }
                }
            }
        }

        /*
         * Add Event
         */
        private void _checkInfoForEvent(Event eventInfo)
        {
            if (string.IsNullOrWhiteSpace(TxtEventName.Text))
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
            if (selectedContact == null)
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

            if (eventInfo.Id > 0)
            {
                _updateEventInDatabase(eventInfo);
            }
            else
            {
                _addEventToDatabase(eventInfo);
            }
        }

        private void _checkInfoForRecurringEvent(RecurringEvent recurringEvent)
        {
            if (string.IsNullOrWhiteSpace(TxtEventName.Text))
            {
                MessageBox.Show("Please enter EVENT NAME", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            recurringEvent.Name = TxtEventName.Text;
            recurringEvent.Location = TxtLocation.Text;
            recurringEvent.Type = CmbType.Text;
            recurringEvent.Note = TxtNote.Text;
            recurringEvent.EventDate = DPickerDate.Value;
            recurringEvent.UserId = UserSession.UserData.Id;
            recurringEvent.Status = CmbStatus.Text;

            Contact selectedContact = (Contact)CmbContact.SelectedItem;
            if (selectedContact == null)
            {
                if (string.IsNullOrWhiteSpace(CmbContact.Text))
                {
                    recurringEvent.ContactId = 0;
                }
                else
                {
                    ContactRepository contactRepository = new ContactRepository();
                    recurringEvent.ContactId = contactRepository.AddContact(new Contact { Name = CmbContact.Text, UserId = UserSession.UserData.Id });
                }
            }
            else
            {
                recurringEvent.ContactId = selectedContact.Id;
            }

            if (ChkEndingStatus.Checked)
                recurringEvent.EventEndDate = DateTime.MinValue;
            else
                recurringEvent.EventEndDate = DPickerEndDate.Value;


            if (recurringEvent.Id > 0)
                _updateEventInDatabase(recurringEvent);
            else
                _addEventToDatabase(recurringEvent);
        }

        private async void _addEventToDatabase(Event newEvent)
        {
            if (newEvent is RecurringEvent tempRecurring)
            {
                _messageStatus = await Task.Run(() => _recurringEventRepository.AddEvent(tempRecurring));
            }
            else
            {
                _messageStatus = await Task.Run(() => _eventRepository.AddEvent(newEvent));
            }

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
        private void _setPropertiesForEditEvent(Event eventInfo)
        {
            LblHeading.Text = "VIEW EVENT";
            BtnAction.Text = "EDIT INFORMATION";
            BtnAction.Left -= 50;

            TxtEventName.Text = eventInfo.Name;
            TxtLocation.Text = eventInfo.Location;
            TxtNote.Text = eventInfo.Note;
            CmbType.Text = eventInfo.Type;
            DPickerDate.Value = eventInfo.EventDate;

            TxtEventName.Enabled = false;
            TxtLocation.Enabled = false;
            TxtNote.Enabled = false;
            CmbType.Enabled = false;
            CmbContact.Enabled = false;
            DPickerDate.Enabled = false;

            BtnDeleteEvent.Visible = true;
            _editingStatus = false;
            ChkRecurring.Visible = false;
            
            if(eventInfo is RecurringEvent recurringEventInfo)
            {
                if (!_recurringPropertySet)
                {
                    GrpRecurring.Visible = true;
                    GrpRecurring.Top -= 40;
                    this.Top -= 170;
                    this.Height += 170;
                    BtnAction.Top += 170;
                    BtnDeleteEvent.Top += 170;
                    _recurringPropertySet = true;
                }
                else
                {
                    BtnAction.Left += 10;
                }

                CmbStatus.Text = recurringEventInfo.Status;
                CmbStatus.Enabled = false;

                if (recurringEventInfo.EventEndDate <= DPickerEndDate.MinDate)
                {
                    ChkEndingStatus.Checked = true;
                    DPickerEndDate.Value = DPickerEndDate.MaxDate;
                }
                else
                {
                    ChkEndingStatus.Checked = false;
                    DPickerEndDate.Value = recurringEventInfo.EventEndDate;
                }

                DPickerEndDate.Enabled = false;
                ChkEndingStatus.Enabled = false;
            }
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

            _editingStatus = true;
            BtnDeleteEvent.Visible = false;
            BtnAction.Text = "Save Event";
            BtnAction.Left += 40;

            if (_recurringStatus)
            {
                CmbStatus.Enabled = true;
                DPickerEndDate.Enabled = true;
                ChkEndingStatus.Enabled = true;
            }
        }

        private async void _updateEventInDatabase(Event updateEvent)
        {
            if (updateEvent is RecurringEvent recurringEvent)
            {
                _messageStatus = await Task.Run(() => _recurringEventRepository.UpdateEvent(recurringEvent));
            }
            else
            {
                _messageStatus = await Task.Run(() => _eventRepository.UpdateEvent(updateEvent));
            }

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
                _setPropertiesForEditEvent(updateEvent);
            }
        }

        /*
         * Deleting Event
         */
        private void BtnDeleteEvent_Click(object sender, EventArgs e)
        {
            if (_recurringStatus)
            {
                _deleteEvent(_recurringEvent);
            }
            else
            {
                _deleteEvent(_eventInfo);
            }
        }

        private async void _deleteEvent(Event eventInfo)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to DELETE?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
               if(eventInfo is RecurringEvent recurringEvent)
                {
                    _messageStatus = await Task.Run(() => _recurringEventRepository.DeleteEvent(recurringEvent));
                }
                else
                {
                    _messageStatus = await Task.Run(() => _eventRepository.DeleteEvent(_eventInfo));
                }

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
                this.Top -= 100;
                this.Height += 200;
                BtnAction.Top += 200;
                BtnDeleteEvent.Top += 200;
                _recurringStatus = true;
                DPickerEndDate.Value = DateTime.Now;
            }
            else
            {
                GrpRecurring.Visible = false;
                this.Top += 100;
                this.Height -= 200;
                BtnAction.Top -= 200;
                BtnDeleteEvent.Top -= 200;
                _recurringStatus = false;
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

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
    public partial class TransactionActionForm : MaterialForm
    {
        private readonly MaterialSkinManager _materialSkinManager;
        private MessageStatus _messageStatus;

        private NormalTransactionRepository _normalTransactionRepository;
        private RecurringTransactionRepository _recurringTransactionRepository; 

        private Transaction _normalTransaction;
        private RecurringTransaction _recurringTransaction;

        private bool _recurringStatus;
        private bool _editingStatus;
        private bool _recurringPropertySet = false;

        public TransactionActionForm()
        {
            InitializeComponent();
            DPickerDate.Value = DateTime.Now;

            _materialSkinManager = DesignSettings.GetDesign();
            _materialSkinManager.AddFormToManage(this);

            _recurringStatus = false;
            UserSession.ParentForm.Hide();
            lblHeading.Text = "ADD TRANSACTION";

            BtnDeleteTransaction.Visible = false;
            _normalTransaction = new Transaction();
            _recurringTransaction = new RecurringTransaction();
        }

        public TransactionActionForm(Transaction selectedTransaction)
        {
            InitializeComponent();
            _materialSkinManager = DesignSettings.GetDesign();
            _materialSkinManager.AddFormToManage(this);

            UserSession.ParentForm.Hide();

            if (selectedTransaction is RecurringTransaction tempRecurringTransaction)
            {
                _recurringTransaction = tempRecurringTransaction;
                _recurringStatus = true;
                _setPropertiesForEditEvent(_recurringTransaction);
            }
            else
            {
                _normalTransaction = selectedTransaction;
                _recurringStatus = false;
                _setPropertiesForEditEvent(_normalTransaction);
            }
        }

        private async void TransactionActionForm_Load(object sender, EventArgs e)
        {
            ContactRepository contactRepository = new ContactRepository();
            _normalTransactionRepository = new NormalTransactionRepository();
            _recurringTransactionRepository = new RecurringTransactionRepository();

            List<Contact> contactList = await Task.Run(() => contactRepository.GetContacts(UserSession.UserData.Id));
            CmbContact.DataSource = contactList;
            CmbContact.DisplayMember = "Name";

            if (_recurringStatus)
            {
                _setContactForTransaction(contactList, _recurringTransaction);
            }
            else
            {
                _setContactForTransaction(contactList, _normalTransaction);
            }
        }

        private void _setContactForTransaction(List<Contact> contactList, Transaction transaction)
        {
            if (transaction.Id > 0)
            {
                if (transaction.ContactId == 0)
                {
                    CmbContact.Text = "";
                }
                else
                {
                    for (int i = 0; i < contactList.Count; i++)
                    {
                        if (transaction.ContactId == contactList[i].Id)
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
                if (_recurringTransaction.Id == 0)
                    _checkInfoForRecurringTransaction(_recurringTransaction);
                else
                {
                    if (_editingStatus)
                    {
                        _checkInfoForRecurringTransaction(_recurringTransaction);
                    }
                    else
                    {
                        _activatePropertiesForEditEvent();
                    }
                }
            }
            else
            {
                if (_normalTransaction.Id == 0)
                    _checkInfoForTransaction(_normalTransaction);
                else
                {
                    if (_editingStatus)
                    {
                        _checkInfoForTransaction(_normalTransaction);
                    }
                    else
                    {
                        _activatePropertiesForEditEvent();
                    }
                }
            }
        }

        private void _checkInfoForTransaction(Transaction transaction)
        {
            if (string.IsNullOrWhiteSpace(TxtTransactionName.Text))
            {
                MessageBox.Show("Please enter TRANSACTION NAME", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(NumUpDownAmount.Value <= 0)
            {
                MessageBox.Show("Please enter AMOUNT", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            transaction.Name = TxtTransactionName.Text;
            transaction.Amount = Convert.ToDouble(NumUpDownAmount.Text);
            transaction.Type = CmbType.Text;
            transaction.Note = TxtNote.Text;
            transaction.TransactionDate = DPickerDate.Value;
            transaction.UserId = UserSession.UserData.Id;

            Contact selectedContact = (Contact)CmbContact.SelectedItem;
            if (selectedContact == null)
            {
                if (string.IsNullOrWhiteSpace(CmbContact.Text))
                {
                    transaction.ContactId = 0;
                }
                else
                {
                    ContactRepository contactRepository = new ContactRepository();
                    transaction.ContactId = contactRepository.AddContact(new Contact { Name = CmbContact.Text, UserId = UserSession.UserData.Id });
                }
            }
            else
            {
                transaction.ContactId = selectedContact.Id;
            }

            if (transaction.Id > 0)
            {
                _updateTransactionInDatabase(transaction);
            }
            else
            {
                _addTransactionToDatabase(transaction);
            }
        }

        private void _checkInfoForRecurringTransaction(RecurringTransaction recurringTransaction)
        {
            if (string.IsNullOrWhiteSpace(TxtTransactionName.Text))
            {
                MessageBox.Show("Please enter TRANSACTION NAME", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (NumUpDownAmount.Value <= 0)
            {
                MessageBox.Show("Please enter AMOUNT", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            recurringTransaction.Name = TxtTransactionName.Text;
            recurringTransaction.Amount = Convert.ToDouble(NumUpDownAmount.Text);
            recurringTransaction.Type = CmbType.Text;
            recurringTransaction.Note = TxtNote.Text;
            recurringTransaction.TransactionDate = DPickerDate.Value;
            recurringTransaction.UserId = UserSession.UserData.Id;
            recurringTransaction.Status = CmbStatus.Text;

            Contact selectedContact = (Contact)CmbContact.SelectedItem;
            if (selectedContact == null)
            {
                if (string.IsNullOrWhiteSpace(CmbContact.Text))
                {
                    recurringTransaction.ContactId = 0;
                }
                else
                {
                    ContactRepository contactRepository = new ContactRepository();
                    recurringTransaction.ContactId = contactRepository.AddContact(new Contact { Name = CmbContact.Text, UserId = UserSession.UserData.Id });
                }
            }
            else
            {
                recurringTransaction.ContactId = selectedContact.Id;
            }

            if (ChkEndingStatus.Checked)
                recurringTransaction.TransactionEndDate = DateTime.MinValue;
            else
                recurringTransaction.TransactionEndDate = DPickerEndDate.Value;


            if (recurringTransaction.Id > 0)
                _updateTransactionInDatabase(recurringTransaction);
            else
                _addTransactionToDatabase(recurringTransaction);
        }

        private async void _addTransactionToDatabase(Transaction transaction)
        {
            if (transaction is RecurringTransaction tempRecurring)
            {
                _messageStatus = await Task.Run(() => _recurringTransactionRepository.AddRecurringTransaction(tempRecurring));
            }
            else
            {
                _messageStatus = await Task.Run(() => _normalTransactionRepository.AddNormalTransaction(transaction));
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

        private void _setPropertiesForEditEvent(Transaction transaction)
        {
            lblHeading.Text = "VIEW TRANSACTION";
            BtnAction.Text = "EDIT INFORMATION";

            TxtTransactionName.Text = transaction.Name;
            NumUpDownAmount.Text = transaction.Amount.ToString();
            TxtNote.Text = transaction.Note;
            CmbType.Text = transaction.Type;
            DPickerDate.Value = transaction.TransactionDate;

            TxtTransactionName.Enabled = false;
            NumUpDownAmount.Enabled = false;
            TxtNote.Enabled = false;
            CmbType.Enabled = false;
            CmbContact.Enabled = false;
            DPickerDate.Enabled = false;

            BtnDeleteTransaction.Visible = true;
            _editingStatus = false;
            ChkRecurring.Visible = false;

            if (transaction is RecurringTransaction recurringTransaction)
            {
                if (!_recurringPropertySet)
                {
                    GrpRecurring.Visible = true;
                    GrpRecurring.Top -= 40;
                    this.Top -= 100;
                    this.Height += 180;
                    BtnAction.Top += 170;
                    BtnDeleteTransaction.Top += 170;
                    _recurringPropertySet = true;
                }
                else
                {
                    BtnAction.Left += 10;
                }

                CmbStatus.Text = recurringTransaction.Status;
                CmbStatus.Enabled = false;

                if (recurringTransaction.TransactionEndDate <= DPickerEndDate.MinDate)
                {
                    ChkEndingStatus.Checked = true;
                    DPickerEndDate.Value = DPickerEndDate.MaxDate;
                }
                else
                {
                    ChkEndingStatus.Checked = false;
                    DPickerEndDate.Value = recurringTransaction.TransactionEndDate;
                }

                DPickerEndDate.Enabled = false;
                ChkEndingStatus.Enabled = false;
            }
        }

        private void _activatePropertiesForEditEvent()
        {
            lblHeading.Text = "EDIT TRANSACTION";

            TxtTransactionName.Enabled = true;
            NumUpDownAmount.Enabled = true;
            TxtNote.Enabled = true;
            CmbType.Enabled = true;
            CmbContact.Enabled = true;
            DPickerDate.Enabled = true;

            _editingStatus = true;
            BtnDeleteTransaction.Visible = false;
            BtnAction.Text = "Save Transaction";
            BtnAction.Left -= 10;

            if (_recurringStatus)
            {
                CmbStatus.Enabled = true;
                ChkEndingStatus.Enabled = true;
                if(!ChkEndingStatus.Checked)
                {
                    DPickerEndDate.Enabled = true;
                }
            }
        }

        private async void _updateTransactionInDatabase(Transaction transaction)
        {
            if (transaction is RecurringTransaction recurringTransaction)
            {
                _messageStatus = await Task.Run(() => _recurringTransactionRepository.UpdateRecurringTransaction(recurringTransaction));
            }
            else
            {
                _messageStatus = await Task.Run(() => _normalTransactionRepository.UpdateNormalTransaction(transaction));
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
                _setPropertiesForEditEvent(transaction);
            }
        }

        private void BtnDeleteTransaction_Click(object sender, EventArgs e)
        {
            if (_recurringStatus)
            {
                _deleteTransaction(_recurringTransaction);
            }
            else
            {
                _deleteTransaction(_normalTransaction);
            }
        }

        private async void _deleteTransaction(Transaction transaction)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to DELETE?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (transaction is RecurringTransaction recurringTransaction)
                {
                    _messageStatus = await Task.Run(() => _recurringTransactionRepository.DeleteRecurringTransaction(recurringTransaction));
                }
                else
                {
                    _messageStatus = await Task.Run(() => _normalTransactionRepository.DeleteNormalTransaction(transaction));
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
                BtnDeleteTransaction.Top += 170;
                _recurringStatus = true;
                DPickerEndDate.Value = DateTime.Now;
            }
            else
            {
                GrpRecurring.Visible = false;
                this.Top += 100;
                this.Height -= 200;
                BtnAction.Top -= 200;
                BtnDeleteTransaction.Top -= 170;
                _recurringStatus = false;
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void TransactionActionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            UserSession.ParentForm.Dispose();
        }

        private void ChkEndingStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkEndingStatus.Checked)
                DPickerEndDate.Enabled = false;
            else
                DPickerEndDate.Enabled = true;
        }
    }
}

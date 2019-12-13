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
    public partial class ContactListForm : MaterialForm
    {
        private readonly MaterialSkinManager _materialSkinManager;
        private ContactRepository _contactRepository;
        private MessageStatus _messageStatus;

        public ContactListForm()
        {
            InitializeComponent();
            _materialSkinManager = DesignSettings.GetDesign();
            _materialSkinManager.AddFormToManage(this);

            UserSession.ParentForm.Hide();
            _contactRepository = new ContactRepository();
            _messageStatus = new MessageStatus();
            ContactsListView.HideSelection = true;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            UserSession.ParentForm.Show();
        }

        private async void ContactsForm_Activated(object sender, EventArgs e)
        {
            LblUserName.Text = UserSession.UserData.UserName;

            List<Contact> listOfContact = await Task.Run(()=>_contactRepository.GetContacts(UserSession.UserData.Id));
            ContactsListView.Items.Clear();
            foreach (Contact contact in listOfContact)
            {
                ListViewItem listView = new ListViewItem(new string[] { contact.Name })
                {
                    Tag = contact
                };
                ContactsListView.Items.Add(listView);
            }                                 
        }

        private void ContactsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            UserSession.ParentForm.Dispose();
        }

        private void BtnAddContact_Click(object sender, EventArgs e)
        {
            ContactActionForm contactAction = new ContactActionForm();
            contactAction.Activate();
            contactAction.Show();
        }

        private void BtnEditContact_Click(object sender, EventArgs e)
        {
            if (ContactsListView.SelectedItems.Count > 0)
            {
                Contact contact = (Contact)ContactsListView.SelectedItems[0].Tag;
                ContactActionForm contactAction = new ContactActionForm(contact);
                contactAction.Activate();
                contactAction.Show();
            }
            else
            {
                MessageBox.Show("Select a CONTACT before EDITING", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void BtnDeleteContact_Click(object sender, EventArgs e)
        {
            if (ContactsListView.SelectedItems.Count > 0)
            {
                Contact contact = (Contact)ContactsListView.SelectedItems[0].Tag;

                DialogResult result = MessageBox.Show("Are you sure you want to DELETE?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    _messageStatus = await Task.Run(() => _contactRepository.DeleteContact(contact));

                    if (_messageStatus.ErrorStatus)
                    {
                        MessageBox.Show(_messageStatus.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(_messageStatus.Message, "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Select a CONTACT before DELETING", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

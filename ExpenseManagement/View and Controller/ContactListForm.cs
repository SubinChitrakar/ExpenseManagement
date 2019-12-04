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
        private readonly MaterialSkinManager materialSkinManager;
        private ContactRepository contactRepository;
        private MessageStatus messageStatus;

        public ContactListForm()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            UserSession.ParentForm.Hide();
            contactRepository = new ContactRepository();
            messageStatus = new MessageStatus();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            UserSession.ParentForm.Show();
        }

        private async void ContactsForm_Activated(object sender, EventArgs e)
        {
            lblUserName.Text = UserSession.UserData.UserName;

            List<Contact> ListOfContact = await Task.Run(()=>contactRepository.GetContacts(UserSession.UserData.Id));
            contactsListView.Items.Clear();
            foreach (Contact contact in ListOfContact)
            {
                ListViewItem listView = new ListViewItem(new string[] { contact.Name })
                {
                    Tag = contact
                };
                contactsListView.Items.Add(listView);
            }                                 
        }

        private void ContactsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            UserSession.ParentForm.Dispose();
        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            ContactActionForm contactAction = new ContactActionForm();
            contactAction.Activate();
            contactAction.Show();
        }

        private void btnEditContact_Click(object sender, EventArgs e)
        {
            if (contactsListView.SelectedItems.Count > 0)
            {
                Contact contact = (Contact)contactsListView.SelectedItems[0].Tag;
                ContactActionForm contactAction = new ContactActionForm(contact);
                contactAction.Activate();
                contactAction.Show();
            }
            else
            {
                MessageBox.Show("Select a CONTACT before EDITING", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void btnDeleteContact_Click(object sender, EventArgs e)
        {
            if (contactsListView.SelectedItems.Count > 0)
            {
                Contact contact = (Contact)contactsListView.SelectedItems[0].Tag;

                DialogResult result = MessageBox.Show("Are you sure you want to DELETE?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    messageStatus = await Task.Run(() => contactRepository.DeleteContact(contact));

                    if (messageStatus.ErrorStatus)
                    {
                        MessageBox.Show(messageStatus.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("CONTACT Deleted Successfully", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

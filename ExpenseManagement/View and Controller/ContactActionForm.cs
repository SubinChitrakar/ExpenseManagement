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
    public partial class ContactActionForm : MaterialForm
    {
        private MaterialSkinManager materialSkinManager;
        private Contact contact;

        public void LoadDesign()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        public ContactActionForm()
        {
            LoadDesign();
            contact = new Contact();
            lblHeading.Text = "Add Contact";
            btnContactAction.Text = "Add Contact";
        }

        public ContactActionForm(Contact editContact)
        {
            LoadDesign();
            contact = editContact;
            lblHeading.Text = "Edit Contact";
            btnContactAction.Text = "Edit Contact";
            txtContactName.Text = contact.Name;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnContactAction_Click(object sender, EventArgs e)
        {
            string contactName = txtContactName.Text;
            ContactRepository contactRepository = new ContactRepository();
            MessageStatus messageStatus = new MessageStatus();

            if (string.IsNullOrWhiteSpace(contactName))
            {
                MessageBox.Show("Please enter CONTACT NAME", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Contact tempContact = contactRepository.GetContactFromName(contactName);
            if (tempContact.Id > 0)
            {
                MessageBox.Show("CONTACT Already Exists", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            contact.Name = contactName;
            contact.UserId = UserSession.UserData.Id;
            if (contact.Id > 0)
            {
                messageStatus = contactRepository.UpdateContact(contact);
            }
            else
            {
                messageStatus = contactRepository.AddContact(contact);
            }

            if (messageStatus.ErrorStatus)
            {
                DialogResult result = MessageBox.Show(messageStatus.Message, "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Cancel)
                {
                    this.Dispose();
                }
            }
            else
            {
                MessageBox.Show(messageStatus.Message, "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
        }
    }
}

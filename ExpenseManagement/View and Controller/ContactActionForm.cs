﻿using ExpenseManagement.Model;
using ExpenseManagement.Repository;
using ExpenseManagement.Utilities;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseManagement.View_and_Controller
{
    public partial class ContactActionForm : MaterialForm
    {
        private MaterialSkinManager _materialSkinManager;
        private Contact _contact;

        public void LoadDesign()
        {
            InitializeComponent();
            _materialSkinManager = DesignSettings.GetDesign();
            _materialSkinManager.AddFormToManage(this);
        }

        public ContactActionForm()
        {
            LoadDesign();
            _contact = new Contact();
            LblHeading.Text = "Add Contact";
            BtnContactAction.Text = "Add Contact";
        }

        public ContactActionForm(Contact editContact)
        {
            LoadDesign();
            _contact = editContact;
            LblHeading.Text = "Edit Contact";
            BtnContactAction.Text = "Edit Contact";
            TxtContactName.Text = _contact.Name;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private async void BtnContactAction_Click(object sender, EventArgs e)
        {
            string contactName = TxtContactName.Text;
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

            int id;
            _contact.Name = contactName;
            BtnContactAction.Enabled = false;
            _contact.UserId = UserSession.UserData.Id;
            if (_contact.Id > 0)
            {
                id = await Task.Run(() => contactRepository.UpdateContact(_contact));
            }
            else
            {
                id = await Task.Run(() => contactRepository.AddContact(_contact));
            }

            if (id > 0)
            {
                if (id == 1)
                {
                    MessageBox.Show("Contact Updated Successfully", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Contact Added Successfully", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("An Error Occured", "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Cancel)
                {
                    this.Dispose();
                }
            }
        }
    }
}

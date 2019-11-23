using ExpenseManagement.Model;
using ExpenseManagement.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseManagement
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            ContactRepository contactRepository = new ContactRepository();
            /*
             * Add
                Contact newContact = new Contact {
                    Name = "Subin"
                };
                MessageBox.Show(contactRepository.AddContact(contact), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            */

            /*Read
                int leftControl = 1;
                List<Contact> contactList = contactRepository.GetContacts();
                foreach(Contact contact in contactList)
                {
                    Label newLabel = new Label();
                    this.Controls.Add(newLabel);
                    newLabel.Left = 100;
                    newLabel.Top = leftControl * 25;
                    newLabel.Text = contact.Name;
                    leftControl++;
                }
            */

            /*
             * Update 
                Contact updateContact = new Contact
                {
                    Id = 1,
                    Name = "Rahul"
                };
                MessageBox.Show(contactRepository.UpdateContact(updateContact), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            */

            /*
             * Delete
                Contact deleteContact = new Contact
                {
                    Id = 1,
                    Name = "Rahul"
                };
                MessageBox.Show(contactRepository.DeleteContact(deleteContact), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
             */

        }
    }
}

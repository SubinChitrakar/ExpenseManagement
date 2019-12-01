﻿using ExpenseManagement.Model;
using ExpenseManagement.Utilities;
using System;
using System.Windows.Forms;

namespace ExpenseManagement.View_and_Controller
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {

            InitializeComponent();
            UserSession.ParentForm = this;
        }

        private void Dashboard_Activated(object sender, EventArgs e)
        {
            if (UserSession.UserData == null)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Activate();
                loginForm.Show();
            }
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            ContactListForm contactsForm = new ContactListForm();
            contactsForm.Activate();
            contactsForm.Show();
        }
    }
}
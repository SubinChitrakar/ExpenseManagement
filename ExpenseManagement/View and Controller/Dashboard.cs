using ExpenseManagement.Utilities;
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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {

            InitializeComponent();
            UserSession.ParentForm = this;
        }

        private void Dashboard_Activated(object sender, EventArgs e)
        {
           if(UserSession.UserData == null)
           {
                LoginForm loginForm = new LoginForm();
                loginForm.Activate();
                loginForm.Show();
            }
           else
           {
                label1.Text = UserSession.UserData.UserName;
           }
        }
    }
}

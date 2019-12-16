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
    public partial class ChangePassword : MaterialForm
    {
        private MaterialSkinManager _materialSkinManager;

        public ChangePassword()
        {
            InitializeComponent();
            _materialSkinManager = DesignSettings.GetDesign();
            _materialSkinManager.AddFormToManage(this);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtnChangePassword_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtOldPassword.Text))
            {
                MessageBox.Show("Please enter Old PASSWORD", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtNewPassword.Text))
            {
                MessageBox.Show("Please enter NEW PASSWORD", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!Encrypt.EncryptData(TxtOldPassword.Text).Equals(UserSession.UserData.Password))
            {
                MessageBox.Show("Incorrect PASSWORD", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!Validator.ValidatePassword(TxtConfirmPassword.Text))
            {
                MessageBox.Show("PASSWORD should be atleast 6 characters long and must contain One Uppercase, Lowercase and Special Character", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtConfirmPassword.Text))
            {
                MessageBox.Show("Please enter CONFIRM PASSWORD", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(TxtConfirmPassword.Text != TxtNewPassword.Text)
            {
                MessageBox.Show("NEW PASSWORD and CONFIRM PASSWORD are DIFFERENT", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UserSession.UserData.Password = Encrypt.EncryptData(TxtNewPassword.Text);
            new UserRepository().UpdateUserPassword(UserSession.UserData);
            MessageBox.Show("PASSWORD HAS BEEN CHANGED SUCESSFULLY", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }
    }
}

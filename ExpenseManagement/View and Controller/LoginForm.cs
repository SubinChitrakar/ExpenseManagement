using ExpenseManagement.Model;
using ExpenseManagement.Repository;
using ExpenseManagement.Utilities;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace ExpenseManagement
{
    public partial class LoginForm : MaterialForm
    {
        private UserRepository _userRepository;
        private MessageStatus _messageStatus;
        private User _user;

        private readonly MaterialSkinManager _materialSkinManager;

        public LoginForm()
        {   
            InitializeComponent();
            _materialSkinManager = DesignSettings.GetDesign();
            _materialSkinManager.AddFormToManage(this);

            UserSession.ParentForm.Hide();
            _userRepository = new UserRepository();
            _messageStatus = new MessageStatus();
        }

        /*
         * Form Close
         */
        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            UserSession.ParentForm.Dispose();
        }

        /*
         * Login Form
         */
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = TxtUsernameLogin.Text;
            string password = TxtPasswordLogin.Text;

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Please enter USERNAME", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter PASSWORD", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _user = _userRepository.VerifyUser(username, Encrypt.EncryptData(password));
            if (_user.Id > 0)
            {
                UserSession.UserData = _user;
                this.Dispose();
                UserSession.ParentForm.Activate();
                UserSession.ParentForm.Show();
            }
            else
            {
                DialogResult result = MessageBox.Show("USERNAME / PASSWORD Incorrect", "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Retry)
                {
                    TxtPasswordLogin.Text = "";
                }
                else
                {
                    this.Dispose();
                    UserSession.ParentForm.Dispose();
                }
            }
        }

        /*
         * Register User
         */
        private void BtnRegister_Click(object sender, EventArgs e)
        {
            //Assigning Values
            string firstName = TxtFirstName.Text;
            string lastName = TxtLastName.Text;
            string username = TxtUsername.Text;
            string password = TxtPassword.Text;
            string confirmPassword = TxtConfirmPassword.Text;

            //Checking all the Values
            if (string.IsNullOrWhiteSpace(firstName))
            {
                MessageBox.Show("Please enter FIRST NAME", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(lastName))
            {
                MessageBox.Show("Please enter LAST NAME", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Please enter USERNAME", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (username.Contains(" "))
            {
                MessageBox.Show("USERNAME should not contain SPACES", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _user = _userRepository.GetUserFromUsername(username);
            if (_user.Id > 0)
            {
                MessageBox.Show("USERNAME Already Taken", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter PASSWORD", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!Validator.ValidatePassword(password))
            {
                MessageBox.Show("PASSWORD should be atleast 6 characters long and must contain One Uppercase, Lowercase and Special Character", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Please enter CONFIRM PASSWORD", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (password != confirmPassword)
            {
                MessageBox.Show("PASSWORD and CONFIRM PASSWORD are DIFFERENT", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Creating Object
            User newUser = new User
            {
                FirstName = firstName,
                LastName = lastName,
                UserName = username,
                Password = Encrypt.EncryptData(confirmPassword)
            };

            //Adding User
            _messageStatus = _userRepository.AddUser(newUser);
            if (_messageStatus.ErrorStatus)
            {
                DialogResult result = MessageBox.Show(_messageStatus.Message, "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Cancel)
                {
                    this.Dispose();
                    UserSession.ParentForm.Dispose();
                }
            }
            else
            {
                TxtFirstName.Text = "";
                TxtLastName.Text = "";
                TxtUsername.Text = "";
                TxtPassword.Text = "";
                TxtConfirmPassword.Text = "";
                MessageBox.Show(_messageStatus.Message, "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

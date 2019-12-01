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
        private UserRepository userRepository;
        private MessageStatus messageStatus;
        private User user;

        private readonly MaterialSkinManager materialSkinManager;

        public LoginForm()
        {   
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            UserSession.ParentForm.Hide();
            userRepository = new UserRepository();
            messageStatus = new MessageStatus();
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
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsernameLogin.Text;
            string password = txtPasswordLogin.Text;

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

            user = userRepository.GetUserFromUsername(username);
            bool status = false;
            if (user.Id > 0)
            {
                status = user.Password.Equals(Encrypt.EncryptData(password));
            }

            if (status)
            {
                UserSession.UserData = user;
                this.Dispose();
                UserSession.ParentForm.Activate();
                UserSession.ParentForm.Show();
            }
            else
            {
                DialogResult result = MessageBox.Show("USERNAME / PASSWORD Incorrect", "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Retry)
                {
                    txtPasswordLogin.Text = "";
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
        private void btnRegister_Click(object sender, EventArgs e)
        {
            //Assigning Values
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

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

            user = userRepository.GetUserFromUsername(username);
            if (user.Id > 0)
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
            messageStatus = userRepository.AddUser(newUser);
            if (messageStatus.ErrorStatus)
            {
                DialogResult result = MessageBox.Show(messageStatus.Message, "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Cancel)
                {
                    this.Dispose();
                    UserSession.ParentForm.Dispose();
                }
            }
            else
            {
                txtFirstName.Text = "";
                txtLastName.Text = "";
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtConfirmPassword.Text = "";
                MessageBox.Show("USER Sucessfully Registered", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

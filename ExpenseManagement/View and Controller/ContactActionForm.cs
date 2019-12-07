using ExpenseManagement.Model;
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
            _materialSkinManager = MaterialSkinManager.Instance;
            _materialSkinManager.AddFormToManage(this);
            _materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            _materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
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

            _contact.Name = contactName;
            BtnContactAction.Enabled = false;
            _contact.UserId = UserSession.UserData.Id;
            if (_contact.Id > 0)
            {
                messageStatus = await Task.Run(() => contactRepository.UpdateContact(_contact));
            }
            else
            {
                messageStatus = await Task.Run(() => contactRepository.AddContact(_contact));
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

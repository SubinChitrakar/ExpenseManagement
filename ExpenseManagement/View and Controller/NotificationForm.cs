using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseManagement.View_and_Controller
{
    public partial class NotificationForm : Form
    {
        public NotificationForm(string message)
        {
            InitializeComponent();

            StartPosition = FormStartPosition.Manual;
            Rectangle size = Screen.PrimaryScreen.WorkingArea;
            Location = new Point(size.Width - Width - 10, size.Height - Height - 10);

            LblMessage.Text = message;

            NotificationBackground.RunWorkerAsync();
        }

        private void WaitDoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(5000);
        }

        private void WaitCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Dispose();
        }
    }
}
    
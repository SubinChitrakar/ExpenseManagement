using ExpenseManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseManagement.Utilities
{
    public static class UserSession
    {
        public static Form ParentForm;
        public static User UserData = null;
        public static bool signIn = false;
    }
}

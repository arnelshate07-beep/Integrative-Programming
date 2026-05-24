using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierApplication
{
    public static class Program
    {
        public static string CurrentUserId = "Arnel";
        public static string CurrentPassword = "password123";
        public static string CurrentUserName = "Arnel Hate";

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }
    }
}
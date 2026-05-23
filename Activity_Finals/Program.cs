using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Activity_Finals;


namespace Activity_Finals
{
    internal static class Program
    {
        public static string CurrentUserId = "admin";
        public static string CurrentPassword = "admin123";
        public static string CurrentAdminName = "Hate";

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

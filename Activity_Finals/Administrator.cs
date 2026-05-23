using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;

namespace Activity_Finals
{
    public class Administrator : Users
    {
        private string admin_name;

        public Administrator(string name, string id, string pass)
            : base(id, pass)
        {
            admin_name = name;
        }

        public void updateAdminName(string name)
        {
            admin_name = name;
            Program.CurrentAdminName = name;
        }

        public string GetAdminName()
        {
            return admin_name;
        }
    }
}


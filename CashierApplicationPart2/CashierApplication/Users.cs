using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApplication
{
    public class Users
    {
        private string user_Id;
        protected string user_Password;

        public Users(string user, string pass)
        {
            this.user_Id = user;
            this.user_Password = pass;
        }

        public bool verifyLogin(string Id, string pass)
        {
            return user_Id.Equals(Id) && user_Password.Equals(pass);
        }

        public string GetUserId()
        {
            return user_Id;
        }
    }
}
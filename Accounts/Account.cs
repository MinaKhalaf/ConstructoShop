using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts
{
    public class Account
    {
        private string[] Accounts = { "admin", "admin" };
        static void Main(string[] args)
        {
            //bool w =Fn_ValidateUser("admin", "admin");
        }
        public bool Fn_ValidateUser(string User,string Pass)
        {

            if (Accounts[0] == User && Accounts[1] == Pass)
            {
                return true;
            }
            else return false;
         
        }
    }
}

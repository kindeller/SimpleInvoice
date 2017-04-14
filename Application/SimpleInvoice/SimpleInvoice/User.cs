using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInvoice
{
    public class User
    {
        private string username, password;
        public User(string un, string pw)
        {
            username = un;
            password = pw;
        }

        public string getUsername()
        {
            return username;
        }

        public bool checkPassword(string pw)
        {
            if (pw == password)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}

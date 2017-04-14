using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleInvoice
{
    public partial class Login : Form
    {
        List<User> Users = new List<User>();
        public Login()
        {
            InitializeComponent();
            Users.Add(new User("lister", "1234"));

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (findUser(txtUsername.Text))
            {
                if (checkPassword(txtUsername.Text, txtPassword.Text))
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Incorrect Password!");
                }
            }
            else
            {
                MessageBox.Show("No User found!");
            }
        }

        private bool findUser(string user)
        {
            bool found = false;
            foreach (User u in Users)
            {
                if(u.getUsername() == user)
                {
                    found = true;
                }
            }
            return found;
        }

        private bool checkPassword(string user, string pw)
        {
            bool correct = false;
            foreach (User u in Users)
            {
                if (u.getUsername() == user)
                {
                    if (u.checkPassword(pw))
                    {
                        correct = true;
                    }
                    else
                    {
                        correct = false;
                    }
                }
            }
            return correct;
        }

    }
}

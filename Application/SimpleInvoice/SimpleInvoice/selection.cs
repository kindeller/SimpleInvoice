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
    public partial class Selection : Form
    {

        Form1 mainform;
        List<Customer> customersList;

        public Selection()
        {
            InitializeComponent();
        }

        public void updateInterface(string title, List<Customer> customers, Form1 form)
        {
            labelTitle.Text = title;
            mainform = form;
            customersList = customers;

            for (int i = 0; i < customersList.Count; i++)
            {
                string listString;
                listString = $"{i}: {customersList[i].FirstName} {customersList[i].LastName}";
                listItems.Items.Add(listString);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {

            //MessageBox.Show(listItems.SelectedItem.ToString());
            string[] splitItems;
            splitItems = listItems.SelectedItem.ToString().Split(':');
            mainform.setCurrentCustomer(customersList[int.Parse(splitItems[0])]);
            this.Close();
            
        }
    }
}

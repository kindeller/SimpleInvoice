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
    public partial class Form1 : Form
    {
        //saved customer and invoices arrays
        Customer[] CustomerList = new Customer[1];
        Invoice[] InvoiceList = new Invoice[1];

        //displayed data
        Customer currentCustomer;
        List<Invoice> currentCustomerInvoices;
        Invoice currentInvoice;

        public Form1()
        {
            InitializeComponent();
            initData();
        }

        private void addCustomer(Customer customer)
        {
            growCustomerArray();
            //add customer in last slot;
            CustomerList[CustomerList.Length - 1] = customer;

        }


        private List<Customer> searchCustomerFirstName(string name)
        {
            List<Customer> foundCustomers = new List<Customer>();

            for (int index = 0; index < CustomerList.Length; index++)
            {
                if (CustomerList[index].FirstName.Contains(name))
                {
                    foundCustomers.Add(CustomerList[index]);
                }
            }
            return foundCustomers;
        }

        private List<Customer> searchCustomerLastName(string name)
        {
            List<Customer> foundCustomers = new List<Customer>();

            for (int index = 0; index < CustomerList.Length; index++)
            {
                if (CustomerList[index].LastName.Contains(name))
                {
                    foundCustomers.Add(CustomerList[index]);
                }
            }
            return foundCustomers;
        }

        private Customer searchCustomerID(int id)
        {
            Customer foundCustomer = new Customer();

            for (int index = 0; index < CustomerList.Length; index++)
            {
                if (CustomerList[index].CustomerID == id)
                {
                    foundCustomer = CustomerList[index];
                }
            }
            return foundCustomer;
        }

        private List<Invoice> searchCustomerInvoices(int customerID)
        {
            List<Invoice> invoices = new List<Invoice>();

            //loop through invoices
            foreach (Invoice inv in InvoiceList)
            {
                //find those that match customer id
                if (inv.CustomerID == customerID)
                {
                    //add to list
                    invoices.Add(inv);
                }
            }
            //return list
            return invoices;
        }

        private Invoice searchCustomerInvoiceID(int invoiceID)
        {
            Invoice foundInvoice = new Invoice();

            //loop through invoices
            foreach (Invoice inv in InvoiceList)
            {
                //find those that match customer id
                if (inv.InvoiceID == invoiceID)
                {
                    //add to list
                    foundInvoice = inv;
                }
            }
            //return list
            return foundInvoice;
        }

        public void setCurrentCustomer(Customer cust)
        {
            currentCustomer = cust;
            updateCustomer();
        }

        private void updateCustomer()
        {
            clearInput();
            txtCustomerNumber.Text = currentCustomer.CustomerID.ToString();
            txtCustomerFirstName.Text = currentCustomer.FirstName;
            txtCustomerLastName.Text = currentCustomer.LastName;
            txtCustomerContact.Text = currentCustomer.ContactNumber.ToString();
            txtCustomerAddress.Text = currentCustomer.Address;
            updateCustomerInvoiceList();
        }

        private void clearInput()
        {
            listCustomerInvoices.Items.Clear();
            listInvoiceItems.Items.Clear();
            txtCustomerAddress.Text = "";
            txtCustomerContact.Text = "";
            txtCustomerFirstName.Text = "";
            txtCustomerLastName.Text = "";
            txtCustomerNumber.Text = "";
            txtInvoiceNumber.Text = "";
            txtInvoiceTotal.Text = "";
            datePayment.Text = "";
        }

        public void updateCustomerInvoiceList()
        {
            currentCustomerInvoices = searchCustomerInvoices(currentCustomer.CustomerID);
            if(currentCustomerInvoices.Count > 0)
            {
                foreach (Invoice inv in currentCustomerInvoices)
                {
                    string str = $"{inv.InvoiceID}: - Total Cost: {inv.TotalCost} - Date: {inv.PaymentDate.ToString()}";
                    listCustomerInvoices.Items.Add(str);
                }
            }

        }

        private void updateInvoice()
        {
            txtInvoiceNumber.Text = currentInvoice.InvoiceID.ToString();
            txtInvoiceTotal.Text = currentInvoice.TotalCost.ToString();
            datePayment.Value = currentInvoice.PaymentDate;
            foreach (string item in currentInvoice.Items)
            {
                listInvoiceItems.Items.Add(item);
            }
        }

        private void growCustomerArray()
        {
            //copy array
            Customer[] tempCustomerList = CustomerList;
            //resize
            CustomerList = new Customer[CustomerList.Length + 1];
            //readd values
            for(int id = 0; id < tempCustomerList.Length; id++)
            {
                CustomerList[id] = tempCustomerList[id];
            }
            
        }

        //iniitalise some data on load

        private void initData()
        {

            Customer cust = new Customer(1, "frank", "Underwood", 0800909090, "1 something way, Funkytown, awesome land");
            CustomerList[0] = cust;
            growCustomerArray();
            cust = new Customer(2, "frank", "sinatra", 0800909090, "1 something way, Funkytown, awesome land");
            CustomerList[1] = cust;

            Invoice inv = new Invoice(1, 1, 20.99, new DateTime(2017, 02, 20), new string[] { "Shampoo", "Apples", "AK-47" });
            InvoiceList[0] = inv;
        }

        //Menu Items

        private void goldToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            picBackground.Image = Properties.Resources.gold;
        }

        private void greenToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            picBackground.Image = Properties.Resources.green;
        }

        private void steelToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            picBackground.Image = Properties.Resources.steel;
        }




        //old menu items...it disappeared cant delete or breaks everything :S

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            picBackground.Image = Properties.Resources.green;
        }

        private void goldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            picBackground.Image = Properties.Resources.gold;
        }

        private void steelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            picBackground.Image = Properties.Resources.steel;
        }



        //Customer Functions

        private void btnCustomerAdd_Click(object sender, EventArgs e)
        {


            //create empty customer object
            Customer cust = new Customer();

            //get all inputs and assign to new customer
            cust.CustomerID = Customer.IDCounter;
            cust.FirstName = txtCustomerFirstName.Text;
            cust.LastName = txtCustomerLastName.Text;
            cust.ContactNumber = int.Parse(txtCustomerContact.Text);
            cust.Address = txtCustomerAddress.Text;

            //add this to array
            addCustomer(cust);

            //update current customer
            currentCustomer = cust;
            updateCustomer();

        }

        private void btnCustomerUpdate_Click(object sender, EventArgs e)
        {

        }


        //Invoice Functions

        private void btnInvoiceAdd_Click(object sender, EventArgs e)
        {
            //create empty invoice object
            Invoice inv = new Invoice();

            //assign values

            //add to list
        }

        private void btnInvoiceUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnCustomerSearchFirstName_Click(object sender, EventArgs e)
        {
            List<Customer> foundCustomers = new List<Customer>();
            foundCustomers = searchCustomerFirstName(txtCustomerFirstName.Text);

            if(foundCustomers.Count <= 1)
            {
                if (foundCustomers.Count < 1)
                {
                    MessageBox.Show("No Customers with that first name found!");
                }
                else
                {
                    currentCustomer = foundCustomers[0];
                    updateCustomer();
                }

            }
            else
            {
                Selection selectCustomer = new Selection();
                selectCustomer.updateInterface("Select a Customer", foundCustomers, this);
                selectCustomer.ShowDialog();
            }
            

        }

        private void btnCustomerSearchLastName_Click(object sender, EventArgs e)
        {
            List<Customer> foundCustomers = new List<Customer>();
            foundCustomers = searchCustomerLastName(txtCustomerLastName.Text);

            if (foundCustomers.Count <= 1)
            {
                if (foundCustomers.Count < 1)
                {
                    MessageBox.Show("No Customers with that last name found!");
                }
                else
                {
                    currentCustomer = foundCustomers[0];
                    updateCustomer();
                }
            }
            else
            {
                Selection selectCustomer = new Selection();
                selectCustomer.updateInterface("Select a Customer", foundCustomers, this);
                selectCustomer.ShowDialog();
            }
            
        }

        private void btnCustomerInvoicesShow_Click(object sender, EventArgs e)
        {
            string[] itemStings = listCustomerInvoices.SelectedItem.ToString().Split(':');
            currentInvoice = searchCustomerInvoiceID(int.Parse(itemStings[0]));
            updateInvoice();


        }

        private void btnCustomerSearchNumber_Click(object sender, EventArgs e)
        {
            Customer foundCustomer = new Customer();
            foundCustomer = searchCustomerID(int.Parse(txtCustomerNumber.Text));

                if (foundCustomer.FirstName == null)
                {
                    MessageBox.Show("No Customers matching that ID Found!");
                }
                else
                {
                    currentCustomer = foundCustomer;
                    updateCustomer();
                }

        }

        private void btnInvoiceSearchNumber_Click(object sender, EventArgs e)
        {
            currentInvoice = searchCustomerInvoiceID(int.Parse(txtInvoiceNumber.Text));
            updateInvoice();
            currentCustomer = searchCustomerID(currentInvoice.CustomerID);
            updateCustomer();
        }
    }
}

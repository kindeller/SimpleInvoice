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
    public partial class Main : Form
    {
        //saved customer and invoices arrays
        Customer[] CustomerList = new Customer[1];
        Invoice[] InvoiceList = new Invoice[1];

        //displayed data arrays
        Customer currentCustomer;
        List<Invoice> currentCustomerInvoices;
        Invoice currentInvoice;

        public Main()
        {
            InitializeComponent();
            //initialises some data for the form
            initData();
            //prompts login when loaded
            Login loginWindow = new Login();
            loginWindow.ShowDialog();

        }

        //custom functions to grow a static array when adding to
        private void addCustomer(Customer customer)
        {
            growCustomerArray();
            //add customer in last slot;
            CustomerList[CustomerList.Length - 1] = customer;

        }

        //custom functions to grow a static array when adding to
        private void addInvoice(Invoice inv)
        {
            growInvoiceArray();
            //add invoice in last slot;
            InvoiceList[InvoiceList.Length - 1] = inv;

        }

        //search for a customer by first name and return all matching customers
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

        //Search for a custmer by last name and return all matching customers
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

        //search for a customer via ID (as this is unique only one instance should return)
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

        //search for a custmers invoices and return all found.
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

        //called to set the current customer from another form
        public void setCurrentCustomer(Customer cust)
        {
            currentCustomer = cust;
            updateCustomer();
        }

        //Updates UI to customer info from current customer.
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

        //clears all input fields - called when changing customer etc
        private void clearInput()
        {
            listCustomerInvoices.Items.Clear();
            listboxInvoiceItems.Items.Clear();
            txtCustomerAddress.Text = "";
            txtCustomerContact.Text = "";
            txtCustomerFirstName.Text = "";
            txtCustomerLastName.Text = "";
            txtCustomerNumber.Text = "";
            txtInvoiceNumber.Text = "";
            txtInvoiceTotal.Text = "";
            datePayment.Text = "";
        }

        //called to update the customer invoice list with all invoices associated by customer ID
        public void updateCustomerInvoiceList()
        {
            //first clear of whatever is in it already
            listCustomerInvoices.Items.Clear();
            //search and assign the results
            currentCustomerInvoices = searchCustomerInvoices(currentCustomer.CustomerID);
            //validate results
            if(currentCustomerInvoices.Count > 0)
            {
                //loop through these
                foreach (Invoice inv in currentCustomerInvoices)
                {
                    //creating a string from the data to add to the invoice list
                    string str = $"{inv.InvoiceID}: - Total Cost: {inv.TotalCost} - Date: {inv.PaymentDate.ToString()}";
                    //add this string
                    listCustomerInvoices.Items.Add(str);
                }
            }

        }

        //called to update the UI to the current invoice details
        private void updateInvoice()
        {
            
            txtInvoiceNumber.Text = currentInvoice.InvoiceID.ToString();
            txtInvoiceTotal.Text = currentInvoice.TotalCost.ToString();
            datePayment.Value = currentInvoice.PaymentDate;
            listboxInvoiceItems.Items.Clear();
            foreach (string item in currentInvoice.Items)
            {
                listboxInvoiceItems.Items.Add(item);
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

        private void growInvoiceArray()
        {
            //copy array
            Invoice[] tempInvoiceList = InvoiceList;
            //resize
            InvoiceList = new Invoice[InvoiceList.Length + 1];
            //readd values
            for (int id = 0; id < tempInvoiceList.Length; id++)
            {
                InvoiceList[id] = tempInvoiceList[id];
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

            Invoice inv = new Invoice(1, 20.99, new DateTime(2017, 02, 20), new string[] { "Shampoo", "Apples", "AK-47" });
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

            if(txtCustomerFirstName.Text == "" || txtCustomerLastName.Text == "" || txtCustomerAddress.Text == "")
            {
                MessageBox.Show("Please ensure all fields are complete!");
            }
            else
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


        }

        private void btnCustomerUpdate_Click(object sender, EventArgs e)
        {
            if(currentCustomer != null)
            {
                currentCustomer.FirstName = txtCustomerFirstName.Text;
                currentCustomer.LastName = txtCustomerLastName.Text;
                currentCustomer.Address = txtCustomerAddress.Text;
                currentCustomer.ContactNumber = int.Parse(txtCustomerContact.Text);
            }
            else
            {
                MessageBox.Show("No Customer To update!");
            }

        }




        //Invoice Functions

        private void btnInvoiceAdd_Click(object sender, EventArgs e)
        {
            if(currentCustomer == null || currentCustomer.FirstName == "")
            {
                MessageBox.Show("Please Search or add a customer first!");
            }
            else
            {
                
                if(listboxInvoiceItems.Items.Count <= 0)
                {
                    MessageBox.Show("Please Add Items to the invoice");
                }
                else
                {
                    string[] invoiceItems = new string[listboxInvoiceItems.Items.Count];

                    for (int i = 0; i < listboxInvoiceItems.Items.Count; i++)
                    {
                        invoiceItems[i] = listboxInvoiceItems.Items[i].ToString();
                    }
                    
                    //create empty invoice object
                    Invoice inv = new Invoice(currentCustomer.CustomerID, double.Parse(txtInvoiceTotal.Text), datePayment.Value, invoiceItems);

                    //add to list
                    addInvoice(inv);
                    updateCustomerInvoiceList();
                }
            }
        }

        //called to edit an invoice details and save it to the array
        private void btnInvoiceUpdate_Click(object sender, EventArgs e)
        {
            //validation checks
            if(currentInvoice != null)
            {
                if(listboxInvoiceItems.Items.Count != 0)
                {
                    double p = 0;
                    if(!double.TryParse(txtInvoiceTotal.Text,out p))
                    {
                        //update invoice
                        currentInvoice.PaymentDate = datePayment.Value;
                        currentInvoice.TotalCost = double.Parse(txtInvoiceTotal.Text);

                        List<string> invoiceItems = new List<string>();
                        //loop through and assign items in list to the invoice items
                        for (int i = 0; i < listboxInvoiceItems.Items.Count; i++)
                        {
                            invoiceItems.Add(listboxInvoiceItems.Items[i].ToString());
                        }
                        //update this list to the invoice
                        currentInvoice.Items = invoiceItems;
                    }
                    else
                    {
                        MessageBox.Show("Please enter a numberical value!");
                    }

                }
                else
                {
                    MessageBox.Show("An Invoice must have items, add some below!");
                }

            }
            else
            {
                MessageBox.Show("No Invoice to update!");
            }

        }

        private void btnCustomerSearchFirstName_Click(object sender, EventArgs e)
        {
            //validation checks
            if(txtCustomerFirstName.Text != "")
            {
                //temp customer list
                List<Customer> foundCustomers = new List<Customer>();
                //assign from results
                foundCustomers = searchCustomerFirstName(txtCustomerFirstName.Text);

                //validate results
                if (foundCustomers.Count <= 1)
                {
                    if (foundCustomers.Count < 1)
                    {
                        MessageBox.Show("No Customers with that first name found!");
                    }
                    else
                    {
                        //single result, update 
                        currentCustomer = foundCustomers[0];
                        updateCustomer();
                    }

                }
                else
                {
                    //if multiple, create instance of selection form.
                    Selection selectCustomer = new Selection();
                    //assign its values and the customer list.
                    selectCustomer.updateInterface("Select a Customer", foundCustomers, this);
                    //show dialog to restrict use of second main invoice form.
                    selectCustomer.ShowDialog();
                }

            }
            else
            {
                MessageBox.Show("Please Enter a name!");
            }


        }

        private void btnCustomerSearchLastName_Click(object sender, EventArgs e)
        {
            //validation checks
            if(txtCustomerLastName.Text != "")
            {
                //temp customer list
                List<Customer> foundCustomers = new List<Customer>();
                //search for customers
                foundCustomers = searchCustomerLastName(txtCustomerLastName.Text);

                //validation on results
                if (foundCustomers.Count <= 1)
                {
                    if (foundCustomers.Count < 1)
                    {
                        MessageBox.Show("No Customers with that last name found!");
                    }
                    else
                    {
                        //otherwise update customer if only one is found
                        currentCustomer = foundCustomers[0];
                        updateCustomer();
                    }
                }
                else
                {
                    //if multiple, create instance of selection form.
                    Selection selectCustomer = new Selection();
                    //assign its values and the customer list.
                    selectCustomer.updateInterface("Select a Customer", foundCustomers, this);
                    //show dialog to restrict use of second main invoice form.
                    selectCustomer.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Please enter a name!");
            }

            
        }

        private void btnCustomerInvoicesShow_Click(object sender, EventArgs e)
        {
            //validation checks
            if(listCustomerInvoices.SelectedItem != null)
            {
                //create a temp list of string array and split text using :
                string[] itemStings = listCustomerInvoices.SelectedItem.ToString().Split(':');
                //search using the first index of string (should be customer invoice ID)
                currentInvoice = searchCustomerInvoiceID(int.Parse(itemStings[0]));
                //update fields with new current invoice.
                updateInvoice();
            }
            else
            {
                MessageBox.Show("No Invoices Selected!");
            }



        }

        private void btnCustomerSearchNumber_Click(object sender, EventArgs e)
        {
            //validation checks
            if(txtCustomerNumber.Text != "")
            {
                int i = 0;
                if (int.TryParse(txtCustomerNumber.Text,out i))
                {
                    //create new customer
                    Customer foundCustomer = new Customer();
                    //assign temp customer object
                    foundCustomer = searchCustomerID(int.Parse(txtCustomerNumber.Text));

                    //check if found by null checking
                    if (foundCustomer.FirstName == null)
                    {
                        MessageBox.Show("No Customers matching that ID Found!");
                    }
                    else
                    {
                        //otherwise update fields.
                        currentCustomer = foundCustomer;
                        updateCustomer();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Characters!");
                }
            }
            else
            {
                MessageBox.Show("Please input a value!");
            }

        }

        private void btnInvoiceSearchNumber_Click(object sender, EventArgs e)
        {

            if (txtInvoiceNumber.Text != "")
            {
                int i = 0;
                if (int.TryParse(txtInvoiceNumber.Text, out i))
                {
                    //try and assign the current invoice from value checked.
                    currentInvoice = searchCustomerInvoiceID(int.Parse(txtInvoiceNumber.Text));
                    //if the invoice Id is 0, its an empty version and so none was found.
                    if (currentInvoice.InvoiceID != 0)
                    {
                        //if it isnt, populate other fields and update accordingly.
                        currentCustomer = searchCustomerID(currentInvoice.CustomerID);
                        updateCustomer();
                        updateInvoice();
                    }
                    else
                    {
                        MessageBox.Show("No Invoice found with that ID!");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Characters!");
                }
            }
            else
            {
                MessageBox.Show("Please input a value!");
            }



        }

        private void btnInvoiceAddItem_Click(object sender, EventArgs e)
        {
            //validation checks
            if(currentCustomer != null || currentInvoice != null)
            {
                //if somethings selected
                if(comboInvoiceItems.SelectedItem != null)
                {
                    //add the item
                    listboxInvoiceItems.Items.Add(comboInvoiceItems.SelectedItem);
                }
                else
                {
                    MessageBox.Show("No Item Selected!");
                }
                
            }
            else
            {
                MessageBox.Show("Please create or select a customer first!");
            }
            
            
        }

        private void btnRemoveInvoiceItem_Click(object sender, EventArgs e)
        {
            listboxInvoiceItems.Items.Remove(listboxInvoiceItems.SelectedItem); 
        }

        private void btnRemoveAllInvoiceItems_Click(object sender, EventArgs e)
        {
            listboxInvoiceItems.Items.Clear();
        }

        private void exitToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

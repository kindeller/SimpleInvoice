using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInvoice
{
    public class Invoice
    {

        public Invoice() { }

        //constructor
        public Invoice(int id, int custID, double total, DateTime pay, string[] items)
        {
            InvoiceID = id;
            CustomerID = custID;
            TotalCost = total;
            PaymentDate = pay;
            Items = items;
        }

        //properties
        public int InvoiceID { get; set; }
        public int CustomerID { get; set; }
        public double TotalCost { get; set; }
        public DateTime PaymentDate { get; set; }
        public string[] Items { get; set; }

        public void addItem(string item)
        {
            GrowItemsArray();

            Items[Items.Length - 1] = item;

        }

        private void GrowItemsArray()
        {
            //copy array
            string[] tempItemsList = Items;
            //resize
            Items = new string[Items.Length + 1];
            //readd values
            for (int id = 0; id < tempItemsList.Length; id++)
            {
                Items[id] = tempItemsList[id];
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInvoice
{
    public class Invoice
    {
        public static int IDCounter = 1;

        public Invoice() { }

        //constructor
        public Invoice(int custID, double total, DateTime pay, string[] items)
        {
            InvoiceID = IDCounter;
            CustomerID = custID;
            TotalCost = total;
            PaymentDate = pay;
            Items = new List<string>();
            foreach (string item in items)
            {
                Items.Add(item);
            }
            IDCounter++;
        }

        //properties
        public int InvoiceID { get; set; }
        public int CustomerID { get; set; }
        public double TotalCost { get; set; }
        public DateTime PaymentDate { get; set; }
        public List<string> Items { get; set; }

        public void addItem(string item)
        {
            Items.Add(item);
        }

        public void removeItem(string item)
        {
            Items.Remove(item);
        }

    }
}

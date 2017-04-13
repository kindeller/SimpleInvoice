using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInvoice
{
    class Invoice
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

        }

    }
}

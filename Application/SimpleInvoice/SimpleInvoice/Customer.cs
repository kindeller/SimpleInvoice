using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInvoice
{
    class Customer
    {

        public Customer() { }

        //contstructor
        public Customer(int id, string fn, string ln, int cont, string[] add)
        {
            CustomerID = id;
            FirstName = fn;
            LastName = ln;
            ContactNumber = cont;
            Address = add;
        }

        //properties
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ContactNumber { get; set; }
        public string[] Address { get; set; }

    }
}

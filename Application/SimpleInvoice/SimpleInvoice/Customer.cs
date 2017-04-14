using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInvoice
{

    public class Customer
    {

        public static int IDCounter = 0;

        public Customer() { IDCounter++; }

        //contstructor
        public Customer(int id, string fn, string ln, int cont, string add)
        {
            CustomerID = id;
            FirstName = fn;
            LastName = ln;
            ContactNumber = cont;
            Address = add;
            IDCounter++;
        }

        //properties
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ContactNumber { get; set; }
        public string Address { get; set; }

    }
}

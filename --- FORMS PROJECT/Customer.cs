using System;
using System.Collections.Generic;
// Ethan Sylvester 101479568 | Amanda Gurney 101443253 | Taylor Martin 100849882
// Group MA1 22 | Assignment 2
// COMP 2129 | CRN: 15646

using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Group22_Project
{
    internal class Customer
    {
        public static int customerIDRef = 1;
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public int NumOfBookings { get; set; }


        // Constructor
        public Customer(string fname, string lname, string phone)
        {

            FirstName = fname;
            LastName = lname;
            PhoneNumber = phone;
            NumOfBookings = 1;
            customerIDRef++;
            CustomerID = customerIDRef;
        }

        // Set customerID automatically.
        public void IncrementBookings()
        {
            NumOfBookings++;
        }

        public override string ToString()
        {
            return $"   -- Customer ID: {CustomerID}  |  Name: {FirstName} {LastName}  |  Phone: {PhoneNumber}  |  Number Of Bookings: {NumOfBookings}";
        }


    }
}

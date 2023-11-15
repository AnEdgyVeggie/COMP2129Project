using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group
{
    internal class Customer
    {
        private int customerID;
        private string firstName;
        private string lastName;
        private string phone;
        private int numOfBookings;

        // Constructor
        public Customer(string fname, string lname, string phone, int bookings)
        {
            customerID = createCustomerID();
            firstName = fname;
            lastName = lname;
            this.phone = phone;
            numOfBookings = bookings;
        }

        // Set customerID automatically.

        private int createCustomerID()
        {
            Random rnd = new Random();
            int generatedID = rnd.Next(1, 9999);

            return generatedID;
        }

        // Accessors
        public int getCustomerID()
        {
            return customerID;
        }
        public void setCustomerID(int id)
        {
                customerID = id;
        }

        public string getFirstName()
        {
            return firstName;
        }
        public void setFirstName(string fName)
        {
            firstName = fName;
        }

        public string getLastName()
        {
            return lastName;
        }
        public void setLastName(string lName)
        {
            lastName = lName;
        }

        public string getPhone()
        {
            return phone;
        }
        public void setPhone(string phone)
        {
            this.phone = phone;
        }

        public int getNumOfBookings()
        {
            return numOfBookings;
        }
        public void setNumOfBookings(int bookings)
        {
            numOfBookings = bookings;
        }
    }
}

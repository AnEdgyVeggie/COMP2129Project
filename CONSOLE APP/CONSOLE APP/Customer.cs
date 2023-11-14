using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSOLE_APP
{
    internal class Customer
    {
        public int ID {  get; set; }
        private string firstName;
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
      

        private int numberOfBookings = 0;


        public Customer(int id, string firstName, string lastName, string phoneNumber) { 
            ID = id;
            this.firstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            numberOfBookings++;
        }


        public override string ToString()
        {
            return this.firstName;
        }
    }
}

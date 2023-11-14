using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSOLE_APP
{
    internal class Flight
    {
        // This variable should increment with every instance, and then
        // the flight number is copied from the reference so that it is automatically
        // a unique ID
        public static int FlightNumberRef = 1000;
        public int FlightNumber;

        private Customer[] customersList = new Customer[10]; 


        public Flight()
        {
            FlightNumberRef++;
            FlightNumber = FlightNumberRef;
        }


        // This function handles extending the array 5 customers at a time to reduce
        // memory use while also not using a ton of resources to copy the array repeatedly
        public void AddCustomer(Customer passenger)
        {
            bool extendArray = true;
            for (int i = 0; i < customersList.Length; i++) {
                if (customersList[i] == null)
                {
                    extendArray = false;
                    customersList[i] = passenger;
                    break;

                }
            }
            if (extendArray)
            {
                Customer[] tempArray = new Customer[customersList.Length + 5];
                for (int i = 0; i < customersList.Length; i++) {
                    tempArray[i] = customersList[i];
                }
                customersList = tempArray;
                Console.WriteLine("+++++  ARRAY EXTENDED +++++");
            }
        }

        public string ToString()
        {
            string returnString = "";
            foreach (Customer customer in customersList)
            {
                returnString += customer.ToString();
            }
            return returnString;
        }
        public int CustomerListLength()
        {
            return customersList.Length; 
        }
    }
}

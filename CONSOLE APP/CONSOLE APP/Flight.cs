using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSOLE_APP
{
    internal class Flight
    {
        public static int FlightNumberRef = 1000;
        public int FlightNumber { get; }
        public int MaxPassengers { get; set; }

        private Customer[] customersList = new Customer[10]; 


        public Flight(int maxPassengers)
        {
            // FlightNumberRef should increment with every instance, and then
            // the flight number is taken from the value so that it is automatically
            // a unique 4 digit ID
            FlightNumberRef++;

            FlightNumber = FlightNumberRef;
            MaxPassengers = maxPassengers;
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
                if (customersList.Length == MaxPassengers)
                {
                    Console.WriteLine("MAXIMUM PASSENGER LIMIT HAS BEEN REACHED.");
                    Console.WriteLine("PLEASE TRY ANOTHER FLIGHT.");
                    return;
                }
                else if (customersList.Length + 5 > MaxPassengers)
                {
                    int growth = MaxPassengers - customersList.Length;

                    Customer[] tempArray = new Customer[customersList.Length + growth];
                    for (int i = 0; i < customersList.Length; i++)
                    {
                        tempArray[i] = customersList[i];
                    }
                    customersList = tempArray;
                }
                else
                {
                    Customer[] tempArray = new Customer[customersList.Length + 5];
                    for (int i = 0; i < customersList.Length; i++)
                    {
                        tempArray[i] = customersList[i];
                    }
                    customersList = tempArray;
                }
                Console.WriteLine("+++++  ARRAY EXTENDED +++++");

            }
        }

        public string ToString()
        {
            return $"                  Flight Number: {FlightNumber}.                 \n" +
                $"           Number of Passengers: {GetPassengerCount()} out of {MaxPassengers}          ";
        }
        public int CustomerListLength()
        {
            return customersList.Length; 
        }

        private int GetPassengerCount()
        {
            int count = 0;
            foreach (Customer customer in customersList)
            {
                if (customer != null)
                {
                    count++;
                }
            }
            return count;
        }
    }
}

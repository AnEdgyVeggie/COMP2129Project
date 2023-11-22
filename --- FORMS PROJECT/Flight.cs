using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group22_Project
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

            for (int i = 0; i < customersList.Length; i++)
            {
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
                    // MAX CUSTOMERS ACHIEVED. PRINT RESULT. NO MORE CUSTOMERS ALLOWED
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

            }
        }

        public string ToString()
        {
            string returnString = $"Flight Number: {FlightNumber}:       Number of Passengers: {GetPassengerCount()} out of {MaxPassengers}\n";
            foreach (Customer customer in customersList)
            {
                if (customer !=  null)
                    returnString += customer.ToString() + "\n";
            }
            return returnString;
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

        public void LoadExampleFlight()
        {
            AddCustomer(new Customer("Ethan", "Sylvester", "(123)-456-7890"));
            AddCustomer(new Customer("Amanda", "Gurney", "(098)-765-4321"));
            AddCustomer(new Customer("Taylor", "Martin", "(555)-123-4567"));
            AddCustomer(new Customer("Houman", "Haji", "(555)-987-6541"));
            AddCustomer(new Customer("Andrew", "Rudder", "(555)-654-9874"));
            for (int i = 0; i < 10; i++)
            {
                customersList[0].IncrementBookings();
                if (i > 9) { customersList[1].IncrementBookings(); }
                if (i > 7) { customersList[2].IncrementBookings(); }
                if (i > 3) { customersList[3].IncrementBookings(); }
                if (i > 4) { customersList[4].IncrementBookings(); }
            }
        }

    }
}

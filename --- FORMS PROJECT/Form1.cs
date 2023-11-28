// Ethan Sylvester 101479568 | Amanda Gurney 101443253 | Taylor Martin 100849882
// Group MA1 22 | Assignment 2
// COMP 2129 | CRN: 15646

using System.Diagnostics.Eventing.Reader;
using System.Runtime.ExceptionServices;
using System.Text.RegularExpressions;

namespace Group22_Project
{
    public partial class Form1 : Form
    {
        // Preloaded example flights
        Flight[]? flights = new Flight[] {
            new Flight(12),
            new Flight(10),
            new Flight(2),
            new Flight(132),
            new Flight(56),
        };

        List<Customer?> customersList = new List<Customer>();  // this is going to work as a pseudo customers database


        private void InitializeProgram() // This function initializes flights to preload customers into one of the flights.
        {
            SetExampleData(); // For demoing software only, disable in enterprise edition
        }


        public Form1()
        {
            InitializeComponent();
            InitializeProgram();
        }

        private void button1_Click(object sender, EventArgs e) // DisplayFlightsBtn
        {
            ResultsList.Clear();

            String[] flightList;
            bool flightFound = false;
            if (AllFlightsCheckBox.Checked)
            {
                foreach (Flight flight in flights)
                {
                    if (flight != null)
                    {
                        ResultsList.Text += flight.ToString() + "\n";
                        flightFound = true;
                    }
                }
                if (!flightFound)
                {
                    ResultsList.Text = "There are no flights recorded currently.";
                }
            }
            else
            {

                flightList = FlightList.Text.Split(",");

                if (flightList.Length > 0)
                {
                    for (int i = 0; i < flightList.Length; i++)
                    {
                        flightFound = false;
                        foreach (Flight flight in flights)
                        {
                            if (flight != null)
                            {
                                if (flightList[i].Trim() == flight.FlightNumber.ToString())
                                {
                                    ResultsList.Text += flight.ToString() + "\n";
                                    flightFound = true;
                                    break;
                                }
                            }

                        }
                        if (!flightFound)
                        {
                            ResultsList.Text += $"Flight {flightList[i].Trim()} is not a recorded flight.\n";
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e) // Add Flight
        {
            ResultsList.Clear();
            int maxPass = 0;
            try
            {
                maxPass = int.Parse(MaxPassText.Text);
            }
            catch
            {
                ResultsList.Text = "Please enter only an integer";
                return;
            }
            if (int.Parse(MaxPassText.Text) <= 0)
            {
                ResultsList.Text = "Please enter an integer greater than zero";
                return;
            }

            Flight newFlight = new Flight(maxPass);
            int totalFlights = 0;
            for (int i = 0; i < flights.Length; i++)
            {
                if (flights[i] == null)
                {
                    flights[i] = newFlight;
                    break;
                }

                if (i == flights.Length - 1)
                {

                    ExtendFlights();
                }
            }
            foreach (Flight flight in flights)
            {
                if (flight != null) totalFlights++;
            }

            ResultsList.Text = $"New Flight Created Successfully. \nFlight number: {newFlight.FlightNumber}. \nMax Passengers: {maxPass} \nTotal number of active flights: {totalFlights}";

        }

        private void button3_Click(object sender, EventArgs e) // Delete Flight
        {
            int deleteNum = 0;
            try
            {
                deleteNum = int.Parse(DelFlightText.Text);
            }
            catch
            {
                ResultsList.Text = "Please enter an integer only! Flight numbers do not contain letters or symbols.";
            }

            // cycle through array
            for (int i = 0; i < flights.Length; i++)
            {
                if (flights[i] != null) // null values will not have a flightnumber and cause crash
                {                       // so they need to be skipped
                    if (flights[i].FlightNumber == deleteNum)
                    {
                        if (flights[i].GetPassengerCount() > 0)
                        {
                            ResultsList.Text = $"Flight {deleteNum} currently has passengers. Can not delete a flight if it has passengers!";
                            return;
                        }

                        flights[i] = null;
                        ResultsList.Text = $"Flight {deleteNum} deleted successfully!";
                        return;
                    }
                }
            }

            ResultsList.Text = $"Deletion Failed! Flight {deleteNum} is not in the system.";

        }

        private void button4_Click(object sender, EventArgs e) // Add Passenger
        {
            bool activeFlights = false;
            for (int i = 0; i < flights.Length; i++)
            {
                if (flights[i] != null)
                {
                    activeFlights = true;
                    break;
                }
            }
            if (!activeFlights)
            {
                ResultsList.Text = "There are currently no flights to add customers to.";
                return;
            }

            Flight? selectedFlight = null;

            string flightString = AddCustFlightNumText.Text;


            int flightNumber = 0;

            int.TryParse(flightString, out flightNumber);


            foreach (Flight flight in flights)
            {
                if (flight != null)
                {
                    if (flight.FlightNumber == flightNumber)
                        selectedFlight = flight;
                }

            }
            Customer?[] tempFlight = null;
            if (selectedFlight != null)
            {
                tempFlight = selectedFlight.GetCustomerArray();
            }

            string firstName = "", lastName = "", phone = "", bookingString = "";


            firstName = AddCustFNameText.Text;

            lastName = AddCustLNameText.Text;

            phone = AddCustPhoneText.Text;

            Regex nameReg = new Regex("^[a-zA-Z'-]*$");
            Regex phoneReg = new Regex("^[0-9]{10}$");

            if (firstName == "" || lastName == "")
            {
                ResultsList.Text = "Please enter a name into both name fields";
                return;
            }
            else if (!nameReg.IsMatch(firstName) || !nameReg.IsMatch(lastName))
            {
                ResultsList.Text = "Names can only contain Letters and certain symbols (' and -)";
                return;
            }
            if (phone == "" || !phoneReg.IsMatch(phone))
            {
                ResultsList.Text = "Please enter a phone number (10 digits only, no symbols)";
                return;
            }

            Customer tryCustomer = (new Customer(firstName, lastName, PhoneNumberFormatter(phone)));



            for (int i = 0; i < customersList.Count; i++)
            {
                if (customersList[i] == null) continue;

                if (tryCustomer.FirstName == customersList[i].FirstName && tryCustomer.LastName == customersList[i].LastName)
                {
                    foreach (Customer cust in tempFlight)
                    {
                        if (cust != null && cust.FirstName == tryCustomer.FirstName && cust.LastName == tryCustomer.LastName)
                        {
                            ResultsList.Text = $"{firstName} {lastName} has already been added to this flight";
                            return;
                        }
                    }

                    customersList[i].IncrementBookings();
                    selectedFlight.AddCustomer(customersList[i]);
                    ResultsList.Text = $"{customersList[i].FirstName} {customersList[i].LastName} was successfully added to flight {selectedFlight.FlightNumber}\n" +
                    $"Nice to see you back, enjoy your flight.";
                    return;
                }
            }

            if (flightNumber != 0)
            {
                customersList.Add(tryCustomer);
                selectedFlight.AddCustomer(tryCustomer);
                ResultsList.Text = $"{firstName} {lastName} was successfully added to flight {selectedFlight.FlightNumber}";
            } else
            {
                customersList.Add(tryCustomer);
                ResultsList.Text = $"{firstName} {lastName} was successfully added to the customers database";
            }
            
        }

        private void ResultsList_TextChanged(object sender, EventArgs e) // Results
        {

        }

        private void ListCustomerBtn_Click(object sender, EventArgs e) // list customers
        {
            ResultsList.Clear();
            foreach (Customer cust in customersList)
            {
                if (cust == null) continue;
                ResultsList.Text += $"{cust.CustomerID} -- {cust.FirstName} {cust.LastName} -- {cust.PhoneNumber}\n";
            }
        }

        private void delCustomerBtn_Click(object sender, EventArgs e) // delete customer
        {
            int customerID = 0;
            try
            {
                customerID = int.Parse(customerIDbox.Text);
            }
            catch
            {
                ResultsList.Text = "Please enter only an integer into the Customer ID box.";
            }
            for (int i = 0; i < customersList.Count; i++)
            {
                if (customersList[i] != null)
                {
                    if (customersList[i].CustomerID == customerID)
                    {
                        if (SearchFlights(customersList[i]))
                        {
                            ResultsList.Text = "Can not delete customers who are on an active flight!";
                            return;

                        }
                        else
                        {
                            ResultsList.Text = $"{customersList[i].FirstName} {customersList[i].LastName} -- ID: {customersList[i].CustomerID} has been removed from the system";
                            customersList[i] = null;
                            return;
                        }
                    }
                }
            }
            ResultsList.Text = "The customer you are searching for could not be found. Please check the identification number.";
        }


 /*
         ||||||||||||||||||||||||||
         ||| NON-FORM FUNCTIONS |||
         ||||||||||||||||||||||||||
 */
        public void SetExampleData()
        {
            // presetting 5 names into the 'customers database'
            customersList.Add(new Customer("Ethan", "Sylvester", "(123)-456-7890"));
            customersList.Add(new Customer("Amanda", "Gurney", "(098)-765-4321"));
            customersList.Add(new Customer("Taylor", "Martin", "(555)-123-4567"));
            customersList.Add(new Customer("Houman", "Haji", "(555)-987-6541"));
            customersList.Add(new Customer("Andrew", "Rudder", "(555)-654-9874"));

            // presetting 1 flight with 5 customers
            for (int i = 0; i < 3; i++)
            {
                flights[0].AddCustomer(customersList[i]);
            }

            // randomly setting the customers booking numbers so that data isnt just one's
            for (int i = 0; i < 10; i++)
            {
                customersList[0].IncrementBookings();
                if (i > 9) { customersList[1].IncrementBookings(); }
                if (i > 7) { customersList[2].IncrementBookings(); }
                if (i > 3) { customersList[3].IncrementBookings(); }
                if (i > 4) { customersList[4].IncrementBookings(); }
            }
        }


        private bool SearchFlights(Customer cust)
        {
            foreach (Flight flight in flights)
            {
                foreach (Customer customer in flight.GetCustomerArray())
                {
                    if (customer == null) continue;
                    if (customer.CustomerID == cust.CustomerID)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        // Only for formatting strings into a nicer phone-number format
        private string PhoneNumberFormatter(string number)
        {
            string first = "", second = "", third = "";
            for (int i = 0; i < number.Length; i++)
            {
                if (i <= 2) first += number[i];
                else if (i > 2 && i < 6) second += number[i];
                else third += number[i];
            }
            return $"({first})-{second}-{third}";
        }


        void ExtendFlights()
        {
            Flight[] tempFlights = new Flight[flights.Length + 5];
            for (int i = 0; i < flights.Length; i++)
            {
                tempFlights[i] = flights[i];
            }
            flights = tempFlights;
        }
    }
}
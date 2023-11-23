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



        private void InitializeProgram() // This function initializes flights to preload customers into one of the flights.
        {
            flights[0].LoadExampleFlight();
        }


        public Form1()
        {
            InitializeComponent();
            InitializeProgram();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

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
                maxPass = Int32.Parse(MaxPassText.Text);
            }
            catch
            {
                ResultsList.Text = "Please enter only an integer";
                return;
            }
            if (Int32.Parse(MaxPassText.Text) <= 0)
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
                deleteNum = Int32.Parse(DelFlightText.Text);
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

            try
            {
                flightNumber = Int32.Parse(flightString);
            }
            catch
            {
                ResultsList.Text = "Please enter a recorded flight only";
            }

            foreach (Flight flight in flights)
            {
                if (flight != null)
                {
                    if (flight.FlightNumber == flightNumber)
                        selectedFlight = flight;
                }

            }
            if (selectedFlight == null)
            {
                ResultsList.Text = "There was no flight matching this flight number.";
                return;
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
            } else if (!nameReg.IsMatch(firstName) || !nameReg.IsMatch(lastName)) {
                ResultsList.Text = "Names can only contain Letters and certain symbols (' and -)";
                return;
            }
            if (phone == "" || !phoneReg.IsMatch(phone))
            {
                ResultsList.Text = "Please enter a phone number (10 digits only, no symbols)";
                return;
            }

            
            selectedFlight.AddCustomer(new Customer(firstName, lastName, PhoneNumberFormatter(phone)));

            ResultsList.Text = $"{firstName} {lastName} was successfully added to flight {selectedFlight.FlightNumber}";
        }


        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ResultsList_TextChanged(object sender, EventArgs e) // Results
        {

        }

        // Only for formatting strings into a nicer phone-number format
        private string PhoneNumberFormatter(string number)
        {
            string first = "", second = "", third = "";
            for (int i = 0; i < number.Length; i++) {
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

        private void DelFlightText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
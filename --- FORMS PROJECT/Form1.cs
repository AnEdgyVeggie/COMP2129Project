using System.Diagnostics.Eventing.Reader;

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
            if (AllFlightsCheckBox.Checked)
            {
                foreach (Flight flight in flights)
                {
                    if (flight != null)
                    {
                        ResultsList.Text += flight.ToString() + "\n";
                    }
                }
            }
            else
            {
                
                flightList = FlightList.Text.Split(",");

                if (flightList.Length > 0)
                {
                    for (int i = 0; i < flightList.Length; i++)
                    {
                        bool flightFound = false;
                        foreach(Flight flight in flights) {
                            if (flightList[i].Trim() == flight.FlightNumber.ToString())
                            {
                                ResultsList.Text += flight.ToString() + "\n";
                                flightFound = true;
                                break;
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
            } catch
            {
                ResultsList.Text = "Please enter only an integer";
                return;
            }
            if (Int32.Parse(MaxPassText.Text) <= 0) {
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
                    totalFlights++;
                    break;
                }   
                    totalFlights++;
                
                if (i == flights.Length - 1)
                {

                    ExtendFlights();

                }
            }
            ResultsList.Text = $"New Flight Created Successfully. \nFlight number: {newFlight.FlightNumber}. \nMax Passengers: {maxPass} \nTotal number of active flights: {totalFlights}";

        }

        private void button3_Click(object sender, EventArgs e) // Delete Flight
        {

        }

        private void button4_Click(object sender, EventArgs e) // Add Passenger
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) // Results
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ResultsList_TextChanged(object sender, EventArgs e)
        {

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
using CONSOLE_APP;
using System.Dynamic;

string topDecoration = ".:'''''''''''''''''''''''''''''''''''''''''''''''''''':.",
    spacerDecoration = "|                                                      |",
    bottomDecoration = "':....................................................:'";


// Start flights array at 10. Will later be expanded when array is full in AddFlight function
Flight[] flights = new Flight[10];

Customer customer = new Customer("first", "last", "100", 0);

Flight flight = new Flight(12);
Flight flight1 = new Flight(12);
Flight flight2 = new Flight(12);
Flight flight3 = new Flight(12);
flights[0] = flight;
flights[1] = flight1;
flights[2] = flight2;
flights[3] = flight3;
flight.AddCustomer(customer);

Banner();
MenuSelection();



void Banner()
{
    Console.WriteLine(topDecoration);
    Console.WriteLine(spacerDecoration);
    Console.WriteLine("|             GBC AIRLINES BOOKING SYSTEM              |");
    Console.WriteLine(spacerDecoration);
    Console.WriteLine(bottomDecoration);
}

void DisplayMenu()
{
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine(topDecoration);
    Console.WriteLine(spacerDecoration);
    Console.WriteLine("|                    FLIGHT MENU                       |");
    Console.WriteLine(spacerDecoration);
    Console.WriteLine("|      Please select a choice from the menu below      |");
    Console.WriteLine("|      ------------------------------------------      |");
    Console.WriteLine(spacerDecoration);
    Console.WriteLine("|      1: Add Customer                                 |");
    Console.WriteLine("|      2: Add Flight                                   |");
    Console.WriteLine("|      3: View Flights                                 |");
    Console.WriteLine("|      4: View a Particular Flight                     |");
    Console.WriteLine("|      5: Delete Flight                                |");
    Console.WriteLine("|      6: Exit Application                             |");
    Console.WriteLine(spacerDecoration);
    Console.WriteLine(bottomDecoration);
}

void MenuSelection()
{
    bool exitCondition = false;

    while (!exitCondition)
    {
        DisplayMenu();
        int selectInt = -1;
        Console.WriteLine();
        Console.Write(" Selection: ");
        string selection = Console.ReadLine();
        Console.WriteLine();
        try
        {
            selectInt = Int32.Parse(selection);
        } catch {
            Console.WriteLine();
            Console.WriteLine("============================================");
            Console.WriteLine("     ERROR: PLEASE ENTER A NUMBER ONLY!     ");
            Console.WriteLine("============================================");
            selectInt = -1;
        }


        switch (selectInt)
        {
            case 1:
                AddCustomer();
                break;
            case 2:
                AddFlight();
                break;
            case 3:
                ViewAllFlights();
                break;
            case 4:
                ViewSingleFlight();
                break;
            case 5:
                DeleteFlight();
                break;
            case 6:
                exitCondition = true;
                break;
            default:
                Console.WriteLine("   Please pick one of the available options");
                break;

        }
    }
}

void AddCustomer()
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
    if (!activeFlights) {
        Console.WriteLine();
        Console.WriteLine("      ============================================");
        Console.WriteLine("           THERE ARE NO FLIGHTS IN THE SYSTEM     ");
        Console.WriteLine("      ============================================");
        return;
    }

    Flight? selectedFlight = null;

    Console.WriteLine();
    Console.WriteLine(topDecoration);
    Console.WriteLine(spacerDecoration);
    Console.WriteLine("|            Please enter the flight number            |");
    Console.WriteLine("|         you would like to add a customer to          |");
    Console.WriteLine("|                                                      |");
    Console.WriteLine(bottomDecoration);

    Console.WriteLine();
    string flightString = Console.ReadLine();
    Console.WriteLine();

    int flightNumber = 0;

    try
    {
        flightNumber = Int32.Parse(flightString);
    } catch
    {
        Console.WriteLine();
        Console.WriteLine("      ============================================");
        Console.WriteLine("           ERROR: PLEASE ENTER A NUMBER ONLY!     ");
        Console.WriteLine("      ============================================");
        AddCustomer(); // recursive call instead of doing a while loop
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
        string selection = "";

        while (selection != "n" || selection != "y"
            || selection != "yes" || selection != "no")
        {
            Console.WriteLine();
            Console.WriteLine("      ============================================");
            Console.WriteLine("          There were no flights matching this     ");
            Console.WriteLine("            flight number. Try again? (Y/N)       ");
            Console.WriteLine("      ============================================");
            Console.WriteLine();
            Console.Write("  Selection: ");
            selection = Console.ReadLine().ToLower();
            Console.WriteLine();

            if (selection == "y" || selection == "yes")
            {
                AddCustomer();
            } else if (selection == "n" || selection == "no") { }
            {
                Console.Clear();
                Banner();
                return;
            }
        }

    }

    bool correctInfo = false;
    int booking = 0;
    string firstName = "", lastName = "", phone = "", bookingString = "";
    while (!correctInfo)
    {
        Console.WriteLine();
        Console.Write("  Please Enter Customer First Name:      ");
        firstName = Console.ReadLine();
        Console.WriteLine();
        Console.Write("  Please Enter Customer Last Name:       ");
        lastName = Console.ReadLine();
        Console.WriteLine();
        Console.Write("  Please Enter Customer Phone Number:    ");
        phone = Console.ReadLine();
        Console.WriteLine();
        Console.Write("  Please Enter Customer Booking Number:  ");
        bookingString = Console.ReadLine();
        try
        {
             booking = Int32.Parse(bookingString);
        } 
        catch
        {
            Console.WriteLine();
            Console.WriteLine("      ============================================");
            Console.WriteLine("       ERROR: BOOKING NEEDS TO BE AN INTEGER ONLY ");
            Console.WriteLine("      ============================================");
        }
        if (booking != -1)
        {
            correctInfo = true;
        }
    }
    // ccustomerID  |  firstname  |  lastName  |  phone  |  numOfBookings

    flight.AddCustomer(new Customer(firstName, lastName, phone, booking));
}

void AddFlight()
{
    bool exitCondition = false;
    Console.WriteLine();
    Console.WriteLine(topDecoration);
    Console.WriteLine(spacerDecoration);
    Console.WriteLine("|          You are about to add a new flight           |");
    Console.WriteLine("|                  Continue? (Y/N)                     |");
    Console.WriteLine(spacerDecoration);
    Console.WriteLine(bottomDecoration);
    Console.WriteLine();
    while (!exitCondition)
    {
        Console.Write("  Selection: ");
        string selection = Console.ReadLine().ToLower();
        if (selection == "n" || selection == "no")
        {
            return;
        }
        if (selection == "y" || selection  == "yes")
        {
            exitCondition = true;
        }
    }

}

void ViewAllFlights()
{
    Console.WriteLine(topDecoration);
    foreach (Flight flight in flights)
    {
        if (flight != null)
        {
            Console.WriteLine(flight.ToString());
            Console.WriteLine(spacerDecoration);
        }
    }
    Console.WriteLine(bottomDecoration);
    Console.WriteLine();
    Console.WriteLine("      ============================================");
    Console.WriteLine("              Press Enter To Return To Menu       ");
    Console.WriteLine("      ============================================");
    Console.Read();
    Console.Clear();
}

void ViewSingleFlight()
{
    // TODO: FINISH THIS FUNCTION
}

void DeleteFlight()
{
    // TODO: FINISH THIS FUNCTION
}

void EndProgram()
{
    // TODO: FINISH THIS FUNCTION
}
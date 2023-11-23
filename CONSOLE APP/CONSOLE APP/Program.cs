// Ethan Sylvester | 101479568
// COMP 2129 | CRN: 15646

/// This program features a few functions which are used to extend an array
/// The idea here is that instead of instantiating a flight array or a 
/// passenger array which could consume unnecessary/unused memory, you 
/// choose to create a smaller array with the ability to scale it as 
/// needed. Usually, this would be done using a list, however the 
/// assignment outlined that lists were not to be used. As the assignment
/// indicates this should be a professionally built program, we wanted to
/// make it as efficient and resource conscious as possible.

using CONSOLE_APP;
using System.Dynamic;
using System.Runtime.InteropServices;

string topDecoration = ".:'''''''''''''''''''''''''''''''''''''''''''''''''''':.",
    spacerDecoration = "|                                                      |",
    bottomDecoration = "':....................................................:'";

// Start flights array at 10. Will later be expanded when array is full in AddFlight function
Flight[]? flights = new Flight[4];

Customer customer = new Customer("first", "last", "100", 0);

Flight flight = new Flight(12);
Flight flight1 = new Flight(10);
Flight flight2 = new Flight(2);
Flight flight3 = new Flight(132);
flights[0] = flight;
flights[1] = flight1;
flights[2] = flight2;
flights[3] = flight3;
flight.AddCustomer(customer);

Banner();
MenuSelection();



void Banner()
{
    Console.Clear();
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
        Banner();
        DisplayMenu();
        int selectInt = -1;
        Console.WriteLine();
        Console.Write(" Selection: ");
        string selection = Console.ReadLine();
        Console.WriteLine();
        try
        {
            // you could instead use tryparse to determine if it is parseable (returns bool) and
            // then use
            // if (int.TryParse(selection) { selectInt = Int32.Parse(selection); }
            // but I chose to use try/catch instead.
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
                EndProgram();
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
                MenuSelection();
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

    flight.AddCustomer(new Customer(firstName, lastName, phone, booking));
    Console.WriteLine();
    Console.WriteLine($"     {firstName} {lastName} was added as a customer.");
    Console.WriteLine();
    Console.WriteLine("      ============================================");
    Console.WriteLine("              Press Enter To Return To Menu       ");
    Console.WriteLine("      ============================================");
    Console.Read();
    Console.Clear();
}

void AddFlight()
{
    bool exitCondition = false;
    Console.WriteLine();
    Console.WriteLine(topDecoration);
    Console.WriteLine(spacerDecoration);
    Console.WriteLine("|          You are about to add a new flight           |");
    Console.WriteLine("|       Are you sure you want to continue? (Y/N)       |");
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
        } else if (selection == "y" || selection  == "yes")
        {
            exitCondition = true;
        } else
        {
            Console.WriteLine();
            Console.WriteLine("      ============================================");
            Console.WriteLine("           ERROR: PLEASE ENTER A NUMBER ONLY!     ");
            Console.WriteLine("      ============================================");
            Console.WriteLine();
            Console.WriteLine(topDecoration);
            Console.WriteLine(spacerDecoration);
            Console.WriteLine("|          You are about to add a new flight           |");
            Console.WriteLine("|       Are you sure you want to continue? (Y/N)       |");
            Console.WriteLine(spacerDecoration);
            Console.WriteLine(bottomDecoration);
            Console.WriteLine();
        }
    }

    exitCondition = false;
    int maxPass = -1;
    while (!exitCondition)
    {
        Console.WriteLine(topDecoration);
        Console.WriteLine(spacerDecoration);
        Console.WriteLine("|           Please specify the maximum amount          |");
        Console.WriteLine("|                of passengers allowed                 |");
        Console.WriteLine(spacerDecoration);
        Console.WriteLine(bottomDecoration);
        Console.WriteLine();
        string passengerString = Console.ReadLine();
        try
        {
            if (passengerString == "")
            {
                maxPass = 10;
            } else
            {
                if (Int32.Parse(passengerString) > 0) 
                {
                    maxPass = Int32.Parse(passengerString);
                } else
                {
                    maxPass = Int32.Parse(passengerString + "error");
                }
            }
            exitCondition = true;
        } catch
        {
            Console.WriteLine();
            Console.WriteLine("      ============================================");
            Console.WriteLine("        ERROR: PLEASE ENTER A VALID NUMBER ONLY!  ");
            Console.WriteLine("      ============================================");
            Console.WriteLine();
        }
    }
    Flight newFlight = new Flight(maxPass);
    for (int i = 0; i < flights.Length; i++)
    {
        if (flights[i] == null)
        {
            flights[i] = newFlight;
            break;
        }
        if (i == flights.Length-1)
        {
            ExtendFlights();
        }
    }
    Console.WriteLine();
    Console.WriteLine("      ============================================");
    Console.WriteLine("             NEW FLIGHT SUCCESSFULLY ADDED!       ");
    Console.WriteLine("      ============================================");

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
    int flightNumber = -1;

    while (flightNumber == -1)
    {
        Console.WriteLine();
        Console.WriteLine(topDecoration);
        Console.WriteLine(spacerDecoration);
        Console.WriteLine("|            Please enter the flight number            |");
        Console.WriteLine("|                You would like to view                |");
        Console.WriteLine(spacerDecoration);
        Console.WriteLine(bottomDecoration);
        Console.Write("  Selection:  ");
        string numberString = Console.ReadLine();

        try
        {   
            flightNumber = Int32.Parse(numberString);
        }
        catch
        {
            Console.WriteLine();
            Console.WriteLine("      ============================================");
            Console.WriteLine("           ERROR: PLEASE ENTER A NUMBER ONLY!     ");
            Console.WriteLine("      ============================================");
        }
    }
    // cycle through flights array
    for (int i = 0; i < flights.Length; i++)
    {
        if (flights[i] != null) // null values will not have a flightnumber and cause crash
        {                       // so they need to be skipped
            if (flights[i].FlightNumber == flightNumber)
            {
                Console.WriteLine();
                Console.WriteLine(flights[i].ToString());
                Console.WriteLine();
                Console.WriteLine("      ============================================");
                Console.WriteLine("              Press Enter To Return To Menu       ");
                Console.WriteLine("      ============================================");
                Console.Read();
                Console.Clear();
                return;
            } 
        }
    }
    // if the return isnt hit in the loop, there were no matching flights
    Console.WriteLine();
    Console.WriteLine("      ============================================");
    Console.WriteLine("       There were no flights matching this number ");
    Console.WriteLine("      ============================================");
    Console.WriteLine();
    return;
}

void DeleteFlight()
{
    // for deletions, you should make sure that this is the function intended, not to lock people in
    Console.WriteLine();
    Console.WriteLine(topDecoration);
    Console.WriteLine(spacerDecoration);
    Console.WriteLine("|          You are about to delete a flight            |");
    Console.WriteLine("|       Are you sure you want to continue? (Y/N)       |");
    Console.WriteLine(spacerDecoration);
    Console.WriteLine(bottomDecoration);
    bool exitCondition = false;
    while (!exitCondition)
    {
        Console.WriteLine();
        Console.Write("  Selection: ");
        string selection = Console.ReadLine().ToLower();
        if (selection == "n" || selection == "no")
        {
            return;
        }
        if (selection == "y" || selection == "yes")
        {
            exitCondition = true;
        }
    }

    // reset exitcondition for reuse
    exitCondition = false;
    int deleteNum = -1;

    Console.WriteLine();
    Console.Write("Enter the flight number you would like to delete: ");
    string delete = Console.ReadLine();
    try
    {
        deleteNum = Int32.Parse(delete);
    } catch
    {
        Console.WriteLine();
        Console.WriteLine("      ============================================");
        Console.WriteLine("           ERROR: PLEASE ENTER A NUMBER ONLY!     ");
        Console.WriteLine("      ============================================"); 
    }

    // cycle through array
    for( int i = 0; i < flights.Length; i++)
    {
        if (flights[i] != null) // null values will not have a flightnumber and cause crash
        {                       // so they need to be skipped
            if (flights[i].FlightNumber == deleteNum)
            {
                while (!exitCondition)
                {   // again, you want to be sure of deletions as they are permeneant
                    Console.WriteLine();
                    Console.WriteLine(topDecoration);
                    Console.WriteLine("|             You are choosing to delete:              |");
                    Console.WriteLine(flights[i].ToString());
                    Console.WriteLine("|       Are you sure you want to continue? (Y/N)       |");
                    Console.WriteLine(bottomDecoration);
                    Console.WriteLine();

                    Console.Write("  Selection: ");
                    string selection = Console.ReadLine().ToLower();
                    if (selection == "n" || selection == "no")
                    {
                        return;
                    }
                    if (selection == "y" || selection == "yes")
                    {
                        exitCondition = true;
                    }
                }
                flights[i] = null;
            }
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Flight {deleteNum} deleted successfully!");
}

void EndProgram()
{
    Console.WriteLine(topDecoration);
    Console.WriteLine(spacerDecoration);
    Console.WriteLine("|                   Have a great day                   |");
    Console.WriteLine(spacerDecoration);
    Console.WriteLine(bottomDecoration);
    Console.ReadLine();
    Environment.Exit(0);
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
using CONSOLE_APP;
using System.Dynamic;

string topDecoration = ".:'''''''''''''''''''''''''''''''''''''''''''''''''''':.",
    spacerDecoration = "|                                                      |",
    bottomDecoration = "':....................................................:'";

// Start flights array at 10. Will later be expanded when array is full in AddFlight function
Flight[] flights = new Flight[10];

Banner();
DisplayMenu();



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
    Console.WriteLine("|      2: View Flights                                 |");
    Console.WriteLine("|      3: View a Particular Flight                     |");
    Console.WriteLine("|      4: Delete Flight                                |");
    Console.WriteLine("|      5: Exit Application                             |");
    Console.WriteLine(spacerDecoration);
    Console.WriteLine(bottomDecoration);
    MenuSelection();
}

void MenuSelection()
{
    bool exitCondition = false;

    while (!exitCondition)
    {
        int selectInt = -1;
        Console.WriteLine();
        Console.Write(" Selection: ");
        string selection = Console.ReadLine();
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

        }
    }
}

void AddCustomer()
{
    for (int i = 0; i < flights.Length; i++)
    {
        // determine if there are any flights
    }
/*    if (flights.Length == 0)
    {
        Console.WriteLine();
        Console.WriteLine("============================================");
        Console.WriteLine("     THERE ARE NO FLIGHTS IN THE SYSTEM     ");
        Console.WriteLine("============================================");
        return;
    }*/

    Console.WriteLine();
    Console.WriteLine(topDecoration);
    Console.WriteLine(spacerDecoration);
    Console.WriteLine("|            Please enter the flight number            |");
    Console.WriteLine("|         you would like to add a customer to          |");
    Console.WriteLine("|                                                      |");
    Console.WriteLine(bottomDecoration);
    string flightString = Console.ReadLine();
    int flightNumber = 0,  match = 0;

    try
    {
        flightNumber = Int32.Parse(flightString);
    } catch
    {
        Console.WriteLine();
        Console.WriteLine("============================================");
        Console.WriteLine("     ERROR: PLEASE ENTER A NUMBER ONLY!     ");
        Console.WriteLine("============================================");
        AddCustomer(); // recursive call instead of doing a while loop
    }

    foreach (Flight flight in flights)
    {
        if (flight.FlightNumber == flightNumber)
            match = flightNumber;
    }
    if (match == 0)
    {
        Console.WriteLine();
        Console.WriteLine("============================================");
        Console.WriteLine("     There were no flights matching this    ");
        Console.WriteLine("      flight number. Try again? (Y/N)       ");
        Console.WriteLine("============================================");
    }
    string selection = "";
    while (selection != "n" && selection != "y" 
        && selection != "yes" && selection != "no")
    {
        selection = Console.ReadLine().ToLower();
    }
    if (selection == "y" || selection == "yes")
    {
        AddCustomer();
    } else
    {
        DisplayMenu();
    }
}

void AddFlight()
{
    // TODO: FINISH THIS FUNCTION
}

void ViewAllFlights()
{
    // TODO: FINISH THIS FUNCTION
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
using CONSOLE_APP;
using System.Dynamic;

string topDecoration = ".:'''''''''''''''''''''''''''''''''''''''''''''''''''':.",
    spacerDecoration = "|                                                      |",
    bottomDecoration = "':....................................................:'";

// Start flights array at 10. Will later be expanded when array is full in AddFlight function
Flight[] flights = new Flight[10];

Banner();
DisplayMenu();
MenuSelection();


void Banner()
{
    Console.WriteLine(topDecoration);
    Console.WriteLine("|                                                      |");
    Console.WriteLine("|             GBC AIRLINES BOOKING SYSTEM              |");
    Console.WriteLine("|                                                      |");
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
            Console.WriteLine("||| ERROR! NUMERICAL VALUES ACCEPTED ONLY |||");
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

        }
    }
}

void AddCustomer()
{
    // TODO: FINISH THIS FUNCTION
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
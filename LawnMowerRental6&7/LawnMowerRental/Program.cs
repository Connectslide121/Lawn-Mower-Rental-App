

using System;

class Program
{
    static void Main()
    {
        DataStorage.LoadDataFromJson();

        if (DataStorage.lawnMowers.Count == 0)
        {
            RegisterAllLawnMowers();
        }
        Console.WriteLine("Welcome to the Lawn Mower Rental System");
        while (true)
        {
            Console.WriteLine("\nOptions:");
            Console.WriteLine("1. Register New Customer");
            Console.WriteLine("2. Register Lawn Mower Rental");
            Console.WriteLine("3. List of Customers with Rentals");
            Console.WriteLine("4. Delete Customer");
            Console.WriteLine("5. Clear Data");
            Console.WriteLine("6. Exit");
            Console.WriteLine();
            Console.Write("Select an option: ");
            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Invalid choice. Please try again.");
                continue;
            }
            switch (choice)
            {
                case 1:
                    RegisterNewCustomer();
                    DataStorage.SaveDataToJson();
                    break;
                case 2:
                    RegisterLawnMowerRental();
                    DataStorage.SaveDataToJson();
                    break;
                case 3:
                    ListCustomersWithRentals();
                    break;
                case 4:
                    DeleteCustomer();
                    DataStorage.SaveDataToJson();
                    break;
                case 5:
                    ClearData();
                    DataStorage.SaveDataToJson();
                    break;
                case 6:
                    DataStorage.SaveDataToJson();
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
            Console.WriteLine();
        }
    }

    // ... The rest of the Program class methods here ...

    static void RegisterAllLawnMowers()
    {
        // Register lawn mowers here
    }
}


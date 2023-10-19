// See https://aka.ms/new-console-template for more information



//In the CustomerManager class, add the following method to find a customer by their ID
using Microsoft.VisualBasic;

public Customer FindCustomerById(int customerId)
{
    return customers.Find(customer => customer.CustomerId == customerId);
}
//After you add the method, integrate this search function into the MainMenuController class. Modify the MenuController method as follows
public static void MenuController(string userInput)
{
    // ... (existing code)
    switch (userInputInt)
    {
        case 1:
            // Rent a lawn mower - You can add the code here
            break;
        case 2:
            // Return a lawn mower - You can add the code here
            break;
        case 3:
            // View current rentals - You can add the code here
            break;
        case 4:
            // Register new customer - You can add the code here
            break;
        case 5:
            customerManager.ViewListOfCustomers();
            break;
        case 6:
            Console.WriteLine("Exiting the app...");
            return;
        case 7:
            SearchCustomerById(); // Call the search customer function
            break;
        default:
            Main.MainMenu();
            break;
    }
}
//Now create a new method, SearchCustomerById, in the MainMenuController class to interact with the user for searching customers by their ID
//This concept will allow the user to search for the Customer ID we can also integrate the search function
//through their names but we need to consider the possibilities of the customers having with the same for
//example if the user search for the name “John” and out of 20 registered customer 10 of them appeared in
//your search so in this case we need another method to sort the customers with the same name in order to get the information that we need.


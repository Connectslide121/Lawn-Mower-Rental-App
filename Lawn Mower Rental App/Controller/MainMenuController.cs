using Lawn_Mower_Rental_App.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lawn_Mower_Rental_App.Controller
{
    public class MainMenuController
    {
        public static void MenuController(string userInput)
        {
                if (int.TryParse(userInput, out int userInputInt))
                {
                    switch (userInputInt)
                    {
                        case 1:
                            Console.WriteLine("Going to RentLawnMower..."); //REPLACE WITH A CALL FOR THE METHOD
                            break;
                        case 2:
                            Console.WriteLine("Going to ReturnLawnMower..."); //REPLACE WITH A CALL FOR THE METHOD
                            break;
                        case 3:
                            Console.WriteLine("Going to CurrentInventory..."); //REPLACE WITH A CALL FOR THE METHOD
                            break;
                        case 4:
                            NewCustomerForm newCustomerForm4 = new NewCustomerForm();
                            CustomerManager customerManager4 = new CustomerManager();
                            customerManager4.RegisterNewCustomer(newCustomerForm4.CustomerForm());
                            break;
                        case 5:
                            CustomerManager customerManager5 = new CustomerManager();
                            customerManager5.ViewListOfCustomers();
                            break;
                        case 6:
                            Console.WriteLine("Exiting the app...");
                            return;
                        default: 
                            Main.MainMenu();

                        break;
                    }
                }
                else 
                { 
                    Main.MainMenu();

            }
        }
    }
}

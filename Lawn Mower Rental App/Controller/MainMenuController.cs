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
            CustomerManager customerManager = new CustomerManager();
            NewCustomerForm newCustomerForm = new NewCustomerForm();
            DeleteCustomerForm deleteCustomerForm = new DeleteCustomerForm();

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
                            newCustomerForm.NewCustomerForm_();
                            break;
                        case 5:
                            customerManager.ViewListOfCustomers();
                            break;
                        case 6:
                            deleteCustomerForm.DeleteCustomerForm_();
                            break;
                        case 7:
                            Console.WriteLine("Exiting the app...");
                            return;
                        default: 
                            MainMenu.MainMenu_();

                        break;
                    }
                }
                else 
                { 
                    MainMenu.MainMenu_();

            }
        }
    }
}

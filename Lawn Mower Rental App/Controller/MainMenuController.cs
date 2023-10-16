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
                            Console.WriteLine("Going to NewCustomer..."); //REPLACE WITH A CALL FOR THE METHOD
                            break;
                        case 5:
                            Console.WriteLine("Going to CustomerList..."); //REPLACE WITH A CALL FOR THE METHOD
                            break;
                        case 6:
                            Console.WriteLine("Exiting the app...");
                            return;
                    }
                }
                else 
                { 
                    Main.MainMenu();                
                }
        }
    }
}

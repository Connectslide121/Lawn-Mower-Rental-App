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
            RentLawnMowerForm rentLawnMowerForm = new RentLawnMowerForm();


            NewLawnMowerForm newLawnMowerForm = new NewLawnMowerForm();
            DeleteLawnMowerForm deleteLawnMowerForm = new DeleteLawnMowerForm();
            LawnMowerManager lawnMowerManager = new LawnMowerManager();

            NewCustomerForm newCustomerForm = new NewCustomerForm();
            DeleteCustomerForm deleteCustomerForm = new DeleteCustomerForm();
            CustomerManager customerManager = new CustomerManager();



            if (int.TryParse(userInput, out int userInputInt))
                {
                    switch (userInputInt)
                    {
                        case 1:
                            rentLawnMowerForm.RentLawnMowerForm_();
                            break;
                        case 2:
                            Console.WriteLine("Going to ..."); //REPLACE WITH A CALL FOR THE METHOD
                            break;
                        case 3:
                            Console.WriteLine("Going to ..."); //REPLACE WITH A CALL FOR THE METHOD
                            break;
                        case 4:
                            Console.WriteLine("Going to ..."); //REPLACE WITH A CALL FOR THE METHOD
                            break;


                        case 5:
                            newLawnMowerForm.NewLawnMowerForm_();
                            break;
                        case 6:
                            deleteLawnMowerForm.DeleteLawnMowerForm_();
                            break;
                        case 7:
                            lawnMowerManager.ViewListOfLawnMowers();
                            break;
                        case 8:
                            Console.WriteLine("Going to ..."); //REPLACE WITH A CALL FOR THE METHOD
                            break;



                        case 9:
                            newCustomerForm.NewCustomerForm_();
                            break;
                        case 10:
                            deleteCustomerForm.DeleteCustomerForm_();
                            break;
                        case 11:
                            customerManager.ViewListOfCustomers();
                            break;
                        case 12:
                            Console.WriteLine("Going to..."); //REPLACE WITH A CALL FOR THE METHOD
                            break;


                        case 13:
                            Console.WriteLine("Exiting the app..."); //REPLACE WITH A CALL FOR THE METHOD
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

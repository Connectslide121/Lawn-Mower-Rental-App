using Lawn_Mower_Rental_App.Model;
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

            ViewActiveRentalsForm viewActiveRentalsForm = new ViewActiveRentalsForm();
            ViewRentalHistoryForm viewRentalHistoryForm = new ViewRentalHistoryForm();

            NewLawnMowerForm newLawnMowerForm = new NewLawnMowerForm();
            DeleteLawnMowerForm deleteLawnMowerForm = new DeleteLawnMowerForm();
            LawnMowerManager lawnMowerManager = new LawnMowerManager();
            UpdateMaintenanceForm updateMaintenanceForm = new UpdateMaintenanceForm();

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
                            viewActiveRentalsForm.ViewActiveRentalsForm_();
                            break;
                        case 4:
                            viewRentalHistoryForm.ViewRentalHistoryForm_();
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
                            updateMaintenanceForm.UpdateMaintenanceForm_();
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
                             Console.WriteLine("Search by First Name, Last Name, ID, Address, Contact Number or Date of Registry.");
                             string searchQuery = Console.ReadLine();
                             List<Customer> searchResults = customerManager.SearchCustomers(searchQuery);
                             CustomerSearchView.DisplaySearchResults(searchResults); // Jon you're a genius
                        break;


                    case 13:
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

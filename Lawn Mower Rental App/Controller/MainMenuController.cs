using Lawn_Mower_Rental_App.Helper;
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
            ReturnLawnMowerForm returnLawnMowerForm = new ReturnLawnMowerForm();
            RentalManager rentalManager = new RentalManager();
            ViewActiveRentalsForm viewActiveRentalsForm = new ViewActiveRentalsForm();
            ViewRentalHistoryForm viewRentalHistoryForm = new ViewRentalHistoryForm();
            ViewDelayedRentals viewDelayedRentals = new ViewDelayedRentals();

            NewLawnMowerForm newLawnMowerForm = new NewLawnMowerForm();
            DeleteLawnMowerForm deleteLawnMowerForm = new DeleteLawnMowerForm();
            LawnMowerManager lawnMowerManager = new LawnMowerManager();
            UpdateMaintenanceForm updateMaintenanceForm = new UpdateMaintenanceForm();

            NewCustomerForm newCustomerForm = new NewCustomerForm();
            DeleteCustomerForm deleteCustomerForm = new DeleteCustomerForm();
            CustomerManager customerManager = new CustomerManager();

            EarningsProfitView earningsProfitView = new EarningsProfitView();

            

            if (int.TryParse(userInput, out int userInputInt))
                {
                        switch (userInputInt)
                        {

                        case 1:
                            rentLawnMowerForm.RentLawnMowerForm_();
                            break;
                        case 2:
                            returnLawnMowerForm.ReturnLawnMowerForm_();
                            break;
                        case 3:
                            rentalManager.ViewReturnsToday();
                            break;
                        case 4:
                            rentalManager.GetDelayedRentals();
                            break;
                        case 5:
                            viewActiveRentalsForm.ViewActiveRentalsForm_();
                            break;
                        case 6:
                            viewRentalHistoryForm.ViewRentalHistoryForm_();
                            break;


                        case 7:
                            newLawnMowerForm.NewLawnMowerForm_();
                            break;
                        case 8:
                            deleteLawnMowerForm.DeleteLawnMowerForm_();
                            break;
                        case 9:
                            lawnMowerManager.ViewListOfLawnMowers();
                            break;
                        case 10:
                            updateMaintenanceForm.UpdateMaintenanceForm_();
                            break;


                        case 11:
                            newCustomerForm.NewCustomerForm_();
                            break;
                        case 12:
                            deleteCustomerForm.DeleteCustomerForm_();
                            break;
                        case 13:
                            customerManager.ViewListOfCustomers();
                            break;
                        case 14: // These cases are getting complicated so they can work and be accepted by visual studio
                        Console.WriteLine("Enter customer type (Basic/Prime):");
                        if (Enum.TryParse(HelperMethods.ReadLine(), true, out selectedCustomerType))
                            {
                            Console.WriteLine("Enter search query:");
                            string searchQuery = HelperMethods.ReadLine();

                            List<Customer> searchResults = customerManager.SearchCustomers(searchQuery, selectedCustomerType);

                            CustomerSearchView.DisplaySearchResults(searchResults);
                             }
                             else
                             {
                            Console.WriteLine("Invalid customer type. Please enter 'Basic' or 'Prime'.");
                             }
                             break;




                    case 15:
                            earningsProfitView.DisplayEarningsProfitMenu();
                            break;


                        case 16:
                            Console.WriteLine("Exiting the app...");
                            Environment.Exit(0);
                            break;


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

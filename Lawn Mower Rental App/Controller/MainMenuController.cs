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
        
        public static void MainMenuController_(string userInput)
        {
            if (int.TryParse(userInput, out int userInputInt))
            {
                switch (userInputInt)
                {

                    case 1:
                        MainMenu.RentalMenu();
                        break;
                    case 2:
                        MainMenu.LawnMowerMenu();
                        break;
                    case 3:
                        MainMenu.CustomerMenu();
                        break;
                    case 4:
                        MainMenu.AccountingMenu();
                        break;

                    case 5:
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

        public static void RentalMenuController(string userInput)
        {
            RentLawnMowerForm rentLawnMowerForm = new RentLawnMowerForm();
            ReturnLawnMowerForm returnLawnMowerForm = new ReturnLawnMowerForm();
            RentalManager rentalManager = new RentalManager();
            ViewActiveRentalsForm viewActiveRentalsForm = new ViewActiveRentalsForm();
            ViewRentalHistoryForm viewRentalHistoryForm = new ViewRentalHistoryForm();

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
                    default:
                        MainMenu.RentalMenu();
                        break;

                }
            }
            else
            {
                MainMenu.RentalMenu();
            }

        }
        public static void LawnMowerMenuController(string userInput)
        {
            NewLawnMowerForm newLawnMowerForm = new NewLawnMowerForm();
            DeleteLawnMowerForm deleteLawnMowerForm = new DeleteLawnMowerForm();
            LawnMowerManager lawnMowerManager = new LawnMowerManager();
            UpdateMaintenanceForm updateMaintenanceForm = new UpdateMaintenanceForm();

            if (int.TryParse(userInput, out int userInputInt))
            {
                switch (userInputInt)
                {
                    case 1:
                        newLawnMowerForm.NewLawnMowerForm_();
                        break;
                    case 2:
                        deleteLawnMowerForm.DeleteLawnMowerForm_();
                        break;
                    case 3:
                        lawnMowerManager.ViewListOfLawnMowers();
                        break;
                    case 4:
                        updateMaintenanceForm.UpdateMaintenanceForm_();
                        break;
                    default:
                        MainMenu.LawnMowerMenu();
                        break;

                }
            }
            else
            {
                MainMenu.LawnMowerMenu();
            }
        }

        public static void CustomerMenuController(string userInput)
        {
            NewCustomerForm newCustomerForm = new NewCustomerForm();
            DeleteCustomerForm deleteCustomerForm = new DeleteCustomerForm();
            CustomerManager customerManager = new CustomerManager();
            CustomerSearchView customerSearchView = new CustomerSearchView();
            AddPointsView addPointsView = new AddPointsView();
            ChangeCustomerView changeCustomerView = new ChangeCustomerView();

            if (int.TryParse(userInput, out int userInputInt))
            {
                switch (userInputInt)
                {
                    case 1:
                        newCustomerForm.NewCustomerForm_();
                        break;
                    case 2:
                        deleteCustomerForm.DeleteCustomerForm_();
                        break;
                    case 3:
                        customerManager.ViewListOfCustomers();
                        break;
                    case 4:
                        customerSearchView.SearchCustomers();
                        break;
                    case 5:
                        addPointsView.AddPointsMenu();
                        break;
                    case 6:
                        changeCustomerView.ChangeCustomerType();
                        break;
                    default:
                        MainMenu.CustomerMenu();
                        break;

                }
            }
            else
            {
                MainMenu.CustomerMenu();
            }
        }

        public static void AccountingMenuController(string userInput)
        {
            EarningsProfitView earningsProfitView = new EarningsProfitView();

            if (int.TryParse(userInput, out int userInputInt))
            {
                switch (userInputInt)
                {
                    case 1:
                        earningsProfitView.DisplayEarningsProfitMenu();
                        break;
                    default:
                        MainMenu.AccountingMenu();
                        break;

                }
            }
            else
            {
                MainMenu.AccountingMenu();
            }
        }
    }
}

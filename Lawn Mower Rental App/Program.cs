// See https://aka.ms/new-console-template for more information

using Lawn_Mower_Rental_App.Controller;
using Lawn_Mower_Rental_App.Model;
using Lawn_Mower_Rental_App.View;

//NewLawnMowerForm newLawnMowerForm = new NewLawnMowerForm();
//newLawnMowerForm.NewLawnMowerForm_();

//DeleteLawnMowerForm deleteLawnMowerForm = new DeleteLawnMowerForm();
//deleteLawnMowerForm.DeleteLawnMowerForm_();

//NewCustomerForm newCustomerForm = new NewCustomerForm();
//newCustomerForm.NewCustomerForm_();

//CustomerManager customerManager = new CustomerManager();
//customerManager.ViewListOfCustomers();

LawnMowerManager lawnMowerManager = new LawnMowerManager();
lawnMowerManager.ViewListOfLawnMowers();

//MainMenu.MainMenu_();
Console.ReadKey();
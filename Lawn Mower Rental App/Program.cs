// See https://aka.ms/new-console-template for more information

using Lawn_Mower_Rental_App.Model;
using Lawn_Mower_Rental_App.View;
using Lawn_Mower_Rental_App.View.Lawn_Mower_Rental_App.View;

CustomerManager customermanager = new CustomerManager();
customermanager.ViewListOfCustomers();
Console.ReadKey();

MainMenu.MainMenu_();
Console.ReadKey();
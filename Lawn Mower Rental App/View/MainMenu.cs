using Lawn_Mower_Rental_App.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lawn_Mower_Rental_App.View
{
    public class MainMenu
    {
        public static void MainMenu_()
        {
            RentalManager rentalManager = new RentalManager();
            LawnMowerManager lawnMowerManager = new LawnMowerManager();
            
            Console.Clear();
            Console.WriteLine("|***************************************** LAWN MOWER RENTAL (TM) **************************************|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t MAIN MENU \t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t Select an option by entering the corresponding number: \t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t 1.- Rent a lawn mower \t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t 2.- Return a lawn mower \t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t 3.- View active rentals \t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t 4.- View history of rentals \t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t 5.- Register new lawn mower \t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t 6.- Delete lawn mower \t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t 7.- View list of lawn mowers \t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t 8.- Update lawn mower info \t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t 9.- Register new customer \t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t 10.- Delete customer \t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t 11.- View list of customers \t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t 12.- Search for customer \t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t 13.- Exit \t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|*******************************************************************************************************|");
            Console.WriteLine();
            Console.WriteLine("Enter the number of your choice:");

            MainMenuController.MenuController(Console.ReadLine());
        }
    }
}

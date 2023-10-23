using Lawn_Mower_Rental_App.Controller;
using Lawn_Mower_Rental_App.Helper;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

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
            HelperMethods.WriteColoredText("|\t\t\t\t\t\t MAIN MENU \t\t\t\t\t\t|", "MAIN MENU", ConsoleColor.Blue);
            Console.WriteLine("|\t\t\t Select an option by entering the corresponding number: \t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t 01.- Rent a lawn mower \t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t 02.- Return a lawn mower \t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t 03.- View returns expected today \t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t 04.- View delayed rentals \t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t 05.- View active rentals \t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t 06.- View rental history \t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t 07.- Register new lawn mower \t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t 08.- Delete lawn mower \t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t 09.- View list of lawn mowers \t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t 10.- Update lawn mower last maintenance \t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t 11.- Register new customer \t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t 12.- Delete customer \t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t 13.- View list of customers \t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t 14.- Search for customer \t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t 15.- Accounting information \t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t 16.- Exit \t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|*******************************************************************************************************|");
            Console.WriteLine("Enter the number of your choice:");

            MainMenuController.MenuController(HelperMethods.ReadLine());
        }
    }
}

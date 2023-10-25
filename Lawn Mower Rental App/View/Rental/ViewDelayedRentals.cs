using Lawn_Mower_Rental_App.Controller;
using Lawn_Mower_Rental_App.Helper;
using Lawn_Mower_Rental_App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lawn_Mower_Rental_App.View
{
    public class ViewDelayedRentals
    {
        public static void ViewDelayedRentals_(List<Rental> delayedRentals)
        {
            Console.Clear();
            Console.WriteLine("|***************************************** LAWN MOWER RENTAL (TM) **************************************|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            HelperMethods.WriteColoredText("|\t\t\t\t\t     DELAYED RENTALS \t\t\t\t\t\t|", "DELAYED RENTALS", ConsoleColor.Magenta);
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t----------------------------------------------\t\t\t\t|");

            if (delayedRentals.Count == 0)
            {
                Console.WriteLine("|\t\t\t\t\t   No delayed rentals found.\t\t\t\t\t|");
            }
            else
            {
                foreach (Rental rental in delayedRentals)
                {
                    HelperMethods.WriteLineFitBox("|\t", rental.ToString(), "|", 96);
                }
            }

            Console.WriteLine("|\t\t\t\t----------------------------------------------\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|*******************************************************************************************************|");
            Console.WriteLine("Press any key to go back to the Main Menu");
            HelperMethods.ReadLine();
            MainMenu.MainMenu_();
        }
    }
}

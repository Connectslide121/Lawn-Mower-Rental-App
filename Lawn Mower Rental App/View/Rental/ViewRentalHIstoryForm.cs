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
    public class ViewRentalHistoryForm
    {
        public void ViewRentalHistoryForm_()
        {
            RentalManager rentalManager = new RentalManager();
            List<Rental> rentalHistory = rentalManager.GetRentalHistory();

            Console.Clear();
            Console.WriteLine("|***************************************** LAWN MOWER RENTAL (TM) **************************************|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            HelperMethods.WriteColoredText("|\t\t\t\t\t     RENTAL HISTORY \t\t\t\t\t\t|", "RENTAL HISTORY", ConsoleColor.Magenta);
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t----------------------------------------------\t\t\t\t|");

            if (rentalHistory.Count == 0)
            {
                Console.WriteLine("|\t\t\t\t\tNo rental history found.\t\t\t\t\t|");
            }
            else
            {
                foreach (Rental rental in rentalHistory)
                {
                    int lineLength = 95;

                    if (rental.ToString().Length < lineLength)
                    {
                        Console.Write("|\t"); Console.Write(rental.ToString().PadRight(lineLength)); Console.WriteLine(" |");
                    }
                    else if (rental.ToString().Length > lineLength)
                    {
                        Console.Write("|\t"); Console.Write(rental.ToString().Substring(0, lineLength)); Console.WriteLine("|");
                    }
                    else
                    {
                        Console.Write("|\t"); Console.Write(rental.ToString()); Console.WriteLine("|");
                    }
                }
            }

            Console.WriteLine("|\t\t\t\t----------------------------------------------\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|*******************************************************************************************************|");
            Console.WriteLine("Press any key to go back to the Main Menu");
            Console.ReadKey();
            MainMenu.MainMenu_();
        }
    }
}

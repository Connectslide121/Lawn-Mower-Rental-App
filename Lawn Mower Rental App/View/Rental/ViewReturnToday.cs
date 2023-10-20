
using Lawn_Mower_Rental_App.Controller;
using Lawn_Mower_Rental_App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Lawn_Mower_Rental_App.View
{
    public class ViewReturnToday
    {
        public static void ViewReturnToday_(List<Rental> returnToday)
        {
            Console.Clear();
            Console.WriteLine("|***************************************** LAWN MOWER RENTAL (TM) **************************************|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            MainMenuController.WriteColoredText("|\t\t\t\t\t RENTAL RETURNS TODAY \t\t\t\t\t\t|", "RENTAL RETURNS TODAY", ConsoleColor.Magenta);
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t----------------------------------------------\t\t\t\t|");

            if (returnToday.Count == 0)
            {
                Console.WriteLine("|\t\t\t\t\t   No rentals found.\t\t\t\t\t\t|");
            }
            else
            {
                foreach (Rental rental in returnToday)
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

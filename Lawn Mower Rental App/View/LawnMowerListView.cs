using Lawn_Mower_Rental_App.Controller;
using Lawn_Mower_Rental_App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lawn_Mower_Rental_App.View
{
    public class LawnMowerListView
    {
        public static void LawnMowerListView_(List<LawnMower> lawnMowers)
        {
            Console.Clear();
            Console.WriteLine("|***************************************** LAWN MOWER RENTAL (TM) **************************************|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            MainMenuController.WriteColoredText("|\t\t\t\t\t    LAWN MOWER LIST \t\t\t\t\t\t|", "LAWN MOWER LIST", ConsoleColor.Green);
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t---------------------------------------------\t\t\t\t\t|");

            if (lawnMowers.Count == 0)
            {
                Console.WriteLine("|\t\t\tNo lawn mowers registered yet.\t\t\t|");
            }
            else
            {
                foreach (var lawnMower in lawnMowers)
                {
                    Console.WriteLine($"|\t{lawnMower}\t\t|");
                }
            }

            Console.WriteLine("|\t\t\t-----------------------------------------------\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|*******************************************************************************************************|");
            Console.WriteLine();
            Console.WriteLine("Press any key to go back to the Main Menu");
            Console.ReadKey();
            MainMenu.MainMenu_();
        }
    }
}

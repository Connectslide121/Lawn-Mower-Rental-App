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
    public class LawnMowerListView
    {
        public static void LawnMowerListView_(List<ElectricLawnMower> electricLawnMowers, List<PetrolLawnMower> petrolLawnMowers)
        {
            Console.Clear();
            Console.WriteLine("|***************************************** LAWN MOWER RENTAL (TM) **************************************|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            HelperMethods.WriteColoredText("|\t\t\t\t\t      LAWN MOWER LIST \t\t\t\t\t\t|", "LAWN MOWER LIST", ConsoleColor.Green);
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t---------------------------------------------\t\t\t\t|");

            if (electricLawnMowers.Count + petrolLawnMowers.Count == 0)
            {
                Console.WriteLine("|\t\t\tNo lawn mowers registered yet.\t\t\t|");
            }
            else
            {
                HelperMethods.WriteColoredText("|\t\t\t\t\t    ELECTRIC LAWN MOWERS \t\t\t\t\t|", "ELECTRIC LAWN MOWERS", ConsoleColor.DarkGreen);
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");

                foreach (ElectricLawnMower electricLawnMower in electricLawnMowers)
                {
                    HelperMethods.WriteLineFitBox("|", electricLawnMower.ToString(), "|", 103);
                }

                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                HelperMethods.WriteColoredText("|\t\t\t\t\t    PETROL LAWN MOWERS \t\t\t\t\t\t|", "PETROL LAWN MOWERS", ConsoleColor.DarkGreen);
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                foreach (PetrolLawnMower petrolLawnMower in petrolLawnMowers)
                {
                    HelperMethods.WriteLineFitBox("|", petrolLawnMower.ToString(), "|", 103);
                }
            }

            Console.WriteLine("|\t\t\t\t-----------------------------------------------\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|*******************************************************************************************************|");
            Console.WriteLine("Press any key to go back to the Main Menu");
            HelperMethods.ReadLine();
            MainMenu.MainMenu_();
        }
    }
}

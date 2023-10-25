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
    public class EarningsProfitView
    {
        public void DisplayEarningsProfitMenu()
        {
            RentalManager rentalManager = new RentalManager();

            Console.Clear();
            Console.WriteLine("|***************************************** LAWN MOWER RENTAL (TM) **************************************|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            HelperMethods.WriteColoredText("|\t\t\t\t\t EARNINGS, COSTS & PROFIT VIEW \t\t\t\t\t|", "EARNINGS, COSTS & PROFIT VIEW", ConsoleColor.Cyan);
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t----------------------------------------------\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            HelperMethods.WriteLineFitBox("|\t\t\t\t\t Earnings: ", $"{rentalManager.CalculateTotalEarnings().ToString()} SEK", "|", 53);
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            HelperMethods.WriteLineFitBox("|\t\t\t\t\t Costs: ", $"{rentalManager.CalculateTotalCosts().ToString()} SEK", "|", 56);
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            HelperMethods.WriteLineFitBox("|\t\t\t\t\t Profit: ", $"{rentalManager.CalculateTotalProfit().ToString()} SEK", "|", 55);
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t----------------------------------------------\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|*******************************************************************************************************|");
            Console.WriteLine("Press any key to go back to Main Menu");
            HelperMethods.ReadLine();
            MainMenu.MainMenu_();
        }
    }
}
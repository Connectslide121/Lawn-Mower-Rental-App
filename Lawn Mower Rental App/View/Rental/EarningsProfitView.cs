using Lawn_Mower_Rental_App.Controller;
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
            MainMenuController.WriteColoredText("|\t\t\t\t\t EARNINGS, COSTS & PROFIT VIEW \t\t\t\t\t|", "EARNINGS, COSTS & PROFIT VIEW", ConsoleColor.Cyan);
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t----------------------------------------------\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");

            string earnings = rentalManager.CalculateTotalEarnings().ToString();
            int lineLengthEarnings = 52;

            if (earnings.Length < lineLengthEarnings)
            {
                Console.Write("|\t\t\t\t\t Earnings: "); Console.Write($"{earnings} SEK".PadRight(lineLengthEarnings)); Console.WriteLine(" |");
            }
            else if (earnings.Length > lineLengthEarnings)
            {
                Console.Write("|\t\t\t\t\t Earnings: "); Console.Write($"{earnings} SEK".Substring(0, lineLengthEarnings)); Console.WriteLine("|");
            }
            else
            {
                Console.Write("|\t\t\t\t\t Earnings: "); Console.Write($"{earnings} SEK"); Console.WriteLine("|");
            }

            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");

            string costs = rentalManager.CalculateTotalCosts().ToString();
            int lineLengthCosts = 55;

            if (costs.Length < lineLengthCosts)
            {
                Console.Write("|\t\t\t\t\t Costs: "); Console.Write($"{costs} SEK".PadRight(lineLengthCosts)); Console.WriteLine(" |");
            }
            else if (costs.Length > lineLengthCosts)
            {
                Console.Write("|\t\t\t\t\t Costs: "); Console.Write($"{costs} SEK".Substring(0, lineLengthCosts)); Console.WriteLine("|");
            }
            else
            {
                Console.Write("|\t\t\t\t\t Costs: "); Console.Write($"{costs} SEK"); Console.WriteLine("|");
            }

            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");

            string profit = rentalManager.CalculateTotalProfit().ToString();
            int lineLengthProfit = 54;

            if (profit.Length < lineLengthProfit)
            {
                Console.Write("|\t\t\t\t\t Profit: "); Console.Write($"{profit} SEK".PadRight(lineLengthProfit)); Console.WriteLine(" |");
            }
            else if (profit.Length > lineLengthProfit)
            {
                Console.Write("|\t\t\t\t\t Profit: "); Console.Write($"{profit} SEK".Substring(0, lineLengthProfit)); Console.WriteLine("|");
            }
            else
            {
                Console.Write("|\t\t\t\t\t Profit: "); Console.Write($"{profit} SEK"); Console.WriteLine("|");
            }

            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t----------------------------------------------\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|*******************************************************************************************************|");
            Console.WriteLine();
            Console.WriteLine("Press any key to go back to Main Menu");
            Console.ReadKey();
            MainMenu.MainMenu_();


        }
    }
}
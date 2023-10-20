using Lawn_Mower_Rental_App.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lawn_Mower_Rental_App.View
{
    public class EarningsProfitView
    {
        private RentalManager rentalManager;

        public EarningsProfitView(RentalManager manager)
        {
            rentalManager = manager;
        }
        public EarningsProfitView()
        {

        }
        public void DisplayEarningsProfitMenu(RentalManager manager)
        {
            this.rentalManager = manager;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("|***************************************** LAWN MOWER RENTAL (TM) **************************************|");
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                MainMenuController.WriteColoredText("|\t\t\t\t\t EARNINGS & PROFIT VIEW \t\t\t\t\t|", "EARNINGS & PROFIT VIEW", ConsoleColor.Magenta);
                Console.WriteLine("|\t\t\t\t----------------------------------------------\t\t\t\t|");
                Console.WriteLine("|\t\t1. View Earnings\t\t\t\t\t\t|\n|\t\t2. View Profit\t\t\t\t\t\t\t|");
                Console.WriteLine("|\t\t3. Back to Main Menu\t\t\t\t\t\t|");
                Console.WriteLine("|\t\t\t\t----------------------------------------------\t\t\t\t|");
                Console.Write("Enter your choice (1/2/3): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ViewEarnings();
                        break;
                    case "2":
                        ViewProfit();
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please enter 1, 2, or 3.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        public void ViewEarnings()
        {
            decimal totalEarnings = rentalManager.CalculateTotalEarnings();
            Console.Clear();
            Console.WriteLine("|***************************************** LAWN MOWER RENTAL (TM) **************************************|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            MainMenuController.WriteColoredText("|\t\t\t\t\t EARNINGS VIEW \t\t\t\t\t\t|", "EARNINGS VIEW", ConsoleColor.Magenta);
            Console.WriteLine("|\t\t\t\t----------------------------------------------\t\t\t\t|");
            Console.WriteLine($"|\tTotal Earnings: {totalEarnings} SEK\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t----------------------------------------------\t\t\t\t|");
            Console.WriteLine("Press any key to go back to the Earnings & Profit menu");
            Console.ReadKey();
        }

        public void ViewProfit()
        {
            decimal totalProfits = rentalManager.CalculateTotalProfits();
            Console.Clear();
            Console.WriteLine("|***************************************** LAWN MOWER RENTAL (TM) **************************************|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            MainMenuController.WriteColoredText("|\t\t\t\t\t PROFIT VIEW \t\t\t\t\t\t|", "PROFIT VIEW", ConsoleColor.Magenta);
            Console.WriteLine("|\t\t\t\t----------------------------------------------\t\t\t\t|");
            Console.WriteLine($"|\tTotal Profit: {totalProfits} SEK\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t----------------------------------------------\t\t\t\t|");
            Console.WriteLine("Press any key to go back to the Earnings & Profit menu");
            Console.ReadKey();
        }
    }
}

using Lawn_Mower_Rental_App.Controller;
using Lawn_Mower_Rental_App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lawn_Mower_Rental_App.View
{
    public class NewLawnMowerForm
    {
        public void NewLawnMowerForm_()
        {
            LawnMowerManager lawnMowerManager = new LawnMowerManager();
            LawnMower lawnMower = new LawnMower(lawnMowerManager.GetLawnMowerId());

            Console.Clear();
            Console.WriteLine("|***************************************** LAWN MOWER RENTAL (TM) **************************************|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            MainMenuController.WriteColoredText("|\t\t\t\t\t     NEW LAWN MOWER \t\t\t\t\t\t|", "NEW LAWN MOWER", ConsoleColor.Green);
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t Please enter the lawn mower information as requested: \t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t Model: \t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t       The rest of the properties will be generated automatically\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|*******************************************************************************************************|");
            Console.WriteLine("Please enter model:");
            lawnMower.Model = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("|***************************************** LAWN MOWER RENTAL (TM) **************************************|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            MainMenuController.WriteColoredText("|\t\t\t\t\t     NEW LAWN MOWER \t\t\t\t\t\t|", "NEW LAWN MOWER", ConsoleColor.Green);
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t Please enter the lawn mower information as requested: \t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");

            string model = lawnMower.Model;
            int lineLengthModel = 55;

            if (model.Length < lineLengthModel)
            {
                Console.Write("|\t\t\t\t\t Model: "); Console.Write(model.PadRight(lineLengthModel)); Console.WriteLine(" |");
            }
            else if (model.Length > lineLengthModel)
            {
                Console.Write("|\t\t\t\t\t Model: "); Console.Write(model.Substring(0, lineLengthModel)); Console.WriteLine("|");
            }
            else
            {
                Console.Write("|\t\t\t\t\t Model: "); Console.Write(model); Console.WriteLine("|");
            }

            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine($"|\t\t\t\tLawn Mower (ID: {lawnMower.LawnMowerId}) registered successfully!\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|*******************************************************************************************************|");
            Console.WriteLine("Press any key to go back to the Main Menu");

            lawnMowerManager.RegisterNewLawnMower(lawnMower);

            Console.ReadKey();
            MainMenu.MainMenu_();
        }
    }
}

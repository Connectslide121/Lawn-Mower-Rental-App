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
    public class NewLawnMowerForm
    {
        public void NewLawnMowerForm_()
        {
            LawnMowerManager lawnMowerManager = new LawnMowerManager();

            Console.Clear();
            Console.WriteLine("|***************************************** LAWN MOWER RENTAL (TM) **************************************|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            HelperMethods.WriteColoredText("|\t\t\t\t\t     NEW LAWN MOWER \t\t\t\t\t\t|", "NEW LAWN MOWER", ConsoleColor.Green);
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

            LawnMower lawnMower = new LawnMower(lawnMowerManager.GetLawnMowerId());
            lawnMower.Model = HelperMethods.ReadLine();

            Console.Clear();
            Console.WriteLine("|***************************************** LAWN MOWER RENTAL (TM) **************************************|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            HelperMethods.WriteColoredText("|\t\t\t\t\t     NEW LAWN MOWER \t\t\t\t\t\t|", "NEW LAWN MOWER", ConsoleColor.Green);
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t Please enter the lawn mower information as requested: \t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            HelperMethods.WriteLineFitBox("|\t\t\t\t\t Model: ", lawnMower.Model, "|", 56);
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

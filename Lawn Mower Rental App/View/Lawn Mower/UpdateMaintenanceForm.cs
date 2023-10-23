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
    public class UpdateMaintenanceForm
    {
        public void UpdateMaintenanceForm_()
        {
            Console.Clear();
            Console.WriteLine("|***************************************** LAWN MOWER RENTAL (TM) **************************************|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            HelperMethods.WriteColoredText("|\t\t\t\t\tUPDATE MAINTENANCE STATUS \t\t\t\t\t|", "UPDATE MAINTENANCE STATUS", ConsoleColor.Green);
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\tPlease enter the information as requested: \t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t Lawn Mower ID: \t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t New Maintenance Date (yyyy-MM-dd): \t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|*******************************************************************************************************|");
            Console.WriteLine("Enter Lawn Mower ID: ");
            string lawnMowerIdInput = HelperMethods.ReadLine();
            bool success = false;
            DateTime newMaintenanceDate = DateTime.Now;

            if (int.TryParse(lawnMowerIdInput, out int lawnMowerId))
            {
                LawnMowerManager manager = new LawnMowerManager();

                Console.Clear();
                Console.WriteLine("|***************************************** LAWN MOWER RENTAL (TM) **************************************|");
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                HelperMethods.WriteColoredText("|\t\t\t\t\tUPDATE MAINTENANCE STATUS \t\t\t\t\t|", "UPDATE MAINTENANCE STATUS", ConsoleColor.Green);
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                Console.WriteLine("|\t\t\t\tPlease enter the information as requested: \t\t\t\t|");
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                Console.WriteLine($"|\t\t\t\t\t Lawn Mower ID: {lawnMowerId}\t\t\t\t\t\t|");
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                Console.WriteLine("|\t\t\t\t\t New Maintenance Date (yyyy-MM-dd): \t\t\t\t|");
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                Console.WriteLine("|*******************************************************************************************************|");
                Console.WriteLine("Enter the new maintenance date (yyyy-MM-dd): ");

                if (DateTime.TryParse(HelperMethods.ReadLine(), out newMaintenanceDate))
                {
                    if (manager.UpdateMaintenanceStatus(lawnMowerId, newMaintenanceDate))
                    {
                        success = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Lawn Mower ID. Maintenance status update failed.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid date format. Maintenance status update failed.");
                }
            }
            else
            {
                Console.WriteLine("Invalid Lawn Mower ID. Maintenance status update failed.");
            }

            if (success)
            {
                Console.Clear();
                Console.WriteLine("|***************************************** LAWN MOWER RENTAL (TM) **************************************|");
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                HelperMethods.WriteColoredText("|\t\t\t\t\tUPDATE MAINTENANCE STATUS \t\t\t\t\t|", "UPDATE MAINTENANCE STATUS", ConsoleColor.Green);
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                Console.WriteLine("|\t\t\t\tPlease enter the information as requested: \t\t\t\t|");
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                Console.WriteLine($"|\t\t\t\t\t Lawn Mower ID: {lawnMowerId}\t\t\t\t\t\t|");
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                Console.WriteLine($"|\t\t\t\t\t New Maintenance Date (yyyy-MM-dd): {newMaintenanceDate.ToString("d")} \t\t\t|");
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                Console.WriteLine("|\t\t\t\tMaintenance status updated successfully!\t\t\t\t|");
                Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
                Console.WriteLine("|*******************************************************************************************************|");
            }
            Console.WriteLine("Press any key to go back to the Main Menu.");
            Console.ReadKey();
            MainMenu.MainMenu_();
        }
    }
}

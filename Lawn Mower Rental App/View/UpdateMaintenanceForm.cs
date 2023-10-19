using Lawn_Mower_Rental_App.Controller;
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
            Console.WriteLine("|\t\t\t\t  UPDATE MAINTENANCE STATUS \t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t Please enter the information as requested: \t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t Lawn Mower ID: \t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t New Maintenance Date (yyyy-MM-dd): \t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|*******************************************************************************************************|");
            Console.WriteLine();

            Console.Write("Enter Lawn Mower ID: ");
            string lawnMowerIdInput = Console.ReadLine();
            bool success = false; // Bool was the key to make it only go trough if both forms are valid.
            if (int.TryParse(lawnMowerIdInput, out int lawnMowerId))
            {
                LawnMowerManager manager = new LawnMowerManager();

                Console.Write("Enter the new maintenance date (yyyy-MM-dd): ");
                if (DateTime.TryParse(Console.ReadLine(), out DateTime newMaintenanceDate))
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
                Console.WriteLine("Maintenance status updated successfully.");
            }
            Console.WriteLine("Press any key to go back to the Main Menu.");
            Console.ReadKey();
            MainMenu.MainMenu_();
        }
    }
}

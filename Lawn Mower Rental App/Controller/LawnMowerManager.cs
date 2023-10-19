using Lawn_Mower_Rental_App.Model;
using Lawn_Mower_Rental_App.View;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Lawn_Mower_Rental_App.Controller
{
    public class LawnMowerManager
    {
        private List<LawnMower> lawnMowers;
        string relativePath = Path.Combine(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Data")), "LawnMowerData.json");

        private List<Rental> rentalsToUpdate;
        string relativePathRentals = Path.Combine(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Data")), "RentalData.json");

        public LawnMowerManager()
        {
            lawnMowers = LoadLawnMowersFromJson();
            rentalsToUpdate = LoadRentalsFromJson();
            UpdateLawnMowerAvailability();
        }
       
        private List<LawnMower> LoadLawnMowersFromJson()
        {
            try
            {
                string jsonData = File.ReadAllText(relativePath);
                return JsonSerializer.Deserialize<List<LawnMower>>(jsonData);
            }
            catch (Exception) { ErrorsExceptions.LawnMowerFileNotFoundException(); }
            return lawnMowers;
        }

        public int GetLawnMowerId() //WE NEED TO CALL THIS METHOD WHENEVER CREATING A NEW INSTANCE OF LAWN MOWER: LawnMower lawnMower = new LawnMower(GetLawnMowerId(), LastMaintenance DateTime)
        {
            if (lawnMowers.Count == 0)
            {
                return 1;
            }

            int highestID = lawnMowers.Max(mower => mower.LawnMowerId);

            for (int i = 1; i<= highestID +1; i++)
            {
                if(!lawnMowers.Any(mower => mower.LawnMowerId == i))
                {
                    return i;
                }
            }

            return highestID + 1;
        }

        public void SaveLawnMowersToJson(List<LawnMower> lawnMowers)
        {
            try
            {
                string jsonData = JsonSerializer.Serialize(lawnMowers, typeof(List<LawnMower>), new JsonSerializerOptions
                {
                    WriteIndented = true
                });

                File.WriteAllText(relativePath, jsonData);
            }
            catch { ErrorsExceptions.LawnMowerFileNotFoundException(); }
        }

        public void RegisterNewLawnMower(LawnMower lawnMower)
        {
            lawnMowers.Add(lawnMower);
            SaveLawnMowersToJson(lawnMowers);
        }

        public void DeleteLawnMower(int userInput)
        {
            DeleteLawnMowerForm deleteLawnMowerForm = new DeleteLawnMowerForm();
            int initialCount = lawnMowers.Count;

            lawnMowers.RemoveAll(lawnMower => lawnMower.LawnMowerId == userInput);
            SaveLawnMowersToJson(lawnMowers);

            if (lawnMowers.Count == initialCount)
            {
                deleteLawnMowerForm.LawnMowerNotFoundMessage(userInput);
            }
            else
            {
                deleteLawnMowerForm.LawnMowerDeletedMessage(userInput);
            }
        }

        public void ViewListOfLawnMowers()
        {
            LawnMowerListView.LawnMowerListView_(lawnMowers);
        }

        public LawnMower FindLawnMowerById()
        {
            int rentedMowerId = lawnMowers.FindIndex(m => m.IsAvailable == true);
            
            LawnMower selectedMower = lawnMowers[rentedMowerId];
            return selectedMower;
        }

        private List<Rental> LoadRentalsFromJson()
        {
            try
            {
                string jsonData = File.ReadAllText(relativePathRentals);
                return JsonSerializer.Deserialize<List<Rental>>(jsonData);
            }
            catch (Exception) { ErrorsExceptions.RentalsFileNotFoundException(); }
            return rentalsToUpdate;
        }

        public void UpdateLawnMowerAvailability()
        {
            List<LawnMower> lawnMowersToUpdate = new List<LawnMower>();

            foreach (Rental rental in rentalsToUpdate)
            {
                if (rental.LawnMower.IsAvailable == false)
                {
                    lawnMowersToUpdate.Add(rental.LawnMower);
                }
            }

            foreach (LawnMower lawnMower in lawnMowersToUpdate)
            {
                LawnMower lawnMowerToUpdate = lawnMowers.Find(m => m.LawnMowerId == lawnMower.LawnMowerId);
                
                lawnMowerToUpdate.IsAvailable = false;
                               
            }




            SaveLawnMowersToJson(lawnMowers);
        }
        public bool UpdateMaintenanceStatus(int lawnMowerId, DateTime newMaintenanceDate)
        {
            LawnMower lawnMowerToUpdate = lawnMowers.Find(m => m.LawnMowerId == lawnMowerId);
            if (lawnMowerToUpdate != null)
            {
                lawnMowerToUpdate.LastMaintenance = newMaintenanceDate;
                SaveLawnMowersToJson(lawnMowers);
                return true;
            }
            else
            {
                Console.WriteLine("Invalid Input");
                return false;
            }
        }

    }










    //private string SerializeToJson(List<LawnMower> lawnMowerList) //****** IS THIS A CUSTOM JSON SERIALIZER???????????? 
    //{
    //    StringBuilder jsonBuilder = new StringBuilder();
    //    jsonBuilder.Append("[");

    //    foreach (var mower in lawnMowerList)
    //    {
    //        jsonBuilder.Append("{");
    //        jsonBuilder.AppendFormat("\"LawnMowerId\": {0},", mower.LawnMowerId);
    //        jsonBuilder.AppendFormat("\"Model\": \"{0}\",", mower.Model);
    //        jsonBuilder.AppendFormat("\"IsAvailable\": {0},", mower.IsAvailable.ToString().ToLower());
    //        jsonBuilder.AppendFormat("\"LastMaintenance\": \"{0}\",", mower.LastMaintenance.HasValue ? mower.LastMaintenance.Value.ToString("yyyy-MM-dd") : "");
    //        jsonBuilder.AppendFormat("\"PricePerDay\": {0}", mower.PricePerDay.ToString(CultureInfo.InvariantCulture));
    //        jsonBuilder.Append("},");
    //    }

    //    if (lawnMowerList.Count > 0)
    //    {

    //        jsonBuilder.Remove(jsonBuilder.Length - 1, 1);
    //    }

    //    jsonBuilder.Append("]");

    //    return jsonBuilder.ToString();
    //}

    //public void ReturnLawnMower()
    //{
    //    Console.WriteLine("Please enter the lawn mower ID to return:");
    //    if (int.TryParse(Console.ReadLine(), out int lawnMowerId))
    //{
    //    LawnMower lawnMower = lawnMowers.FirstOrDefault(mower => mower.LawnMowerId == lawnMowerId);

    //    if (lawnMower != null)
    //        {
    //            lawnMower.IsAvailable = true;
    //            SaveLawnMowersToJson();
    //            Console.WriteLine("Lawn mower returned successfully.");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Lawn mower not found with the specified ID.");
    //        }
    //    }
    //    else
    //    {
    //        Console.WriteLine("Invalid input. Please enter a valid integer ID.");
    //    }
    //}



    //public void RentLawnMower()
    //{
    //    Console.WriteLine("Please enter the lawn mower ID to rent:");
    //    if (int.TryParse(Console.ReadLine(), out int lawnMowerId))
    //    {
    //    LawnMower lawnMower = lawnMowers.FirstOrDefault(mower => mower.LawnMowerId == lawnMowerId);

    //    if (lawnMower != null)
    //{
    //        if (lawnMower.IsAvailable)
    //    {
    //                lawnMower.IsAvailable = false;
    //            SaveLawnMowersToJson();
    //            Console.WriteLine("Lawn mower rented successfully.");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Lawn mower with ID " + lawnMowerId + " is not available for rent.");
    //        }
    //    }
    //    else
    //    {
    //        Console.WriteLine("Lawn mower not found with the specified ID.");
    //    }
    //    }
    //    else
    //    {
    //        Console.WriteLine("Invalid input. Please enter a valid integer ID.");
    //    }  
    //       // A if and else method felt like it made the most sense to do here. 
    //}


}

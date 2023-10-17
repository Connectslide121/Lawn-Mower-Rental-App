using Lawn_Mower_Rental_App.Model;
using Lawn_Mower_Rental_App.View;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lawn_Mower_Rental_App.Controller
{
    public class LawnMowerManager
    {
        List<LawnMower> lawnMowers;
        string relativePath = Path.Combine(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..")), "InventoryData.json");

        public LawnMowerManager()
        {
            lawnMowers = LoadLawnMowersFromJson();
        }
       
        private List<LawnMower> LoadLawnMowersFromJson()
        {
            try
            {
                if (File.Exists(relativePath))
                {
                    foreach (var line in File.ReadLines(relativePath))
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 5)
                        {
                            int id = int.Parse(parts[0]);
                            string model = parts[1];
                            bool isAvailable = bool.Parse(parts[2]);
                            DateTime? lastMaintenance = string.IsNullOrEmpty(parts[3]) ? (DateTime?)null : DateTime.Parse(parts[3]);
                            decimal pricePerDay = decimal.Parse(parts[4], CultureInfo.InvariantCulture);
                            lawnMowers.Add(new LawnMower(id, lastMaintenance));
                        }
                    }
                }
            }
            catch (Exception){ ErrorsExceptions.LawnMowerFileNotFoundException(); }
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
        public void SaveLawnMowersToJson()
        {
            try
            {
                string json = SerializeToJson(lawnMowers);

                // Write the JSON string to the inventory file
                File.WriteAllText(relativePath, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error saving lawn mowers to JSON: " + ex.Message);
            }
        }

        private string SerializeToJson(List<LawnMower> lawnMowerList)
        {
            StringBuilder jsonBuilder = new StringBuilder();
            jsonBuilder.Append("[");

            foreach (var mower in lawnMowerList)
            {
                jsonBuilder.Append("{");
                jsonBuilder.AppendFormat("\"LawnMowerId\": {0},", mower.LawnMowerId);
                jsonBuilder.AppendFormat("\"Model\": \"{0}\",", mower.Model);
                jsonBuilder.AppendFormat("\"IsAvailable\": {0},", mower.IsAvailable.ToString().ToLower());
                jsonBuilder.AppendFormat("\"LastMaintenance\": \"{0}\",", mower.LastMaintenance.HasValue ? mower.LastMaintenance.Value.ToString("yyyy-MM-dd") : "");
                jsonBuilder.AppendFormat("\"PricePerDay\": {0}", mower.PricePerDay.ToString(CultureInfo.InvariantCulture));
                jsonBuilder.Append("},");
            }

            if (lawnMowerList.Count > 0)
            {

                jsonBuilder.Remove(jsonBuilder.Length - 1, 1);
            }

            jsonBuilder.Append("]");

            return jsonBuilder.ToString();
        }
        public void ReturnLawnMower()
        {
            Console.WriteLine("Please enter the lawn mower ID to return:");
            if (int.TryParse(Console.ReadLine(), out int lawnMowerId))
        {
            LawnMower lawnMower = lawnMowers.FirstOrDefault(mower => mower.LawnMowerId == lawnMowerId);

            if (lawnMower != null)
                {
                    lawnMower.IsAvailable = true;
                    SaveLawnMowersToJson();
                    Console.WriteLine("Lawn mower returned successfully.");
                }
                else
                {
                    Console.WriteLine("Lawn mower not found with the specified ID.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer ID.");
            }
        }

        public void RentLawnMower()
        {
            Console.WriteLine("Please enter the lawn mower ID to rent:");
            if (int.TryParse(Console.ReadLine(), out int lawnMowerId))
            {
            LawnMower lawnMower = lawnMowers.FirstOrDefault(mower => mower.LawnMowerId == lawnMowerId);

            if (lawnMower != null)
        {
                if (lawnMower.IsAvailable)
            {
                        lawnMower.IsAvailable = false;
                    SaveLawnMowersToJson();
                    Console.WriteLine("Lawn mower rented successfully.");
                }
                else
                {
                    Console.WriteLine("Lawn mower with ID " + lawnMowerId + " is not available for rent.");
                }
            }
            else
            {
                Console.WriteLine("Lawn mower not found with the specified ID.");
            }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer ID.");
            }  
               // A if and else method felt like it made the most sense to do here. 
        }

        public void DeleteLawnMower()
        {

        }
    }
}

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
        public void DeleteLawnMower()
        {

        }
    }
}

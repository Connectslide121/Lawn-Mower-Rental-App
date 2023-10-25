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
        private List<PetrolLawnMower> petrolLawnMowers;
        string relativePathPetrol = Path.Combine(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Data")), "PetrolLawnMowerData.json");

        private List<ElectricLawnMower> electricLawnMowers;
        string relativePathElectric = Path.Combine(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Data")), "ElectricLawnMowerData.json");

        private List<Rental> rentals;
        string relativePathRentals = Path.Combine(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Data")), "RentalData.json");

        public LawnMowerManager()
        {
            electricLawnMowers = LoadElectricLawnMowersFromJson();
            petrolLawnMowers = LoadPetrolLawnMowersFromJson();
            rentals = LoadRentalsFromJson();
            UpdateLawnMowerAvailability();
        }
       
        private List<ElectricLawnMower> LoadElectricLawnMowersFromJson() 
        {
            try
            {
                string jsonData = File.ReadAllText(relativePathElectric);
                return JsonSerializer.Deserialize<List<ElectricLawnMower>>(jsonData);
            }
            catch (Exception) { ErrorsExceptions.ElectricLawnMowerFileNotFoundException(); }
            return electricLawnMowers;
        }

        private List<PetrolLawnMower> LoadPetrolLawnMowersFromJson()
        {
            try
            {
                string jsonData = File.ReadAllText(relativePathPetrol);
                return JsonSerializer.Deserialize<List<PetrolLawnMower>>(jsonData);
            }
            catch (Exception) { ErrorsExceptions.PetrolLawnMowerFileNotFoundException(); }
            return petrolLawnMowers;
        }

        public int GetLawnMowerId()
        {
            if (electricLawnMowers.Count == 0 && petrolLawnMowers.Count == 0)
            {
                return 1;
            }
            else
            {
                int nextId = 1;
                bool idInUse;

                do
                {
                    if (electricLawnMowers.Any(mower => mower.LawnMowerId == nextId))
                    {
                        idInUse = true;
                        nextId++;
                    }
                    else if (petrolLawnMowers.Any(mower => mower.LawnMowerId == nextId))
                    {
                        idInUse = true;
                        nextId++;
                    }
                    else
                    {
                        idInUse = false;
                    }
                }
                while (idInUse == true);

            return nextId;
            }
        }

        public void SaveElectricLawnMowersToJson(List<ElectricLawnMower> electricLawnMowers)
        {
            try
            {
                string jsonData = JsonSerializer.Serialize(electricLawnMowers, typeof(List<ElectricLawnMower>), new JsonSerializerOptions
                {
                    WriteIndented = true
                });

                File.WriteAllText(relativePathElectric, jsonData);
            }
            catch { ErrorsExceptions.ElectricLawnMowerFileNotFoundException(); }
        }

        public void SavePetrolLawnMowersToJson(List<PetrolLawnMower> petrolLawnMowers)
        {
            try
            {
                string jsonData = JsonSerializer.Serialize(petrolLawnMowers, typeof(List<PetrolLawnMower>), new JsonSerializerOptions
                {
                    WriteIndented = true
                });

                File.WriteAllText(relativePathPetrol, jsonData);
            }
            catch { ErrorsExceptions.PetrolLawnMowerFileNotFoundException(); }
        }

        public void RegisterElectricLawnMower(ElectricLawnMower electricLawnMower)
        {
                electricLawnMowers.Add(electricLawnMower);
                SaveElectricLawnMowersToJson(electricLawnMowers);
        }

        public void RegisterPetrolLawnMower(PetrolLawnMower petrolLawnMower)
        {
            petrolLawnMowers.Add(petrolLawnMower);
            SavePetrolLawnMowersToJson(petrolLawnMowers);
        }


        public void DeleteLawnMower(int userInput)
        {
            DeleteLawnMowerForm deleteLawnMowerForm = new DeleteLawnMowerForm();
            int initialCount = electricLawnMowers.Count + petrolLawnMowers.Count;

            electricLawnMowers.RemoveAll(lawnMower => lawnMower.LawnMowerId == userInput);
            SaveElectricLawnMowersToJson(electricLawnMowers);

            petrolLawnMowers.RemoveAll(lawnMower => lawnMower.LawnMowerId == userInput);
            SavePetrolLawnMowersToJson(petrolLawnMowers);

            if (electricLawnMowers.Count + petrolLawnMowers.Count == initialCount)
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
            LawnMowerListView.LawnMowerListView_(electricLawnMowers, petrolLawnMowers);
        }

        public ElectricLawnMower FindElectricLawnMowerById()
        {
            int rentedElectricMowerId = electricLawnMowers.FindIndex(m => m.IsAvailable == true);
            ElectricLawnMower selectedElectricMower = new ElectricLawnMower(GetLawnMowerId());
            
            try
            {
                selectedElectricMower = electricLawnMowers[rentedElectricMowerId];
                return selectedElectricMower;
            }
            catch (Exception ex)
            {
                RentLawnMowerForm.NoLawnMowersAvailableMessage();//We shoudl have a specific message
                return selectedElectricMower;
            }
        }

        public PetrolLawnMower FindPetrolLawnMowerById()
        {
            int rentedPetrolMowerId = petrolLawnMowers.FindIndex(m => m.IsAvailable == true);
            PetrolLawnMower selectedPetrolMower = new PetrolLawnMower(GetLawnMowerId());

            try
            {
                selectedPetrolMower = petrolLawnMowers[rentedPetrolMowerId];
                return selectedPetrolMower;
            }
            catch (Exception ex)
            {
                RentLawnMowerForm.NoLawnMowersAvailableMessage();//We shoudl have a specific message
                return selectedPetrolMower;
            }
        }

        private List<Rental> LoadRentalsFromJson()
        {
            try
            {
                string jsonData = File.ReadAllText(relativePathRentals);
                return JsonSerializer.Deserialize<List<Rental>>(jsonData);
            }
            catch (Exception) { ErrorsExceptions.RentalsFileNotFoundException(); }
            return rentals;
        }

        public void UpdateLawnMowerAvailability()
        {
            List<int> lawnMowerIdsToUpdate = new List<int>();

            foreach (Rental rental in rentals)
            {
                if (rental.LawnMower.IsAvailable == false)
                {
                    lawnMowerIdsToUpdate.Add(rental.LawnMower.LawnMowerId);
                }
            }

            foreach (int id in lawnMowerIdsToUpdate)
            {
                ElectricLawnMower electricLawnMowerToUpdate = electricLawnMowers.Find(m => m.LawnMowerId == id);
                
                if (electricLawnMowerToUpdate != null)
                {
                    electricLawnMowerToUpdate.IsAvailable = false;
                }
            }
            SaveElectricLawnMowersToJson(electricLawnMowers);

            foreach (int id in lawnMowerIdsToUpdate)
            {
                PetrolLawnMower petrolLawnMowerToUpdate = petrolLawnMowers.Find(m => m.LawnMowerId == id);

                if (petrolLawnMowerToUpdate != null)
                {
                    petrolLawnMowerToUpdate.IsAvailable = false;
                }
            }
            SavePetrolLawnMowersToJson(petrolLawnMowers);
        }

        public bool UpdateMaintenanceStatus(int lawnMowerId, DateTime newMaintenanceDate)
        {
            ElectricLawnMower electricLawnMowerToUpdate = electricLawnMowers.Find(m => m.LawnMowerId == lawnMowerId);
            PetrolLawnMower petrolLawnMowerToUpdate = petrolLawnMowers.Find(m => m.LawnMowerId == lawnMowerId);

            if (electricLawnMowerToUpdate != null)
            {
                electricLawnMowerToUpdate.LastMaintenance = newMaintenanceDate;
                SaveElectricLawnMowersToJson(electricLawnMowers);
                return true;
            }
            else if(petrolLawnMowerToUpdate != null)
            {
                petrolLawnMowerToUpdate.LastMaintenance = newMaintenanceDate;
                SavePetrolLawnMowersToJson(petrolLawnMowers);
                return true;
            }
            else
            {
                Console.WriteLine("Lawn Mower not found");
                return false;
            }
        }

        public void ReturnLawnMower(int lawnMowerId)
        {
            ElectricLawnMower electricLawnMowerToReturn = electricLawnMowers.Find(m => m.LawnMowerId == lawnMowerId);
            PetrolLawnMower petrolLawnMowerToReturn = petrolLawnMowers.Find(m => m.LawnMowerId == lawnMowerId);

            if (electricLawnMowerToReturn != null)
            {
                electricLawnMowerToReturn.IsAvailable = true;
                SaveElectricLawnMowersToJson(electricLawnMowers);
            }
            else if (petrolLawnMowerToReturn != null)
            {
                petrolLawnMowerToReturn.IsAvailable = true;
                SavePetrolLawnMowersToJson(petrolLawnMowers);
            }
        }
    }
}

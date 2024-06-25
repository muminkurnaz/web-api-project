using System.Collections.Generic;
using System.Linq;
using VehicleAPI.Models;

namespace VehicleAPI.Services
{
    public class VehicleRepository
    {
        private List<Car> cars = new List<Car>
        {
            new Car { Id = 1, Color = "Red", HeadlightsOn = true, Wheels = 4, ModelYear = 2015, FuelType = "Gasoline" },
            new Car { Id = 2, Color = "Blue", HeadlightsOn = false, Wheels = 4, ModelYear = 2022, FuelType = "Diesel" },
            new Car { Id = 3, Color = "Black", HeadlightsOn = true, Wheels = 4, ModelYear = 2016, FuelType = "Gasoline" },
            new Car { Id = 4, Color = "White", HeadlightsOn = false, Wheels = 4, ModelYear = 2024, FuelType = "Diesel" },
            new Car { Id = 5, Color = "Red", HeadlightsOn = false, Wheels = 4, ModelYear = 2005, FuelType = "LPG" }
        };

        private List<Bus> buses = new List<Bus>
        {
            new Bus { Id = 1, Color = "Red",    ModelYear = 2016, FuelType = "Gasoline" },
            new Bus { Id = 2, Color = "Blue",   ModelYear = 2017, FuelType = "Gasoline" },
            new Bus { Id = 3, Color = "White",  ModelYear = 2012, FuelType = "Gasoline" },
            new Bus { Id = 4, Color = "Black",  ModelYear = 2024, FuelType = "Diesel" },
            new Bus { Id = 5, Color = "White",  ModelYear = 2022, FuelType = "Diesel" }
            
        };

        private List<Boat> boats = new List<Boat>
        {
            new Boat { Id = 1, Color = "Red",    ModelYear = 2018, FuelType = "Gasoline" },
            new Boat { Id = 2, Color = "Blue",   ModelYear = 2022, FuelType = "Gasoline" },
            new Boat { Id = 3, Color = "White",  ModelYear = 2015, FuelType = "Gasoline" },
            new Boat { Id = 4, Color = "White",  ModelYear = 2016, FuelType = "Gasoline" },
            new Boat { Id = 5, Color = "White",  ModelYear = 2022, FuelType = "Gasoline" }
        };

        private List<Plane> planes = new List<Plane>
        {
            new Plane { Id = 1, Color = "WHite",  ModelYear = 2022, FuelType = "Jet Fuel" },
            new Plane { Id = 2, Color = "White",  ModelYear = 2023, FuelType = "Jet Fuel" },
            new Plane { Id = 3, Color = "White",  ModelYear = 2024, FuelType = "Jet Fuel" },
            new Plane { Id = 4, Color = "White",  ModelYear = 2024, FuelType = "Jet Fuel" },
            new Plane { Id = 5, Color = "WHite",  ModelYear = 2020, FuelType = "Jet Fuel" }
        };

        public IEnumerable<Car> GetCarsByColor(string color) =>
            cars.Where(c => c.Color.ToLower() == color.ToLower());

        public IEnumerable<Bus> GetBusesByColor(string color) =>
            buses.Where(b => b.Color.ToLower() == color.ToLower());

        public IEnumerable<Boat> GetBoatsByColor(string color) =>
            boats.Where(b => b.Color.ToLower() == color.ToLower());

        public IEnumerable<Plane> GetPlanesByModelYear(int modelYear) =>
            planes.Where(p => p.ModelYear == modelYear);



        public void TurnOnOffHeadlights(int carId, bool turnOn)
        {
            var car = cars.FirstOrDefault(c => c.Id == carId);
            if (car != null)
            {
                car.HeadlightsOn = turnOn;
                return;
            }

         
        }

        public void DeleteCar(int carId)
        {
            var car = cars.FirstOrDefault(c => c.Id == carId);
            if (car != null)
            {
                cars.Remove(car);
            }
        }
        public void DeleteBus(int busId)
        {
            var bus = buses.FirstOrDefault(b => b.Id == busId);
            if (bus != null)
            {
                buses.Remove(bus);
            }
        }

        public void DeleteBoat(int boatId)
        {
            var boat = boats.FirstOrDefault(b => b.Id == boatId);
            if (boat != null)
            {
                boats.Remove(boat);
            }
        }

        public void DeletePlane(int planeId)
        {
            var plane = planes.FirstOrDefault(p => p.Id == planeId);
            if (plane != null)
            {
                planes.Remove(plane);
            }
        }
        public void AddCar(Car car)
        {
            cars.Add(car);
        }

        public void AddBus(Bus bus)
        {
            buses.Add(bus);
        }

        public void AddBoat(Boat boat)
        {
            boats.Add(boat);
        }

        public void AddPlane(Plane plane)
        {
            planes.Add(plane);
        }


        public IEnumerable<Vehicle> GetAllVehicles() =>
            cars.Cast<Vehicle>().Concat(buses).Concat(boats).Concat(planes);

        public IEnumerable<Car> GetAllCars() => cars;
        public IEnumerable<Bus> GetAllBuses() => buses;
        public IEnumerable<Boat> GetAllBoats() => boats;
        public IEnumerable<Plane> GetAllPlanes() => planes;

        public IEnumerable<Vehicle> GetVehiclesByColor(string color) =>
            GetAllVehicles().Where(v => v.Color.ToLower() == color.ToLower());

        public IEnumerable<Vehicle> GetAllVehiclesSortedByModelYear() =>
            GetAllVehicles().OrderBy(v => v.ModelYear);
    }
}

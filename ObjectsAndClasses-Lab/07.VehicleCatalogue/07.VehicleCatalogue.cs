using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Car> newListCars = new List<Car>();
            List<Truck> newListTrucks = new List<Truck>();
            Catalog catalogueVehlice = new Catalog();

            while (input != "end")
            {
                string[] data = input.Split('/').ToArray();

                string type = data[0];
                string brand = data[1];
                string model = data[2];

                if (type == "Car")
                {
                    int horsePower = int.Parse(data[3]);
                    Car currentCar = new Car();
                    currentCar.Brand = brand;
                    currentCar.Model = model;
                    currentCar.HorsePower = horsePower;

                    newListCars.Add(currentCar);

                }

                else if (type == "Truck")
                {
                    int weight = int.Parse(data[3]);
                    Truck currentTrucks = new Truck();
                    currentTrucks.Brand = brand;
                    currentTrucks.Model = model;
                    currentTrucks.Weight = weight;

                    newListTrucks.Add(currentTrucks);
                }

                input = Console.ReadLine();
            }
            catalogueVehlice.Cars = newListCars;
            catalogueVehlice.Trucks = newListTrucks;

            if (catalogueVehlice.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");

                foreach (Car carList in catalogueVehlice.Cars.OrderBy(car => car.Brand))
                {
                    Console.WriteLine($"{carList.Brand}: {carList.Model} - {carList.HorsePower}hp");
                }
            }


            if (catalogueVehlice.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");

                foreach (Truck truckList in catalogueVehlice.Trucks.OrderBy(truck => truck.Brand))
                {
                    Console.WriteLine($"{truckList.Brand}: {truckList.Model} - {truckList.Weight}kg");
                }
            }

        }
    }
    public class Truck
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public int Weight { get; set; }
    }

    public class Car
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public int HorsePower { get; set; }
    }

    public class Catalog
    {
        public List<Car> Cars { get; set; }

        public List<Truck> Trucks { get; set; }

        //public void CatalogueVehlice(List<Car> newListCars, List<Truck> newListTrucks)
        //{
        //    Cars = new List<Car>();
        //    Trucks = new List<Truck>();
        //}


    }
}

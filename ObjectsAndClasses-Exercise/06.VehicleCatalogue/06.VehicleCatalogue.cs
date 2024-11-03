using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Vehicle> vehicles = new List<Vehicle>();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] commandEllements = command.Split().ToArray();
                string type = commandEllements[0];
                string model = commandEllements[1];
                string color = commandEllements[2];
                string horsePower = commandEllements[3];

                Vehicle vehicle = new Vehicle(type, model, color, double.Parse(horsePower));
                vehicles.Add(vehicle);
                command = Console.ReadLine();

            }

            string currentModel = Console.ReadLine();

            while (currentModel != "Close the Catalogue")
            {

                Console.WriteLine(vehicles.FirstOrDefault(x => x.Model == currentModel).ToString());

                currentModel = Console.ReadLine();
            }

            List<Vehicle> cars = vehicles.FindAll(x => x.Type == "car");
            double carHorsePower = cars.Sum(c => c.HorsePower);
            double carAveragePower = carHorsePower / cars.Count;

            List<Vehicle> trucks = vehicles.FindAll(x => x.Type == "truck");
            double truckHorsePower = trucks.Sum(c => c.HorsePower);
            double truckAveragePower = truckHorsePower / trucks.Count;

            if (cars.Count == 0)
            {
                carAveragePower = 0;
            }
            if (trucks.Count == 0)
            {
                truckAveragePower = 0;
            }

            Console.WriteLine($" Cars have average horsepower of: {carAveragePower:F2}.");
            Console.WriteLine($" Trucks have average horsepower of: {truckAveragePower:F2}.");
    
        }

        public class Vehicle
        {
            public string Type { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }
            public double HorsePower { get; set; }

            public Vehicle(string type, string model, string color, double horsePower)
            {
                this.Type = type;
                this.Model = model;
                this.Color = color;
                this.HorsePower = horsePower;

            }

            public override string ToString()
            {

                StringBuilder sb = new StringBuilder();

                if (this.Type == "car")
                {
                    sb.AppendLine($"Type: Car");
                }
                else if (this.Type == "truck")
                {
                    sb.AppendLine($"Type: Truck");
                }
                sb.AppendLine($"Model: { this.Model}");
                sb.AppendLine($"Color: { this.Color}");
                sb.AppendLine($"Horsepower: { this.HorsePower}");

                return sb.ToString().TrimEnd();
            }
        }
    }
}

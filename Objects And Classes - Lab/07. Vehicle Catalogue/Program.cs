using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            Catalogue catalogue = new Catalogue();

            while (true)
            {
                string command = Console.ReadLine();

                if (command=="end")
                {
                    break;
                }

                string[] commandSplit = command.Split('/');

                string type = commandSplit[0];


                if (type == "Car")
                {
                    Car car = new Car
                    {
                        Brand = commandSplit[1],
                        Model = commandSplit[2],
                        HorsePower = int.Parse(commandSplit[3])
                    };
                        catalogue.Cars.Add(car);
                   
                }
                else if (type == "Truck")
                {
                    Truck truck = new Truck
                    {
                        Brand = commandSplit[1],
                        Model = commandSplit[2],
                        Weight = int.Parse(commandSplit[3])
                    };
                    catalogue.Trucks.Add(truck);
                }
            }

            if (catalogue.Cars.Count>0)
            {
            List<Car> orderedAlphabeticalCars = catalogue.Cars.OrderBy(car => car.Brand).ToList();

                    Console.WriteLine("Cars:");
                foreach (Car car in orderedAlphabeticalCars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            if (catalogue.Trucks.Count > 0)
            {
                List<Truck> orderedAlphabeticalTrucks = catalogue.Trucks.OrderBy(truck => truck.Brand).ToList();

                Console.WriteLine("Trucks:");
                foreach (Truck truck in orderedAlphabeticalTrucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }

        }
    }
    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }

    class Car
    {
        
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }

    class Catalogue
    {
        public Catalogue()
        {
            Cars = new List<Car>();
            Trucks = new List<Truck>();
        }

        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }
    }
}
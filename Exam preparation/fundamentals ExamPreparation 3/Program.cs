using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Catalogue> catalogue = new List<Catalogue>();

            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] info = input.Split();
                string type = info[0];
                string model = info[1];
                string color = info[2];
                int horsePower = int.Parse(info[3]);

                Catalogue vehicle = new Catalogue
                {
                    Type = type,
                    Model = model,
                    Color = color,
                    HorsePower = horsePower
                };
                catalogue.Add(vehicle);

                input = Console.ReadLine();
            }

            var truckList = catalogue.Where(x => x.Type == "truck").ToList();
            var carsList = catalogue.Where(x => x.Type == "car").ToList();

            input = Console.ReadLine();
            while (input != "Close the Catalogue")
            {
                var currCar = carsList.Where(x => x.Model == input).ToList();
                var currTruck = truckList.Where(x => x.Model == input).ToList();

                if (currCar.Count > 0)
                {
                    Console.WriteLine($"Type: Car");
                    Console.WriteLine($"Model: {currCar[0].Model}");
                    Console.WriteLine($"Color: {currCar[0].Color}");
                    Console.WriteLine($"Horsepower: {currCar[0].HorsePower}");
                }
                else
                {
                    Console.WriteLine($"Type: Truck");
                    Console.WriteLine($"Model: {currTruck[0].Model}");
                    Console.WriteLine($"Color: {currTruck[0].Color}");
                    Console.WriteLine($"Horsepower: {currTruck[0].HorsePower}");
                }

                input = Console.ReadLine();
            }

            var avarageHpCars = carsList.Select(x => x.HorsePower).Average();
            var avarageHpTrucks = truckList.Select(x => x.HorsePower).Average();

            Console.WriteLine($"Cars have average horsepower of: {avarageHpCars:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {avarageHpTrucks:f2}.");
        }
    }
    class Catalogue
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace Exersice_6._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            Catalogue catalogue = new Catalogue();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }

                string[] tokens = command.Split();
                string type = tokens[0];

                if (type == "car")
                {
                    Cars car = new Cars
                    {
                        Type = tokens[0],
                        Model = tokens[1],
                        Color = tokens[2],
                        HorsePower = int.Parse(tokens[3])
                    };
                    catalogue.listCars.Add(car);
                }

                else if (type == "truck")
                {
                    Trucks truck = new Trucks
                    {
                        Type = tokens[0],
                        Model = tokens[1],
                        Color = tokens[2],
                        HorsePower = int.Parse(tokens[3])
                    };
                    catalogue.listTrucks.Add(truck);
                }
            }

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Close the Catalogue")
                {
                    break;
                }

                string[] tokens = command.Split();
                string vehicleMake = tokens[0];

                foreach (var car in catalogue.listCars)
                {
                    if (car.Model == vehicleMake)
                    {
                        Console.WriteLine($"Type: {char.ToUpper(car.Type[0]) + car.Type.Substring(1).ToLower()}");
                        Console.WriteLine($"Model: {car.Model}");
                        Console.WriteLine($"Color: {car.Color}");
                        Console.WriteLine($"Horsepower: {car.HorsePower}");
                    }
                }

                foreach (var truck in catalogue.listTrucks)
                {
                    if (truck.Model == vehicleMake)
                    {
                        Console.WriteLine($"Type: {char.ToUpper(truck.Type[0]) + truck.Type.Substring(1).ToLower()}");
                        Console.WriteLine($"Model: {truck.Model}");
                        Console.WriteLine($"Color: {truck.Color}");
                        Console.WriteLine($"Horsepower: {truck.HorsePower}");
                    }
                }
            }

            double carsAvarageHorsePower = catalogue.listCars.Select(x => x.HorsePower).Average();
            double trucksAvarageHorsePower = catalogue.listTrucks.Select(x => x.HorsePower).Average();

            Console.WriteLine($"Cars have average horsepower of: {carsAvarageHorsePower:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {trucksAvarageHorsePower:f2}.");
        }
    }
}
class Cars
{
    public string Type { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }
    public int HorsePower { get; set; }
}
class Trucks
{
    public string Type { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }
    public int HorsePower { get; set; }
}
class Catalogue
{
    public Catalogue()
    {
        listCars = new List<Cars>();
        listTrucks = new List<Trucks>();
    }
    public List<Cars> listCars { get; set; }
    public List<Trucks> listTrucks { get; set; }
}



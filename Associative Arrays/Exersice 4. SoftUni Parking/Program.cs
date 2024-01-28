using System;
using System.Collections.Generic;

namespace _4._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, string> parkingSpots = new Dictionary<string, string>();
            int numberOfCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCars; i++)
            {
                string input = Console.ReadLine();
                string[] tokens = input.Split();
                string command = tokens[0];

                if (command == "register")
                {
                    string name = tokens[1];
                    string plateNumber = tokens[2];
                    if (!parkingSpots.ContainsKey(name))
                    {
                        parkingSpots.Add(name, plateNumber);
                        Console.WriteLine($"{name} registered {plateNumber} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {plateNumber}");
                    }
                }

                else if (command == "unregister")
                {
                    string name = tokens[1];
                    if (!parkingSpots.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                    else
                    {
                        parkingSpots.Remove(name);
                        Console.WriteLine($"{name} unregistered successfully");
                    }
                }
            }

            foreach (var car in parkingSpots)
            {
                Console.WriteLine($"{car.Key} => {car.Value}");
            }
        }
    }
}
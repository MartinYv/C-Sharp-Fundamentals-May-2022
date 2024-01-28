using System;
using System.Collections.Generic;

namespace Problem_3___P_rates
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, KeyValuePair<int, int>> targetedCities = new Dictionary<string,  KeyValuePair<int, int>>();

            string input = Console.ReadLine();
            while (input!="Sail")
            {
                string[] info = input.Split("||");
                //city, population, gold

                string city = info[0];
                int population = int.Parse(info[1]);                     
                int gold = int.Parse(info[2]);

                if (!targetedCities.ContainsKey(city))
                {
                    targetedCities.Add(city, new KeyValuePair<int, int>(population, gold));
                }
                else
                {
                    targetedCities[city] = new KeyValuePair<int, int>(targetedCities[city].Key + population, targetedCities[city].Value + gold);
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            while (input!="End")
            {
                string[] info = input.Split("=>");
                string action = info[0];

                if (action == "Plunder")
                {
                    string city = info[1];
                    int peopleKilled = int.Parse(info[2]);
                    int goldStolen = int.Parse(info[3]);

                    targetedCities[city] = new KeyValuePair<int, int>(targetedCities[city].Key - peopleKilled, targetedCities[city].Value - goldStolen);

                    Console.WriteLine($"{city} plundered! {goldStolen} gold stolen, {peopleKilled} citizens killed.");

                    if (targetedCities[city].Key <=0 || targetedCities[city].Value <= 0)
                    {
                        Console.WriteLine($"{city} has been wiped off the map!");
                        targetedCities.Remove(city);
                    }
                }

                else if (action == "Prosper")
                {
                    string city = info[1];
                    int goldGiven = int.Parse(info[2]);

                    if (goldGiven < 0)
                    {
                        Console.WriteLine($"Gold added cannot be a negative number!");
                      // input = Console.ReadLine();
                      // continue;
                    }
                    else
                    {
                        targetedCities[city] = new KeyValuePair<int, int>(targetedCities[city].Key, targetedCities[city].Value + goldGiven);
                        Console.WriteLine($"{goldGiven} gold added to the city treasury. {city} now has {targetedCities[city].Value} gold.");
                    }
                } 
                
                input = Console.ReadLine();
            }

            if (targetedCities.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {targetedCities.Count} wealthy settlements to go to:");
                foreach (var city in targetedCities)
                {
                    Console.WriteLine($"{city.Key} -> Population: {city.Value.Key} citizens, Gold: {city.Value.Value} kg");
                }
            }
            else
            {
                Console.WriteLine($"Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }
    }
}

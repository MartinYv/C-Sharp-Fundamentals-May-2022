using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3___Plant_Discovery
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, KeyValuePair<int, List<int>>> flowers = new Dictionary<string, KeyValuePair<int, List<int>>>();
            int numberOfFlowers = int.Parse(Console.ReadLine());


            for (int i = 0; i < numberOfFlowers; i++)
            {
                string[] flowersInfo = Console.ReadLine().Split("<->");

                string plant = flowersInfo[0];
                int rarity = int.Parse(flowersInfo[1]);

                if (!flowers.ContainsKey(plant))
                {
                    flowers.Add(plant, new KeyValuePair<int, List<int>>(rarity, new List<int>()));
                }
                else
                {
                    flowers.Remove(plant);
                    flowers.Add(plant, new KeyValuePair<int, List<int>>(rarity, new List<int>()));
                }
            }

            string command = Console.ReadLine();
            while (command != "Exhibition")
            {
                string[] flowersInfo = command.Split(new char[] { ':', '-', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string action = flowersInfo[0];
                string plant = flowersInfo[1];

               if (!flowers.ContainsKey(plant))
               {
                   Console.WriteLine("error");
                   command = Console.ReadLine();
                    continue;
               }

                if (action == "Rate")
                {
                    int rating = int.Parse(flowersInfo[2]);                  
                    flowers[plant].Value.Add(rating);
                }
                else if (action == "Update")
                {
                    int newRarity = int.Parse(flowersInfo[2]);
                    flowers[plant] = new KeyValuePair<int, List<int>>(newRarity, new List<int>(flowers[plant].Value));
                }
                else if (action == "Reset")
                {
                    flowers[plant] = new KeyValuePair<int, List<int>>(flowers[plant].Key, new List<int>());
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Plants for the exhibition:");

            foreach (var flower in flowers)
            {
                double sum = flower.Value.Value.Sum();
                double count = flower.Value.Value.Count;
                double avarage = sum / count;
                
                if (Double.IsNaN(avarage))
                {
                    avarage = 0;
                }
                Console.WriteLine($"- {flower.Key}; Rarity: {flower.Value.Key}; Rating: {Math.Abs(avarage):f2}");
            }
        }
    }
}
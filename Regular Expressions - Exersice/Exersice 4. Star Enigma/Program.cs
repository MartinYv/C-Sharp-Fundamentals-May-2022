using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Exersice_4._Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<name>[A-z][a-z]+)*[^@\/,!:']*:(?<population>[\d]+)[^@\/,!:']*!(?<type>[A,D])[^@\/,!:']*!->(?<soliderCount>[\d]+)";
            List<string> atackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();


            int numberOfMessages = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfMessages; i++)
            {
                string message = Console.ReadLine();
                int sum = message.ToLower().Count(x => x == 's' || x == 't' || x == 'a' || x == 'r');
                
                string decriptedMessage = "";
               
                foreach (var ch in message)
                {
                    decriptedMessage += (char)(ch - sum);
                }

                Match match = Regex.Match(decriptedMessage, pattern);

                if (match.Success)
                {
                    string nameOfThePlanet = match.Groups["name"].Value;
                    char type = char.Parse(match.Groups["type"].Value);

                    if (type == 'A')
                    {
                        atackedPlanets.Add(nameOfThePlanet);
                    }
                    else
                    {
                        destroyedPlanets.Add(nameOfThePlanet);
                    }
                }
            }
            Console.WriteLine($"Attacked planets: {atackedPlanets.Count}");
            if (atackedPlanets.Count > 0)
            {
                foreach (var planet in atackedPlanets)
                {
                    Console.WriteLine($"-> {string.Join("", planet)} ");
                }
            }
            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            if (destroyedPlanets.Count >0)
            {
                foreach (var planet in destroyedPlanets)
                {
                    Console.WriteLine($"-> {string.Join("", planet)} ");
                }
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Exersice_2._Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string namePatten = @"(?<name>[A-Za-z])";
            string numbersPattern = @"(?<numbers>\d+)";
            var participants = new Dictionary<string, int>();


            List<string> membersInTheRace = Console.ReadLine().Split(", ").ToList();
            string input = Console.ReadLine();

            while (input != "end of race")
            {
                MatchCollection name = Regex.Matches(input, namePatten);
                MatchCollection kilometers = Regex.Matches(input, numbersPattern);


                string nameOfParticipant = "";
                foreach (Match letter in name)
                {
                    nameOfParticipant += letter;
                }


                string currKilometersToString = string.Join("", kilometers);
                int currKillometersToInt = 0;
                for (int i = 0; i < currKilometersToString.Length; i++)
                {
                    currKillometersToInt += int.Parse(currKilometersToString[i].ToString());
                }


                if (membersInTheRace.Contains(nameOfParticipant))
                {
                    if (!participants.ContainsKey(nameOfParticipant))
                    {
                        participants.Add(nameOfParticipant, currKillometersToInt);

                    }
                    else
                    {
                        participants[nameOfParticipant] += currKillometersToInt;
                    }
                }

                input = Console.ReadLine();
            }

            var top3 = participants.OrderByDescending(x => x.Value).Take(3).ToList();
            Console.WriteLine($"1st place: {top3[0].Key}");
            Console.WriteLine($"2nd place: {top3[1].Key}");
            Console.WriteLine($"3rd place: {top3[2].Key}");

          // for (int i = 0; i < top3.Count; i++)
          // {
          //     Console.WriteLine($"1st place: {top3[0].Key}");
          //     Console.WriteLine($"2nd place: {top3[1].Key}");
          //     Console.WriteLine($"3rd place: {top3[2].Key}");
          //     break;
          // }
            

        }
    }
}

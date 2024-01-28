using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {

            List <string> numsAndWordsList = Console.ReadLine().Split().ToList();

            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (var word in numsAndWordsList)
            {
                string currWord = word.ToLower();

                if (counts.ContainsKey(currWord))
                {
                    counts[currWord]++;
                }
                else
                {
                    counts.Add(currWord, 1);
                }
            }

            foreach (var currCount in counts)
            {
            if (currCount.Value % 2 != 0)
            {
                    Console.Write($"{currCount.Key} ");
            }

            }


        }
    }
}

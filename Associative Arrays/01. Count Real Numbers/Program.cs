using System;
using System.Collections.Generic;
using System.Linq;

namespace Associative_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

            SortedDictionary<double, int> counts = new SortedDictionary<double, int>();
            foreach (var currNum in numbers)
            {
                if (counts.ContainsKey(currNum))
                {
                    counts[currNum]++;
                }
                else
                {
                    counts.Add(currNum, 1);
                }
            }

            foreach (var number in counts)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}

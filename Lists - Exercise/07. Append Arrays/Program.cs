using System;
using System.Linq;

namespace _07._Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("|").Select(s => string.Join(" ", s.Split(" ", StringSplitOptions.RemoveEmptyEntries))).Where(s => !string.IsNullOrWhiteSpace(s)).Reverse().ToArray();

            Console.WriteLine(string.Join(" ", input));
        }
    }
}

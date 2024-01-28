using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> firstNums = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondNums = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> result = new List<int>();

            int biggerList = Math.Max(firstNums.Count, secondNums.Count);

            for (int i = 0; i < biggerList; i++)
            {
                if (firstNums.Count > i)
                {
                    result.Add(firstNums[i]);
                }
                if (secondNums.Count > i)
                {
                    result.Add(secondNums[i]);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}

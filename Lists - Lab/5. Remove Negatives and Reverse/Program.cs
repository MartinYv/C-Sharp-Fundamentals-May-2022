using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < Numbers.Count; i++)
            {
                if (Numbers[i] < 0)
                {
                   Numbers.RemoveAt (i);
                    i--; ;
                }
            }
            Numbers.Reverse();
            if (Numbers.Count <= 0)
            {
                Console.WriteLine("empty");
                return;
            }
            Console.WriteLine(string.Join(" ", Numbers));
        }
    }
}

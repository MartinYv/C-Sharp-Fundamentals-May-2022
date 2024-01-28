using System;
using System.Linq;

namespace _06._Even_and_Odd_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int odd = 0;
            int even = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int number = numbers[i];

                if (number %2 == 0)
                {
                    even += number;
                }
                else
                {
                    odd += number;
                }


            }
                Console.WriteLine(even-odd);

           }
    }
}

using System;
using System.Linq;

namespace Exercise_03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            int lines = int.Parse(Console.ReadLine());
            int []arrayOne = new int[lines];
            int[] arrayTwo = new int[lines];

            for (int i = 0; i < lines; i++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (i%2==0)
                {
                    arrayOne[i] = numbers[0];
                    arrayTwo[i] = numbers[1];
                }
                else
                {
                    arrayOne[i] = numbers[1];
                    arrayTwo[i] = numbers[0];
                }
            }
            Console.WriteLine(String.Join(" ", arrayOne));
            Console.WriteLine(String.Join(" ", arrayTwo));
        }
    }
}

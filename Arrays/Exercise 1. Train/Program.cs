using System;

namespace Exercise_1._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int[] wagons = new int[input];
            int sum = 0;
            for (int i = 0; i < wagons.Length; i++)
            {
                
                wagons[i] = int.Parse(Console.ReadLine());
                sum +=wagons[i];
            }
            foreach (var wagon in wagons)
            {
                Console.Write($"{wagon} ");
            }
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}

using System;

namespace _5._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string order = Console.ReadLine();
            double quanity = double.Parse(Console.ReadLine());

            OrderPrice(order, quanity);
          
        }

        private static void OrderPrice(string order, double quanity)
        {
            if (order == "coffee")
            {
                Console.WriteLine($"{(1.50 * quanity):f2}");
            }
            else if (order == "water")
            {
                Console.WriteLine($"{(1 * quanity):f2}");
            }
            else if (order == "coke")
            {
                Console.WriteLine($"{(1.40 * quanity):f2}");
            }
            else if (order == "snacks")
            {
                Console.WriteLine($"{(2 * quanity):f2}");

            }
        }
    }
}

using System;

namespace _1._Burger_bus
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCities = int.Parse(Console.ReadLine());

            // Печалбата се смята като се извади разхода от нея.
            decimal incomePerCity = 0;
            decimal totalIncome = 0;
            decimal expencesPerCity = 0;
            


            for (int i = 1; i <=numberOfCities; i++)
            {
               
                string nameOfTheCity = Console.ReadLine();
                incomePerCity = decimal.Parse(Console.ReadLine());
                expencesPerCity = decimal.Parse(Console.ReadLine());

                

                if (i % 3 == 0)
                {
                    expencesPerCity += expencesPerCity * (decimal)0.5;
                }

                if (i % 5 == 0)
                {
                    incomePerCity -= incomePerCity * (decimal)0.10;
                }

                incomePerCity -= expencesPerCity;
                totalIncome += incomePerCity;

                Console.WriteLine($"In {nameOfTheCity} Burger Bus earned {incomePerCity:f2} leva.");
                 
            }
            Console.WriteLine($"Burger Bus total profit: {totalIncome:f2} leva.");
            


        }
    }
}

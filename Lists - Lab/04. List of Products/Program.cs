using System;
using System.Collections.Generic;

namespace _04._List_of_Products
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfProducts = int.Parse(Console.ReadLine());
            List<string> ListOfProducts = new List <string>();
            
            for (int i = 0; i < numberOfProducts; i++)
            {
               string product = Console.ReadLine();
                ListOfProducts.Add(product);
            }

            ListOfProducts.Sort();
            int counter = 1;

            foreach (var product in ListOfProducts)
            {
                Console.WriteLine($"{counter++}.{product}");
            }
        }
    }
}

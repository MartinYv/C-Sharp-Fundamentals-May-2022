using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Exersice_1._Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
        
            string pattern = @">>(?<product>[A-Z][a-z]+)<<(?<price>\d+(.\d+)?)!(?<quantity>\d+)";
            List<string> products = new List<string>();
            double totalPrice = 0;
            
            string input = Console.ReadLine();
            while (input != "Purchase")
            {
                Match matches = Regex.Match(input, pattern, RegexOptions.IgnoreCase);
                if (matches.Success)
                {
                    var name = matches.Groups["product"].Value;
                    products.Add(name);
                    var price = double.Parse(matches.Groups["price"].Value);
                    var quantity = double.Parse(matches.Groups["quantity"].Value);
                    totalPrice += price * quantity;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Bought furniture:");
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
            Console.WriteLine($"Total money spend: {totalPrice:f2}");


        }
    }
}

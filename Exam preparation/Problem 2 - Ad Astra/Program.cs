using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Problem_2___Ad_Astra
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(#{1}|\|{1})(?<product>[A-Z][a-z]* ?[A-z][a-z]*)\1(?<date>[\d+]{2}\/[\d+]{2}\/[\d+]{2})(#{1}|\|{1})(?<callories>[0-9]{1,})\1";

            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, pattern);

            int callories = 0;
            

            foreach (Match match in matches)
            {
                callories += int.Parse(match.Groups["callories"].Value);
            }

            int foodLastsForDays = callories / 2000;

            Console.WriteLine($"You have food to last you for: {foodLastsForDays} days!");

            foreach (Match product in matches)
            {
                Console.WriteLine($"Item: {product.Groups["product"].Value}, Best before: {product.Groups["date"].Value}, Nutrition: {product.Groups["callories"].Value}");

            }


        }
    }
}

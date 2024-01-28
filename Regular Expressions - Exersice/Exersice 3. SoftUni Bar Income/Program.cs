using System;
using System.Text.RegularExpressions;

namespace Exersice_3._SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"%(?<name>[A-Z][a-z]+)%[^|,.%]*<(?<product>[\w]+)>[^|,.%]*\|(?<quantity>[\d]+)\|[^|,.%]*?(?<price>[\d]+.?[\d]+)?\$";
            double totalPrice = 0;
            string input = Console.ReadLine();
            while (input != "end of shift")
            {
                Match currMatch = Regex.Match(input, pattern);

                if (currMatch.Success)
                {
                    //George: Croissant - 20.60
                    double currPrice = double.Parse(currMatch.Groups["quantity"].Value) * double.Parse (currMatch.Groups["price"].Value);
                    Console.WriteLine($"{currMatch.Groups["name"]}: {currMatch.Groups["product"]} - {currPrice:f2}");
                    totalPrice += currPrice;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {totalPrice:f2}");

                }
    }
}

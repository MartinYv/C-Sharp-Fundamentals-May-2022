using System;
using System.Text.RegularExpressions;

namespace regex_task
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\S+)(\>{1})(?<digits>[\d]{3})(\|{1})(?<lower>[a-z]{3})(\|{1})(?<upper>[A-Z]{3})(\|{1})(?<simbols>[\S]{3})(\<{1})\1";


            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                Match match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    string enctiptedPass = $"{match.Groups["digits"].Value}" + $"{match.Groups["lower"].Value}" + $"{match.Groups["upper"]}" + $"{match.Groups["simbols"]}";
                    Console.WriteLine($"Password: {enctiptedPass}");
                }
                else
                {
                    Console.WriteLine("Try another password!");
                }
            }
        }
    }
}

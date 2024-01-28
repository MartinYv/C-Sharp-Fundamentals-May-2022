using System;
using System.Text.RegularExpressions;

namespace _3._Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
           string pattern = @"(?<date>[0-9]{2})([-/\.])(?<month>[A-Z][a-z]{2})\1(?<year>[0-9]{4})";

            MatchCollection matches = Regex.Matches(input, pattern);

            //Now it's time to find all the valid dates in the input and print each date in the following format:
            //"Day: {day}, Month: {month}, Year: {year}", each on a new line.

            foreach (Match match in matches)
            {
                var date = match.Groups["date"];
                var month = match.Groups["month"];
                var year = match.Groups["year"];
                Console.WriteLine($"Day: {date}, Month: {month}, Year: {year}");
            }

        }
    }
}

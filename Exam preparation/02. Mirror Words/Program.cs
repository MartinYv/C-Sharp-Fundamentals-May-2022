using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Mirror_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\#|@)(?<word1>[A-z]{3,})\1{2}(?<word2>[A-z]{3,})\1";
            string input = Console.ReadLine();

            List<string[]> pairs = new List<string[]>();

            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                string wordOne = match.Groups["word1"].Value;
                string wordTwo = string.Join("", match.Groups["word2"].Value.ToString().Reverse());

                if (wordOne == wordTwo)
                {
                    pairs.Add(new string[2] { wordOne, match.Groups["word2"].Value });
                }
            }


            if (matches.Count <= 0)
            {
                Console.WriteLine($"No word pairs found!");
            }
            else
            {
                Console.WriteLine($"{matches.Count} word pairs found!");
            }

            if (pairs.Count <= 0)
            {
                Console.WriteLine($"No mirror words!");
            }
            else
            {
                Console.WriteLine($"The mirror words are:");
            }

            Console.Write(string.Join(", ", pairs.Select(x => $"{x[0]} <=> {x[1]}")));

        }
    }
}

using System;
using System.Linq;

namespace _4._Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            //     string[] bannedWords = Console.ReadLine().Split(", ");
            //     string text = Console.ReadLine();
            //
            //     foreach (var word in bannedWords)
            //     {
            //         string replacedByAsterisks = new string ('*', word.Length);
            //         text = text.Replace(word, replacedByAsterisks);
            //     }
            //     Console.WriteLine(text);


            string[] bannedWords = Console.ReadLine().Split(", ").ToArray();
            string text = Console.ReadLine();

            foreach (var word in bannedWords)
            {
                if (text.Contains(word))
                {
                    string replacedByAsterisks = new string('*', word.Length);
                    text = text.Replace(word, replacedByAsterisks);
                }
            }
            Console.WriteLine(text);


        }
        
    }
}


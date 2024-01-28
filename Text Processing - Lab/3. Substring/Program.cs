using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordToRemove = Console.ReadLine();
            string text = Console.ReadLine();

            while (text.Contains(wordToRemove))
            {
                
               text= text.Replace(wordToRemove, string.Empty);

               
            }
            Console.WriteLine(text);
        }
    }
}

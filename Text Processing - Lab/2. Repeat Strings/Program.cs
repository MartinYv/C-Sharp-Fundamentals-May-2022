﻿using System;
using System.Linq;

namespace _2._Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
                string[] words = Console.ReadLine().Split().ToArray();
           
                foreach (var word in words)
                {
                    for (int i = 0; i < word.Length; i++)
                    {
                    Console.Write($"{word}");
           
                   }
               }

        }
    }
}

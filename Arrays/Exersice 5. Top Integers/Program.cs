﻿using System;
using System.Linq;

namespace Ecersices_5._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                bool biggerNumber = true;
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[i]<=array[j])
                    {
                        biggerNumber = false;
                    }
                }
                if (biggerNumber)
                {
                    Console.Write($"{array[i]} ");
                }
            }


                }
    }
}

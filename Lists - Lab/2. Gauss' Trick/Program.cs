﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Gauss__Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> summedNumbers = new List <int>();
            for (int i = 0; i < numbers.Count/2; i++)
            {
                int currentSummedN = numbers[i] + numbers[numbers.Count-1 - i];
                summedNumbers.Add(currentSummedN);
            }
            if (numbers.Count % 2 != 0)
            {
                summedNumbers.Add (numbers[numbers.Count / 2]);
            }
            Console.WriteLine(string.Join(" ", summedNumbers));
        }
    }
}

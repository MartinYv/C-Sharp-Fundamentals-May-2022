﻿using System;
using System.Linq;

namespace Problem_2___The_Lift
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleWaiting = int.Parse(Console.ReadLine());
            int[] lift = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            for (int i = 0; i < lift.Length ; i++)
            {

                while (lift[i] != 4)
                {
                    if (peopleWaiting > 0)
                    {

                        lift[i]++;
                        peopleWaiting--;

                    }
                    else
                    {
                        break;
                    }


                }
            }
            if (!lift.All(x => x == 4) && (peopleWaiting == 0))
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(' ', lift));
            }

            else if (lift.All(x => x == 4) && peopleWaiting > 0)
            {
                Console.WriteLine($"There isn't enough space! {peopleWaiting} people in a queue!");
                Console.WriteLine(string.Join(' ', lift));
            }

            else if (lift.All(x => x == 4) && peopleWaiting == 0)
            {
                Console.WriteLine(string.Join(' ', lift));
            }           
        }
    }
}
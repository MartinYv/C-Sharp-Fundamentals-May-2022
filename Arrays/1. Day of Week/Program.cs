using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            int daysOfTheWeek =int.Parse(Console.ReadLine());
            string[] weekDays =
            {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"
            };

            if (daysOfTheWeek <= 7 && daysOfTheWeek >= 1)
            {
                Console.WriteLine(weekDays[daysOfTheWeek-1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
              
            }

            }
        }
    }


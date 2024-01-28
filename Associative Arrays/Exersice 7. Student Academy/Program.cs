using System;
using System.Collections.Generic;
using System.Linq;

namespace Exersice_7._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int rotations = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> Students = new Dictionary<string, List<double>>();
            
            for (int i = 0; i < rotations; i++)
            {
                string currName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!Students.ContainsKey(currName))
                {
                    Students[currName] = new List<double>();

                }
                Students[currName].Add(grade);

                }

            foreach (var student in Students)
            {
                if (student.Value.Average() >= 4.5)
                {
                    Console.WriteLine($"{student.Key} -> {student.Value.Average():f2}");
                }

            }


            }

        }
    }


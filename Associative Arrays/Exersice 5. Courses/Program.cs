using System;
using System.Collections.Generic;

namespace Exerice_5._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> students = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input== "end")
                {
                    break;
                }

                string[] tokens = input.Split(" : ");

                string courseName = tokens[0];
                string studentName = tokens[1];

                if (!students.ContainsKey(courseName))
                {
                    students[courseName] =new List<string>();
                }
                students[courseName].Add(studentName);
            }

            foreach (var course in students)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                Console.Write("-- ");
                Console.WriteLine(string.Join("\r\n-- ", course.Value));
            }
        }
    }
}

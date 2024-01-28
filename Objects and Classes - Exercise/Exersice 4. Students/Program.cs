using System;
using System.Collections.Generic;
using System.Linq;

namespace Exersice_4._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List <Student> students= new List<Student>();
            int numberOfStudents = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfStudents; i++)
            {
                string[] studentsInfo = Console.ReadLine().Split();

                Student student = new Student
                {
                    FirstName = studentsInfo[0],
                    LastName = studentsInfo[1],
                    Grade = float.Parse(studentsInfo[2])
                };
                students.Add(student);

            }
            List<Student> OrderedByDesc = students.OrderByDescending(student => student.Grade).ToList();
            foreach (var student in OrderedByDesc)
            {
                Console.WriteLine(student);
            }
        }
    }
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public float Grade { get; set; }
        public override string ToString() => $"{FirstName} {LastName}: {Grade:f2}";


    }
}

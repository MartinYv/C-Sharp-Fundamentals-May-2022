using System;
using System.Collections.Generic;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> ListOfStudents = new List<Student>();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }

                string[] data = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
               // Student student = new Student(data[0], data[1], int.Parse(data[2]), data[3]);

                if (IsStudentExisting(data[0], data[1], ListOfStudents))
                {
                    Student student = ListOfStudents.Find(student => student.FirstName == data[0] && student.LastName == data[1]);
                    student.Age = int.Parse(data[2]);
                    student.City = data[3];
                }
                else
                {
                    Student stundent = new Student(data[0], data[1], int.Parse(data[2]), data[3]);
                ListOfStudents.Add(stundent);
                }
            }

            string cityName = Console.ReadLine();

            foreach (Student student in ListOfStudents)
            {
                if (student.City == cityName)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }



        static bool IsStudentExisting(string FirstName, string LastName, List<Student> ListOfStudents)
        {
            foreach (Student student in ListOfStudents)
            {
                if (student.FirstName == FirstName && student.LastName == LastName)
                {
                    return true;
                }
            }
            return false;
        }
    }
    class Student
    {
        public Student(string firstName, string lastName, int age, string city)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            City = city;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
    }
}

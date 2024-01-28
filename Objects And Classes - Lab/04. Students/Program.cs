using System;
using System.Collections.Generic;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List <Student> ListOfStudents = new List<Student>();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }
                string[] data = command.Split(" ",StringSplitOptions.RemoveEmptyEntries);
                Student student = new Student(data[0], data[1], int.Parse (data[2]), data[3]);
                ListOfStudents.Add(student);
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
    }
    class Student
    {
        public Student(string firstName, string lastName,int age,string city)
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

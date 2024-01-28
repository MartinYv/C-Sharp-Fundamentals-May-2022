using System;
using System.Collections.Generic;
using System.Linq;

namespace Exersice_7._Order_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            List<personalInfo> listOfPeople = new List<personalInfo>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                string[] tokens = command.Split();

                personalInfo data = new personalInfo
                {
                    Name = tokens[0],
                    id = tokens[1],
                    age = int.Parse(tokens[2])
                };
                listOfPeople.Add(data);



            }
            List<personalInfo> orderedByage = listOfPeople.OrderBy(x => x.age).ToList();
            foreach (personalInfo data in orderedByage)
            {
                Console.WriteLine($"{data.Name} with ID: {data.id} is {data.age} years old.");
            }
        }
    }
    class personalInfo
    {
        public string Name { get; set; }
        public string id { get; set; }
        public int age { get; set; }
    }
}

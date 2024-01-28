using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Order_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Persons> persons = new List<Persons>();
            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] info = input.Split();
                string name = info[0];
                string id = info[1];
                int age = int.Parse(info[2]);


                bool isItCointain = persons.Select(x => x.Id).Any(x => x == id);

                if (!isItCointain)
                {
                    Persons person = new Persons
                    {
                        Name = name,
                        Id = id,
                        Age = age
                    };
                    persons.Add(person);
                }
                else
                {
                    Persons currPerson = persons.Find(x => x.Id == id);
                    currPerson.Age = age;
                    currPerson.Name = name;
                }

                input = Console.ReadLine();
            }




            var orderByAge = persons.OrderBy(x => x.Age).ToList();
            foreach (var currPerson in orderByAge)
            {
                Console.WriteLine($"{currPerson.Name} with ID: {currPerson.Id} is {currPerson.Age} years old.");
            }

        }
        class Persons
        {

            public string Name { get; set; }
            public string Id { get; set; }
            public int Age { get; set; }

        }
    }
}
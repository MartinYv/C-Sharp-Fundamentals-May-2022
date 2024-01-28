using System;
using System.Collections.Generic;
using System.Linq;

namespace Message_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<string, KeyValuePair<List<int>, List<int>>> persons = new Dictionary<string, KeyValuePair<List<int>, List<int>>>();            
            // Dictionary<string, KeyValuePair<int, List<int>>> flowers = new Dictionary<string, KeyValuePair<int, List<int>>>();

            List<Persons> persons = new List<Persons>();
            int capacity = int.Parse(Console.ReadLine());


            string input = Console.ReadLine();
            while (input != "Statistics")
            {
                string[] info = input.Split('=');
                string action = info[0];

                if (action == "Add")
                {
                    string username = info[1];
                    int sent = int.Parse(info[2]);
                    int recived = int.Parse(info[3]);
                    
                    bool isItCointain = persons.Any(x => x.Username == username);

                    if (!isItCointain)
                    {
                        Persons person = new Persons
                        {
                            Username = username,
                            Sent = sent,
                            Recived = recived
                        };
                        persons.Add(person);
                    }
                }

                else if (action == "Message")
                {
                    string sender = info[1];
                    string reciver = info[2];

                    var senderUsername = persons.Find(x => x.Username == sender);                  
                    var recieverUsername = persons.Find(x => x.Username == reciver);


                    if (senderUsername != null && recieverUsername != null)
                    {
                        senderUsername.Sent += 1;
                        recieverUsername.Recived += 1;

                        if (senderUsername.Sent + senderUsername.Recived >= capacity)
                        {
                            Console.WriteLine($"{sender} reached the capacity!");
                            persons.Remove(senderUsername);
                        }
                        if (recieverUsername.Recived + recieverUsername.Sent >= capacity)
                        {
                            Console.WriteLine($"{reciver} reached the capacity!");
                            persons.Remove(recieverUsername);
                        }
                    }
                }
                else if (action == "Empty")
                {
                    string username = info[1];
                    var user = persons.Find(x => x.Username == username);
                    persons.Remove(user);
                    if (username == "All")
                    {
                        persons = new List<Persons>();
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Users count: {persons.Count}");
            foreach (Persons per in persons)
            {
                Console.WriteLine($"{per.Username} - {per.Sent + per.Recived}");
            }
        }
        class Persons
        {
            public string Username { get; set; }
            public int Sent { get; set; }
            public int Recived { get; set; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace Exersice_5._Teamwork_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
           // Project project = new Project();
            List<Project> projects = new List<Project>();

            int teamsNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < teamsNumber; i++)
            {
                string[] input = Console.ReadLine().Split("-");

                string creator = input[0], team = input[1];

               Project project = new Project()
                {
                    Creator = creator,
                    Team = team
                };

                bool containsTeam = projects.Any(teamname => teamname.Team == team);
                bool hasCreated = projects.Any(c => c.Creator == creator);

                if (containsTeam)
                {
                    Console.WriteLine($"Team {team} was already created!");
                }
                else if (hasCreated)
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else 
                {
                    projects.Add(project);
                    Console.WriteLine($"Team {team} has been created by {creator}!");
                }
            }
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end of assignment")
                {
                    break;
                }
                string []tokens = command.Split("->");
                string user = tokens[0];
                string team = tokens[1];

                bool teamExist = projects.Any(t => t.Team == team);
                bool containsUser = projects.Any(u => u.Members.Contains(user));
                bool isCreator = projects.Any(c => c.Creator == user);

                if (!teamExist)
                {
                    Console.WriteLine($"Team {team} does not exist!");
                }
                else if (containsUser || isCreator)
                {
                    Console.WriteLine($"Member {user} cannot join team {team}!");
                }
                else
                {
                    foreach (var pr in projects)
                    {
                        if (pr.Team == team && user != pr.Creator)
                        {
                            pr.Members.Add(user);
                        }
                    }
                }

             
            }

            foreach (var pr in projects.OrderByDescending(m => m.Members.Count).ThenBy(t => t.Team).Where(m => m.Members.Count > 0))
            {
                pr.Members.Sort();
                Console.WriteLine($"{pr.Team}");
                Console.WriteLine($"- {pr.Creator}");
                Console.Write("-- ");
                Console.WriteLine(string.Join("\r\n-- ", pr.Members));
            }

            Console.WriteLine("Teams to disband:");
            foreach (var pr in projects.OrderBy(t => t.Team).Where(m => m.Members.Count < 1))
            {
                Console.WriteLine($"{pr.Team}");
            }
        }
    }


}
        
    
    class Project
    {
        
        public string Team { get; set; }
        public string Creator { get; set; }
        public List<string> Members = new List<string>();

    }


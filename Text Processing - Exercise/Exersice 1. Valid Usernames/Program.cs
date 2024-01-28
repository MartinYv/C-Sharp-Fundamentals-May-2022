using System;
using System.Collections.Generic;
using System.Linq;

namespace Exersice_1._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {

                List<string> usernames = Console.ReadLine().Split(", ").ToList();
                List<string> Validusernames = new List<string>();
            
                foreach (var username in usernames)
                {
                    if ((username.Length >= 3 & username.Length <= 16))
                    {
                        bool isValid = true;
                        for (int i = 0; i < username.Length; i++)
                        {
                            char currChar = username[i];
                            if (!(currChar == '-' || currChar == '_' || char.IsDigit(currChar) || char.IsLetter(currChar)))
                            {
                                isValid = false;
                                break;
                            }                    
                        }
                            if (isValid)
                            {
                                Validusernames.Add(username);
                            }
                    }
                }
                Console.WriteLine(string.Join(Environment.NewLine, Validusernames));


            
            }


        }
    }

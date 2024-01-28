using System;
using System.Collections.Generic;

namespace _03._Word_Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> wordsLits = new List<string>();
            Dictionary<string, List <string>> synonimsList = new Dictionary<string, List<string>>();

            int numberOfWords = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfWords; i++)
            {
                string word = Console.ReadLine();
                string synonim = Console.ReadLine();

                
                    if (!synonimsList.ContainsKey(word))
                    {
                        synonimsList.Add(word, new List<string>());
                    }
               

                        synonimsList[word].Add(synonim);
                
                    
                }
            
                foreach (var currWord in synonimsList)
                {
                    Console.WriteLine($"{currWord.Key} - {string.Join(", ", currWord.Value)}");
                }
            }

        }
    }


using System;
using System.Collections.Generic;

namespace Exersice_1._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
       
          Dictionary <char, int> dictonary =new Dictionary<char, int>();
       
          string[] input = Console.ReadLine().Split();
       
          foreach (var item in input)
          {
              foreach (var ch in item)
              {
                  if (!dictonary.ContainsKey(ch))
                  {
                      dictonary.Add(ch, 0);
                  }
                  dictonary[ch]++;
              }        
          }
       
          foreach (var item in dictonary)
          {
              Console.WriteLine($"{item.Key} -> {item.Value}");
          }

           
            }
        }
    }


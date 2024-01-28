using System;
using System.Collections.Generic;
using System.Linq;

namespace Text_Processing
{
    class Program
    {
        static void Main(string[] args)
        {

            //   string input = Console.ReadLine();
            //
            //   while (true)
            //   {
            //
            //       if (input == "end")
            //       {
            //           break;
            //       }
            //       string reversed = "";
            //
            //       for (int i = input.Length - 1; i >= 0; i--)
            //       {
            //           reversed += input[i];
            //       }
            //
            //       Console.WriteLine($"{input} = {reversed}");
            //       input = Console.ReadLine();
            //
            //   }
            //


            string input = Console.ReadLine();
         
            

            while (input != "end")
            {
               
                string reversed = "";

                for (int i = input.Length-1; i >=0; i--)
                {
                    reversed += input[i];
                }
                Console.WriteLine($"{input} = {reversed}");
                    input = Console.ReadLine();
                }
            }
      



        }
    }




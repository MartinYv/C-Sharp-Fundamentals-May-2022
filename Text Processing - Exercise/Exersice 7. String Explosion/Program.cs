using System;
using System.Collections.Generic;
using System.Text;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //    string input = Console.ReadLine();
            //    // abv>1>1>2>2asdasd
            //
            //    StringBuilder sb = new StringBuilder();
            //
            //    int power = 0;
            //
            //    for (int i = 0; i < input.Length; i++)
            //    {
            //        char current = input[i];
            //
            //        if (current == '>')
            //        {
            //            power += int.Parse(input[i + 1].ToString());
            //            sb.Append(current);
            //        }
            //        else if (power == 0)
            //        {
            //            sb.Append(current);
            //        }
            //        else
            //        {
            //            power--;
            //        }
            //
            //    }
            //
            //    Console.WriteLine(sb);



            string text = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            int power = 0;
            for (int i = 0; i < text.Length
                ; i++)
            {
                if (text[i] == '>')
                {
                    power+=(int.Parse(text[i+1].ToString()));
                    sb.Append(text[i]);
                }
                else if (power==0)
                {
                    sb.Append(text[i]);
                }
                else 
                {
                    power--;
                }
            }
            Console.WriteLine(sb);
        }
    }
}

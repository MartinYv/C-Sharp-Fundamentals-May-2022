using System;
using System.Linq;
using System.Text;

namespace Exersice_6._Replace_Repeating_Chars
{
    class Program
    {
      static void Main(string[] args)
      {
            //    string input = Console.ReadLine();
            //
            //    StringBuilder sb = new StringBuilder();
            //
            //    sb.Append(input[0]);
            //
            //    for (int i =1; i < input.Length; i++)
            //    {
            //        
            //        if (input[i] == input[i-1])
            //        {
            //            continue;
            //          
            //        }
            //        sb.Append(input[i]);
            //    }
            //    Console.WriteLine(sb); 


            string text = Console.ReadLine();
            StringBuilder finalResult = new StringBuilder();

            for (int i = 0; i < text.Length-1; i++)
            {
                
                if (!(text[i] == text[i+1]))
                {
                    finalResult.Append(text[i]);
                }
              
            }
            finalResult.Append(text[text.Length - 1]);
            Console.WriteLine(finalResult);
        }
    }
}

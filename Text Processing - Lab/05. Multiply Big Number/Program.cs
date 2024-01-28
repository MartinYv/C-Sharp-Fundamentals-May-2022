using System;
using System.Collections.Generic;
using System.Text;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //      string reallyBigNum = Console.ReadLine();
            //      int num = int.Parse(Console.ReadLine());
            //
            //    
            //     
            //
            //      StringBuilder sb = new StringBuilder();
            //      int remainder = 0;
            //
            //      for (int i = reallyBigNum.Length - 1; i >= 0; i--)
            //      {
            //          char lastNum = reallyBigNum[i];
            //          int lastNumAsDigit = int.Parse(lastNum.ToString());
            //
            //          int result = lastNumAsDigit * num + remainder;
            //
            //          sb.Append(result % 10);
            //
            //          remainder = result / 10;
            //      }
            //
            //      if (remainder != 0)
            //      {
            //          sb.Append(remainder);
            //      }
            //
            //      StringBuilder reversedString = new StringBuilder();
            //
            //      for (int i = sb.Length - 1; i >= 0; i--)
            //      {
            //          reversedString.Append(sb[i]);
            //      }
            //
            //      Console.WriteLine(reversedString);



            string bigNum = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            
            int reminder = 0; ;
            StringBuilder sb = new StringBuilder();

            for (int i = bigNum.Length-1; i >=0; i--)
            {
                char lastNum = bigNum[i];
                int lastNumToInt = int.Parse(lastNum.ToString());      // 75/100
               int result = lastNumToInt * number + reminder;

                sb.Append(result % 10);

                reminder = result / 10;
                
            }
            if (reminder!=0)
            {
                sb.Append(reminder);
            }

            StringBuilder resultReversed = new StringBuilder();
            for (int i = sb.Length-1; i >= 0; i--)
            {
                resultReversed.Append(sb[i]);
            }
            Console.WriteLine(resultReversed);
        }
    }
}

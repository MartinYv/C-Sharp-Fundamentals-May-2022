using System;
using System.Linq;

namespace _2._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            //        string[] input = Console.ReadLine().Split(" ").ToArray();
            //
            //
            //        Console.WriteLine(CharMultiplier(input[0], input[1]));
            //    }
            //
            //    public static int CharMultiplier(string str1, string str2)
            //    {
            //        int sum = 0;
            //        string shorter = "";
            //        string longer = "";
            //        if (str1.Length > str2.Length)
            //        {
            //            longer = str1;
            //            shorter = str2;
            //        }
            //        else
            //        {
            //            longer = str2;
            //            shorter= str1;
            //        }
            //
            //        for (int i = 0; i < shorter.Length; i++)
            //        {
            //            sum += shorter[i] * longer[i];
            //        }
            //        for (int i = shorter.Length; i < longer.Length; i++)
            //        {
            //            sum += longer[i];
            //        }
            //
            //        return sum;


            string[] input = Console.ReadLine().Split(" ").ToArray();

            Console.WriteLine(CharMultiplier (input[0], input[1]));
        }

        public static int CharMultiplier(string text1, string text2)
        {
            int sum = 0;
            string longer = "";
            string shorter = "";
            if (text1.Length > text2.Length)
            {
                longer = text1;
                shorter = text2;
            }
            else
            {
                longer = text2;
                shorter = text1;
            }

            for (int i = 0; i < shorter.Length; i++)
            {
                sum += shorter[i] * longer[i];
            }
            for (int k = shorter.Length; k < longer.Length; k++)
            {
                sum += longer[k];
            }

            return (sum);
            

        }
    }
    }

using System;
using System.Text;

namespace _07._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringgg= Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

           Console.WriteLine (RepeatString(stringgg, n));


             }

        private static string RepeatString(string str, int count)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                result.Append(str);
            }

            return result.ToString();
        }

    }
}
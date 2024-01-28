using System;

namespace _09._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();   // int char string 



            if (type == "int")
            {
                int number1 = int.Parse(Console.ReadLine());
                int number2 = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(number1, number2));
            }

            else if (type == "char")
            {
                char char1 = char.Parse(Console.ReadLine());
                char char2 = char.Parse(Console.ReadLine());
                Console.WriteLine(GetMax2(char1, char2));
            }

            else
            {
                string string1 = Console.ReadLine();
                string string2 = Console.ReadLine();
                Console.WriteLine(GetMax3(string1, string2));

            }



                static int GetMax(int first, int second)
                {
                    if (first > second)
                    {
                        return first;
                    }

                    return second;
                }

                static char GetMax2(char first, char second)

                {
                    if (first > second)
                    {
                        return first;
                    }
                    return second;
                }

                static string GetMax3(string first, string second)
                {
                    int result = first.CompareTo(second);
                    if (result > 0)
                    {
                        return first;
                    }
                    return second;
                }

            }
    }
}
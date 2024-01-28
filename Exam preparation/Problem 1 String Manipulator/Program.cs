using System;

namespace Problem_1_String_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] info = input.Split();
                string action = info[0];

                if (action == "Translate")
                {
                    string ch = info[1];
                    string replacement = info[2];

                    text = text.Replace(ch, replacement);
                    Console.WriteLine(text);
                }

                else if (action == "Includes")
                {
                    string substring = info[1];
                        Console.WriteLine(text.Contains(substring));                  
                }

                else if (action == "Start")
                {
                    string substring = info[1];
                    Console.WriteLine(text.StartsWith(substring));
                }

                else if (action == "Lowercase")
                {
                    text = text.ToLower();
                    Console.WriteLine(text);
                }

                else if (action =="FindIndex")
                {
                    string substring = info[1];
                    Console.WriteLine(text.LastIndexOf(substring));
                }

                else if (action == "Remove")
                {
                    int index = int.Parse(info[1]);
                    int lenght = int.Parse(info[2]);

                    text = text.Remove(index, lenght);
                    Console.WriteLine(text);
                }

                input = Console.ReadLine();
            }
        }
    }
}

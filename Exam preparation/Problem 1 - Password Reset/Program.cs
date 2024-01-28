using System;
using System.Linq;
using System.Text;

namespace Problem_1___Password_Reset
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            StringBuilder password = new StringBuilder();

            string input = Console.ReadLine();
            while (input != "Done")
            {
                string[] info = input.Split();

                string action = info[0];

                if (action == "TakeOdd")
                {
                    for (int i = 0; i < text.Length; i++)
                    {
                        if (i % 2 != 0)
                        {
                            password.Append(text[i]);
                        }
                    }
                    text = password.ToString();
                    Console.WriteLine(text);
                }
                else if (action == "Cut")
                {
                    int index = int.Parse(info[1]);
                    int lenght = int.Parse(info[2]);

                    text = text.Remove(index, lenght);

                    Console.WriteLine(text);
                }
                else if (action == "Substitute")
                {
                    string substring = info[1];
                    string replacement = info[2];

                    if (text.Contains(substring))
                    {
                        text = text.Replace(substring, replacement);
                        Console.WriteLine(text);
                    }
                    else
                    {
                        Console.WriteLine($"Nothing to replace!");
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Your password is: {text}");
        }
    }
}

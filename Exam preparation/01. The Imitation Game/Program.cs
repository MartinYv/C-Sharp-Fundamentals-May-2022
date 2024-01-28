using System;

namespace _01._The_Imitation_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();


            string command = Console.ReadLine();
            while (command != "Decode")
            {
                string[] info = command.Split('|');
                string action = info[0];

                if (action == "Move")
                {
                    int numberOfLetToMove = int.Parse(info[1]);
                    string substing = message.Substring(0, numberOfLetToMove);
                    message = message.Remove(0, numberOfLetToMove);
                    message = message += substing;
                }

                else if (action == "Insert")
                {//"Insert {index} {value}":
                    int index = int.Parse(info[1]);
                    string value = info[2];
                    message = message.Insert(index, value);

                }
                else if (action == "ChangeAll")
                {
                    //"ChangeAll {substring} {replacement}":
                    string substring = info[1];
                    string replacement = info[2];
                    message = message.Replace(substring, replacement);
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"The decrypted message is: { message}");
                }
    }
}

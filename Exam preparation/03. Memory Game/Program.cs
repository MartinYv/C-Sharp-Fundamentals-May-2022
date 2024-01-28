using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Memory_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> mirrorChars = Console.ReadLine().Split(" ").ToList();

            int numberOfMoves = 0;


            while (true)
            {
                string[] indexes = Console.ReadLine().Split(" ");


                if (indexes[0] == "end")
                {
                    break;
                }

                if (mirrorChars.Count == 0)
                {
                    Console.WriteLine($"You have won in {numberOfMoves} turns!");
                    return;
                }

                numberOfMoves++;

                int index1 = int.Parse(indexes[0]);
                int index2 = int.Parse(indexes[1]);


                if (index1 == index2 || index1 < 0 || index1 > mirrorChars.Count - 1 || index2 < 0 || index2 > mirrorChars.Count - 1)
                {
                    string aToInsert = "-" + numberOfMoves.ToString() + "a";
                    mirrorChars.Insert(mirrorChars.Count / 2, aToInsert);
                    mirrorChars.Insert(mirrorChars.Count / 2, aToInsert);
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    continue;
                }

                string charOne = mirrorChars[index1];
                string charTwo = mirrorChars[index2];

                if (charOne == charTwo)
                {
                    mirrorChars.Remove(charOne);
                    mirrorChars.Remove(charTwo);
                    Console.WriteLine($"Congrats! You have found matching elements - {charOne}!");
                }

                else if (charOne != charTwo)
                {
                    Console.WriteLine("Try again!");
                }
            }

            Console.WriteLine("Sorry you lose :(");
            Console.WriteLine(string.Join(" ", mirrorChars));
        }
    }
}

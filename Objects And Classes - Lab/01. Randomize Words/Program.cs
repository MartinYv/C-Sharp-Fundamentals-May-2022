using System;

namespace Objects_and_Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            string [] inputSplit = input.Split();

            Random random = new Random();


            for (int i = 0; i < inputSplit.Length; i++)
            {
                int randomIndex = random.Next(0, inputSplit.Length);

                string currentWord = inputSplit[i];

                inputSplit[i] = inputSplit[randomIndex];
                inputSplit[randomIndex] = currentWord;


            }
            foreach (var word in inputSplit)
            {
                Console.WriteLine(word);
            }
        }
    }
}

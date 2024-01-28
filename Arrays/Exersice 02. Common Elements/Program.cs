using System;

namespace Exersice_02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayOne = Console.ReadLine().Split(' ');
            string[] arrayTwo = Console.ReadLine().Split(' ');

            foreach (var currentElement in arrayOne)
            {
                for (int i = 0; i < arrayTwo.Length; i++)
                {
                    string secondCurrElement = arrayTwo[i];
                    if (currentElement == secondCurrElement)
                    {
                        Console.Write($"{currentElement} ");
                       
                    }
                }
            }
        }
    }
}

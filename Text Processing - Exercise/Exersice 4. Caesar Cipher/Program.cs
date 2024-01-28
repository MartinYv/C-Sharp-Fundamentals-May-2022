using System;
using System.Linq;

namespace Exersice_4._Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
           string message = Console.ReadLine();
    
           string shipheredText = string.Empty;
    
           for (int i = 0; i < message.Length; i++)
           {
               shipheredText += (char) (message[i] + 3);
           }
    
           Console.WriteLine(shipheredText);


           

        }
    }
}

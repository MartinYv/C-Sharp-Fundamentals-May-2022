using System;
using System.Linq;

namespace _3.Exersice__Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
              string[] text = Console.ReadLine().Split('\\').ToArray();
           
           
              // File name: Template File extension: pptx
           
              string[] file = text[text.Length - 1].Split('.');
              Console.WriteLine($"File name: {file[0]}");
              Console.WriteLine($"File extension: {file[1]}");


        }
    }
}

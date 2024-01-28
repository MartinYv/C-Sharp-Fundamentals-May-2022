using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists_manipulations_basics
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            bool isListChanged = false;



            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }

                string[] commandSplit = command.Split();
                string cmd = commandSplit[0];

                if (cmd == "Add")
                {
                    int number = int.Parse(commandSplit[1]);
                    numbers.Add(number);
                    isListChanged = true;

                }
                else if (cmd == "Remove")
                {
                    int number = int.Parse(commandSplit[1]);
                    numbers.Remove(number);
                    isListChanged = true;


                }
                else if (cmd == "RemoveAt")
                {
                    int index = int.Parse(commandSplit[1]);
                    numbers.Remove(numbers[index]);
                    isListChanged = true;


                }
                else if (cmd == "Insert")
                {
                    int number = int.Parse(commandSplit[1]);
                    int index = int.Parse(commandSplit[2]);
                    numbers.Insert(index, number);
                    isListChanged = true;

                }

                else if (cmd == "Contains")
                {
                    int number = int.Parse(commandSplit[1]);
                    if (numbers.Contains(number))
                    {
                        Console.WriteLine("Yes");

                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }

                else if (cmd == "PrintEven")
                {
                    printEven(numbers);

                }
                else if (cmd == "PrintOdd")
                {

                    printOdd(numbers);

                }
                else if (cmd == "GetSum")
                {
                    Console.WriteLine(string.Join(" ", numbers.Sum()));
                }

                else if (cmd == "Filter")
                {
                    PrintFiltered(commandSplit[1], int.Parse(commandSplit[2]), numbers);
                }

                if (isListChanged)
                {
                    Console.WriteLine(string.Join(" ", numbers));
                }

            }
        


            static void printEven(List<int> numbers)
            {
                List<int> evenNumbers = new List<int>();
                for (int i = 0; i < numbers.Count ; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        evenNumbers.Add(numbers[i]);
                    }

                }
                Console.WriteLine(string.Join(" ", evenNumbers));
            }

            static void printOdd(List<int> numbers)
            {
                List<int> oddNumbers = new List<int>();
                for (int i = 0; i < numbers.Count ; i++)
                {
                    if (numbers[i] % 2 != 0)
                    {
                        oddNumbers.Add(numbers[i]);
                    }

                }
                Console.WriteLine(string.Join(" ", oddNumbers));
            }
        }

         static void PrintFiltered(string filter, int number, List<int> numbers)
        {
            

            if (filter == "<")
            {
                foreach (var curnumber in numbers)
                {
                    if (curnumber < number)
                    {
                        Console.Write($"{curnumber} ");
                    }
                }
                Console.WriteLine();
            }
            else if (filter == ">")
            {
                foreach (var curnumber in numbers)
                {
                    if (curnumber > number)
                    {
                        Console.Write($"{curnumber} ");
                    }
                }
                Console.WriteLine();
            }
            else if (filter == ">=")
            {
                foreach (var curnumber in numbers)
                {
                    if (curnumber >= number)
                    {
                        Console.Write($"{curnumber} ");
                    }
                }
                Console.WriteLine();
            }
            else if (filter == "<=")
            {
                foreach (var curnumber in numbers)
                {
                    if (curnumber <= number)
                    {
                        Console.Write($"{curnumber} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
        
        
            
    
    

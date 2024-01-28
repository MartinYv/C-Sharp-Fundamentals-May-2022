using System;
using System.Linq;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rightSum = 0;
            int leftSum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                rightSum = 0;
                leftSum = 0;
                for (int j = 1; j < array.Length; j++)
                {
                   rightSum += array[j];
                }
                for (int k = array.Length-1; k > 0; k--)
                {
                    leftSum += array[k];
                }
                if (leftSum==rightSum)
                {
                    Console.WriteLine(leftSum);
                }
                
            }

         
        }
        }
        }
    




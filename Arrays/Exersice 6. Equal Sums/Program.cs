using System;
using System.Linq;

namespace exersice_6._Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array.Length ==1)
                {
                    Console.WriteLine(0);
                    return;
                }
                leftSum = 0;
                for (int sumLeft = i; sumLeft > 0; sumLeft--)
                {
                    int nextLeftEllementPosition = sumLeft - 1;
                    if (sumLeft>0)
                    {
                        leftSum += array[nextLeftEllementPosition];
                    }
                }
                rightSum = 0;
                for (int j = i; j < array.Length; j++)
                {
                    int nextElementPosition = j + 1;
                    if (j < array.Length -1)
                    {
                        rightSum += array[nextElementPosition];
                    }
                }
                if (leftSum==rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("no");

                }
    }
}

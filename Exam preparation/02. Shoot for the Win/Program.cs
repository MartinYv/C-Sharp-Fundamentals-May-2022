using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Shoot_for_the_Win
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split().Select(int.Parse).ToList();            

            List<int> shootTargets = new List<int>();

            string input = Console.ReadLine();
            while (input != "End")
            {
                int index = int.Parse(input);

                if (index < 0 || index > targets.Count-1)
                {
                    input = Console.ReadLine();
                    continue;
                }

                int indexTarget = targets[index];

                if (targets[index] == -1)
                {
                    input = Console.ReadLine();
                    continue;
                }

                for (int i = 0; i < targets.Count; i++)
                {              
                    
                    if (targets[i] == -1)
                    {                        
                        continue;
                    }

                   else if (targets[i] == targets[index])
                    {
                        targets[index] = -1;
                        shootTargets.Add(targets[i]);                      
                    }                    

                   else if (targets[i] > indexTarget)
                    {                     
                            targets[i] -= indexTarget;
                    }

                   else if (targets[i] <= indexTarget)
                    {
                            targets[i] += indexTarget;                       
                    }
                }

                    input = Console.ReadLine();
            }
            Console.WriteLine($"Shot targets: {shootTargets.Count} -> {string.Join(" ", targets)}");
        }
    }
}

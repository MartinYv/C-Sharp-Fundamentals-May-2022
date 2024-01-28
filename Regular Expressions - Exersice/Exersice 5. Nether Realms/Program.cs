using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Exersice_5._Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            string healthPattern = @"[^+\-\*\/\.,0-9]";
            string damagePattern= @"-?\d+\.?\d*";
            string divideOrMultiplyPatter = @"[\*\/]";
            string splitPatter = @"[,\s]+";
            string input = Console.ReadLine();
            string[] demons = Regex.Split(input, splitPatter).OrderBy(x => x).ToArray();

            for (int i = 0; i < demons.Length; i++)
            {
                string currDemon = demons[i];

                MatchCollection demonHp = Regex.Matches(currDemon, healthPattern);
                

                    double currDemonHP = 0;
                foreach (Match match in demonHp)
                {
                    currDemonHP += char.Parse(match.ToString());
                }

                MatchCollection demonDamage = Regex.Matches(currDemon, damagePattern);
                double currDemonDamage = 0;
                foreach (Match match in demonDamage)
                {
                    currDemonDamage += double.Parse(match.ToString());
                }

                
                MatchCollection multiplyOrDivide = Regex.Matches(currDemon, divideOrMultiplyPatter);
                foreach (Match match in multiplyOrDivide)
                {
                    char currMatch = char.Parse(match.ToString());
                    if (currMatch == '*')
                    {
                        currDemonDamage *= 2;
                    }
                    else
                    {
                        currDemonDamage /= 2;
                    }
                }

                Console.WriteLine($"{currDemon} - {currDemonHP} health, {currDemonDamage:f2} damage");


            }
        }
    }
}

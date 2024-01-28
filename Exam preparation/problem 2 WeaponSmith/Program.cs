using System;
using System.Collections.Generic;
using System.Linq;

namespace problem_2_WeaponSmith
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nameOfWeapon = Console.ReadLine().Split("|").ToList();

            while (true)
            {
                string[] info = Console.ReadLine().Split();

                if (info[0] == "Done")
                {
                    break;
                }

                string action = info[0];

                if (action == "Add")
                {
                    string particle = info[1];
                    int index = int.Parse(info[2]);

                    if (index < 0 || index > nameOfWeapon.Count - 1)
                    {
                        continue;
                    }

                    nameOfWeapon.Insert(index, particle);
                }
                else if (action == "Remove")
                {
                    int index = int.Parse(info[1]);

                    if (index < 0 || index > nameOfWeapon.Count - 1)
                    {
                        continue;
                    }

                    nameOfWeapon.RemoveAt(index);
                }
                else if (action == "Check")
                {

                    if (info[1] == "Even")
                    {
                        for (int i = 0; i < nameOfWeapon.Count; i++)
                        {
                            if (i % 2 == 0)
                            {
                                Console.Write(nameOfWeapon[i] + " ");
                            }
                        }
                    }


                    else if (info[1] == "Odd")
                    {
                        for (int i = 0; i < nameOfWeapon.Count; i++)
                        {
                            if (i % 2 != 0)
                            {
                                Console.Write(nameOfWeapon[i] + " ");
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine($"You crafted {string.Join("", nameOfWeapon)}!");
        }
    }
}
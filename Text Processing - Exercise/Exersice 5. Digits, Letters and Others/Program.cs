using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5._Digits__Letters_and_Others
{
    class Program
    {
        static void Main(string[] args)
        {
             string text = Console.ReadLine();
            
                StringBuilder letters = new StringBuilder();
                StringBuilder digits = new StringBuilder();
                StringBuilder others = new StringBuilder();
            
                foreach (var ch in text)
                {
                     if (char.IsDigit(ch))
                    {
                        digits.Append(ch);
                    }
                    else if (char.IsLetter(ch))
                    {
                        letters.Append(ch);
                    }
                    else
                    {
                        others.Append(ch);
                    }
                }
                    Console.WriteLine(digits);
                    Console.WriteLine(letters);
                    Console.WriteLine(others);

            //   List<char> digits = text.Where(ch => char.IsDigit(ch)).ToList();
            //   List<char> letters = text.Where(ch => char.IsLetter(ch)).ToList();
            //   List<char> others = text.Where(ch => !char.IsLetterOrDigit(ch)).ToList();
            //   Console.WriteLine(string.Join("",digits));
            //   Console.WriteLine(string.Join("",letters));
            //   Console.WriteLine(string.Join("",others));
            //

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace Grocery_Shoping
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> products = Console.ReadLine().Split("|").ToList();

            while (true)
            {
                string[] info = Console.ReadLine().Split("%");
                if (info[0]== "Shop!")
                {
                    break;
                }

                string action = info[0];

                if (action == "Important")
                {
                    string product = info[1];
                    if (products.Contains(product))
                    {
                        products.Remove(product);
                        products.Insert(0, product);
                    }
                    else
                    {
                        products.Insert(0, product);
                    }
                }

                else if (action == "Add")
                {
                    string product = info[1];

                    if (products.Contains(product))
                    {
                        Console.WriteLine("The product is already in the list.");
                    }
                    else
                    {
                        products.Add(product);
                    }
                }

                else if (action == "Swap")
                {
                    string product = info[1];
                    string productTwo = info[2];

                    if (products.Contains(product) && products.Contains(productTwo))
                    {                    

                        int indexOfProduct = products.IndexOf(product);
                        int indexOfProductTwo = products.IndexOf(productTwo);

                        products.Remove(product);
                        products.Remove(productTwo);
                        products.Insert(indexOfProduct, productTwo);
                        products.Insert(indexOfProductTwo, product);


                    }
                    else
                    {
                        bool isInTheList = products.Any(x => x == product);
                        if (isInTheList == true)
                        {
                        Console.WriteLine($"Product {productTwo} missing!");

                        }
                        else
                        {
                            Console.WriteLine($"Product {product} missing!");

                        }
                    }
                }

                else if (action == "Remove")
                {
                    string product = info[1];

                    if (products.Contains(product))
                    {
                        products.Remove(product);
                    }
                    else
                    {
                        Console.WriteLine($"Product {product} isn't in the list.");
                    }
                }
                else if (action == "Reverse")
                {
                    products.Reverse();

                }
            }

            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i+1}. {products[i]}");
            }
        }
    }
}

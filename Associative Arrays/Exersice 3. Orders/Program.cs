using System;
using System.Collections.Generic;

namespace Exersices_3._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            ////"{name} {price} {quantity}"
            ///

            //        Dictionary<string, double> listOfProducts = new Dictionary<string, double>();
            //        Dictionary<string, double> listOfProducts2 = new Dictionary<string, double>();
            //
            //
            //        string command = Console.ReadLine();
            //
            //        while (true)
            //        {
            //            if (command=="buy")
            //            {
            //                break;
            //            }
            //
            //            string[] tokens = command.Split();
            //
            //            string name = tokens[0];
            //            double price = double.Parse(tokens[1]);
            //            double quantity = double.Parse(tokens[2]);
            //
            //            if (!listOfProducts.ContainsKey(name))
            //            {
            //                listOfProducts.Add(name, price);
            //                listOfProducts2.Add(name, quantity);
            //            }
            //            else if (listOfProducts.ContainsKey(name))                
            //            {
            //                listOfProducts.Remove(name);
            //                listOfProducts.Add(name, price);
            //                listOfProducts2[name] += quantity;
            //
            //            }
            //            
            //            command = Console.ReadLine();
            //        }
            //        foreach (var prod in listOfProducts)
            //        {
            //            foreach (var produ in listOfProducts2)
            //            {
            //                if (prod.Key == produ.Key)
            //                {
            //                    Console.WriteLine($"{produ.Key:f2} -> {produ.Value * prod.Value:f2}");
            //                }
            //            }
            //
            //        }

            var products = new Dictionary<string, double>();
            var products2 = new Dictionary<string, double>();

            string input = Console.ReadLine();

            while (true)
            {
                if (input == "buy")
                {
                    break;
                }

                string[] tokens = input.Split();
                string productName = tokens[0];
                double price = double.Parse(tokens[1]);
                double quantity = double.Parse(tokens[2]);


                if (!products.ContainsKey(productName))
                {
                    products.Add(productName, price);
                    products2.Add(productName, quantity);


                }
                else
                {
                    products.Remove(productName);
                    products.Add(productName, price);
                    products2[productName] += quantity;
                }

                input = Console.ReadLine();
            }

            foreach (var product in products)
            {
                foreach (var product2 in products2)
                {
                    if (product.Key == product2.Key)
                    {
                        Console.WriteLine($"{product.Key} -> {product.Value*product2.Value:f2}");
                    }
                }
            }

        }
    }
}

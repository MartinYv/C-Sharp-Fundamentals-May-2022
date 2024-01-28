using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Store_Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            //: Serial Number, Item, Item Quantity and Price for a Box
            List<Box> BoxList = new List<Box>();


            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                string[] commandSplit = command.Split();



                //   Define a class Item, which contains these properties: Name and Price.
                //   Define a class Box, which contains these properties: Serial Number, Item, Item Quantity and Price for a Box.


                Box box = new Box
                {
                    SerialNumber = commandSplit[0],
                    Item = new Item(commandSplit[1], decimal.Parse(commandSplit[3])),
                    ItemQuantity = int.Parse(commandSplit[2])
                };
                BoxList.Add(box);
            }

            
            List<Box> orderedBoxes = BoxList.OrderByDescending(box => box.Price).ToList();

            foreach (Box box in orderedBoxes)
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.Price:f2}");
            }




        }
    }
    class Item
    {
      public Item(string name, decimal price)
      {
          Name = name;
          Price = price;
     
      }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
    class Box
    {
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public decimal Price
        {
            get
            {
                return this.ItemQuantity * this.Item.Price;
            }
        }

    }
}
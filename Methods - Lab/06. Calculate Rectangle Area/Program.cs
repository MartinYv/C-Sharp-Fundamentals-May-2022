using System;

namespace _06._Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double widht = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = Area(widht, height);
            Console.WriteLine(area); 
        
        }

        private static double Area(double widht,double height)
        {
            return widht * height;

        }
    }
}

using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius, area;
            Console.Write("Please enter a radius: ");
            string sRadius = Console.ReadLine();
            bool success = double.TryParse(sRadius, out radius);
            if(!success)
            {
                Console.Write("That wasn't a real number ");
                return;
            }
            //radius = double.Parse(sRadius);
            area = radius * radius * Math.PI;
            Console.WriteLine($"The area of a circle of radius {radius:F3} is {area:F3} ");
            Console.ReadKey();
            
        }
    }
}

using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Please enter a radius: ");
                string sRadius = Console.ReadLine();
                if (sRadius == "Ex")
                {
                    return;
                }
                if (!double.TryParse(sRadius, out double radius))
                {
                    Console.Write("That wasn't a real number try again ");
                    continue;
                }
                
                //radius = double.Parse(sRadius);
                double area = radius * radius * Math.PI;
                Console.WriteLine($"The area of a circle of radius {radius:F3} is {area:F3} ");
                Console.ReadKey();

            }
        }
    }
}

using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool stop = false;
            while (!stop)
            {
                Console.Write("Please enter a number to calculate square root: ");
                string sSquare = Console.ReadLine();
                if (sSquare == "q")
                {
                    stop = true;
                    continue;
                }
                if (!double.TryParse(sSquare, out double square))
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write("That wasn't a real number try again ");
                    
                    continue;
                }
                if (square < 0)
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.Write("Don't use negative numbers ");
                    continue;
                }
                double area = Math.Sqrt(square);
                Console.WriteLine($"The square root of {square:F3} is {area:F3} ");

            }
        }
    }
}

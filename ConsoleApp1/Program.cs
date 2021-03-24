using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.Write("Please enter some text: ");
                var sSquare = Console.ReadLine();
                if (sSquare.ToLower() == "q")
                {
                    exit = !exit;
                }
                Console.WriteLine("");
                Console.WriteLine($"You typed {sSquare}");
            }
        }
    }
}

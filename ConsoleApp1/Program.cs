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
                if (sSquare == "q"  || sSquare == "Q")
                {
                    exit = !exit;
                }
                double square;
                bool result = double.TryParse(sSquare, out square);
                if (!result)
                {
                    Console.WriteLine();
                }

                WriteConsole("");
                WriteConsole($"You typed {sSquare}");
            }
            
        }

        static void WriteConsole(string text)
        {
            Console.WriteLine(text);
        }
    }
}

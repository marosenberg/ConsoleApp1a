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
                Console.Write("Please enter some text: ");
                var sSquare = Console.ReadLine();
                if (sSquare.ToLower() == "q")
                {
                    return;
                }
                Console.WriteLine("");
                Console.WriteLine($"You typed {sSquare}");
            }
        }
    }
}

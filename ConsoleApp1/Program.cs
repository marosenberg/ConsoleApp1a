using System;
using System.Collections;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            myStruct c = new myStruct();
            c.MyInt1 = 100;
            c.MyInt2 = 200;
            Console.WriteLine($"In Main, before change, MyInt1: " +
                $"{c.MyInt1} and MyInt2: {c.MyInt2}");
            myMethod(ref c);
            Console.WriteLine($"In Main, after change, MyInt1: " +
                $"{c.MyInt1} and MyInt2: {c.MyInt2}");
        }

        private static void myMethod(ref myStruct myStruct)
        {
            Console.WriteLine($"In myMethod, before change, MyInt1: " +
                $"{myStruct.MyInt1} and MyInt2: {myStruct.MyInt2}");
            myStruct.MyInt1 = 10;
            Console.WriteLine($"In myMethod, after change, MyInt1: " +
                $"{myStruct.MyInt1} and MyInt2: {myStruct.MyInt2}");


        }

        public struct myStruct
        {
            public int MyInt1 { get; set; }
            public int MyInt2 { get; set; }
        }
        public class myClass
        {
            public int MyInt1 { get; set; }
            public int MyInt2 { get; set; }
        }
    }
}

using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //myStruct mystruct = new myStruct();
            myClass mystruct = new myClass();
            mystruct.MyInt1 = 5;
            mystruct.MyInt2 = 6;
            Console.WriteLine($"Before myMethod MyInt1: " +
                $"{mystruct.MyInt1} and MyInt2: {mystruct.MyInt2}");
            myMethod(mystruct);
            Console.WriteLine($"After myMethod MyInt1: " +
                $"{mystruct.MyInt1} and MyInt2: {mystruct.MyInt2}");
            
            
        }

        private static void myMethod(myClass myStruct)
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

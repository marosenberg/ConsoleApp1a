using System;
using System.Collections;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           ArrayList myList = new ArrayList { "A", 1, 1.5, "D"};
            myList.Add(1.35M);
            myList.Remove("A");
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }
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

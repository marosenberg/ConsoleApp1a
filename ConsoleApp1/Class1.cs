using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class1
    {
        private int myVar;
        private string firstName;
        private string lastName;

        public string FullName
        {
            get
            {
                return firstName + " " + lastName;
                
            }
        }
        public int MyProperty
        {
            get { return myVar; }
            set 
            { 
                if (value > 5 || value < 1)
                {
                    throw new Exception();
                }
                myVar = value; 
            }
        }

    }
}

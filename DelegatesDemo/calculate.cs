using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    internal class calculate
    {
        public delegate int MyDelegate1(int a, int b);

        internal class Calculator

        {

            public int Add(int a, int b)

            {

                return a + b;

            }

            public int Substract(int a, int b)

            {

                return a - b;

            }

            public int Multiply(int a, int b)

            {

                return a * b;

            }

            public int Divide(int a, int b)

            {

                return a / b;

            }
             public void display()
            {
                Console.WriteLine("first");
            }



        }
    }
}

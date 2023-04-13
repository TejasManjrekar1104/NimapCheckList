using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateCode
{
    public delegate void Calculatation(int a, int b);

    class Delegates
    {
        public static void Addition(int a, int b)
        {
            int c = a + b;
            Console.WriteLine($"Total of {a} and {b} is:- {c}");
        }

        public static void Substraction(int a, int b)
        {
            int c = a - b;
            Console.WriteLine($"Substraction of {a} and {b} is:- {c}");
        }

        public static void Multiplication(int a, int b)
        {
            int c = a * b;
            Console.WriteLine($"Multiplication of {a} and {b} is:- {c}");
        }


        static void Main(string[] args)
        {
            Calculatation c = new Calculatation(Addition);
            c.Invoke(10, 15);
            c = Substraction;
            c.Invoke(10, 5);
            c = Multiplication;
            c.Invoke(10, 5);

        }
    }
}
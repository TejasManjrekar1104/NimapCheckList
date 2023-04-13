using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculators
{
    class Calculator
    {
        public static int AddSum(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }

        public static int SubstractSum(int num1, int num2)
        {
            int result = num1 - num2;
            return result;
        }

        public static int MultiplySum(int num1, int num2)
        {
            int result = num1 * num2;
            return result;
        }

        public static int DivideSum(int num1, int num2)
        {
            int result = num1 / num2;
            return result;
        }


        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the value A and B:- ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Which operation u want to do?? ");
            Console.WriteLine("+, -, *, /");
            string op = Console.ReadLine();
            if (op.Equals("+"))
            {
                Console.WriteLine(Calculator.AddSum(a, b));
            }

            else if (op.Equals("-"))
            {
                Console.WriteLine(Calculator.SubstractSum(a, b));
            }

            else if (op.Equals("*"))
            {
                Console.WriteLine(Calculator.MultiplySum(a, b));
            }

            else if (op.Equals("/"))
            {
                Console.WriteLine(Calculator.DivideSum(a, b));
            }

            else
            {
                Console.WriteLine("Error Occured");
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function2
{
    class FunctionInput
    {
        public static void add(int num1, int num2)
        {
            int result = num1 + num2;
            Console.WriteLine(result);
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of a and b:- ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            FunctionInput.add(a, b);

        }
    }
}

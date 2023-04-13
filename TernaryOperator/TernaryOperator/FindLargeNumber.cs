using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TernaryOperator
{
    class FindLargeNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of a, b, c, d :- ");

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());

            string result = ((a > b && a > c && a > d) ? "A is larger than all" : (b > c && b > d) ? "B is larger than all" : (c > d) ? "C is larger than all" : "D is larger than all");

            Console.WriteLine(result);
        }
    }
}
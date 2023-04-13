using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSeries
{
    class Fibonacci
    {
        public static void Main(string[] args)
        {
            //Fibonacci series
            int a = 0; int b = 1; int c;
            Console.WriteLine("Enter Number");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write(a + " " + b + " ");

            for (int i = 2; i <= num; i++)
            {
                c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;
            }
        }
    }
}

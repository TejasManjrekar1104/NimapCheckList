using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    class Calculator
    {
        static void Main(string[] args)
        {
            int a = 45; int b = 33;
            Console.WriteLine("a = 45; b = 33");
            Console.WriteLine("Press 1 for ADDING, Press 2 for SUBSTRACT, Press 3 for MULTIPLY");

            int activity = Convert.ToInt32(Console.ReadLine());
            switch (activity)
            {
                case 1:
                    Console.WriteLine(a + b);
                    break;

                case 2:
                    Console.WriteLine(a - b);
                    break;

                case 3:
                    Console.WriteLine(a * b);
                    break;

                default:
                    Console.WriteLine("error");
                    break;
            }
        }
    }
}
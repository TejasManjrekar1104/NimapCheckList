using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseIf
{
    class IfElseIfCode
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Age");
            int Age = int.Parse(Console.ReadLine());

            if (Age <= 10)
            {
                Console.WriteLine("You are baby");
            }
            else if (Age <= 20 && Age > 10)
            {
                Console.WriteLine("You are grown up");
            }
            else if (Age <= 30 && Age > 20)
            {
                Console.WriteLine("Young man");
            }
            else if (Age <= 50 && Age > 30)
            {
                Console.WriteLine("Working Man");
            }
            else if (Age <= 60 && Age > 50)
            {
                Console.WriteLine("Retired");
            }
            else if (Age <= 100 && Age > 60)
            {
                Console.WriteLine("Old Man");
            }

        }
    }
}

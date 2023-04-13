using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElse
{
    class LicenseEligibility
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What is your AGE?");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age < 18)
            {
                Console.WriteLine("You are not Eligible for license");
            }
            else
            {
                Console.WriteLine("You are Eligible for License");
            }
        }
    }
}
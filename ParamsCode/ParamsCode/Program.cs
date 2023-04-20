using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsCode
{
    class Program
    {
        public static int Add(params int[] par)
        {
            int sum = 0;
            foreach(int i in par)
            {
                sum = sum + i;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Sum of all passed num is:- "+Program.Add(10,15,20,25,30,35));
        }
    }
}

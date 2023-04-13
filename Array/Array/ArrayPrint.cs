using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class ArrayPrint
    {
        public static void Main(string[] args)
        {
            int[] arr = { 34, 44, 2, 55, 67, 98, 33, 11 };

            foreach (int n in arr)
            {
                Console.Write(n + " ");
            }
        }
    }
}

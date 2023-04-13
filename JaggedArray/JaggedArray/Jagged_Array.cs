using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    class Jagged_Array
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[3][];

            arr[0] = new[] { 23, 34, 45, 56, 78, 90, 12, 34 };
            arr[1] = new[] { 21, 32, 43, 54, 76, 98, 09 };
            arr[2] = new[] { 11, 22, 33, 44 };

            foreach (int[] item in arr)
            {
                foreach (int i in item)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }



        }
    }
}

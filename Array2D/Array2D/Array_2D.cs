using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array2D
{
    class Array_2D
    {
        static void Main(string[] args)
        {
            int[,] arr = { { 23, 33, 43, 53 }, { 55, 66, 77, 88 }, { 12, 32, 42, 52 } };
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
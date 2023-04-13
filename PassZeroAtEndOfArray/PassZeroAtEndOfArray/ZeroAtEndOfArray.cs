using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassZeroAtEndOfArray
{
    class ZeroAtEndOfArray
    {
        public static void Main(string[] args)
        {
            //pass all 0 at last without changing the index.
            int[] arr = { 13, 0, 44, 71, 45, 0, 23, 5, 0, 3, 0, 66 };

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    Console.Write(arr[i] + " ");
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    Console.Write(arr[i] + " ");
                }
            }


        }
    }
}

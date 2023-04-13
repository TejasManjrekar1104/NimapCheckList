using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FineLargeAndSecondLarge
{
    class LargeAndSecondLarge
    {
        public static void Main(string[] args)
        {
            //Find Large and Second Large element in ARRAY
            int[] arr = { 45, 55, 12, 34, 89, 56, 22, 17 };

            int large = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > large)
                {
                    large = arr[i];
                }
            }
            Console.WriteLine("Large Element is:- " + large);

            int secondLarge = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > secondLarge && arr[i] < large)
                {
                    secondLarge = arr[i];
                }
            }
            Console.WriteLine("SecondLarge element is:- " + secondLarge);
        }
    }
}

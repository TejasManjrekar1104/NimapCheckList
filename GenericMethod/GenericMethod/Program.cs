using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMethod
{
    class Arrayy
    {
        public static void ShowArray<T>(T[] arr)
        {
            for(int i = 0; i<arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] Number = {10,20,30,40,50,60,70,80,90 };

            string[] Name = { "Tejas", "Manjrekar" };

            double[] Num = {1.1,2.3,3.4,4.5,5.6,6.7 };

            Arrayy.ShowArray(Number);
            Arrayy.ShowArray(Name);
            Arrayy.ShowArray(Num);

        }
    }
}

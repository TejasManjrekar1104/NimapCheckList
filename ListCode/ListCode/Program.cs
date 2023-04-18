using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListCode
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Num = new List<int>();
            Num.Add(10);
            Num.Add(15);
            Num.Add(20);
            Num.Add(25);
            Num.Add(30);
            Num.Add(35);

            foreach(int n in Num)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("_______________________________");

            List<string> Name = new List<string>();
            Name.Add("Tejas");
            Name.Add("Manjrekar");

            foreach(string n in Name)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("_______________________________");

            List<double> Num2 = new List<double>();
            Num2.Add(10.5);
            Num2.Add(13.5);
            Num2.Add(16.5);
            Num2.Add(19.5);
            Num2.Add(20.5);
            foreach (double n in Num2)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("_______________________________");

            Num2.Insert(2, 19.2);
            foreach (double n in Num2)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("--------------------------------");

            Num.Reverse();
            foreach (int n in Num)
            {
                Console.WriteLine(n);
            }

        }
    }
}

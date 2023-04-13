using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLoadingCode
{
    class OverLoading
    {
        public void Add()
        {
            int a = 10;
            int b = 20;
            int c = a + b;
            Console.WriteLine(c);
        }

        public int Add(int a, int b)
        {
            return a + b;

        }

        public string Add(string a, string b)
        {
            return a + " " + b;

        }
        public static void Main()
        {
            OverLoading ol = new OverLoading();
            ol.Add();
            Console.WriteLine(ol.Add(3, 5));
            Console.WriteLine(ol.Add("Tejas", "Manjrekar"));
        }
    }
}
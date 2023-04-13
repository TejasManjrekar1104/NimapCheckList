using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function1
{
    class Function
    {
        public void Add(int a, int b)
        {
            int result = a + b;
            Console.WriteLine(result);
        }
        public static void Main(string[] args)
        {
            Function f = new Function();
            f.Add(5, 8);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticVariableAndMethod
{
    class Static
    {
        public static int id = 1;
        public static string name = "Tejas";

        public static int add(int a, int b)
        {
            return a + b;
            //Console.WriteLine(c);

        }

        public static void Main()
        {
            Console.WriteLine(Static.id);
            Console.WriteLine(Static.name);

            Console.WriteLine(Static.add(3, 4));
        }
    }
}
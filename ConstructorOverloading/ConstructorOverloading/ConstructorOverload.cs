using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorOverloading
{
    class ConstructorOverload
    {
        public ConstructorOverload()
        {
            Console.WriteLine("Hello");
        }

        public ConstructorOverload(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public ConstructorOverload(int a, int b, int c)
        {
            Console.WriteLine(a + b + c);
        }
        public static void Main()
        {
            ConstructorOverload co = new ConstructorOverload();

            ConstructorOverload c1 = new ConstructorOverload(10, 20);

            ConstructorOverload c2 = new ConstructorOverload(10, 20, 30);


        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    class Generics<T>
    {
        T box;

        public Generics(T a)
        {
            this.box = a;
        }

        public T GetBox()
        {
            return this.box;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Generics<int> g = new Generics<int>(10);
            Generics<string> s = new Generics<string>("Tejas");

            Console.WriteLine(g.GetBox());
            Console.WriteLine(s.GetBox());

        }
    }
}

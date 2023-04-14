using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Abstract
{
    interface A
    {
        void Print();
    }

    public abstract class B
    {
        public abstract void Print1();
    }
    class Program : B, A
    {
        public void Print()
        {
            Console.WriteLine("I am interface method");
        }

        public override void Print1()
        {
            Console.WriteLine("I am abstract method");
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Print();
            p.Print1();
        }
    }
}

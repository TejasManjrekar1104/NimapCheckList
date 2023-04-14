using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecplicit_Implementation_Of_Interface
{
    interface A
    {
        void Hello();
    }

    interface B
    {
        void Hello();
    }

    class C : A, B
    {
         void A.Hello()
        {
            Console.WriteLine("Hello Tejas from A interface");
        }

         void B.Hello()
        {
            Console.WriteLine("Hello Tejas form B interface");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            C c = new C();
            ((A)c).Hello();
            ((B)c).Hello();
        }
    }
}

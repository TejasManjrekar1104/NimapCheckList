
using InterfaceInheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceInheritance
{
   interface A
    {
        void A1();
       
    }

   interface B
    {
        void B1();
       
    }

    }
   class Multiple : A,B
    {

    public void A1()
    {
        Console.WriteLine("I am A1");
    }

    public void B1()
    {
        Console.WriteLine("I am B1");
    }

        static void Main(string[] args)
        {
        Multiple m = new Multiple();
        m.A1();
        m.B1();
        }
    }



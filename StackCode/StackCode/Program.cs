using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCode
{
    class Stackk
    {
        static void Main(string[] args)
        {
            Stack mystack = new Stack();
            mystack.Push(10);
            mystack.Push("Tejas");
            mystack.Push(20);
            mystack.Push('A');
            mystack.Push(12);
            mystack.Push(null);
            mystack.Push(10);
           // mystack.Push(10);
            //mystack.Push(10);
            mystack.Push(null); 
            mystack.Push(null);

            foreach (object o in mystack)
            {
                Console.Write(o + "  ");
            }

            Console.WriteLine("Peeked:- " + mystack.Peek());
            mystack.Pop();

            foreach (object o in mystack)
            {
                Console.Write(o + "  ");
            }
        }
    }
}


using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue Q = new Queue();
            Q.Enqueue(10);
            Q.Enqueue(20);
            Q.Enqueue(30);
            Q.Enqueue("Tejas");
            Q.Enqueue('A');
            Q.Enqueue("Thane");
            Q.Enqueue(10.10);
            Q.Enqueue(20.3);
            Q.Enqueue(true);
            Q.Enqueue(null);
            Q.Enqueue(null);
            Q.Enqueue(10);
            Q.Enqueue(10);
            Q.Enqueue(10);

            foreach (object d in Q)
            {
                Console.WriteLine(d);
            }

            Console.WriteLine("--------------------------------");

            Console.WriteLine(Q.Peek());
            Q.Dequeue();

            Console.WriteLine("--------------------------------");

            foreach (object d in Q)
            {
                Console.WriteLine(d);
            }
            Console.WriteLine("--------------------------------");


            Console.WriteLine(Q.Peek());
        }
    }
}

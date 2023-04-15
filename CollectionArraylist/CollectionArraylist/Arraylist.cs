using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CollectionArraylist
{
    class ArraylistDemo
    {
        static void Main(string[] args)
        {
            ArrayList mylist = new ArrayList();

            mylist.Add(10);
            mylist.Add("Tejas");
            mylist.Add(10.5);
            mylist.Add('T');

            foreach (var p in mylist)
            {
                Console.Write(p+" ");
            }

            Console.WriteLine();

            mylist.Insert(2, 20);

            foreach (var p in mylist)
            {
                Console.Write(p+" ");
            }

            mylist.Remove(10.5);

            Console.WriteLine();

            foreach (var p in mylist)
            {
                Console.Write(p + " ");
            }
            Console.WriteLine();

            mylist.RemoveAt(0);

            foreach (var p in mylist)
            {
                Console.Write(p + " ");
            }
        }
    }
}

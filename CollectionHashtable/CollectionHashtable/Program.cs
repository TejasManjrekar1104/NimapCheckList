using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CollectionHashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable()
            {
                {"ID", 101 }, {"Name", "Tejas"},
                {"Salary", 1000 }, {"Address", "Thane"} 
            };

            foreach(object key in ht.Keys)
            {
                Console.WriteLine(key + " : " + ht[key]);
            }

            Console.WriteLine("---------------Removed Salary---------------");
            ht.Remove("Salary");

            foreach (object key in ht.Keys)
            {
                Console.WriteLine(key + " : " + ht[key]);
            }

            Console.WriteLine(ht.Contains("Address"));
            Console.WriteLine(ht.Count);

            //Console.WriteLine(ht["ID"]);
            //Console.WriteLine(ht["Name"]);
            //Console.WriteLine(ht["Salary"]);
            //Console.WriteLine(ht["Address"]);
        }
    }
}

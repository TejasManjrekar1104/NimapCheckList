using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> d = new Dictionary<int, string>();
            d.Add(1, "Tej");
            d.Add(0, "Nimap");
            d.Add(5, "Te");
            d.Add(3, null);
            d.Add(6, null);
            d.Add(1, "Tej");


            foreach (KeyValuePair<int,string> print in d)
            {
                Console.WriteLine(print);
            }
        }
    }
}

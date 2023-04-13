using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousFunctionDemo
{
    class AnonymousFunction
    {
        public delegate void MyDelegate(int num);
        static void Main(string[] args)
        {
            MyDelegate Md = delegate (int num)
            {
                num += 10;
                Console.WriteLine(num);
            };

            Md.Invoke(5);


        }
    }
}

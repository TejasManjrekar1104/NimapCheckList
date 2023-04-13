using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyConstructor
{
    class Emp
    {
        string name;
        int id;

        public Emp(string name, int id)
        {
            this.name = name;
            this.id = id;
        }

        Emp(Emp cc)
        {
            this.name = cc.name;
            this.id = cc.id;
        }

        public void Getdata()
        {
            Console.WriteLine(name);
            Console.WriteLine(id);

        }

        class CopyConstructor
        {
            public static void Main()
            {
                Emp p = new Emp("Tejas", 2);
                p.Getdata();
            }
        }
    }
}
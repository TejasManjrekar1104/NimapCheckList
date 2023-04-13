using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Construct
    {
        int id;
        string name;

        public Construct(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public int Getid()
        {
            return this.id;
        }

        public string Getname()
        {
            return this.name;
        }

        static void Main(string[] args)
        {
            Construct Tejas = new Construct(1, "Tejas");

            Console.WriteLine("Emp Id is: {0}", Tejas.id);
            Console.WriteLine("Emp Name is: {0}", Tejas.name);

            Console.WriteLine("--------------------");

            Construct Yuvraj = new Construct(2, "Yuvraj");

            Console.WriteLine("Emp Id is: {0}", Yuvraj.id);
            Console.WriteLine("Emp Name is: {0}", Yuvraj.name);



        }
    }
}
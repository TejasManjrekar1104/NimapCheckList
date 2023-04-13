using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverridding
{
    class Parent
    {
        public virtual void Education()
        {
            Console.WriteLine("You will do Engineering");
        }
    }

    class Child : Parent
    {
        public override void Education()
        {
            Console.WriteLine("No, I want to do Medical");
        }
    }
    class Override
    {
        static void Main(string[] args)
        {
            Parent c = new Child();
            c.Education();
        }
    }
}

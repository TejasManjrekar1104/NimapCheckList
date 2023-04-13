using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    //ABSTRACT CLASS
    abstract class MechanicalShop
        {

        //ABSTRACT METHODS
        public abstract void VehicalType();
        public abstract void Color();

        public abstract void Cost(int a);

        //CONCREATE METHODS
        public MechanicalShop()
        {
            Console.WriteLine("WE PROVIDE ALL TYPE OF SERVICES");
        }

        public MechanicalShop(string a)
        {
            a = "Tejas";
            Console.WriteLine(a);
        }



    }

    class Customer1 : MechanicalShop
    { 
        public override void Color()
        {
            Console.WriteLine("RED");
        }

        public override void VehicalType()
        {
            Console.WriteLine("HONDA CITY");
        }

        public override void Cost(int a)
        {
            double Total = a + (a * 0.20);
            Console.WriteLine(Total);
        }
    }

    class Customer2 : MechanicalShop
    {
        public override void Color()
        {
            Console.WriteLine("BLUE");
        }
        public override void VehicalType()
        {
            Console.WriteLine("SWIFT");
        }

        public override void Cost(int a)
        {
            double Total = a + (a * 0.20);
            Console.WriteLine(Total);
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Customer1 c1 = new Customer1();
            c1.VehicalType();
            c1.Color();
            c1.Cost(10000);
            //c1.MechanicalShop();

            Console.WriteLine("---------------------------");

            Customer2 c2 = new Customer2();
            c2.VehicalType();
            c2.Color();
            c2.Cost(12000);
           // c2.MechanicalShop();
        }
    }
}

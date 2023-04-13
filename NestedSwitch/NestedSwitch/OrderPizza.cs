using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedSwitch
{
    class OrderPizza
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1 for non-veg pizza 2 for veg pizza");
            int pizza = Convert.ToInt32(Console.ReadLine());

            switch (pizza)
            {
                case 1:
                    Console.WriteLine("u have choosen non-veg pizza");
                    Console.WriteLine("1 for chicken 2 for meat");
                    int nonveg = Convert.ToInt32(Console.ReadLine());
                    switch (nonveg)
                    {
                        case 1:
                            Console.WriteLine("u have choosen chicken pizza");
                            break;
                        case 2:
                            Console.WriteLine("u have choosen meat pizza");
                            break;
                    }
                    break;

                case 2:
                    Console.WriteLine("u have choosen veg pizza");
                    Console.WriteLine("1 for tomato 2 for onion");
                    int veg = Convert.ToInt32(Console.ReadLine());
                    switch (veg)
                    {
                        case 1:
                            Console.WriteLine("u have choosen tomato");
                            break;
                        case 2:
                            Console.WriteLine("u have choosen onion");
                            break;
                    }
                    break;
            }
        }
    }
}
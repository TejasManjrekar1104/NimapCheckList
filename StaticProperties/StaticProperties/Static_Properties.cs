using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticProperties
{
    class Student
    {
        private static int id;
        private static string name;

        public static int _id
        {
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("id cant be null or zero");
                }
                else
                {
                    id = value;
                }
            }
            get
            {
                return id;
            }
        }

        public static string _name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("enter the name");
                }
                else
                {
                    name = value;
                }
            }
            get
            {
                return name;
            }
        }
    }
    class Static_Properties
    {
        public static void Main()
        {
            Student._id = 102;
            Student._name = "Tejas";

            Console.WriteLine(Student._id);
            Console.WriteLine(Student._name);
        }
    }
}
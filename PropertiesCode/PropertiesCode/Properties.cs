using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesCode
{
    class student
    {
        private int _StdId;
        private string _StdName;


        public int StdId
        {
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("entered value is zero or negative");
                }
                else
                {
                    _StdId = value;
                }
            }
            get
            {
                return _StdId;
            }
        }


        public string StdName
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("please enter name");
                }
                else
                {
                    _StdName = value;
                }

            }
            get
            {
                return _StdName;
            }

        }
    }

    class Properties
    {
        static void Main(string[] args)
        {
            student Tejas = new student();
            Tejas.StdId = 101;
            Tejas.StdName = "Tejas";

            Console.WriteLine(Tejas.StdId);
            Console.WriteLine(Tejas.StdName);


        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties2
{
    class Employee { 
    public int EmpId { get; private set; }
    public string EmpName { get; private set; }

    public Employee(int empid, string empname)
    {
        EmpId = empid;
        EmpName = empname;
    }
}

class Property
{

    public static void Main()
    {
        Employee e = new Employee(101, "Tejas");
        Console.WriteLine(e.EmpId);
        Console.WriteLine(e.EmpName);

    }
}
}
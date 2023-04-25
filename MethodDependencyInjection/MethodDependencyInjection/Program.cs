using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodDependencyInjection
{
    public interface Iaccount
    {
        void Print();
    }

    class CurrentAccount : Iaccount
    {
        public void Print()
        {
            Console.WriteLine("it is current account");
        }
    }

    class SavingAccount : Iaccount
    {
        public void Print()
        {
            Console.WriteLine("it is saving account");
        }
    }

    class Account
    {
        public void PrintAccount(Iaccount account)
        {
            account.Print();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Account a = new Account();
            a.PrintAccount(new CurrentAccount());

            a.PrintAccount(new SavingAccount());

        }
    }
}

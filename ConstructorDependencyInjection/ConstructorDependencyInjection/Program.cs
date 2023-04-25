using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDependencyInjection
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
        private Iaccount account;

        public Account(Iaccount account)
        {
            this.account = account;
        }

        public void PrintAccount()
        {
            account.Print();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Iaccount ca = new CurrentAccount();
            Account c = new Account(ca);
            c.PrintAccount();

            Iaccount sa = new SavingAccount();
            Account s = new Account(sa);
            s.PrintAccount();
        }
    }
}

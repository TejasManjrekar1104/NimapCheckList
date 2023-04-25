﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyDependencyInjection
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
        public Iaccount account { get; set; }

        public void PrintAccount()
        {
            account.Print();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Account a = new Account();
            a.account = new CurrentAccount();
            a.PrintAccount();


            a.account = new SavingAccount();
            a.PrintAccount();
        }
    }
}

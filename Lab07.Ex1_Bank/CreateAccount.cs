﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07.Ex1_Bank
{
    class CreateAccount
    {
        static void Main()
        {
            BankAccount berts = NewBankAccount();
            Write(berts);
            TestDeposit(berts);
            Write(berts);
            TestWithdraw(berts);
            Write(berts);


            BankAccount freds = NewBankAccount();
            Write(freds);
            TestDeposit(freds);
            Write(freds);
            TestWithdraw(freds);
            Write(freds);


            Console.ReadLine(); //Для удобства проверки
        }

        static BankAccount NewBankAccount()
        {
            BankAccount created = new BankAccount();

            Console.Write("Enter the account balance! : ");
            decimal balance = decimal.Parse(Console.ReadLine());

            created.Populate(balance);

            return created;
        }

        static void Write(BankAccount acc)
        {
            Console.WriteLine("Account number is {0}", acc.Number());
            Console.WriteLine("Account balance is {0}", acc.Balance());
            Console.WriteLine("Account type is {0}", acc.Type());
        }
        public static void TestDeposit(BankAccount acc)
        {
            Console.Write("Enter amount to deposit: ");
            decimal amount = decimal.Parse(Console.ReadLine());
            acc.Deposit(amount);
        }
        public static void TestWithdraw(BankAccount acc)
        {
            Console.Write("Enter amount to withdraw: ");
            decimal amount = decimal.Parse(Console.ReadLine());
            if (!acc.Withdraw(amount))
            {
                Console.WriteLine("Insufficient funds.");
            }
        }


    }
}

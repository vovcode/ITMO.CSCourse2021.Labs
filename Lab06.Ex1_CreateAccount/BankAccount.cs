using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06.Ex1_CreateAccount
{
    class BankAccount
    {

        public void Populate(long number, decimal balance)
        {

            accNo = number;
            accBal = balance;
            accType = AccountType.Checking;
        }
        public long Number()
        {
            return accNo;
        }
        public decimal Balance()
        {
            return accBal;
        }

        public string Type()
        {
            return accType.ToString();
        }
        private long accNo;
        private decimal accBal;
        private AccountType accType;

    }

}
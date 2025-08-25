using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    internal struct Account
    {
        private int accountId;
        private string accountHolder;
        private int balance;

        public int AccountId
        {
            get { return accountId; }
            set { accountId = value; }
        }
        public string AccountHolder
        {
            get { return accountHolder; }
            set { accountHolder = value; }
        }
        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public override string ToString()
        {
            return $"ID: {AccountId}, Holder: {AccountHolder}, Balance: {Balance}";
        }
    }
}

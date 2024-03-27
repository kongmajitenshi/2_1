using System;

namespace Proj6
{
    internal class Account
    {
        public string Number;
        public string Owner;
        public decimal Balance;

        public bool AddBalance(decimal money)
        {
            if (money <= 0) {
                return false;
            }

            Balance += money;
            return true;
        }

        public bool SubBalance(decimal money)
        {
            if (Balance - money >= 0) {
                Balance -= money;
                return true;
            } else {
                return false;
            }
        }
    }
}
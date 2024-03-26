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
            if (money <= 0)
            {
                return false;
            }
            Balance += money;
            return true;
        }

        public bool SubBanalce(decimal money)
        {
            bool result = true;
            
            Balance -= money;
            if (Balance < 0)
            {
                Balance += money;
                result = false;
            }

            //if (money < 0){
            //    result = false;
            //}else if(Balance - money < 0){
            //    result = false;
            //}else{
            //    Balance -= money;
            //}
            
            return result;
        }
    }
}
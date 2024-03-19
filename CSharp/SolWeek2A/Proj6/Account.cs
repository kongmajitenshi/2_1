using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj6
{
    public class Account
    {
        public string Number;
        public string Owner;
        public decimal Balance;
        public void AddBalance(decimal PlusMoney)
        {
            Balance = Balance + PlusMoney;
        }
    }
}

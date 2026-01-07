using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises01
{
    public class SwiftPayment : IBankPayment
    {

        private readonly int _amount;

        private readonly string _bankAccount;

        public SwiftPayment(int amount, string bankAccount)
        {
            _amount = amount;
            _bankAccount = bankAccount;
        }
        public int Amount() => _amount;

        public string BankAccount() => _bankAccount;

    }
}

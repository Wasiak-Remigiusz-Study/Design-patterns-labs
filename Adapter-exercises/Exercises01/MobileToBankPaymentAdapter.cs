using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises01
{
    public class MobileToBankPaymentAdapter : IBankPayment
    {
        private  IMobilePayment _iMobilePayment;

        public MobileToBankPaymentAdapter(IMobilePayment iMobilePayment)
        {
            _iMobilePayment = iMobilePayment;
        }
        public int Amount()
        {
            return _iMobilePayment.Amount();
        }

        public string BankAccount()
        {
            string digits = new string(_iMobilePayment.PhoneNumber() //W przypadku w pełni funkcjonalnego systemu moglibyśmy przeszukiwać bazę danych w celu identyfikacji numeru konta.
                .Where(char.IsDigit)
                .ToArray());

            Console.WriteLine($"digits: {digits}");

            string last5Digits = digits.Length >= 5 ? digits[^5..] : digits.PadLeft(5, '0');
            Console.WriteLine($"digits: {last5Digits}");

            string bankAccount = "PL123456789012345678901" + last5Digits;

            return bankAccount;
        }
    }
}

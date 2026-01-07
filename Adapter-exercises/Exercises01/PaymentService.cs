using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Exercises01
{
    public class PaymentService // klasa odpowiedzialna za przetwarzanie płatności
    {


        public void ProcessPayment(IBankPayment payment)
        {
            Console.WriteLine("[STARTING PROCESS PAYMENT]");

            if (payment.Amount() <= 0)
            {
                Console.WriteLine($"[WRONG AMOUNT] - Payment amount must be greater than ZERO.\nAmount given: {payment.Amount()}");
                Console.WriteLine("[PROCESS PAYMENT TERMINATED DUE TO VALIDATION ERROR]");
                return;
            }
                

            string accountNumber = payment.BankAccount();

            if (!ValidateBankAccount(accountNumber))
            {
                Console.WriteLine($"[WRONG ACCOUNT NUMBER] - Account must start with 'PL' and have 26 digits.\nAccount number given: {accountNumber}.");
                Console.WriteLine("[PROCESS PAYMENT TERMINATED DUE TO VALIDATION ERROR]");
                return;
            }



            Console.WriteLine($"[PROCESS PAYMENT SUCCESSFUL] - Processed payment with amount {payment.Amount()} PLN.");
            Console.WriteLine($"Account recipient: {accountNumber}");
            Console.WriteLine("[FINISHING PROCESS PAYMENT]");


        }



        private bool ValidateBankAccount( string accountNumber)
        {
            if (string.IsNullOrEmpty(accountNumber))
                return false;

            var regex = new Regex(@"^PL\d{26}$");
            return regex.IsMatch(accountNumber);

        }


        private bool LogTransaction()
        {
            throw new NotImplementedException();
        }
    }
}

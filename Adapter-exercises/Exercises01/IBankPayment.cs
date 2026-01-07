using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises01
{
    public interface IBankPayment //interfejs płatności bankowej
    {
        int Amount(); // metoda zwracająca kwotę płatności,
        string BankAccount(); // metoda zwracająca numer konta bankowego odbiorcy płatności

    }
}

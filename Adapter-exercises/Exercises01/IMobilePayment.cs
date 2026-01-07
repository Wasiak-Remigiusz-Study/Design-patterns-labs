using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Exercises01
{
    public interface IMobilePayment // nowy interfejs, który reprezentuje płatności mobilne
    {
        int Amount(); // zwracający kwotę płatności,
        string PhoneNumber(); //  zwracający numer telefonu użytkownika(zamiast numeru konta bankowego).
    }
}

/*
Zadanie 1 Adapter


Część I.

Pracujesz w firmie finansowej. 
Twoim zadaniem jest stworzenie podstawowego systemu do obsługi płatności, system ten będzie przetwarzał płatności bankowe na podstawie interfejsu IBankPayment.

Twoim celem jest napisanie kodu, który pozwoli na obsługę płatności przez klasę PaymentService, wykorzystującą metodę ProcessPayment.

Wymagania:



Interfejs IBankPayment – interfejs płatności bankowej, zawierający dwie metody:

int Amount(); – zwracająca kwotę płatności,
string BankAccount(); – zwracająca numer konta bankowego odbiorcy płatności.
Klasa PaymentService – klasa odpowiedzialna za przetwarzanie płatności:

Stwórz metodę ProcessPayment, która przyjmuje jeden argument - obiekt implementujący interfejs IBankPayment, i przetwarza płatność na podstawie danych 
dostarczonych przez ten obiekt. Sprawdź, czy kwota płatności jest większa niż 0 - jeśli kwota jest nieprawidłowa, wyświetl 
komunikat błędu oraz dodaj metodę pomocniczą ValidateBankAccount, która sprawdza, czy numer konta ma poprawny format - składa się z 26 cyft, a zaczyna się 
od „PL”. Jeśli numer konta jest nieprawidłowy, wyświetl komunikat błędu.
Jako zadanie dodatkowe możesz dodać metodę LogTransaction, która zapisuje informacje o płatności (kwota i numer konta, data) do pliku.
Przetestowanie systemu płatności:

Stwórz przykład płatności bankowej - klasę SwiftPayment implementującą interfejs IBankPayment.
Wykorzystaj klasę PaymentService do przetworzenia płatności.



Część II.

Mija kilka lat i Twoja firma chce dodać obsługę płatności BLIK. Klasa obsługująca płatności BLIK została dostarczona przez zewnętrzną firmę i 
implementuje interfejs IMobilePayment, który jest inny niż IBankPayment, używany w Twoim systemie. Twoim zadaniem jest stworzenie rozwiązania, które 
pozwoli na przetwarzanie płatności BLIK bez modyfikacji kodu systemu.

W tym celu zastosujesz wzorzec projektowy Adapter, aby „dopasować” interfejs IMobilePayment do IBankPayment, umożliwiając systemowi przetwarzanie płatności BLIK.

Nowe wymagania funkcjonalne
Interfejs IMobilePayment – nowy interfejs, który reprezentuje płatności mobilne, zawierający:

int Amount(); – zwracający kwotę płatności,
string PhoneNumber(); – zwracający numer telefonu użytkownika (zamiast numeru konta bankowego).
Klasa BlikPayment– implementująca interfejs IMobilePayment 
Klasa MobileToBankPaymentAdapter – klasa adaptera, która:

Implementuje IBankPayment.
Przekształca numer telefonu na numer konta bankowego - spróbuj wymyślić swoją logikę. 
W przypadku w pełni funkcjonalnego systemu moglibyśmy przeszukiwać bazę danych w celu identyfikacji numeru konta przypisanego do danego numeru telefonu.
*/

using Exercises01;

class Program
{
    static void Main(string[] args)
    {
        PaymentService paymentService = new PaymentService();

        // -- Część I.
        Console.WriteLine(" -- Część I - platność bankowa\n");

        IBankPayment swiftPayment01 = new SwiftPayment(1000, "PL12345678901234567890123456");
        paymentService.ProcessPayment(swiftPayment01);

        Console.WriteLine();

        IBankPayment swiftPayment02 = new SwiftPayment(-12, "PL12345678901234567890123456");
        paymentService.ProcessPayment(swiftPayment02);

        Console.WriteLine();

        IBankPayment swiftPayment03 = new SwiftPayment(1000, "PL1234567890123456789");
        paymentService.ProcessPayment(swiftPayment03);





        // -- Część II.
        Console.WriteLine();

        Console.WriteLine(" -- Część II - Blik with Adapter \n");

        IMobilePayment blikPayment01 = new BlikPayment(1200, "005555");
        IBankPayment blikAdapter = new MobileToBankPaymentAdapter(blikPayment01);
        paymentService.ProcessPayment(blikAdapter);
    }
}


namespace ConsoleApp1
{
    public class SmsSender
    {
        public void SendSms(string recipient, string message)
        {
            Console.WriteLine($"Sending message: {message} to: {recipient}.");
        }
    }
}

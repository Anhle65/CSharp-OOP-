using System;

namespace InterfaceAndInheritance
{
    public class SmsNotifictionChannel : INotificationChannel
    {
        public void Send(Message message)
        {
            Console.WriteLine("Sending sms ...");
        }
    }
}

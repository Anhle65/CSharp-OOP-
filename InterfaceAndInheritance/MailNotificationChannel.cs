
using System;

namespace InterfaceAndInheritance
{
    public class MailNotificationChannel : INotificationChannel
    { 
        public void Send(Message message)
        {
            Console.WriteLine("Sending email ...");
        }
    }
}

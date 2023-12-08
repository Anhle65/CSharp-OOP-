using System;
using System.Net.Mail;

namespace InterfaceAndInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var encoder = new VideoEncoder();
            encoder.RegisterNotificationChannel(new MailNotificationChannel());
            encoder.RegisterNotificationChannel(new SmsNotifictionChannel());
            encoder.Encode(new Video());
        }
    }
}

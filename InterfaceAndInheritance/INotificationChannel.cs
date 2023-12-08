using System.Net.Http;

namespace InterfaceAndInheritance
{
    public interface INotificationChannel
    {
        //void Send(Mail message);
        void Send(Message message);
    }
}

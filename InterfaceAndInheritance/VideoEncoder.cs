using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InterfaceAndInheritance
{
    public class VideoEncoder
    {
        //private readonly MailService _mailService;
        private readonly IList<INotificationChannel> _notificationChannels;
        public VideoEncoder()
        {
            //_mailService = new MailService();
            _notificationChannels = new List<INotificationChannel>();
        }
        public void Encode (Video video)
        {
            //Video encoding logic...


            //_mailService.Send(new Mail());
            foreach (var channel in _notificationChannels)
                channel.Send(new Message());
        }
        public void RegisterNotificationChannel(INotificationChannel channel)
        {
            _notificationChannels.Add(channel);
        }
    }
}

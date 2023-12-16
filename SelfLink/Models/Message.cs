using System.Linq;
using SelfLink.Database;
using SelfLink.Interfaces;
using SelfLink.Services;

namespace SelfLink.Models
{
    public class Message : ICollection
    {
        public string SenderUserName { get; }
        public string ReceiverUserName { get; }
        public string Text { get; private set; }

        public Message(MessageJson json)
        {
            if (!Validation.ValidateMessageInfo(json.ReceiverUserName))
            {
                return;
            }

            SenderUserName = json.SenderUserName;
            ReceiverUserName = json.ReceiverUserName;
            Text = json.Text;

            Instance.Database.Add(this);
        }

        public Message(string senderUserName, string receiverUserName, string message)
        {
            if (!Validation.ValidateMessageInfo(receiverUserName))
            {
                return;
            }

            SenderUserName = senderUserName;
            ReceiverUserName = receiverUserName;
            Text = message;

            Instance.Database.Add(this);
        }

        public User Sender()
        {
            return Instance.Database.Users()
                .First(user => user.UserName == SenderUserName);
        }

        public User Receiver()
        {
            return Instance.Database
                .Users()
                .First(user => user.UserName == ReceiverUserName);
        }
    }
}
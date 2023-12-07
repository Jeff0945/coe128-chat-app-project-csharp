using System.Linq;
using System.Windows.Forms;
using SelfLink.Database;
using SelfLink.Interfaces;

namespace SelfLink.Models
{
    public class Message : ICollection
    {
        public string SenderUserName { get; }
        public string ReceiverUserName { get; }
        public string Text { get; private set; }

        public Message(string senderUserName, string receiverUserName, string message)
        {
            if (!Validate(receiverUserName))
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

        #region Private functions

        private bool Validate(string userName)
        {
            bool exists = Instance.Database
                .Users()
                .Any(user => user.UserName == userName);

            if (!exists)
            {
                MessageBox.Show($@"User ""{userName}"" does not exist.");
            }

            return exists;
        }

        #endregion
    }
}
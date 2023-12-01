using System.Linq;
using System.Windows.Forms;
using LocalChat.Services;
using LocalChat.Interfaces;

namespace LocalChat.Models
{
    public class Message : ICollection
    {
        public int Id { get; }
        public string UserName { get; }
        public string Text { get; private set; }

        public Message(string userName, string message)
        {
            if (!Validate(userName)) return;
            
            Id = GenerateId();
            UserName = userName;
            Text = message;

            Data.Database.Add(this);
        }

        public User User()
        {
            return Data.Database
                .Users()
                .First(user => user.UserName == UserName);
        }

        public Message Update(string message)
        {
            Text = message;
            
            return this;
        }

        private bool Validate(string userName)
        {
            bool exists = Data.Database
                .Users()
                .Any(user => user.UserName == userName);

            if (!exists) MessageBox.Show("User does not exist.");

            return exists;
        }

        private int GenerateId()
        {
            var messages = Data.Database.Messages().ToList();

            if (!messages.Any()) return 1;

            return messages.Last().Id + 1;
        }
    }
}
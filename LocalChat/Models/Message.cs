using System.Linq;
using LocalChat.Services;
using LocalChat.Interfaces;

namespace LocalChat.Models
{
    public class Message : ICollection
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Text { get; set; }

        public Message(string userName, string message)
        {
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

        private int GenerateId()
        {
            var messages = Data.Database.Messages().ToList();

            if (!messages.Any())
            {
                return 1;
            }

            return messages.Last().Id + 1;
        }
    }
}
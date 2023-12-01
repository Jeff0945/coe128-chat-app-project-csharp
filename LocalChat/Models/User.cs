using System.Collections.Generic;
using System.Linq;
using LocalChat.Components.UsersList;
using LocalChat.Interfaces;
using LocalChat.Services;

namespace LocalChat.Models
{
    public class User : ICollection
    {
        public string UserName { get; set; }
        public string Name { get; set; }

        public User(string userName, string name, Chats instance)
        {
            UserName = userName;
            Name = name;
            
            Data.Database.Add(this);
            instance.recipientsList.Controls.Add(new UserPanel(this));
        }

        public List<Message> Messages()
        {
            return Data.Database.Messages()
                .Where(message => message.UserName == UserName)
                .ToList();
        }
    }
}
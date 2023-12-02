using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using LocalChat.Components.UsersList;
using LocalChat.Interfaces;
using LocalChat.Services;

namespace LocalChat.Models
{
    public class User : ICollection
    {
        public string UserName { get; private set; }
        public string Name { get; private set; }

        public User(string userName, string name)
        {
            if (!Validate(userName))
            {
                return;
            }
            
            UserName = userName;
            Name = name;
            
            Data.Database.Add(this);
            Data.Instance.recipientsList.Controls.Add(new UserPanel(this));
        }

        public List<Message> Messages()
        {
            return Data.Database.Messages()
                .Where(message => message.UserName == UserName)
                .ToList();
        }

        public void Update(string userName = null, string name = null)
        {
            if (!Validate(userName))
            {
                return;
            }

            if (userName != null) UserName = userName;
            if (name != null) Name = name;
            
            GuiFunctions.ReloadUsers();
        }

        public void PlacePanel()
        {
            Data.Instance.recipientsList.Controls.Add(new UserPanel(this));
        }

        private bool Validate(string userName)
        {
            var exists = Data.Database
                .Users()
                .Any(user => user.UserName == userName && user != this);

            if (exists)
            {
                MessageBox.Show($"{userName} already exists.");
            }

            return !exists;
        }
    }
}
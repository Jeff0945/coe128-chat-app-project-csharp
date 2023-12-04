using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SelfLink.Components.UsersList;
using SelfLink.Interfaces;
using SelfLink.Services;

namespace SelfLink.Models
{
    public class User : ICollection
    {
        public string UserName { get; private set; }
        public string Name { get; private set; }
        public UserPanel Component { get; private set; }

        public User(string userName, string name)
        {
            if (!Validate(userName))
            {
                return;
            }
            
            UserName = userName;
            Name = name;
            
            Instance.Database.Add(this);
        }

        public List<Message> Messages()
        {
            return Instance.Database.Messages()
                .Where(message => message.UserName == UserName)
                .ToList();
        }

        public void Update(string userName = null, string name = null)
        {
            if (!Validate(userName))
            {
                return;
            }

            if (userName != null)
            {
                UserName = userName;
                Component.UpdateUserName(userName);
            }

            if (name != null)
            {
                Name = name;
                Component.UpdateName(name);
            }
        }

        public UserPanel CreateComponent()
        {
            Component = new UserPanel(this);
            return Component;
        }

        #region Private functions

        private bool Validate(string userName)
        {
            var exists = Instance.Database
                .Users()
                .Any(user => user.UserName == userName && user != this);

            if (exists)
            {
                MessageBox.Show($@"User name ""{userName}"" already exists.");
            }

            return !exists;
        }

        #endregion
    }
}
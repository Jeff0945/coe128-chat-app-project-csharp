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
        public bool IsSender { get; }
        public bool IsReceiver { get; set; }
        public UserPanel Component { get; private set; }

        public User(string userName, string name, bool isSender = false)
        {
            if (!Validate(userName, isSender))
            {
                return;
            }
            
            UserName = userName;
            Name = name;
            IsSender = isSender;

            Instance.Database.Add(this);
        }

        public UserPanel CreateComponent()
        {
            Component = new UserPanel(this);
            return Component;
        }

        #region Private functions

        private bool Validate(string userName, bool isSender = false)
        {
            var users = Instance.Database.Users().ToList();
            var exists = users.Any(user => user.UserName == userName && user != this);
            var hasClient = users.Any(user => user.IsSender);

            if (exists)
            {
                MessageBox.Show($@"User name ""{userName}"" already exists.");
                return false;
            }

            if (isSender && hasClient)
            {
                MessageBox.Show(@"A sender already exists");
                return false;
            }
            
            return true;
        }

        #endregion
    }
}
using System.Linq;
using System.Windows.Forms;
using SelfLink.Components.UsersList;
using SelfLink.Database;
using SelfLink.Interfaces;

namespace SelfLink.Models
{
    public class User : ICollection
    {
        public string UserName { get; }
        public string Name { get; }
        public bool IsClient { get; }
        public bool IsReceiver { get; set; }
        public UserPanel Component { get; }

        public User(string userName, string name, bool isClient = false)
        {
            if (!Validate(userName, isClient))
            {
                return;
            }
            
            UserName = userName;
            Name = name;
            IsClient = isClient;

            if (!IsClient)
            {
                Component = new UserPanel(this);
            }

            Instance.Database.Add(this);
        }

        #region Private functions

        private bool Validate(string userName, bool isSender = false)
        {
            var users = Instance.Database.Users().ToList();
            var exists = users.Any(user => user.UserName == userName && user != this);
            var hasClient = users.Any(user => user.IsClient);

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
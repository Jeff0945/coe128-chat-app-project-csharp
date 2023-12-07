using System.Collections.Generic;
using System.Linq;
using SelfLink.Interfaces;
using SelfLink.Models;

namespace SelfLink.Services
{
    public class Collection : List<ICollection>
    {
        public IEnumerable<User> Users()
        {
            return this.OfType<User>();
        }

        public IEnumerable<Message> Messages()
        {
            return this.OfType<Message>();
        }
        
        public User Client()
        {
            return Users().FirstOrDefault(user => user.IsSender);
        }

        public User Receiver()
        {
            return Users().FirstOrDefault(user => user.IsReceiver);
        }

        public void Add(User item)
        {
            base.Add(item);

            if (!item.IsSender)
            {
                Gui.AppendUser(item.CreateComponent());
            }
        }
    }
}
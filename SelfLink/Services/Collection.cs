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

        public void Add(User item)
        {
            base.Add(item);
            Gui.AppendUser(item.CreateComponent());
        }
    }
}
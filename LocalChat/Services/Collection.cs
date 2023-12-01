using System.Collections.Generic;
using System.Linq;
using LocalChat.Interfaces;
using LocalChat.Models;

namespace LocalChat.Services
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
    }
}
﻿using System.Collections.Generic;
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

        public IEnumerable<User> ConnectedUsers()
        {
            return this.OfType<User>()
                .Where(user => user.Connection != null);
        }

        public IEnumerable<Message> Messages()
        {
            return this.OfType<Message>();
        }
        
        public User Client()
        {
            return Users().FirstOrDefault(user => user.IsClient);
        }

        public User Receiver()
        {
            return Users().FirstOrDefault(user => user.IsReceiver);
        }

        public void Add(User item)
        {
            base.Add(item);

            if (!item.IsClient)
            {
                Gui.AppendUser(item.Component);
            }
        }

        public void Add(Message item)
        {
            base.Add(item);

            if (item.Sender().UserName == Receiver()?.UserName)
            {
                Gui.ShowMessage(item);
            }

            if (item.Receiver().UserName == Receiver()?.UserName)
            {
                Gui.ShowMessage(item);
            }
        }
    }
}
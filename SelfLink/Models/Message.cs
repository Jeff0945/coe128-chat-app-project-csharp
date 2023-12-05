﻿using System.Linq;
using System.Windows.Forms;
using SelfLink.Interfaces;
using SelfLink.Services;

namespace SelfLink.Models
{
    public class Message : ICollection
    {
        public string UserName { get; }
        public string Text { get; private set; }

        public Message(string userName, string message)
        {
            if (!Validate(userName))
            {
                return;
            }
            
            UserName = userName;
            Text = message;

            Instance.Database.Add(this);
        }

        public User User()
        {
            return Instance.Database
                .Users()
                .First(user => user.UserName == UserName);
        }

        #region Private functions

        private bool Validate(string userName)
        {
            bool exists = Instance.Database
                .Users()
                .Any(user => user.UserName == userName);

            if (!exists)
            {
                MessageBox.Show($@"User ""{userName}"" does not exist.");
            }

            return exists;
        }

        #endregion
    }
}
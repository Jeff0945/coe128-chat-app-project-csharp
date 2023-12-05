using System;
using System.Windows.Forms;
using SelfLink.Components.UsersList;

namespace SelfLink.Services
{
    public static class Gui
    {
        public static void AppendUser(UserPanel item)
        {
            Instance.Gui.recipientsList.Controls.Add(item);
        }

        public static void InitializeUser()
        {
            var newUser = new CreateUser();
            if (newUser.ShowDialog() != DialogResult.OK)
            {
                Environment.Exit(0);
            }
        }

        public static void DisplayUserInfo()
        {
            var gui = Instance.Gui;
            var sender = Instance.Database.Sender();
            
            gui.userDisplayName.Text = sender.Name;
            gui.userName.Text = sender.UserName;
        }
    }
}
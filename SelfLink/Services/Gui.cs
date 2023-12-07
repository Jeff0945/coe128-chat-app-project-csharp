using System;
using System.Linq;
using System.Windows.Forms;
using SelfLink.Components.ClientMessage;
using SelfLink.Components.SenderMessage;
using SelfLink.Components.UsersList;
using SelfLink.Database;
using SelfLink.Models;
using Message = SelfLink.Models.Message;

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
            var sender = Instance.Database.Client();
            
            gui.userDisplayName.Text = sender.Name;
            gui.userName.Text = sender.UserName;
        }

        public static void DisplayMessages(User recipient)
        {
            var messages = Instance.Database.Messages()
                .Where(message => message.SenderUserName == recipient.UserName).ToList();
            
            Instance.Gui.messagesPanel.Controls.Clear();

            foreach (var message in messages)
            {
                AddMessage(message);
            }
        }

        public static void AddMessage(Message message)
        {
            var messagePanel = Instance.Gui.messagesPanel;

            if (message.Sender().UserName == Instance.Database.Client().UserName)
            {
                messagePanel.Controls.Add(new ClientPanel(message));
            }
            else
            {
                messagePanel.Controls.Add(new SenderPanel(message));
            }
        }
    }
}
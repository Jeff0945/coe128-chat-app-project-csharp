using System;
using System.Collections.Generic;
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
            FlowLayoutPanel usersList = Instance.Gui.recipientsList;

            if (usersList.InvokeRequired)
            {
                usersList.Invoke((MethodInvoker)delegate { usersList.Controls.Add(item); });
            }
            else
            {
                usersList.Controls.Add(item);
            }
        }

        public static void ShowLogin()
        {
            var newUser = new CreateUser();
            if (newUser.ShowDialog() != DialogResult.OK)
            {
                Environment.Exit(0);
            }
        }

        public static void PopulateUserInfo()
        {
            Interface gui = Instance.Gui;
            User sender = Instance.Database.Client();
            
            gui.userDisplayName.Text = sender.Name;
            gui.userName.Text = sender.UserName;
        }

        public static void ShowConversation(User selectedUser)
        {
            Collection database = Instance.Database;
            string clientUserName = database.Client().UserName;
            List<Message> messages = database.Messages()
                .Where(message => (message.SenderUserName == clientUserName &&
                                   message.ReceiverUserName == selectedUser.UserName) ||
                                  (message.SenderUserName == selectedUser.UserName &&
                                   message.ReceiverUserName == clientUserName)).ToList();
            
            Instance.Gui.messagesPanel.Controls.Clear();

            foreach (var message in messages)
            {
                ShowMessage(message);
            }
        }

        public static void ShowMessage(Message message)
        {
            FlowLayoutPanel messagePanel = Instance.Gui.messagesPanel;

            if (messagePanel.InvokeRequired)
            {
                messagePanel.Invoke((MethodInvoker)delegate { ShowMessage(message); });
            }
            else
            {
                AppendMessagePanel(messagePanel, message);
            }
        }

        private static void AppendMessagePanel(FlowLayoutPanel messagePanel, Message message)
        {
            Control.ControlCollection controls = messagePanel.Controls;

            if (message.SenderUserName == Instance.Database.Client().UserName)
            {
                controls.Add(new ClientPanel(message));
            }
            else if (message.ReceiverUserName == Instance.Database.Client().UserName)
            {
                controls.Add(new SenderPanel(message));
            }
            
            messagePanel.ScrollControlIntoView(controls[controls.Count - 1]);
        }
    }
}
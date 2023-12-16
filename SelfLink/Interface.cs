using System;
using System.Net.Sockets;
using System.Windows.Forms;
using SelfLink.Connection;
using SelfLink.Database;
using SelfLink.Services;
using Message = SelfLink.Models.Message;

namespace SelfLink
{
    public partial class Interface : Form
    {
        public Interface()
        {
            InitializeComponent();
            Instance.Gui = this;
            
            Gui.ShowLogin();
            Gui.PopulateUserInfo();
            
            StartEventListeners();
            
            Server.ConnectOrStart();
        }

        private void StartEventListeners()
        {
            sendButton.Click += HandleSendMessage;
        }

        private void HandleSendMessage(object sender, EventArgs e)
        {
            Collection database = Instance.Database;
            string message = messageInput.Text;
            TcpClient receiver = Instance.IsClient()
                ? Instance.ServerConnection
                : database.Receiver()?.Connection;

            if (receiver == null || database.Receiver() == null || message.Length == 0)
            {
                return;
            }

            var messageObj = new Message(database.Client().UserName, database.Receiver().UserName, message);
            Communication.SendData(messageObj, receiver);
            
            messageInput.Text = "";
        }
    }
}
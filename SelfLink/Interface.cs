using System;
using System.Windows.Forms;
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
            
            Gui.InitializeUser();
            Gui.DisplayUserInfo();

            sendButton.Click += HandleSendMessage;
        }

        private void HandleSendMessage(object sender, EventArgs e)
        {
            var database = Instance.Database;
            var receiver = database.Receiver();
            var message = messageInput.Text;

            if (receiver == null || message.Length == 0)
            {
                return;
            }

            new Message(database.Client().UserName, database.Receiver().UserName, message);
            messageInput.Text = "";
        }
    }
}
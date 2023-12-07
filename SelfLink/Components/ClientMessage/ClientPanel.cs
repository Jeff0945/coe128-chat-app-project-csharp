using System.Drawing;
using System.Windows.Forms;
using Message = SelfLink.Models.Message;

namespace SelfLink.Components.ClientMessage
{
    public sealed partial class ClientPanel : Panel
    {
        public ClientPanel(Message message)
        {
            AutoSize = true;
            BackColor = Color.Transparent;
            Location = new Point(50, 112);
            Margin = new Padding(50, 3, 15, 15);
            MaximumSize = new Size(735, 0);
            MinimumSize = new Size(735, 91);
            Name = $"{message.SenderUserName}-panel";
            Size = new Size(735, 151);
            TabIndex = 1;
            
            Controls.Add(new ClientMessage(message.SenderUserName, message.Text));
            Controls.Add(new ClientName(message.SenderUserName, message.Sender().Name));
            Controls.Add(new ClientPicture(message.SenderUserName));
        }
    }
}
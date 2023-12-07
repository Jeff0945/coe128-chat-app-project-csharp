using System.Drawing;
using System.Windows.Forms;
using Message = SelfLink.Models.Message;

namespace SelfLink.Components.SenderMessage
{
    public partial class SenderPanel : Panel
    {
        public SenderPanel(Message message)
        {
            AutoSize = true;
            BackColor = Color.Transparent;
            Location = new Point(15, 15);
            Margin = new Padding(15, 15, 0, 3);
            MaximumSize = new Size(735, 0);
            MinimumSize = new Size(735, 91);
            Name = $"{message.SenderUserName}-panel";
            Size = new Size(735, 91);
            TabIndex = 0;
            
            Controls.Add(new SenderMessage(message.SenderUserName, message.Text));
            Controls.Add(new SenderName(message.SenderUserName, message.Sender().Name));
            Controls.Add(new SenderPicture(message.SenderUserName));
        }
    }
}
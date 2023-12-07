using System.Drawing;
using System.Windows.Forms;
using SelfLink.Constants;

namespace SelfLink.Components.SenderMessage
{
    public sealed partial class SenderMessage : Label
    {
        public SenderMessage(string userName, string message)
        {
            AutoSize = true;
            BackColor = Color.FromArgb(68, 60, 112);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(228, 236, 242);
            Location = new Point(56, 38);
            Margin = new Padding(3, 0, 0, 15);
            MaximumSize = new Size(675, 0);
            Name = $"{userName}-message";
            Padding = new Padding(9);
            Size = new Size(135, 38);
            TabIndex = 4;
            Text = message;
            TextAlign = ContentAlignment.MiddleLeft;
        }
    }
}
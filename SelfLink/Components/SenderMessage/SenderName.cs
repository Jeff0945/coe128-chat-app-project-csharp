using System.Drawing;
using System.Windows.Forms;

namespace SelfLink.Components.SenderMessage
{
    public sealed partial class SenderName : Label
    {
        public SenderName(string userName, string name)
        {
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(228, 236, 242);
            Location = new Point(56, 3);
            Margin = new Padding(3, 0, 0, 0);
            MinimumSize = new Size(0, 9);
            Name = $"{userName}-name";
            Size = new Size(675, 32);
            TabIndex = 3;
            Text = name;
            TextAlign = ContentAlignment.MiddleLeft;
        }
    }
}
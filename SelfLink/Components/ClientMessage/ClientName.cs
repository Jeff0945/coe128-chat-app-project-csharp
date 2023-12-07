using System.Drawing;
using System.Windows.Forms;

namespace SelfLink.Components.ClientMessage
{
    public sealed partial class ClientName : Label
    {
        public ClientName(string userName, string name)
        {
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(228, 236, 242);
            Location = new Point(3, 3);
            Margin = new Padding(3, 0, 0, 0);
            MinimumSize = new Size(675, 9);
            Name = $"{userName}-name";
            Size = new Size(675, 32);
            TabIndex = 3;
            Text = name;
            TextAlign = ContentAlignment.MiddleRight;
        }
    }
}
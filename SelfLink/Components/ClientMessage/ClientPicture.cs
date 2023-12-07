using System.Drawing;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace SelfLink.Components.ClientMessage
{
    public partial class ClientPicture : IconPictureBox
    {
        public ClientPicture(string userName)
        {
            BackColor = Color.Transparent;
            ForeColor = Color.FromArgb(228, 236, 242);
            IconChar = IconChar.User;
            IconColor = Color.FromArgb(228, 236, 242);
            IconFont = IconFont.Auto;
            IconSize = 38;
            Location = new Point(696, 38);
            Margin = new Padding(0, 15, 15, 15);
            Name = $"{userName}-picture";
            Size = new Size(38, 38);
            SizeMode = PictureBoxSizeMode.CenterImage;
            TabIndex = 2;
            TabStop = false;
        }
    }
}
using System.Drawing;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace SelfLink.Components.SenderMessage
{
    public partial class SenderPicture : IconPictureBox
    {
        public SenderPicture(string userName)
        {
            BackColor = Color.Transparent;
            ForeColor = Color.FromArgb(228, 236, 242);
            IconChar = IconChar.User;
            IconColor = Color.FromArgb(228, 236, 242);
            IconFont = IconFont.Auto;
            IconSize = 38;
            Location = new Point(0, 38);
            Margin = new Padding(0, 15, 15, 15);
            Name = $"{userName}-picture";
            Size = new Size(38, 38);
            SizeMode = PictureBoxSizeMode.CenterImage;
            TabIndex = 2;
            TabStop = false;
        }
    }
}
using System.Drawing;
using System.Windows.Forms;

namespace SelfLink.Components.UsersList
{
    public sealed partial class UserName : Label
    {
        public UserName(string name)
        {
            InitializeComponent();

            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(228, 236, 242);
            Location = new Point(56, 16);
            Name = "userListName";
            Size = new Size(158, 32);
            Text = name;
            TextAlign = ContentAlignment.MiddleLeft;
        }
    }
}
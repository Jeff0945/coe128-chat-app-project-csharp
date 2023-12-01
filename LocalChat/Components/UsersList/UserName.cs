using System.Drawing;
using System.Windows.Forms;

namespace LocalChat.Components.UsersList
{
    public sealed partial class UserName : Label
    {
        public UserName(string name)
        {
            InitializeComponent();

            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(228, 236, 242);
            Location = new Point(44, 16);
            Margin = new Padding(3, 0, 21, 0);
            Name = "userListName";
            Size = new Size(152, 32);
            TabIndex = 3;
            Text = name;
            TextAlign = ContentAlignment.MiddleLeft;
        }
    }
}
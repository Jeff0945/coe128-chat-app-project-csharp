﻿using System.Drawing;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace SelfLink.Components.UsersList
{
    public sealed partial class UserPicture : IconPictureBox
    {
        public UserPicture()
        {
            InitializeComponent();
            
            IconChar = IconChar.User;
            IconColor = Color.FromArgb(228, 236, 242);
            IconFont = IconFont.Auto;
            Location = new Point(18, 16);
            Name = "userListPicture";
            Size = new Size(32, 32);
            SizeMode = PictureBoxSizeMode.CenterImage;
            TabStop = false;
        }
    }
}
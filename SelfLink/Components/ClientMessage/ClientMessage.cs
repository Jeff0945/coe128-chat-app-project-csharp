using System;
using System.Drawing;
using System.Windows.Forms;
using SelfLink.Constants;

namespace SelfLink.Components.ClientMessage
{
    public sealed partial class ClientMessage : Label
    {
        public ClientMessage(string userName, string message)
        {
            AutoSize = true;
            BackColor = Color.FromArgb(68, 60, 112);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(228, 236, 242);
            Margin = new Padding(3, 0, 0, 15);
            MaximumSize = new Size(675, 0);
            Name = $"{userName}-message";
            Padding = new Padding(9);
            Size = new Size(675, 98);
            TabIndex = 4;
            Text = message;
            TextAlign = ContentAlignment.MiddleLeft;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            
            int xLoc = 3 + SizeConstants.ClientMessage - Width;
            Location = new Point(xLoc, 38);
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            
            Invalidate();
        }
    }
}
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using LocalChat.Models;

namespace LocalChat.Components.UsersList
{
    public partial class UserPanel : Panel
    {
        public bool IsSelected { get; set; }
        
        public UserPanel(User user)
        {
            InitializeComponent();

            Name = user.UserName;
            Controls.Add(new UserName(user.Name));
            
            SetProperties();
        }

        public UserPanel(string name)
        {
            InitializeComponent();

            Name = name;
            Controls.Add(new UserName(name));
            
            SetProperties();
        }

        private void SetProperties()
        {
            Location = new Point(15, 0);
            Margin = new Padding(15, 0, 15, 0);
            Size = new Size(202, 64);
            TabIndex = 0;
            
            Controls.Add(new UserPicture());

            Click += OnClick;
            foreach (Control control in Controls)
            {
                control.Click += OnClick;
            }
        }

        private void OnClick(object sender, EventArgs e)
        {
            UnselectSelected();

            if (SelectPanel())
            {
                MessageBox.Show(Name);
            }
        }

        private bool SelectPanel()
        {
            if (IsSelected)
            {
                return false;
            }
            
            IsSelected = true;
            return true;
        }

        private void UnselectSelected()
        {
            Parent.Controls
                .OfType<UserPanel>()
                .Where(panel => panel.IsSelected && panel.Name != Name)
                .ToList()
                .ForEach(panel => panel.IsSelected = false);
        }
    }
}
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SelfLink.Constants;
using SelfLink.Database;
using SelfLink.Models;
using SelfLink.Services;

namespace SelfLink.Components.UsersList
{
    public partial class UserPanel : Panel
    {
        private bool IsSelected { get; set; }
        
        public UserPanel(User user)
        {
            InitializeComponent();

            Name = user.UserName;
            Controls.Add(new UserName(user.Name));
            
            SetProperties();
            SetEvents();
        }

        #region Private functions

        private User GetRecipient()
        {
            return Instance.Database.Users()
                .FirstOrDefault(user => user.UserName == Name);
        }

        private void SetProperties()
        {
            Location = new Point(0, 0);
            Margin = new Padding(0);
            Padding = new Padding(15, 0, 15, 0);
            Size = new Size(232, 64);
            
            Controls.Add(new UserPicture());
        }

        private void SetEvents()
        {
            Click += HandleUserSelection;
            MouseEnter += OnMouseEnter;
            MouseLeave += OnMouseLeave;
            
            foreach (Control control in Controls)
            {
                control.Click += HandleUserSelection;
                control.MouseEnter += OnMouseEnter;
                control.MouseLeave += OnMouseLeave;
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

        private void Unselect()
        {
            IsSelected = false;
            GetRecipient().IsReceiver = false;
            BackColor = Color.Transparent;
        }

        private void UnselectSelected()
        {
            var selected = Parent.Controls
                .OfType<UserPanel>()
                .Where(panel => panel.IsSelected && panel.Name != Name)
                .ToList();
            
            if (selected.Count == 0)
            {
                return;
            }
            
            selected.ForEach(item => item.Unselect());
        }
        
        #endregion

        #region Event handlers

        private void OnMouseEnter(object sender, EventArgs e)
        {
            if (IsSelected)
            {
                return;
            }
            
            BackColor = Color.FromArgb(49, 49, 56);
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            if (IsSelected)
            {
                return;
            }

            BackColor = Color.Transparent;
        }

        private void HandleUserSelection(object sender, EventArgs e)
        {
            UnselectSelected();

            if (!SelectPanel())
            {
                return;
            }
            
            GetRecipient().IsReceiver = true;
            BackColor = AppColors.Secondary;
            Gui.DisplayMessages(GetRecipient());
        }

        #endregion
    }
}
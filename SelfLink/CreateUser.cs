using System;
using System.Windows.Forms;
using SelfLink.Models;

namespace SelfLink
{
    public partial class CreateUser : Form
    {
        public CreateUser()
        {
            InitializeComponent();

            confirmButton.Click += Confirmed;
            exitButton.Click += Exit;
        }

        private void Confirmed(object sender, EventArgs e)
        {
            var userNameId = userIdentifier.Text;
            var name = userName.Text;

            if (userNameId.Length == 0 || name.Length == 0)
            {
                MessageBox.Show(@"Username and name field should not be empty.");
                return;
            }
            
            new User(userNameId, name, true);
            
            DialogResult = DialogResult.OK;
        }

        private void Exit(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
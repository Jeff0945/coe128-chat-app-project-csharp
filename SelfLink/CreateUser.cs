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
            new User(userIdentifier.Text, userName.Text, true);
            
            DialogResult = DialogResult.OK;
        }

        private void Exit(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
using System.Windows.Forms;
using SelfLink.Services;

namespace SelfLink
{
    public partial class Chats : Form
    {
        public Chats()
        {
            InitializeComponent();
            Instance.Gui = this;
            
            Gui.InitializeAllChat();
        }
    }
}
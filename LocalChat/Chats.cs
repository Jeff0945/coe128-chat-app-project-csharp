using System.Windows.Forms;
using LocalChat.Services;

namespace LocalChat
{
    public partial class Chats : Form
    {
        public Chats()
        {
            InitializeComponent();
            Instance.Gui = this;
        }
    }
}
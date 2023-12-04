using System.Windows.Forms;
using SelfLink.Services;

namespace SelfLink
{
    public partial class Interface : Form
    {
        public Interface()
        {
            InitializeComponent();
            Instance.Gui = this;
            
            Gui.InitializeAllChat();
        }
    }
}
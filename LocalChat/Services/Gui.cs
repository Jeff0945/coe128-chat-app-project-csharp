using System.Linq;
using LocalChat.Components.UsersList;

namespace LocalChat.Services
{
    public static class Gui
    {
        public static void AppendUser(UserPanel item)
        {
            Instance.Gui.recipientsList.Controls.Add(item);
        }
    }
}
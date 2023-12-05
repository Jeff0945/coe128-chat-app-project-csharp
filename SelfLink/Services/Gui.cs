using SelfLink.Components.UsersList;

namespace SelfLink.Services
{
    public static class Gui
    {
        public static void AppendUser(UserPanel item)
        {
            Instance.Gui.recipientsList.Controls.Add(item);
        }
    }
}
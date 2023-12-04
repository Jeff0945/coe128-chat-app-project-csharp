using System.Linq;
using SelfLink.Components.UsersList;

namespace SelfLink.Services
{
    public static class Gui
    {
        public static void AppendUser(UserPanel item)
        {
            Instance.Gui.recipientsList.Controls.Add(item);
        }

        public static void InitializeAllChat()
        {
            AppendUser(new UserPanel("All"));

            Instance.Gui.recipientsList.Controls.OfType<UserPanel>()
                .FirstOrDefault()?.PerformClick();
        }
    }
}
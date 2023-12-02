using System.Linq;

namespace LocalChat.Services
{
    public static class GuiFunctions
    {
        public static void ReloadUsers()
        {
            Data.Instance.recipientsList.Controls.Clear();

            Data.Database.Users()
                .ToList()
                .ForEach(user => user.PlacePanel());
        }
    }
}
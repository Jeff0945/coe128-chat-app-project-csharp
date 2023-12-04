using SelfLink.Models;

namespace SelfLink.Services
{
    public static class Instance
    {
        public static readonly Collection Database = new Collection();
        public static User CurrentUser = null;
        public static User SelectedRecipient = null;
            
        internal static Chats Gui = null;
    }
}
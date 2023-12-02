using LocalChat.Models;

namespace LocalChat.Services
{
    public static class Instance
    {
        public static readonly Collection Database = new Collection();
        public static Chats Gui = null;
        public static User CurrentUser = null;
    }
}
using LocalChat.Models;

namespace LocalChat.Services
{
    public static class Data
    {
        public static readonly Collection Database = new Collection();
        public static Chats Instance = null;
        public static User CurrentUser = null;
    }
}
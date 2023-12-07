using SelfLink.Services;

namespace SelfLink.Database
{
    public static class Instance
    {
        public static Interface Gui = null;
        public static readonly Collection Database = new Collection();
    }
}
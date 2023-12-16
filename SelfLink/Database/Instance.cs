using System.Net.Sockets;
using SelfLink.Services;

namespace SelfLink.Database
{
    public static class Instance
    {
        internal static Interface Gui = null;
        internal static TcpClient ServerConnection = null;
        internal static readonly Collection Database = new Collection();

        public static bool IsClient()
        {
            return ServerConnection != null;
        }
    }
}
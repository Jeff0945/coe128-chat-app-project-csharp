using System.Net.Sockets;
using SelfLink.Services;

namespace SelfLink.Database
{
    public static class Instance
    {
        internal static Interface Gui = null;
        internal static TcpClient Server = null;
        internal static readonly Collection Database = new Collection();

        public static bool IsConnectedToServer()
        {
            return Server != null;
        }
    }
}
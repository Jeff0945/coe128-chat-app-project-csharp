using System;
using System.Net.Sockets;
using System.Threading.Tasks;
using SelfLink.Database;

namespace SelfLink.Connection
{
    public static class Client
    {
        private const string IpAddress = "127.0.0.1";
        private const int Port = 57388;
        
        public static async Task<bool> TryConnect()
        {
            try
            {
                var server = new TcpClient();
                await server.ConnectAsync(IpAddress, Port);

                Instance.Server = server;
                
                Communication.StartMessageListener(server);
                SendClientInfo(server);
                
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private static void SendClientInfo(TcpClient client)
        {
            Communication.SendData(Instance.Database.Client(), client);
        }
    }
}
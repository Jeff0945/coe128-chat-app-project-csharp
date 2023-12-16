using System.Net;
using System.Net.Sockets;
using System.Threading;
using SelfLink.Database;

namespace SelfLink.Connection
{
    public static class Server
    {
        private const int Port = 57388;

        public static async void ConnectOrStart()
        {
            if (!await Client.TryConnect())
            {
                ServerStart();
            }
        }

        private static void ServerStart()
        {
            var localEndPoint = new IPEndPoint(IPAddress.Any, Port);

            var server = new TcpListener(localEndPoint);
            server.Start();

            var connectionListener = new Thread(ListenForConnections)
            {
                IsBackground = true
            };
            connectionListener.Start(server);

            Instance.Gui.Text += @" (Server)";
        }

        private static void ListenForConnections(object obj)
        {
            var server = (TcpListener)obj;
            
            while (true)
            {
                var client = server.AcceptTcpClient();
                
                Communication.StartMessageListener(client);
                
                SynchronizeUsers(client);
                SynchronizeMessages(client);
            }
        }

        private static void SynchronizeUsers(TcpClient client)
        {
            foreach (var user in Instance.Database.Users())
            {
                Communication.SendData(user, client);
            }
        }

        public static void SynchronizeToOtherUsers()
        {
            var database = Instance.Database;
            
            foreach (var connected in Instance.Database.ConnectedUsers())
            {
                foreach (var user in database.Users())
                {
                    Communication.SendData(user, connected.Connection);
                }
            }
        }

        private static void SynchronizeMessages(TcpClient client)
        {
            foreach (var message in Instance.Database.Messages())
            {
                Communication.SendData(message, client);
            }
        }
    }
}
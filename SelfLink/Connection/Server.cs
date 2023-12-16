using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using SelfLink.Database;
using SelfLink.Models;
using SelfLink.Services;

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

            SetWindowTitleStatus();
        }

        private static void SetWindowTitleStatus()
        {
            if (Instance.Gui.InvokeRequired)
            {
                Instance.Gui.Invoke((MethodInvoker)delegate
                {
                    Instance.Gui.Text += @" (Server)";
                });
            }
            else
            {
                Instance.Gui.Text += @" (Server)";
            }
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
                Communication.TrySendData(user, client);
            }
        }

        public static void SynchronizeToOtherUsers(User newUser)
        {
            Collection database = Instance.Database;
            IEnumerable<User> connectedUsers = database.ConnectedUsers()
                .Where(item => item.UserName != newUser.UserName)
                .ToList();
            
            foreach (User connected in connectedUsers)
            {
                foreach (var user in database.Users())
                {
                    Communication.TrySendData(user, connected.Connection);
                }
            }
        }

        private static void SynchronizeMessages(TcpClient client)
        {
            foreach (var message in Instance.Database.Messages())
            {
                Communication.TrySendData(message, client);
            }
        }
    }
}
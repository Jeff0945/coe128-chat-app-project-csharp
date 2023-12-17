using System;
using System.Diagnostics;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;
using SelfLink.Constants;
using SelfLink.Database;

namespace SelfLink.Connection
{
    public static class Client
    {
        public static async Task<bool> TryConnect()
        {
            try
            {
                var server = new TcpClient();
                await server.ConnectAsync(SocketConfig.IpAddress, SocketConfig.Port);

                Instance.ServerConnection = server;
                
                Communication.StartMessageListener(server);
                SendClientInfo(server);
                
                SetWindowTitleStatus();
                
                return true;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                return false;
            }
        }

        private static void SetWindowTitleStatus()
        {
            if (Instance.Gui.InvokeRequired)
            {
                Instance.Gui.Invoke((MethodInvoker)delegate
                {
                    Instance.Gui.Text += @" (Client)";
                });
            }
            else
            {
                Instance.Gui.Text += @" (Client)";
            }
        }

        private static void SendClientInfo(TcpClient client)
        {
            Communication.TrySendData(Instance.Database.Client(), client);
        }
    }
}
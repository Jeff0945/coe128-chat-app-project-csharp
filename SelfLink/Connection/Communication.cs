using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using Object = SelfLink.Services.Object;

namespace SelfLink.Connection
{
    public static class Communication
    {
        private const int BufferSize = 1024;
        private static readonly byte[] Buffer = new byte[BufferSize];
        
        public static void SendData(object data, TcpClient connection)
        {
            NetworkStream stream = connection.GetStream();
            byte[] toSend = Object.SerializeToBytes(data);
            
            stream.Write(toSend, 0, toSend.Length);
        }

        public static void StartMessageListener(TcpClient client)
        {
            var messageListener = new Thread(ListenForMessages)
            {
                IsBackground = true
            };
            messageListener.Start(client);
        }

        private static void ListenForMessages(object obj)
        {
            var connection = (TcpClient)obj;
            NetworkStream stream = connection.GetStream();

            AsyncCallback callback = null;
            callback = asyncResult =>
            {
                try
                {
                    HandleStreamRead(connection, asyncResult, callback);
                }
                catch (Exception)
                {
                    // ignore
                }
            };

            stream.BeginRead(Buffer, 0, Buffer.Length, callback, null);
        }

        private static void HandleStreamRead(TcpClient connection, IAsyncResult asyncResult, AsyncCallback callback)
        {
            NetworkStream stream = connection.GetStream();
            int bytesRead = stream.EndRead(asyncResult);

            if (bytesRead <= 0)
            {
                return;
            }
                    
            HandleData(connection, Buffer, bytesRead);
            stream.BeginRead(Buffer, 0, Buffer.Length, callback, null);
        }

        private static void HandleData(TcpClient connection, byte[] buffer, int bytesRead)
        {
            string jsonData = Encoding.UTF8.GetString(buffer, 0, bytesRead);
            
            Object.Deserialize(jsonData, connection);
        }
    }
}
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SelfLink.Connection;
using SelfLink.Database;
using SelfLink.Models;
using Message = SelfLink.Models.Message;

namespace SelfLink.Services
{
    public static class Object
    {
        public static byte[] SerializeToBytes(object obj)
        {
            string json = JsonConvert.SerializeObject(obj);
            return Encoding.UTF8.GetBytes(json);
        }

        public static void Deserialize(string json, TcpClient connection = null)
        {
            List<string> jsonData = Regex.Matches(json, @"{[^{}]*}")
                .Cast<Match>()
                .Select(match => match.Value)
                .ToList();

            foreach (string data in jsonData)
            {
                DeserializeToObject(data, connection);
            }
        }

        private static void DeserializeToObject(string json, TcpClient connection = null)
        {
            IfMessage(json);
            IfUser(json, connection);
        }

        private static void IfMessage(string json)
        {
            JObject jsonObj = JObject.Parse(json);

            if (jsonObj["SenderUserName"]?.Value<string>() == null)
            {
                return;
            }
            
            var messageJson = JsonConvert.DeserializeObject<MessageJson>(json);
                
            StoreAndPassMessage(messageJson);
        }

        private static void IfUser(string json, TcpClient connection)
        {
            JObject jsonObj = JObject.Parse(json);

            if (!Validation.IsUserData(jsonObj))
            {
                return;
            }
            
            var userJson = JsonConvert.DeserializeObject<UserJson>(json);

            if (Validation.UserExists(userJson))
            {
                return;
            }

            var newUser = new User(userJson, connection);
            
            Server.SynchronizeToOtherUsers(newUser);
        }

        private static void StoreAndPassMessage(MessageJson messageJson)
        {
            var message = new Message(messageJson);
            
            if (messageJson.ReceiverUserName == Instance.Database.Client().UserName)
            {
                return;
            }

            if (Instance.IsConnectedToServer())
            {
                return;
            }
            
            TryPassMessage(message);
        }

        private static void TryPassMessage(Message message)
        {
            var user = Instance.Database.Users()
                .FirstOrDefault(userData => userData.UserName == message.ReceiverUserName);

            if (user == null)
            {
                return;
            }
            
            Communication.SendData(message, user.Connection);
        }
    }
}
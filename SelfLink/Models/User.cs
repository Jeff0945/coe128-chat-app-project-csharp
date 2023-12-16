using System.Net.Sockets;
using Newtonsoft.Json;
using SelfLink.Components.UsersList;
using SelfLink.Database;
using SelfLink.Interfaces;
using SelfLink.Services;

namespace SelfLink.Models
{
    public class User : ICollection
    {
        public string UserName { get; }
        public string Name { get; }
        [JsonIgnore]
        public bool IsClient { get; }
        [JsonIgnore]
        public bool IsReceiver { get; set; }
        [JsonIgnore]
        public UserPanel Component { get; }
        [JsonIgnore]
        public TcpClient Connection { get; }

        public User(UserJson json, TcpClient connection)
        {
            if (!Validation.ValidateUserInfo(this, json.UserName))
            {
                return;
            }
            
            UserName = json.UserName;
            Name = json.Name;
            Connection = connection;
            Component = new UserPanel(this);

            Instance.Database.Add(this);
        }

        public User(string userName, string name, bool isClient = false)
        {
            if (!Validation.ValidateUserInfo(this, userName, isClient))
            {
                return;
            }
            
            UserName = userName;
            Name = name;
            IsClient = isClient;

            if (!IsClient)
            {
                Component = new UserPanel(this);
            }

            Instance.Database.Add(this);
        }
    }
}
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using SelfLink.Database;
using SelfLink.Models;

namespace SelfLink.Services
{
    public static class Validation
    {
        public static bool UserExists(UserJson userJson)
        {
            return Instance.Database.Users()
                .Any(user => user.UserName == userJson.UserName);
        }
        
        public static bool IsUserData(JObject jsonObj)
        {
            var jsonUserName = jsonObj["UserName"]?.Value<string>();

            return jsonUserName != null && jsonUserName != Instance.Database.Client().UserName;
        }
        
        public static bool ValidateUserInfo(User userObj, string userName, bool isClient = false)
        {
            List<User> users = Instance.Database.Users().ToList();
            bool exists = users.Any(user => user.UserName == userName && user != userObj);
            bool hasClient = users.Any(user => user.IsClient);

            if (exists)
            {
                MessageBox.Show($@"User name ""{userName}"" already exists.");
                return false;
            }

            if (isClient && hasClient)
            {
                MessageBox.Show(@"A sender already exists");
                return false;
            }
            
            return true;
        }

        public static bool ValidateMessageInfo(string userName)
        {
            bool exists = Instance.Database
                .Users()
                .Any(user => user.UserName == userName);

            if (!exists)
            {
                MessageBox.Show($@"User ""{userName}"" does not exist.");
            }

            return exists;
        }
    }
}
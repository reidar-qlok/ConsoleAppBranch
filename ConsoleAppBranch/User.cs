using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBranch
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string UserRole { get; set; }

        public User(string username, string password, string userRole)
        {
            Username = username;
            Password = password;
            UserRole = userRole;
        }
    }
}

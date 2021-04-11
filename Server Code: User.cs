using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_Managment_System_Server
{
    public class User
    {
        private string username;
        private string password;
        private List<Roles> role = new List<Roles>();

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public List<Roles> Role { get => role; }
    }
}

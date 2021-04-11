using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class User
    {
        private string username;
        private string password;
        private string email;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }
    }
    class Role
    {
        private string rolename;
        private string roletype;

        public string Rolename { get => rolename; set => rolename = value; }
        public string Roletype { get => roletype; set => roletype = value; }
    }
    class Goalz
    {
        private string goalname;

        public string Goalname { get => goalname; set => goalname = value; }
    }
    class ToDos
    {
        private string todoname;

        public string Todoname { get => todoname; set => todoname = value; }
    }
}

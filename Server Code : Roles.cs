using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_Managment_System_Server
{
    public class Roles
    {
        private string roleName;
        private string roleType;
        private List<Goal> goals = new List<Goal>();

        public string RoleName { get => roleName; set => roleName = value; }
        public string RoleType { get => roleType; set => roleType = value; }
        public List<Goal> Goals { get => goals; }
    }
}

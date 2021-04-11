using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Datalist//:InterfaceDB
    {
        
        public static List<User> users = new List<User>();
        public void Adduser(User user)
        {
           
            users.Add(user);
        }
        public static List<Role> Roles = new List<Role>();
        public void Addroles(Role role)
        {
            Roles.Add(role);
        }
        public static List<Goalz> goalzs = new List<Goalz>();
        public void AddGoal(Goalz goalz)
        {
            goalzs.Add(goalz);
        }
        public static List<ToDos> toDo = new List<ToDos>();
        public void AddToDo(ToDos toDos)
        {
            toDo.Add(toDos);
            
        }
       
        public int login(User user)
        {
            return -1;

        }
    }
}

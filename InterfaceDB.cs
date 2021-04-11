using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    interface InterfaceDB
    {
        void Adduser(User user);
        void Addroles(Role roles);
        void AddGoal(Goalz goalz);
        void AddToDo(ToDos toDos);
        int login(User u);
    }
}

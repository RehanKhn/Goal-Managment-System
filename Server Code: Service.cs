using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;




namespace Project_Managment_System_Server
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public void AddRole(int i,Roles role)
        {
            userdata.userList[i].Role.Add(role);
        }
        public List<Roles> getRolesList(int i)
        {
            if (i < userdata.userList.Count)
                return userdata.userList[i].Role;
            else
                return null;

        }
        public Roles getRoles(int i,int Rolename)
        {

            return userdata.userList[i].Role[Rolename];
        }
        public void Delete(int i,int ri)
        {
             userdata.userList[i].Role.RemoveAt(ri);
        }
        public void saveRole(int i,Roles roles,int index)
        {
            userdata.userList[i].Role[index].RoleName = roles.RoleName;
            userdata.userList[i].Role[index].RoleType = roles.RoleType;
        }
        public int Adduser(User user)
        {
            userdata.userList.Add(user);
            return userdata.userList.FindIndex(obj => obj.Username == user.Username);
        }
        public List<User> GetUsers()
        {
            return userdata.userList;

        }
        public int LogInUser(User po)
        {
            foreach (User p in userdata.userList)
            {
                if (p.Username == po.Username && p.Password == po.Password)
                {
                    return userdata.userList.FindIndex(obj=> obj.Username==po.Username);
                }
            }
            return -1;
        }
        public User GetUser(int PostID)
        {
            return userdata.userList[PostID];
        }

        public Goal getgoal(int i,string r,int gi)
        {
            for (int ri = 0; ri < userdata.userList[i].Role.Count; ri++)
            {
                if (userdata.userList[i].Role[ri].RoleName == r)
                {
                    return userdata.userList[i].Role[ri].Goals[gi];
                }
            }
            return null;
        }

        public List<Goal> getGoalList(int i,string ri)
        {
            if (i < userdata.userList.Count)
            {
                for (int r = 0; r < userdata.userList[i].Role.Count; r++)
                {
                    if (ri == userdata.userList[i].Role[r].RoleName)
                    {
                        return userdata.userList[i].Role[r].Goals;
                    }
                }
            }
                return null;
            
        }

        public void addGoal(int i,string r,Goal goal)
        {
            for (int ri = 0; ri < userdata.userList[i].Role.Count; ri++)
            {
                if (userdata.userList[i].Role[ri].RoleName == r)
                {
                    userdata.userList[i].Role[ri].Goals.Add(goal);
                }
            }
        }

        public void delGoal(int i,string r,int gi)
        {
            for(int ri=0;ri< userdata.userList[i].Role.Count;ri++)
            {
                if (userdata.userList[i].Role[ri].RoleName == r)
                {
                    userdata.userList[i].Role[ri].Goals.RemoveAt(gi);
                }
            }
            
        }

        public void saveGoal(int i,string r,Goal goal, int gi)
        {
            for (int ri = 0; ri < userdata.userList[i].Role.Count; ri++)
            {
                if (userdata.userList[i].Role[ri].RoleName == r)
                {
                    userdata.userList[i].Role[ri].Goals[gi].Golname=goal.Golname;
                }
            }
        }

        public void AddToDo(int i,string r,string g,ToDo todo)
        {

            for (int ri = 0; ri < userdata.userList[i].Role.Count; ri++)
            {
                if (userdata.userList[i].Role[ri].RoleName == r)
                {

                    for (int gi = 0; gi < userdata.userList[i].Role[ri].Goals.Count; gi++)
                    {
                        if (userdata.userList[i].Role[ri].Goals[gi].Golname == g)
                        {
                            userdata.userList[i].Role[ri].Goals[gi].Todos.Add(todo);
                            
                        }
                    }
                    
                }
            }
            
        }
        public List<ToDo> getToDoList(int i,string r,string g)
        {
            for (int ri = 0; ri < userdata.userList[i].Role.Count; ri++)
            {
                if (userdata.userList[i].Role[ri].RoleName == r)
                {

                    for (int gi = 0; gi < userdata.userList[i].Role[ri].Goals.Count; gi++)
                    {
                        if (userdata.userList[i].Role[ri].Goals[gi].Golname == g)
                        {
                            return userdata.userList[i].Role[ri].Goals[gi].Todos;
                        }
                    }

                }
            }
            return null;
        }
        public ToDo getToDo(int i,string r,string g,int ti)
        {
            for (int ri = 0; ri < userdata.userList[i].Role.Count; ri++)
            {
                if (userdata.userList[i].Role[ri].RoleName == r)
                {

                    for (int gi = 0; gi < userdata.userList[i].Role[ri].Goals.Count; gi++)
                    {
                        if (userdata.userList[i].Role[ri].Goals[gi].Golname == g)
                        {
                            return userdata.userList[i].Role[ri].Goals[gi].Todos[ti];
                        }
                    }

                }
            }
            return null;
        }

        public void DelToDo(int i,string r,string g,int ti)
        {
            for (int ri = 0; ri < userdata.userList[i].Role.Count; ri++)
            {
                if (userdata.userList[i].Role[ri].RoleName == r)
                {

                    for (int gi = 0; gi < userdata.userList[i].Role[ri].Goals.Count; gi++)
                    {
                        if (userdata.userList[i].Role[ri].Goals[gi].Golname == g)
                        {
                            userdata.userList[i].Role[ri].Goals[gi].Todos.RemoveAt(ti);
                        }
                    }

                }
            }
        }
        public void editToDo(int i,string r,string g,ToDo todo, int ti)
        {
            for (int ri = 0; ri < userdata.userList[i].Role.Count; ri++)
            {
                if (userdata.userList[i].Role[ri].RoleName == r)
                {

                    for (int gi = 0; gi < userdata.userList[i].Role[ri].Goals.Count; gi++)
                    {
                        if (userdata.userList[i].Role[ri].Goals[gi].Golname == g)
                        {
                            userdata.userList[i].Role[ri].Goals[gi].Todos[ti].Todos=todo.Todos;
                            userdata.userList[i].Role[ri].Goals[gi].Todos[ti].Date = todo.Date;
                        }
                    }

                }
            }

        }
  /*      public void saveToDo(ToDo todo, int save)
        {
           Datalist3.datastore.RemoveAt(save);
            Datalist2.datastore.Insert(save, todo);
        }
*/
          public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}

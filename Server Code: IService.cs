using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Project_Managment_System_Server
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here

        [OperationContract]
        Roles getRoles(int i,int Rolename);
        [OperationContract]
        List<Roles> getRolesList(int i);
        [OperationContract]
        void AddRole(int i,Roles role);
        [OperationContract]
        void Delete(int i,int ri);
        [OperationContract]
        void saveRole(int i,Roles roles, int index);
        [OperationContract]
        int Adduser(User user);
        [OperationContract]
        User GetUser(int PostID);
        [OperationContract]
        List<User> GetUsers();
        [OperationContract]
        int LogInUser(User po);
        [OperationContract]
        Goal getgoal(int i,string ri,int goals);
        [OperationContract]
        List<Goal> getGoalList(int i,string ri);
        [OperationContract]
        void addGoal(int i,string ri,Goal goal);
        [OperationContract]
        void delGoal(int i,string ri,int gi);
        [OperationContract]
        void saveGoal(int i,string ri,Goal goal, int gi);
        [OperationContract]
        ToDo getToDo(int i,string ri,string gi,int ti);
        [OperationContract]
        List<ToDo> getToDoList(int i,string ri,string gi);
        [OperationContract]
        void AddToDo(int i,string ri,string gi,ToDo todo);
        [OperationContract]
        void DelToDo(int i,string ri,string gi,int ti);
        [OperationContract]
        void editToDo(int i,string ri,string gi,ToDo todo, int ti);
    //    [OperationContract]
    //    void saveToDo(ToDo todo, int save);




    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}

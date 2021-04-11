using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Project
{
    class Database:InterfaceDB
    {
        int a; int b;
        public void Adduser(User user)
        {
            string setting = "Data Source=DESKTOP-1LEO518\\SQLEXPRESS;Initial Catalog=GMS;Integrated Security=True";
            SqlConnection connection = new SqlConnection(setting);
            string query = "Insert into Table_1_User(Username,Password,Email) values ('" + user.Username + " ','" + user.Password + "','" + user.Email + "' )";
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
        }
        public void Addroles(Role roles)
        {
            string setting = "Data Source=DESKTOP-1LEO518\\SQLEXPRESS;Initial Catalog=GMS;Integrated Security=True";
            SqlConnection connection = new SqlConnection(setting);
            string query = "Insert into Table_2_Role(RollName,RollType) values ('" + roles.Rolename + " ','" + roles.Roletype + "')";
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();

        }
        public void AddGoal(Goalz goals)
        {
            string setting = "Data Source=DESKTOP-1LEO518\\SQLEXPRESS;Initial Catalog=GMS;Integrated Security=True";
            SqlConnection connection = new SqlConnection(setting);
            string query = "Insert into Table_3_Goal(Goalname) values ('" + goals.Goalname + "')";
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();

        }
        public void AddToDo(ToDos toDos)
        {
            string setting = "Data Source=DESKTOP-1LEO518\\SQLEXPRESS;Initial Catalog=GMS;Integrated Security=True";
            SqlConnection connection = new SqlConnection(setting);
            string query = "Insert into Table_4_Todo(ToDoname) values ('" + toDos.Todoname + "')";
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();

        }
        public int login(User u)
        {
            string setting = "Data Source=DESKTOP-1LEO518\\SQLEXPRESS;Initial Catalog=GMS;Integrated Security=True";
            SqlConnection connection = new SqlConnection(setting);

            connection.Open();

            SqlCommand l = new SqlCommand("select Sr_user from Table_1_User where(Username=@Username and Password=@Password) ", connection);
            l.Parameters.AddWithValue("@Username", u.Username);
            l.Parameters.AddWithValue("@Password", u.Password);
            int i = -1;
            SqlDataReader reader = l.ExecuteReader();
            if(reader.Read())
            {
                i = (int)reader["Sr_user"];
                System.Windows.Forms.MessageBox.Show(i.ToString());
            }
            return i;
            
        }
    }
}

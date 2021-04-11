# Goal-Management-System-in-C#

 
Contents

Contents	1
1.	Analysis and Requirement Specification	2
1.1	Vision of Project	2
1.2	Scope of Project	2
1.3	Actor of the system	3
1.4	Functional and Non Functional Requirement	3
1.5        Use Case Diagram	4
1.6	Detail Use Cases	5

2	Design and Modeling of the System	6
StoryBoarding	6
2.1   High Level User Story	6
2.2 Low level User Story	7
2.3 User Stories	8















1.	 Analysis and Requirement Specification

1.1	 Vision of Project

Our Vision is to design and develop the most innovative software that will manage client goals, deliver quality services, establishes a competitive environment and enhances consistency, thus providing a stable interference to the users of the software.

                                    
1.2	Scope of Project


This project will consist of creating an innovative application based upon the goal management system. The project will be completed by June, 2019. Modules of the application will include to enter goals, add specific tasks with time period, will see task achievements & summaries and have an admin panel & Ads section.


        

1.3	Actor of the system
	Primary Actor:
Primary actor of the project will be Client/User.
	Secondary Actor:
Secondary actor will be the Advertisement agencies.
	Tertiary Actor:
Tertiary actor will be Companies.






1.4	Functional and Non Functional Requirement


Functional Requirements:
User requirements
Adding Data
User may add data in the inventory with the name, number, Id, images, description of the jobs to be done.
Removing data
User may remove data from the database along with all the information provided about that data.
Replace data
User may replace data from the database along with all the information provided about that data.
View Data
User must view their feed data he/she entered.
Check State of data
User can check current state of the data he made.
Business requirements
  Feedback
User can give about the software.

Business rules (constraints)
	Customer will have the basic knowledge of using the browser.
	Internet Connection is important for all transactions.
	Software will be running properly on web server and database is connected.






Non Functional Requirements:
Security
The system must be secure like the client’s data must be confidential.
Accessibility
System must be accessible 24*7.
Reliability
System must be reliable under specific conditions.
Maintainability
System must be able to adapt to changes either they are to make changes or to remove bugs.
Use ability
The system interface must be user friendly.
Integrity
The system should be able to protect transactions.
Manageability
The system must be developed in a way that it can easily reused & deployed.
Efficiency:
The system must be efficient.
Performance:
The system should show the proper performance according to the client requirement.









1.5 Use Case Diagram






	





















1.6	Detail Use Cases


Use Case ID	Emil/Gmail/Facebook ID/Phone number/ CNIC
Use Case Name	Name of the goal you want to registered
Actor		Primary: Client
	Secondary: Ads publisher
	Tertiary: Companies
Goal	Design a software that can manage user goal or project
Trigger	When user enter his/her goal with specific time period to be accomplished
Pre-Condition		User must have account
	Software must be working properly
Post-Condition		User must entered his/her goals
	User must monitored his/her goal progress
Basic Flow	1.	If you have account Login otherwise Signup
2.	User select his/her roles
3.	Click on registered button
4.	Add Goals with respect to selected roles
5.	Start monitoring entered goals
6.	If goal is accomplished remove it from the list
7.	If goal being delayed or unattended send a reminder message to the user
8.	Allow Ads publisher to post their ads to earn money
9.	Companies are also allowed to be a potential customer
10.	If all the tasks have been completed send a “Target Achieved” message to the user 

Alternative Flow	1a. Page is not redirected to login page
1b. Email/password is incorrect
2a. Information provided is incorrect
3a. Confirmation email isn’t received
8a. Ads are spam
9a. Company violates the software rights
Exception		Server overloaded exception can be handled by automatically sign-out function
	External user/client problem
	Data input problem
Qualities	Security, Accessibility, Reliability, Maintainability, Usability, Integrity, Manageability, Dependency, Efficiency 







2	Design and Modeling of the System

Story Boarding

2.1   High Level User Story

Client:
	As a user I want to register/sign up myself.
	As a user, I want to login so that I can use my account.
	As a user, I want to add my vision, my roles and task completion time, so that I can manage my goals.
	As a user I should be able to add my username, phone number, email, gender, age, password, so that I can use the software.
	As a user, I should be able to remove, improve or change my roles or tasks, so that I can manage properly. 
	As a user, I want to be able to see the summary of the task.
	As a user, I want to be able to feedback, about the software.
	As a user, I want to be able to add my reminder, so that I should be able to complete my task.
Add agencies:
	As an ad agency, I want to be able to add our product adds so that we can earn from it.
	As an ad agency, I want to be able to see the response.   

Companies:
	As the companies, we want to do business with the software.
	As the companies, we want to manage our employee’s timetables.


2.2 Low level User Story

 
 
 
 
 
 
 
 
 
 


Code:

Database.cs
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

Datalist.cs

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

InterfaceDB.cs

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

Program.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}

Student.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Student
    {
        private string userName;
        private string passWord;
        private string selectGender;
        private string selectAge;
        private string fileContent;
        private string name;
        private string surname;
        private string email;

        public string UserName { get => userName; set => userName = value; }
        public string PassWord { get => passWord; set => passWord = value; }
        public string SelectGender { get => selectGender; set => selectGender = value; }
        public string SelectAge { get => selectAge; set => selectAge = value; }
        public string FileContent { get => fileContent; set => fileContent = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Email { get => email; set => email = value; }

       
    }
    class datastore
    {
        public static List<Student> data = new List<Student>();
    }
}

User.cs

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


Editformcs.cs

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Editformcs : Form
    {
        private ServiceReference1.Roles edit = new ServiceReference1.Roles();
        private ServiceReference1.Service1Client server = new ServiceReference1.Service1Client();
        int index=-1;
        int ri = -1;
        public Editformcs()
        {
            InitializeComponent();
        }
        public Editformcs(int i,ServiceReference1.Roles roles,int a)
        {
            InitializeComponent();
            edit = roles;
            ri = a;
            index = i;
        }

        private void Editformcs_Load(object sender, EventArgs e)
        {
            textBox1.Text = edit.RoleName;
            comboBox1.Text = edit.RoleType;

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            edit.RoleName = textBox1.Text;
            edit.RoleType = comboBox1.Text;
           // server.Delete(index);
            server.saveRole(index,edit, ri);
            this.Close();
            Roles roles = new Roles(index);
            this.Hide();
            roles.Show();
        }
    }
}

EditGoal.cs

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class EditGoal : Form
    {
        private ServiceReference1.Goal editgoal = new ServiceReference1.Goal();
        private ServiceReference1.Service1Client server = new ServiceReference1.Service1Client();
        int index=-1;
        public EditGoal()
        {
            InitializeComponent();
        }
        int gi = -1;
        string rolename;
        public EditGoal( int a,string r,ServiceReference1.Goal goal,int g)
        {
            InitializeComponent();
            editgoal = goal;
            index = a;
            gi = g;
            rolename = r;
        }

        private void EditGoal_Load(object sender, EventArgs e)
        {
            textBox2.Text = editgoal.Golname;

        }

        private void btnSaveGoal_Click(object sender, EventArgs e)
        {
            editgoal.Golname = textBox2.Text;
            
            server.saveGoal(index,rolename,editgoal, gi);
            //this.Close();
            Goals goal = new Goals(index);
            goal.Show();


        }
    }
}

EditToDo.cs

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class EditToDo : Form
    {
        private ServiceReference1.ToDo edittodo = new ServiceReference1.ToDo();
        private ServiceReference1.Service1Client server = new ServiceReference1.Service1Client();
        int index=-1;
        int ti = -1;
        string rolename;
        string goalname;
        public EditToDo()
        {
            InitializeComponent();
        }
        public EditToDo(int i,string r,string g,ServiceReference1.ToDo todo, int t)
        {
            InitializeComponent();
            edittodo = todo;
            index = i;
            rolename = r;
            goalname = g;
            ti = t;
        }

        private void EditToDo_Load(object sender, EventArgs e)
        {
            textBox1.Text = edittodo.Todos;
            textBox2.Text = edittodo.Date;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            edittodo.Todos = textBox1.Text;
            edittodo.Date = textBox2.Text;
          //  server.DelToDo(index);
            server.editToDo(index,rolename,goalname,edittodo, ti);
            this.Close();
            ToDocs todo = new ToDocs(index,rolename,goalname);
            todo.Show();
        }
    }
}

Goal.cs

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Goals : Form
    {
        InterfaceDB interfaceDB;
        public static string passgoal;
        public Goals()
        {
            InitializeComponent();
        }
        int index = -1;
        
        public Goals(int i)
        {
            InitializeComponent();
            index = i;
        }
        public Goals(int i,string rolname, string roletype)
        {
            InitializeComponent();
            textBox1.Text = rolname;
            comboBox1.Text = roletype;
            index = i;
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Roles roles = new Roles(index);
            this.Hide();
            roles.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Goals goals = new Goals(index);
            this.Hide();
            goals.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ToDocs toDocs = new ToDocs(index);
            this.Hide();
            toDocs.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Report report = new Report(index);
            this.Hide();
            report.Show();
        }

        private void Goals_Load(object sender, EventArgs e)
        {
            comboBox2.Items.Add("Data Base");
            comboBox2.Items.Add("Static List");
            textBox1.Text = Roles.passname;
           comboBox1.Text = Roles.passtype;
            datashow();

        }

        private void btn_goal_Click(object sender, EventArgs e)
        { if (comboBox2.SelectedIndex == 1)
            {
                ServiceReference1.Service1Client myserver = new ServiceReference1.Service1Client();
                ServiceReference1.Roles myrole = new ServiceReference1.Roles();
                ServiceReference1.Goal mygoal = new ServiceReference1.Goal();
                mygoal.Golname = textBox2.Text;
                myserver.addGoal(index, textBox1.Text, mygoal);
                datashow();
            }
        if(comboBox2.SelectedIndex==0)
            {
                interfaceDB = new Database();
                ToDocs todo = new ToDocs();
                this.Hide();
                todo.Show();
                Goalz goal = new Goalz() { Goalname = textBox2.Text };
                interfaceDB.AddGoal(goal);


            }

        }
        private void datashow()
        {
            ServiceReference1.Service1Client myclient = new ServiceReference1.Service1Client();
            BindingSource abc = new BindingSource();
            abc.DataSource = myclient.getGoalList(index,textBox1.Text);
            dataGridView1.DataSource = abc;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ServiceReference1.Service1Client myserver = new ServiceReference1.Service1Client();
            if (e.ColumnIndex == 1)
            {
                ServiceReference1.Goal mypost = new ServiceReference1.Goal();
                int gi = this.dataGridView1.SelectedCells[0].RowIndex;
                string rname = textBox1.Text;
                mypost = myserver.getgoal(index,rname,gi);
                EditGoal editpost = new EditGoal(index,rname,mypost,gi);
                this.Show();
                editpost.Show();
            }
            if (e.ColumnIndex == 2)
            {
                string rname = textBox1.Text;
                myserver.delGoal(index,rname,e.RowIndex);
                datashow();
            }
            if (e.ColumnIndex == 3)
            {
                passgoal= dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                ToDocs todo = new ToDocs(index,textBox1.Text,passgoal);
                this.Hide();
                todo.Show();

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

Login.cs

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Login : Form
    {
        InterfaceDB intr;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client myserver = new ServiceReference1.Service1Client();
            ServiceReference1.User po = new ServiceReference1.User();
            po.Username = txtname.Text;
            po.Password = txtpass.Text;
            if (txtname.Text == "" && txtpass.Text == "")
            {
                MessageBox.Show("Please Enter your UserName and Password");
            }
            int i = -1;
            if (comboBox1.Text == "Data Base")
            {
                intr = new Database();
                User u = new User();
                u.Username = txtname.Text;
                u.Password = txtpass.Text;
                i=intr.login(u);
                if (i >= 0)

                {
                    MessageBox.Show("login successful");
                    Roles role = new Roles(i);
                    role.Show();
                }
            }
            else
            {
                if ((i = myserver.LogInUser(po)) >= 0)
                {

                    Roles role = new Roles(i);
                    role.Show();


                }
                else
                {

                    lblvalid.Text = "Invalid User";
                    lblvalid.BackColor = System.Drawing.Color.Red;
                }
            }
           
               
            

            
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signup signup = new Signup();
            this.Hide();
            signup.Show();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ResetPassword resetPassword = new ResetPassword();
            this.Hide();
            resetPassword.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

    }
}

Report.cs

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Report : Form
    {
        int index = -1;
        public Report()
        {
            InitializeComponent();
        }

        public Report(int i)
        {
            InitializeComponent();
            index = i;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Roles roles = new Roles();
            roles.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Goals goals = new Goals();
            goals.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ToDocs toDocs = new ToDocs();
            toDocs.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.Show();
        }

        private void Report_Load(object sender, EventArgs e)
        {

        }
    }
}

ResestPassword.cs

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class ResetPassword : Form
    {
        int str_index;
        public ResetPassword()
        {
            InitializeComponent();
        }

        private void ResetPassword_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client server = new ServiceReference1.Service1Client();
            ServiceReference1.User ID = new ServiceReference1.User();
            ID.Username = txtuser.Text;
            ID.Password = txtnewpass.Text;
            server.Adduser(ID);
            txtnewpass.Text = txtpass.Text;
            MessageBox.Show("Password Save");
            Login login = new Login();
            login.Show();
        }
    }
}

Roles.cs

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Roles : Form
    {
        public static string passname;
        public static string passtype;
        InterfaceDB interfaceDB;

        public Roles()
        {
            InitializeComponent();
           
        }
        public Roles(int i)
        {
            InitializeComponent();

            index = i;

        }
        int index = -1;

        private void Roles_Load(object sender, EventArgs e)
        {
            datashow();
            comboBox2.Items.Add("Data Base");
            comboBox2.Items.Add("Static List");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 1)
            {
                ServiceReference1.Service1Client myserver = new ServiceReference1.Service1Client();
                ServiceReference1.Roles myroles = new ServiceReference1.Roles();
                myroles.RoleName = textBox1.Text;
                myroles.RoleType = comboBox1.Text;
                myserver.AddRole(index, myroles);
                datashow();
            }
            if(comboBox2.SelectedIndex==0)
            {
                interfaceDB = new Database();
                Goals goal = new Goals(index, passname, passtype);
                this.Hide();
                goal.Show(); Role role = new Role() { Rolename = textBox1.Text, Roletype = comboBox1.Text };
                interfaceDB.Addroles(role);


            }
            
            

        }
        private void datashow()
        {
            ServiceReference1.Service1Client myclient = new ServiceReference1.Service1Client();
            BindingSource abc = new BindingSource();
            if (index >= 0)
            {
                abc.DataSource = myclient.getRolesList(index);
            }
            dataGridView1.DataSource = abc;
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Roles roles = new Roles(index);
            this.Hide();
            roles.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Goals goals = new Goals(index);
            this.Hide();
            goals.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ToDocs toDocs = new ToDocs(index);
            this.Hide();
            toDocs.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Report report = new Report(index);
            this.Hide();
            report.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ServiceReference1.Service1Client myserver = new ServiceReference1.Service1Client();
            if (e.ColumnIndex == 2)
            {
                ServiceReference1.Roles mypost = new ServiceReference1.Roles();
                int ri = this.dataGridView1.SelectedCells[0].RowIndex;
                mypost = myserver.getRoles(index,ri);
                Editformcs edit = new Editformcs(index,mypost, ri);
                this.Hide();
                edit.Show();
            }
            if (e.ColumnIndex == 3)
            {
                myserver.Delete(index,e.RowIndex);
                datashow();
            }
            if (e.ColumnIndex == 4)
            {
                
                passname = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                passtype = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                Goals goal = new Goals(index,passname, passtype);
                this.Hide();
                goal.Show();

            }
        }
    }
}


SignUp.cs

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Signup : Form
    {
        InterfaceDB interfaceDB;
        public Signup()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Signup_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Data Base");
            comboBox1.Items.Add("Static List");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                if (txtname.Text == "" || txtsurname.Text == "" || txtmail.Text == "" || txtusername.Text == "" || txtpass.Text == "")
                {
                    MessageBox.Show("Fill form carefully.", "Error.");

                    Signup s = new Signup();
                    this.Hide();
                    s.Show();
                }
                else
                {
                    ServiceReference1.Service1Client myserver = new ServiceReference1.Service1Client();
                    ServiceReference1.User myuser = new ServiceReference1.User();
                    myuser.Username = txtusername.Text;
                    myuser.Password = txtpass.Text;
                    int i = -1;
                    if ((i = myserver.Adduser(myuser)) >= 0)
                    {
                        MessageBox.Show("SignUp Successfully");
                        Login login = new Login();
                        this.Hide();
                        login.Show();
                    }
                    else
                    {
                        MessageBox.Show("couldn't signup");
                    }

                }
            }
            if(comboBox1.SelectedIndex==0)
            {
                interfaceDB = new Database();
                MessageBox.Show("Database Added");
                Roles login = new Roles();
                this.Hide();
                login.Show();
                User user = new User() { Email = txtmail.Text, Username = txtusername.Text, Password = txtpass.Text };
                interfaceDB.Adduser(user);
            }
            

        }
    }
}

ToDoscs.cs

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class ToDocs : Form
    {
        InterfaceDB interfaceDB;
        int index = -1;
        public ToDocs()
        {
            InitializeComponent();
        }
        public ToDocs(int i)
        {
            InitializeComponent();
            index = i;
        }
        string rolename;
        string goalname;
        public ToDocs(int i,string r,string g)
        {
            InitializeComponent();
            rolename = r;
            goalname = g;
            index = i;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Roles roles = new Roles(index);
            this.Hide();
            roles.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Goals goals = new Goals(index);
            this.Hide();
            goals.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ToDocs toDocs = new ToDocs(index);
            this.Hide();
            toDocs.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Report report = new Report(index);
            this.Hide();
            report.Show();
        }

        private void ToDocs_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Data Base");
            comboBox1.Items.Add("Static List");
            textBox4.Text = goalname;
            textBox1.Text = rolename;
            textBox3.Text = Roles.passtype;
            datashow();
        }

        private void button5_Click(object sender, EventArgs e)
        {   if (comboBox1.SelectedIndex == 1)
            {
                ServiceReference1.Service1Client myserver = new ServiceReference1.Service1Client();
                ServiceReference1.Roles myrole = new ServiceReference1.Roles();
                ServiceReference1.Goal mygoal = new ServiceReference1.Goal();
                ServiceReference1.ToDo todo = new ServiceReference1.ToDo();
                todo.Todos = textBox2.Text;
                todo.Date = dateTimePicker1.Text;
                myserver.AddToDo(index, textBox1.Text, textBox4.Text, todo);
                datashow();
            }
        if (comboBox1.SelectedIndex==0)
            {
                interfaceDB = new Database();
                ToDos toDos = new ToDos() { Todoname = textBox2.Text };
                interfaceDB.AddToDo(toDos);
            }
           
        }
        private void datashow()
        {
            ServiceReference1.Service1Client myclient = new ServiceReference1.Service1Client();
            BindingSource abc = new BindingSource();
            abc.DataSource = myclient.getToDoList(index,textBox1.Text,textBox4.Text);
            dataGridView1.DataSource = abc;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ServiceReference1.Service1Client myserver = new ServiceReference1.Service1Client();
            if (e.ColumnIndex == 2)
            {
                ServiceReference1.ToDo mypost = new ServiceReference1.ToDo();
                int ti = this.dataGridView1.SelectedCells[0].RowIndex;
                mypost = myserver.getToDo(index,textBox1.Text,textBox4.Text,ti);
                string rolename = textBox1.Text;
                string goalname = textBox4.Text;
                EditToDo editpost = new EditToDo(index,rolename,goalname,mypost, ti);
                editpost.Show();
            }
            if (e.ColumnIndex == 3)
            {
                myserver.DelToDo(index, textBox1.Text, textBox4.Text, e.RowIndex);
                datashow();
            }
        }
    }
    
}

Server Code:

Datalist.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_Managment_System_Server
{
   // public class userdata
   // {
   //     public static List<Roles> userList = new List<Roles>();
   // }


    public class userdata
    {
        public static List<User> userList = new List<User>();
    }


  /*  public class Datalist3
    {
        public static List<Goal> datastore = new List<Goal>();
    }
    public class Datalist2
    {
        public static List<ToDo> datastore = new List<ToDo>();
    }
    */
}


Goal.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_Managment_System_Server
{
    public class Goal
    {
        private string golname;
        private List<ToDo> todos = new List<ToDo>();

        public string Golname { get => golname; set => golname = value; }
        public List<ToDo> Todos { get => todos; }
    }
}

IService.cs

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

Roles.cs

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

Service.cs

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

ToDo.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_Managment_System_Server
{
    public class ToDo
    {
        private string todos;
        private string date;

        public string Todos { get => todos; set => todos = value; }
        public string Date { get => date; set => date = value; }
    }
}
User.cs

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

 	
2.3 User Stories
	As a user, I want to be able to manage my goals on time, so, that I can work consistently to achieve my targets.    
	As an ad agency, I want to be able to add our product adds so that we can earn from it.    
	As a company, I want to be on board and access to admin panel so that we can use it for employees track.                                                       









                                                                           














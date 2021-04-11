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

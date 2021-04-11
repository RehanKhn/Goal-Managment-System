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

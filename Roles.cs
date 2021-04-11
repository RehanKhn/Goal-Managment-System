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

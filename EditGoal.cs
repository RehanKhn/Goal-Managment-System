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

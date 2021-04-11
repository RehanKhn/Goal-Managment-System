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

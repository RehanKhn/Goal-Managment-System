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

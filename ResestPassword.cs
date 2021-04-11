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


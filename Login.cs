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


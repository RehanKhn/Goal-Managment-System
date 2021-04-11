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


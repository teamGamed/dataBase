using dataBase.db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dataBase
{
    public partial class Login : Form
    {
        public Doctor d ;
        string username;
        string password;
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            username = textBox1.Text;
            password = textBox2.Text.ToLower();
            if (username == "" || password == "")
                MessageBox.Show("Please Enter All Information");
            else
            {
                User user = dbUser.get(username);
                Doctor d = dbDoctor.Get(username);
                if (user != null && d != null&& password== user.Password)
                {
                   
                    //doctor form
                    MessageBox.Show("Sucseed");
                    Doctor_Prf df = new Doctor_Prf(user);
                    df.Visible = true;
                }
                else
                    MessageBox.Show("Email or password is wrong");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            username = textBox1.Text.ToLower();
            password = textBox2.Text.ToLower();
            if (username == "" || password == "")
                MessageBox.Show("Please Enter All Information");
            else
            {
                User user = dbUser.get(username);
                Patient p = dbPatient.Get(username);
                if (user != null && p != null && password == user.Password)
                {
                    //doctor form
                    MessageBox.Show("Sucseed");
                }
                else
                    MessageBox.Show("Email or password is wrong");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            username = textBox1.Text.ToLower();
            password = textBox2.Text.ToLower();
            if (username == "fcis" && password == "fcis")
            {

                //doctor form
                MessageBox.Show("Sucseed");
                Admin a = new Admin();
                a.Visible = true;
            }
            else
                MessageBox.Show("Email or password is wrong");
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}

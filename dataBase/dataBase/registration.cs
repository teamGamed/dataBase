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
    public partial class registration : Form
    {
        public registration()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!dbUser.checkForUsername(username.Text))
            {
                MessageBox.Show("username is already existed");
                return;
            }
            var user = new User
            {
                Username = username.Text,
                Name = name.Text,
                Password = password.Text,
                Address = address.Text,
                Email = email.Text,
                Sex = sex.Text[0].ToString(),
                Type = type.Text
            };
            user.SaveDb();
            MessageBox.Show("DONE "+ user.Username);
            if (user.Type == "doctor")
            {
                var doctorForm = new doctorRegisteration(user.Username) {Visible = true};
            }
            else if(user.Type == "patient")
            {
                var patientForm = new patientRegistration(user.Username) {Visible = true};
            }
        }
    }
}

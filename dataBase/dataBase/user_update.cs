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
    public partial class user_update : Form
    {
        User user;
        public user_update(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User edit_user = new User();
            if (textBox1.Text == "")
                edit_user.Username = user.Username;
            else
                edit_user.Username = textBox1.Text;
            if (textBox2.Text == "")
                edit_user.Name = user.Name;
            else
                edit_user.Name = textBox2.Text;
            if (textBox3.Text == "")
                edit_user.Email = user.Email;
            else
                edit_user.Email = textBox3.Text;
            if (textBox4.Text == "")
                edit_user.Phone = user.Phone;
            else
                edit_user.Phone = textBox4.Text;
            if (textBox5.Text == "")
                edit_user.Address = user.Address;
            else
                edit_user.Address = textBox5.Text;
            if (textBox7.Text == "")
                edit_user.Password = user.Password;
            else
                edit_user.Password = textBox7.Text;
            if (textBox6.Text == "")
                edit_user.Type = user.Type;
            else
                edit_user.Type = textBox6.Text;
            if (textBox8.Text == "")
                edit_user.Sex = user.Sex;
            else
                edit_user.Sex = textBox8.Text;
            dbUser.update(edit_user);
            MessageBox.Show("data updated");
            pationt_prf pf = new pationt_prf(edit_user);
            dbUser.update(edit_user);
            pf.Visible = true;

        }
    }
}

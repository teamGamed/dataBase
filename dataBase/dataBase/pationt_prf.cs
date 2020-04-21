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
    public partial class pationt_prf : Form
    {
       
        public User p;
        public pationt_prf(User p)
        {
            this.p = p;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            insert_appointment i = new insert_appointment(p);
            i.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pationt_prf_Load(object sender, EventArgs e)
        {
            label4.Text = p.Username;
            label6.Text = p.Name;
            label5.Text = p.Email;
            label10.Text = p.Phone;
            label12.Text = p.Address;
            label14.Text = p.Password;
            label16.Text = p.Type;
            label15.Text = p.Sex;
            //Patient temp_doc = dbPatient.Get(p.Username);

            /* string constr = "Data source = orcl; User Id = hr; Password =hr; ";
             string cmdstr = $"select * from APPOINTMENT where DOCTOR_USERNAME = '{d.Username}' ";
             OracleDataAdapter adpt = new OracleDataAdapter(cmdstr, constr);
             DataSet dst = new DataSet();
             adpt.Fill(dst);
             dataGridView1.DataSource = dst.Tables[0];*/
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            user_update f = new user_update(p);
            f.Visible = true;

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

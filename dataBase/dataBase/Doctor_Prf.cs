using Oracle.DataAccess.Client;
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
    public partial class Doctor_Prf : Form
    {
        public User d;
        public Doctor_Prf(User d)
        {
            this.d = d;
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        } 

        private void Doctor_Prf_Load(object sender, EventArgs e)
        {
            Doctor temp_doc = dbDoctor.Get(d.Username);
            label4.Text = d.Username;
            label6.Text = temp_doc.Department;
            label5.Text = temp_doc.Shift;
            string constr = "Data source = orcl; User Id = hr; Password =hr; ";
            string cmdstr = $"select * from APPOINTMENT where DOCTOR_USERNAME = '{d.Username}' ";
            OracleDataAdapter adpt = new OracleDataAdapter(cmdstr, constr);
            DataSet dst = new DataSet();
            adpt.Fill(dst);
            dataGridView1.DataSource = dst.Tables[0];
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}

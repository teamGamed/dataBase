using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dataBase.db;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;



namespace dataBase
{
    public partial class Form1 : Form
    {
        string constr = "Data source = orcl; User Id = hr; Password =hr; ";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            string cmdstr = "select * from doctor";
            OracleDataAdapter adp = new OracleDataAdapter( cmdstr, constr);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }


        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Login f = new Login();
            f.Visible = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("Please Enter Doctor Name");
            else
            {
                string name = textBox1.Text.ToLower();
                string query = $"SELECT * FROM doctor " +
                       $"WHERE username LIKE '%{name}%' ";
                OracleDataAdapter adp_search = new OracleDataAdapter(query, constr);
                DataSet ds_searsh = new DataSet();
                adp_search.Fill(ds_searsh);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ds_searsh.Tables[0];
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}

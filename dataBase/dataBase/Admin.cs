using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
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
    public partial class Admin : Form
    {
        OracleCommandBuilder builder;
        string constr = "Data source = orcl; User Id = hr; Password =hr; ";
        OracleDataAdapter adp;
        DataSet ds;
        public Admin()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {

                string cmdstr = "select * from DOCTOR";
                adp = new OracleDataAdapter(cmdstr, constr);
                ds = new DataSet();
                adp.Fill(ds);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {
           
                  string cmdstr = " select * from DOCTOR";
                            adp = new OracleDataAdapter(cmdstr, constr);
                            ds = new DataSet();
                            adp.Fill(ds);
                            dataGridView1.DataSource = null;
                            dataGridView1.DataSource = ds.Tables[0];
            }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked) {
                string cmdstr = "select * from disease";
                adp = new OracleDataAdapter(cmdstr, constr);
            ds = new DataSet();
            adp.Fill(ds);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommandBuilder builder = new OracleCommandBuilder(adp);
            adp.Update(ds.Tables[0]);

        }
    }
}

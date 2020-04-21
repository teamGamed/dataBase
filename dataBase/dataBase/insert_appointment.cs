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
    public partial class insert_appointment : Form
    {
        User user;
        public insert_appointment(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void insert_appointment_Load(object sender, EventArgs e)
        {
            string constr = "Data source = orcl; User Id = hr; Password =hr; ";
            string cmdstr = "select * from APPOINTMENT";
            OracleConnection conn = new OracleConnection(constr);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = cmdstr;
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr= cmd.ExecuteReader();
            while (dr.Read())
            {
                if ((dr[2].ToString()) == user.Username)
                    dataGridView1.Rows.Add(dr[0], dr[1], dr[3], dr[4], true);
                else
                    dataGridView1.Rows.Add(dr[0], dr[1], dr[3], dr[4], false);
            }
            dr.Close();
            conn.Clone();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

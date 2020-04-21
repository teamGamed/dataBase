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
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            for(int i = 0; i< dbDisease.GetAllDisease().Count; i++)
            {
                comboBox1.Items.Add(dbDisease.GetAllDisease()[i].Name);
            }
        }


        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }
    }
}

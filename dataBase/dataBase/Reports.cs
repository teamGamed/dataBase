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
    public partial class Reports : Form
    {
        patientExamination rep1;
        appointmentsReport rep2;
        patientdiseaseReport rep3;

        public Reports()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = rep2;
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            rep1 = new patientExamination();
            rep2 = new appointmentsReport();
            rep3 = new patientdiseaseReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = rep1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = rep3;
        }
    }
}

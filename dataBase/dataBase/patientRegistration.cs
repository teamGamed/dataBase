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

namespace dataBase
{
    public partial class patientRegistration : Form
    {
        private string username;
        public patientRegistration(string username)
        {
            this.username = username;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var patient = new Patient
            {
                Username = username,
                Height = int.Parse(Height.Text),
                Weight = int.Parse(Weight.Text),
                University = University.Text,
                BloodType = blood.Text,
                Birthday = Birthday.Text
            };
            dbPatient.create(patient);
            MessageBox.Show("DONE");
        }

        private void patientRegistration_Load(object sender, EventArgs e)
        {

        }
    }
}

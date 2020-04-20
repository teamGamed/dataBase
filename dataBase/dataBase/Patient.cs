using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dataBase.db;

namespace dataBase
{
    class Patient:User
    {
        public int Weight { get; set; }

        public int Height { get; set; }

        public string Birthday { get; set; }

        public string BloodType { get; set; }

        public string University { get; set; }

        public List<Appointment> Appointments { get; }

        public Patient()
        {

        }

        public Patient(User user)
        {
            Copy(user);
            Appointments = dbPatient.GetAllAppointments(this.Username);
        }

        protected bool Equals(Patient other)
        {
            return base.Equals(other) && Weight == other.Weight && Height == other.Height && Birthday == other.Birthday && BloodType == other.BloodType && University == other.University && Equals(Appointments, other.Appointments);
        }

        
    }
}

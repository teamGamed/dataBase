using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataBase
{
    public class Doctor:User
    {
        public string Department { get; set; }

        public string Shift { get; set; }

        public string Degree { get; set; }

        public List<Appointment> Appointments { get; }

        public Doctor(User user)
        {
            Copy(user);
            Appointments = new List<Appointment>();
            Appointments = dbDoctor.GetAllAppointments(this.Username);
        }


        /*protected bool Equals(Doctor other)
        {
            return base.Equals(other) && Department == other.Department && Shift == other.Shift && Degree == other.Degree;
        }*/


    }
}

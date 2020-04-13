using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataBase
{
    public class Appointment
    {
        public int Id { get; set; }

        public string DoctorUsername { get; set; }

        public string PatientUsername { get; set; }

        public string Date { get; set; }

        public string Room { get; set; }

        protected bool Equals(Appointment other)
        {
            return DoctorUsername == other.DoctorUsername && PatientUsername == other.PatientUsername && Date == other.Date && Room == other.Room;
        }

    }
}

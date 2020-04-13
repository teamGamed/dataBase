using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataBase
{
    public static class dbAppointment
    {
        public const string TABLE = "Appointment";
        public const string ID = "id";
        public const string DOCTOR_USERNAME = "doctor_username";
        public const string PATIENT_USERNAME = "patient_username";
        public const string APPOINTMENT_DATE = "appointment_date";
        public const string ROOM = "room";

        public static int Create(Appointment appointment)
        {
            int id = new Random().Next(10000);
            string query = $"INSERT INTO {TABLE} " +
                           $"VALUES ( {id}, '{appointment.DoctorUsername}'," +
                           $" '{appointment.PatientUsername}', '{appointment.Date}'," +
                           $" '{appointment.Room}' )";
            int r = dbHelper.executeNonQuery(query);
            return r;
        }
    }
}

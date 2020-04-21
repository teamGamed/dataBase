using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataBase
{
    public static class dbDoctor
    {
        public const string TABLE = "doctor";
        public const string USERNAME = "username";
        public const string DEPARTMENT = "Department";
        public const string SHIFT = "shift";
        public const string DEGREE = "Degree";

        public static int Create(Doctor doctor)
        {
            var query = $"INSERT INTO {TABLE} " +
                        $"VALUES ('{doctor.Username}', '{doctor.Department}'," +
                        $"'{doctor.Shift}', '{doctor.Degree}')";
            var r = dbHelper.executeNonQuery(query);
            return r;
        }

        public static Doctor Get(string username)
        {
            var query = $"SELECT * FROM {TABLE} " +
                        $"WHERE {USERNAME} = '{username}' ";
            var dbr = dbHelper.executeReader(query);

            User user = dbUser.get(username);
            Doctor doctor = new Doctor(user);
            while (dbr.Read())
            {
                doctor.Shift = dbr[SHIFT].ToString();
                doctor.Degree = dbr[DEGREE].ToString();
                doctor.Department = dbr[DEPARTMENT].ToString();
            }
            return doctor;
        }

        public static List<Appointment> GetAllAppointments(string username)
        {
            var query = $" SELECT * FROM {dbAppointment.TABLE} " +
                        $" WHERE {dbAppointment.DOCTOR_USERNAME} = '{username}' ";
            var dbr = dbHelper.executeReader(query);
           
            List<Appointment> appointments = new List<Appointment>();
            while (dbr.Read())
            {
                Appointment appointment = new Appointment
                {
                    Id = Int32.Parse(dbr[dbAppointment.ID].ToString()),
                    Date = dbr[dbAppointment.APPOINTMENT_DATE].ToString(),
                    DoctorUsername = dbr[dbAppointment.DOCTOR_USERNAME].ToString(),
                    PatientUsername = dbr[dbAppointment.PATIENT_USERNAME].ToString(),
                    Room = dbr[dbAppointment.ROOM].ToString()
                };
                appointments.Add(appointment);
            }
            return appointments;
        }

        public static List<Doctor> getAllDoctors()
        {
            string query = $"SELECT * FROM {TABLE}";
            List<Doctor> doctors = new List<Doctor>();
            var dbr = dbHelper.executeReader(query);
            while (dbr.Read())
            {
                string username = dbr[USERNAME].ToString();
                Doctor doctor = new Doctor(dbUser.get(username));
                doctor.Shift = dbr[SHIFT].ToString();
                doctor.Degree = dbr[DEGREE].ToString();
                doctor.Department = dbr[DEPARTMENT].ToString();
                doctors.Add(doctor);
            }
            return doctors;
        }

    }
}

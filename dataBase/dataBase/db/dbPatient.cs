using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataBase.db
{
    public class dbPatient
    {
        const string TABLE = "Patient";
        const string USERNAME = "username";
        const string WEIGHT = "weight";
        const string HEIGHT = "height";
        const string BIRTHDAY = "birthday";
        const string BLOOD_TYPE = "blood_type";
        const string UNIVERSITY = "university";

        public static int create(Patient patient)
        {
            var query = $"INSERT INTO {TABLE} " +
                        $"VALUES ( '{patient.Username}', {patient.Weight}," +
                        $" {patient.Height}, '{patient.Birthday}', " +
                        $" '{patient.BloodType}', '{patient.University}' )";

            int r = dbHelper.executeNonQuery(query);
            return r;
        }
        public static Patient Get(string username)
        {
            var query = $"SELECT * FROM {TABLE} " +
                        $"WHERE {USERNAME} = '{username}' ";
            var dbr = dbHelper.executeReader(query);

            User user = dbUser.get(username);
            Patient patient = new Patient(user);
            while (dbr.Read())
            {
                if(dbr[HEIGHT].ToString()=="")
                   patient.Height = 0;
                else
                    patient.Height = int.Parse(dbr[HEIGHT].ToString());
                if (dbr[WEIGHT].ToString() == "")
                    patient.Weight = 0;
                else
                    patient.Weight = int.Parse(dbr[WEIGHT].ToString());
                patient.Birthday = dbr[BIRTHDAY].ToString();
                patient.BloodType = dbr[BLOOD_TYPE].ToString();
                if (dbr[UNIVERSITY].ToString() == "")
                    patient.University = "Data not found";
                else
                patient.University = dbr[UNIVERSITY].ToString();
            }
            return patient;
        }

        public static List<Appointment> GetAllAppointments(string username)
        {
            var query = $" SELECT * FROM {dbAppointment.TABLE} " +
                        $" WHERE {dbAppointment.PATIENT_USERNAME} = '{username}' ";
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
        public static int patientW(string patientName)
        {
            int height; 
            dbHelper.conn = new OracleConnection(dbHelper.dbStr);
            dbHelper.conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = dbHelper.conn;
            cmd.CommandText = "get_user_wh";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("paName", patientName);
            cmd.Parameters.Add("hight", OracleDbType.Int32, ParameterDirection.Output);

             cmd.ExecuteNonQuery();
            try
            {
                height = Convert.ToInt32(cmd.Parameters["hight"].Value.ToString());
            }
            catch
            {
                height = 0;
            }
            return height;
        }


    }
}

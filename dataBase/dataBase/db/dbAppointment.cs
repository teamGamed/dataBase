﻿using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
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
        public static void DeleteAppointment(int id)
        {
            dbHelper.conn = new OracleConnection(dbHelper.dbStr);
            dbHelper.conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = dbHelper.conn;
            cmd.CommandText = "delete_appointment";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("Aid", id);
             cmd.ExecuteNonQuery();
        }
        public static void bookAppointment(Appointment appointment)
        {
            dbHelper.conn = new OracleConnection(dbHelper.dbStr);
            dbHelper.conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = dbHelper.conn;
            cmd.CommandText = "book_appointment";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("Aid", appointment.Id);
            cmd.Parameters.Add("doctorName", appointment.DoctorUsername);
            cmd.Parameters.Add("patientName", appointment.PatientUsername);
            cmd.Parameters.Add("appDate", appointment.Date);
            cmd.Parameters.Add("room", appointment.Room);
            cmd.ExecuteNonQuery();
        }
    }
}

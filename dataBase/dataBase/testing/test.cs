using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataBase.testing
{
    class test
    {
        public static User GenUser()
        {
            var user = new User
            {
                Name = "mahmood",
                Username = "lerooo/" + new Random().Next(10000),
                Address = "obor",
                Email = "mahmoodSherif13@gmail.com/" + new Random().Next(10000),
                Password = "very secret password",
                Phone = "01211079383/" + new Random().Next(10000),
                Sex = "m",
                Type = "doctor",
                PhotoUrl = "photo"
            };
            return user;
        }

        public static Doctor GenDoctor()
        {
            User user = test.GenUser();
            Doctor doctor = new Doctor(user);
            doctor.Shift = "shift";
            doctor.Degree = "degree";
            doctor.Department = "dep";
            return doctor;
        }

        public static Appointment GenAppointment()
        {
            var appointment = new Appointment
            {
                Id = new Random().Next(1000),
                PatientUsername = "pat",
                DoctorUsername = "doc",
                Date = "date",
                Room = "44"
            };
            return appointment;
        }

        public static void Test(bool check, string message, ref int test)
        {
            Debug.Write($"test#{test++}");
            Debug.Assert(check, $"test#{test} fail, {message}");
            Debug.WriteLine($" pass");
        }

    }
}

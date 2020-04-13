using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataBase.testing
{
    public static class dbDoctorTesting
    {
        private static int _teset = 1;

        public static void Run()
        {
            Create1();
            GetAllAppointments1();
        }

        private static void Create1()
        {
            Doctor doc = test.GenDoctor();
            dbUser.create(doc);
            dbDoctor.Create(doc);
            Doctor rDoc = dbDoctor.Get(doc.Username);
            test.Test(doc.Equals(rDoc), "create Doctor",ref _teset);
        }
        
        private static void GetAllAppointments1()
        {
            // pat
            User user = test.GenUser();
            dbUser.create(user);

            // doctor
            Doctor doctor = test.GenDoctor();
            dbUser.create(doctor);
            dbDoctor.Create(doctor);

            // appointment
            Appointment app = new Appointment
            {
                DoctorUsername = doctor.Username,
                PatientUsername = "pat",
                Date = "date",
                Room = "room"
            };
            dbAppointment.Create(app);

            var rApp = dbDoctor.GetAllAppointments(doctor.Username)[0];

            test.Test(app.Equals(rApp), "get appointments",ref _teset);
        }
    }
}

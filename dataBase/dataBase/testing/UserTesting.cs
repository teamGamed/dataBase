using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataBase
{
    public static class UserTesting
    {
        private static int _test = 1;
        public static void Run()
        {
            Debug.WriteLine("User Tests");
            GetById();
            Login();
        }

        private static void Test(bool check, string message)
        {
            Debug.Assert(check, $"test#{_test} fail, {message}");
            Debug.WriteLine($"test#{_test++} pass");
        }

        private static User GenUser()
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
        private static void GetById()
        {
            var user = GenUser();
            dbUser.create(user);
            var rUser = new User(user.Username);
            Test(user.Equals(rUser), "log in");
        }

        private static void Login()
        {
            var user = new User
            {
                Name = "mahmood",
                Username = "mahmoodSherif",
                Address = "obor",
                Email = "mahmoodSherif13@gmail.com/" + new Random().Next(10000),
                Password = "pass",
                Phone = "01211079383/" + new Random().Next(10000),
                Sex = "m",
                Type = "doctor",
                PhotoUrl = "photo"
            };
            Test(user.CheckLogIn("mahmoodSherif", "pass"),"log in");
        }
        
    }
}

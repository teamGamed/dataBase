using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataBase
{
    public static class dbUserTesting
    {

        private static User user;
        public static void run()
        {
            // insert
            user = genUser();
            insert1();
            insert2();
            
            // get 
            get1();

            // update
            update1();

            // done 
            Debug.WriteLine("tests done");
        }
        private static User genUser()
        {
            User user = new User();
            user.Name = "mahmood";
            user.Username = "lerooo/" + new Random().Next(10000);
            user.Address = "obor";
            user.Email = "mahmoodSherif13@gmail.com/" + new Random().Next(10000);
            user.Password = "very secret password";
            user.Phone = "01211079383/" + new Random().Next(10000);
            user.Sex = "m";
            user.Type = "doctor";
            user.PhotoUrl = "photo";
            return user;
        }

        private static void editUser(User user)
        {
            user.Name = "mahmood" + new Random().Next(10000);
            user.Address = "obor" + new Random().Next(10000);
            user.Email = "mahmoodSherif13@gmail.com/" + new Random().Next(10000);
            user.Password = "very secret"+ new Random().Next(10000);
            user.Phone = "01211079383/" + new Random().Next(10000);
            user.Sex = "f";
            user.Type = "doctor";
            user.PhotoUrl = "photo"+ new Random().Next(10000);
        }
        private static void insert1()
        {
            Debug.WriteLine("test#1");
            int r = dbUser.create(user);
            Debug.Assert(r == 1, " test#1 fail, insert new User ");
        }
        private static void insert2()
        {
            Debug.WriteLine("test#2");
            int r = dbUser.create(user);
            Debug.Assert(r == -1, " test#2 fail , insert existent user ");
        }
        private static void get1()
        {
            Debug.WriteLine("test#3");
            User rUser = dbUser.get(user.Username);
            Debug.WriteLine(user.GenString());
            Debug.WriteLine(rUser.GenString());

            Debug.Assert(rUser.Equals(user), "test#3 fail, get User");

        }
        private static void update1()
        {
            Debug.WriteLine("test#4");
            editUser(user);
            int r = dbUser.update(user);
            Debug.Assert(r != -1, " test#3 fail, update User ");

            User rUser = dbUser.get(user.Username);
            Debug.WriteLine(user.GenString());
            Debug.WriteLine(rUser.GenString());
            Debug.Assert(user.Equals(rUser), " test#3 fail, update User not match ");
        }
    }
}

using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataBase
{
    public class dbUser
    {
        public const string TABLE = "user_tb";
        public const string USERNAME = "username";
        public const string PASSWORD = "Password";
        public const string NAME = "Name";
        public const string EMAIL = "Email";
        public const string PHONE = "Phone";
        public const string ADDRESS = "Address";
        public const string PHOTO_URL = "Photo_URL";
        public const string TYPE = "Type";
        public const string SEX = "Sex";
        public const string DOCTOR = "doctor";
        public const string PATIENT = "patient";


        public static bool checkForUsername(string username)
        {
            var query = $"select * from {TABLE} where {USERNAME} = '{username}' ";

            var dbr = db.executeReader(query);
            while (dbr.Read())
            {
                return false;
            }
            dbr.Close();
            return true;
        }

        public static int create(User user)
        {
            if (!checkForUsername(user.Username))
            {
                return -1;
            }
            string insertQuery = 
                            $"INSERT INTO {TABLE}"+ 
                            $" VALUES ('{user.Username}', '{user.Password}', " +
                            $" '{user.Name}', '{user.Email}', '{user.Phone}', " +
                            $" '{user.Address}', '{user.PhotoUrl}', '{user.Type}', '{user.Sex}' ) ";

            int r = db.executeNonQuery(insertQuery);
            return r;
        }

        public static User get(string username)
        {
            string query = $"select * from {TABLE} where {USERNAME} = '{username}' ";

            var dbr = db.executeReader(query);
            var user = new User();

            while (dbr.Read())
            {
                user.Username = dbr[USERNAME].ToString();
                user.Password = dbr[PASSWORD].ToString();
                user.Address = dbr[ADDRESS].ToString();
                user.Email = dbr[EMAIL].ToString();
                user.Name = dbr[NAME].ToString();
                user.Phone = dbr[PHONE].ToString();
                user.PhotoUrl = dbr[PHOTO_URL].ToString();
                user.Sex = dbr[SEX].ToString();
                user.Type = dbr[TYPE].ToString();
            }
            dbr.Close();
            return user;
        }

        public static int update(User user)
        {
            string updateQuery =
                        $"UPDATE {TABLE}  SET  " +
                        $" {PASSWORD} = '{user.Password}'," +
                        $" {NAME} = '{user.Name}', {EMAIL} ='{user.Email}' , {PHONE} = '{user.Phone}',"+ 
                        $" {ADDRESS} = '{user.Address}' , {PHOTO_URL} = '{user.PhotoUrl}', " +
                        $" {TYPE} = '{user.Type}' , {SEX} = '{user.Sex}' WHERE {USERNAME} = '{user.Username}' ";


            int r = db.executeNonQuery(updateQuery);
            return r;
        }
        public static int delete(User user)
        {
            string query = $"DELETE FROM {TABLE} WHERE {USERNAME} = '{user.Username}'";
            
            if (user.Type == DOCTOR)
            {
                // TODO delete doctor row
            }

            if (user.Type == PATIENT)
            {
                // TODO delete patient row
            }

            int r = db.executeNonQuery(query);
            return r;
        }
    }
}

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
        public const string PASSWORD = "password";
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
            var query = $"select * from {TABLE} where {USERNAME} = :username ";
            var parametersList = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("username", username)
            };
            var dbr = dbHelper.executeReader(query, parametersList);
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
                            $" VALUES ( :{USERNAME} , :{PASSWORD} , " +
                            $" :{NAME} , :{EMAIL} , :{PHONE} , " +
                            $" :{ADDRESS} , :{PHOTO_URL} , :{TYPE} , :{SEX} ) ";
            var parametersList = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>(USERNAME, user.Username),
                new KeyValuePair<string, string>(PASSWORD,user.Password),
                new KeyValuePair<string, string>(NAME,user.Name),
                new KeyValuePair<string, string>(EMAIL,user.Email),
                new KeyValuePair<string, string>(PHONE,user.Phone),
                new KeyValuePair<string, string>(ADDRESS,user.Address),
                new KeyValuePair<string, string>(PHOTO_URL,user.PhotoUrl),
                new KeyValuePair<string, string>(TYPE,user.Type),
                new KeyValuePair<string, string>(SEX,user.Sex)
            };
            int r = dbHelper.executeNonQuery(insertQuery, parametersList);
            return r;
        }

        public static User get(string username)
        {
            string query = $"select * from {TABLE} where {USERNAME} = '{username}' ";

            var dbr = dbHelper.executeReader(query);
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


            int r = dbHelper.executeNonQuery(updateQuery);
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

            int r = dbHelper.executeNonQuery(query);
            return r;
        }
        public static void updateName (string username, string name)
        {
            var conn = new OracleConnection(dbHelper.dbStr);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "update_name";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("usernameP", username);
            cmd.Parameters.Add("nameP", name);

            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;


namespace dataBase
{
    public static class dbHelper
    {
        public static OracleConnection conn;
        public const string DB_USERNAME = "hr";
        public const string DB_PASSWORD = "hr";
        public static string dbStr = $"Data source=orcl;User Id={DB_USERNAME}; Password={DB_PASSWORD};";

        public static int executeNonQuery(string queryText, List<KeyValuePair<string, string>> parameters = null)
        {
            conn = new OracleConnection(dbStr);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = queryText;
            cmd.CommandType = CommandType.Text;
            if (parameters != null)
            {
                foreach (var p in parameters)
                {
                    cmd.Parameters.Add(p.Key, p.Value);
                }
            }

            int r = cmd.ExecuteNonQuery();
            conn.Close();
            return r;
        }

        public static OracleDataReader executeReader(string queryText, List<KeyValuePair<string,string>> parameters = null)
        {
            OracleConnection conn = new OracleConnection(dbStr);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;  
            cmd.CommandText = queryText;
            cmd.CommandType = CommandType.Text;
            if (parameters != null)
            {
                foreach (var p in parameters)
                {
                    cmd.Parameters.Add(p.Key, p.Value);
                }
            }

            return cmd.ExecuteReader();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;


namespace dataBase
{
    public static class db
    {
        private static OracleConnection conn;
        private const string DB_USERNAME = "hr";
        private const string DB_PASSWORD = "hr";
        private static string dbStr = $"Data source=orcl;User Id={DB_USERNAME}; Password={DB_PASSWORD};";

        public static int executeNonQuery(string queryText)
        {
            conn = new OracleConnection(dbStr);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = queryText;
            cmd.CommandType = CommandType.Text;
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            return r;
        }

        public static OracleDataReader executeReader(string queryText)
        {
            OracleConnection conn = new OracleConnection(dbStr);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = queryText;
            cmd.CommandType = CommandType.Text;
            return cmd.ExecuteReader();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
namespace db
{
    public class test
    {
        
        public static List<string> get_item()
        {
            List<string> a=new List<string>();
            string ordb = "Data source=orcl;User Id=hr; Password=hr;";
            OracleConnection conn;
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select JOB_ID from JOB_HISTORY";
            //cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                a.Add(dr[0].ToString());
            }
            dr.Close();
            conn.Close();
            return a;
        }
    }
}

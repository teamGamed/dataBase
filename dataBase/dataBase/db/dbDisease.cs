using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace dataBase.db
{
   public static class dbDisease
    {
        public const string TABLE = "Disease";
        public const string id = "Id";
        public const string name = "Name";
        public const string chronic = "Chronic";
        public const string description = "Description";

        public static List<Disease> GetAllDisease()
        {
            List<Disease> allD = new List<Disease>();
            dbHelper.conn = new OracleConnection(dbHelper.dbStr);
            dbHelper.conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = dbHelper.conn;
            cmd.CommandText = "get_all_disease";
            cmd.CommandType =  CommandType.StoredProcedure ;
            cmd.Parameters.Add("disease", OracleDbType.RefCursor, ParameterDirection.Output);
            int r = cmd.ExecuteNonQuery();
            try
            {
                OracleRefCursor curr = (OracleRefCursor)cmd.Parameters["disease"].Value;
                using (OracleDataReader dr = curr.GetDataReader())
                {
                    if (dr.Read())
                    {
                        Disease disease = new Disease
                        {
                            DiseaseID = Convert.ToInt32(dr[id]),
                            Name = dr[name].ToString(),
                            chronic = dr[chronic].ToString(),
                            derscription = dr[description].ToString()
                        };
                        allD.Add(disease);
                    }
                }
            }
            catch
            {
                
            }
            dbHelper.conn.Close();
            return allD;
        }

    }
}

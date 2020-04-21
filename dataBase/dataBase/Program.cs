using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using dataBase.testing;

namespace dataBase
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // tests
            dbUserTesting.run();
           // UserTesting.Run();
            //dbDoctorTesting.Run();

            //Debug.WriteLine(dbUser.checkForUsername("lerooo/40"));
            //string table = "test";
            //string q = $"insert into {table} values (:xx)";
            //List<KeyValuePair<string,string>> list = new List<KeyValuePair<string, string>>();
            //list.Add(new KeyValuePair<string, string>("xx","mahmood"));
            //dbHelper.executeNonQuery(q, list);
            Application.Run(new Form1());
        }
    }
}

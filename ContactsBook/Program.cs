using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Text;
using System.Data.SqlClient;


namespace ContactsBook
{
    class Program
    {
        public static string ConnectionString;
        static Program()
        {
            try
            {
                var mainDBName = ConfigurationManager.AppSettings["defaultDatabase"];
                if (string.IsNullOrEmpty(mainDBName))
                {
                    mainDBName = "main";
                }
                ConnectionString = ConfigurationManager.ConnectionStrings[mainDBName].ConnectionString;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new main());
            
        }


    }
}

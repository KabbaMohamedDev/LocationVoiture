using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LocationVoiture
{
    static class Program
    {

        public static SqlConnection cn = new SqlConnection("data source = (local) ; Initial Catalog = LocationVoiture ; Integrated Security = true");
        public static SqlCommand cmd;
        public static SqlDataAdapter da;
        public static SqlDataAdapter da2;


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}

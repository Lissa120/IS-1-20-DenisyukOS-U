using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace IS_1_20_DenisukOS_U
{
    static class Program
    {
        public class Connection
        {
            public MySqlConnection Conn()
            {
                string connect = "server=10.90.12.110;port=33333;user=st_1_20_12;database=is_1_20_st12_KURS;password=27225069;";
                MySqlConnection Conn;
                Conn = new MySqlConnection(connect);
                return Conn;
            }
            public void Open9()
            {
                Connection conn = new Connection();
                conn.Conn();
            }
            public void Close9()
            {
                MySqlConnection conn = new MySqlConnection();
                conn.Close();
            }
        }
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
        }
    }
}

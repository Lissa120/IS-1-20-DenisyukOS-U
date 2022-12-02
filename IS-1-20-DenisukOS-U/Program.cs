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
                string connect = "server=chuc.caseum.ru;post=33333;user=uchebka;database=uschebka;password=uchebka;";
                MySqlConnection Conn;
                Conn = new MySqlConnection(connect);
                return Conn;
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

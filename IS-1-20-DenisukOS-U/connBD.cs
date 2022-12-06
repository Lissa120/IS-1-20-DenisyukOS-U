using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_1_20_DenisukOS_U
{
    public class Connbd
    {
        public static MySqlConnection connbd()
        {
            string connect = "server=chuc.caseum.ru;port=33333;user=st_1_20_12;database=is_1_20_st12_KURS;password=27225069;";
            MySqlConnection conn = new MySqlConnection(connect);
            return conn;
        }
    }
}

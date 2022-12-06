using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_1_20_DenisukOS_U
{
    public class Class1
    {
        string server = "chuc.caseum.ru";
        string port = "33333";
        string user = "st_1_20_12";
        string database = "is_1_20_st12_KURS";
        string password = "27225069";
        public string connStr;
        public string Connectreturn()
        {
            return connStr = $"host={server};port={port};user={user};database={database};password={password}";
        }
    }
}

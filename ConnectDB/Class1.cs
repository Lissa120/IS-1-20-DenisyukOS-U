using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectDB
{
    public class Class1
    {
        string server = "chuc.caseum.ru";
        string port = "33333";
        string user = "st_1_20_12";
        string database = "is_1_20_st12_KURS";
        string password = "27225069";
        public string connStr;
        public string connection()
        {
            return connStr = $"хост={server};порт={port};пользовтаель={user};базаданных={database};пароль={password}";
        }
    }
}

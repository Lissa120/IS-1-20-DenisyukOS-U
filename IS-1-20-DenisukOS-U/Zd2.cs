using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace IS_1_20_DenisukOS_U
{
    public partial class Zd2 : Form
    {
        MySqlConnection conn;
        //Создаем класс
        public class Connection
        {
            //Создаем MySqlConnection, чтобы подключаться к БД
            public static MySqlConnection OpenConn()
            {
                //"server=chuc.caseum.ru;port=33333;user=st_1_20_12;database=is_1_20_st12_KURS;password=27225069;"
                string connect = "server=chuc.caseum.ru;post=33333;user=uchebka;database=uschebka;password=uchebka;"; //Переменная string, содерживающая строку подключения
                MySqlConnection conn = new MySqlConnection(connect); //Экземпляр класса, в которой строка подключения
                return conn; //Возврат строки
            }
        }
        public Zd2()
        {
            InitializeComponent();
        }

        private void Zd2_Load(object sender, EventArgs e)
        {
            conn = Connection.OpenConn();
            //Прогоняем выполнение метода
            try
            {
                //Выполнение метода
                conn.Open();
            }
            catch(Exception ex)
            {
                //Сообщение об ошибке, если есть исключение
                MessageBox.Show(ex.Message);
            }
        }
    }
}

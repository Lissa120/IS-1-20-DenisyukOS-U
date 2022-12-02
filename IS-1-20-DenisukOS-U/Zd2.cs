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
        //Создаем класс
        public class Connection
        {
            //Создаем MySqlConnection, чтобы подключаться к БД
            public MySqlConnection Conn()
            {
                string connect = "server=chuc.caseum.ru;post=33333;user=uchebka;database=uschebka;password=uchebka;"; //Переменная string, содерживающая строку подключения
                MySqlConnection Conn;
                Conn = new MySqlConnection(connect); //Экземпляр класса, в которой строка подключения
                return Conn; //Возврат строки
            }
        }
        public Zd2()
        {
            InitializeComponent();
        }

        private void Zd2_Load(object sender, EventArgs e)
        {
            //Создаем экземпляр класса Connection
            Connection Conn9 = new Connection();
            //Прогоняем выполнение метода
            try
            {
                //Выполнение метода
                Conn9.Conn();
            }
            catch
            {
                //Сообщение об ошибке, если есть исключение
                MessageBox.Show("Возникла ошибочка!");
            }
        }
    }
}

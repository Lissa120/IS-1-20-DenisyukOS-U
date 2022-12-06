using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static IS_1_20_DenisukOS_U.Program;
using MySql.Data.MySqlClient;

namespace IS_1_20_DenisukOS_U
{
    public partial class Zd3 : Form
    {
        MySqlConnection conn;
        public class Connection
        {
            public static MySqlConnection OpenConn()
            {
                //"server=chuc.caseum.ru;port=33333;user=st_1_20_12;database=is_1_20_st12_KURS;password=27225069;"
                //"server=chuc.caseum.ru;port=33333;user=uchebka;database=uchebka;password=uchebka;"
                string connect = "server=chuc.caseum.ru;port=33333;user=uchebka;database=uchebka;password=uchebka;";
                MySqlConnection conn = new MySqlConnection(connect);
                return conn;
            }
        }
        public Zd3()
        {
            InitializeComponent();
        }
        public void glu()
        {
            string commandStr = "SELECT Notification.id_notification, Notification.number, Notification.employee, Notification.people, Notification.type, Notification.where_from, Notification.weight, Notification.cost, Notification.date, Notification.delivery_address FROM Notification " +
                "JOIN Employee ON Employee.id_employee = Notification.employee JOIN Client ON Client.id_client = Notification.people JOIN Type ON Type.id_type_package = Notification.type JOIN From_where ON From_where.id_country_of_departure = Notification.where_from JOIN Price ON Price.id_price_list = Notification.cost " +
                "JOIN Arrival ON Arrival.id_arrival_address = Notification.delivery_address";
            MySqlCommand command = new MySqlCommand(commandStr, conn);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int row = dataGridView1.Rows.Add();
                dataGridView1.Rows[row].Cells[0].Value = reader[0].ToString();
                dataGridView1.Rows[row].Cells[1].Value = reader[1].ToString();
                dataGridView1.Rows[row].Cells[2].Value = reader[2].ToString();
                dataGridView1.Rows[row].Cells[3].Value = reader[3].ToString();
                dataGridView1.Rows[row].Cells[4].Value = reader[4].ToString();
            }
            reader.Close();
            conn.Close();
        }
        private void Zd3_Load(object sender, EventArgs e)
        {
            conn = Connection.OpenConn();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            glu();
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ColumnHeadersVisible = true;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            conn.Open();
            int row = e.RowIndex;
            string commStr = "SELECT Notification.number, Notification.employee, Notification.people, Notification.type, Notification.where_from, Notification.weight, Notification.cost, Notification.date, Notification.delivery_address FROM Notification " +
                "JOIN Employee ON Employee.id_employee = Notification.employee JOIN Client ON Client.id_client = Notification.people JOIN Type ON Type.id_type_package = Notification.type JOIN From_where ON From_where.id_country_of_departure = Notification.where_from JOIN Price ON Price.id_price_list = Notification.cost " +
                "JOIN Arrival ON Arrival.id_arrival_address = Notification.delivery_address";

            MySqlCommand comm = new MySqlCommand(commStr, conn);
            MySqlDataReader reader = comm.ExecuteReader();

            string inform = "";

            while (reader.Read())
            {
                inform += $"Номер: {reader[0].ToString()}\n";
                inform += $"Сотрудник: {reader[1].ToString()}\n";
                inform += $"Клиент: {reader[2].ToString()}\n";
                inform += $"Тип посылки: {reader[3].ToString()}\n";
                inform += $"От куда поступила: {reader[4].ToString()}\n";
                inform += $"Вес: {reader[5].ToString()}\n";
                inform += $"Цена: {reader[6].ToString()}\n";
                inform += $"Дата: {reader[7].ToString()}\n";
                inform += $"Куда поступила: {reader[8].ToString()}\n";
            }
            reader.Close();
            MessageBox.Show(inform);
            conn.Close();
        }
    }
}

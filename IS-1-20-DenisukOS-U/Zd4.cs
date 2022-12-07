using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConnectDB;
using static ConnectDB.Class1;

namespace IS_1_20_DenisukOS_U
{
    public partial class Zd4 : Form
    {
        Class1 a1 = new Class1();// обявление переменной класса 
        MySqlConnection conn;
        private BindingSource bSource = new BindingSource();
        private MySqlDataAdapter MyDA = new MySqlDataAdapter();
        DataTable table = new DataTable();
        public Zd4()
        {
            InitializeComponent();
        }

        private void Zd4_Load(object sender, EventArgs e)
        {
            //подключение к бд
            a1.Connectreturn();
            conn = new MySqlConnection(a1.connStr);
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = dataGridView1.SelectedCells[0].RowIndex + 1;

                conn.Open();

                string sql = $"SELECT photoUrl FROM t_datatime WHERE Id = {id}";

                MySqlCommand command = new MySqlCommand(sql, conn);

                string picture = command.ExecuteScalar().ToString();

                pictureBox1.ImageLocation = picture;

            }
            catch
            {
                MessageBox.Show("Ошибка загрузки фото");
            }
            finally
            {
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                MySqlCommand command = new MySqlCommand($"SELECT fio, date_of_Birth FROM t_datatime;", conn);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int grid = dataGridView1.Rows.Add();
                    dataGridView1.Rows[grid].Cells[0].Value = reader[0].ToString();
                    dataGridView1.Rows[grid].Cells[1].Value = reader[1].ToString();
                }
                reader.Close();

            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}

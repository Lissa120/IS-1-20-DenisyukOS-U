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

namespace IS_1_20_DenisukOS_U
{
    public partial class Zd5 : Form
    {
        string connStr = "server=chuc.caseum.ru;port=33333;user=st_1_20_12;database=is_1_20_st12_KURS;password=27225069;";
        MySqlConnection conn;
        public Zd5()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Zd5_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection(connStr);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlCommand command = new MySqlCommand($"INSERT INTO t_Uchebka_Smolin (`fioStud`, `datetimeStud`) VALUES (@fio, @datetime);", conn);

                command.Parameters.Add("@fio", MySqlDbType.VarChar);
                command.Parameters.Add("@datetime", MySqlDbType.VarChar);

                conn.Open();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Запись добавлена");
                }
            }
            catch
            {
                MessageBox.Show("Ошибка добавления");
            }
            finally
            {
                conn.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

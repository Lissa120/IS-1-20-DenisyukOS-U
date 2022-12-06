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
    public partial class Zd3 : Form
    {
        MySqlConnection conn;
        Class1 connect;
        public Zd3()
        {
            InitializeComponent();
        }
        private void Zd3_Load(object sender, EventArgs e)
        {
            connect = new Class1();
            connect.Connectreturn();
            conn = new MySqlConnection(connect.connStr);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sql = "SELECT id_people, fio_people, id_client, fio_client FROM People INNER JOIN Client ON id_people = id_client";
                dataGridView1.Columns.Add("id_people", "ид человека");
                dataGridView1.Columns["id_people"].Width = 100;

                dataGridView1.Columns.Add("fio_people", "фио человека");
                dataGridView1.Columns["fio_people"].Width = 100;

                dataGridView1.Columns.Add("id_client", "ид клиента");
                dataGridView1.Columns["id_client"].Width = 100;

                dataGridView1.Columns.Add("fio_client", "фио клиента");
                dataGridView1.Columns["fio_client"].Width = 100;

                MySqlCommand command = new MySqlCommand(sql, conn);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader["id_people"].ToString(), reader["fio_people"].ToString(), reader["id_client"].ToString(), reader["fio_client"].ToString());
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Text, ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
            }
        }
    }
}

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
using static IS_1_20_DenisukOS_U.Connbd;

namespace IS_1_20_DenisukOS_U
{
    public partial class Zd5 : Form
    {
        MySqlConnection conn;
        public Zd5()
        {
            InitializeComponent();
        }

        private void Zd5_Load(object sender, EventArgs e)
        {
            conn = Connbd.connbd();
            Information();
        }
        public void Information()
        {
            conn.Open();
            string inf = "SELECT * FROM t_Uchebka_DENISYUK";
            MySqlCommand cA = new MySqlCommand(inf, conn);
            MySqlDataReader read = cA.ExecuteReader();
            while (read.Read())
            {
                int row = dataGridView1.Rows.Add();
                dataGridView1.Rows[row].Cells[0].Value = read[0].ToString();
                dataGridView1.Rows[row].Cells[1].Value = read[1].ToString();
                dataGridView1.Rows[row].Cells[2].Value = read[2].ToString();
            }
            read.Close();
            conn.Close();
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            string info = textBox1.Text;
            string insert = $"INSERT INTO t_Uchebka_DENISYUK (fioStud, datetimeStud) VALUES (\"{info}\",CURRENT_TIMESTAMP)";
            MySqlCommand cA = new MySqlCommand(insert, conn);
            cA.ExecuteNonQuery();
            conn.Close();
            Information();
        }
    }
}

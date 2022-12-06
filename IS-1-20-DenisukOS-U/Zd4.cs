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
        MySqlConnection conn;
        Class1 connect;
        public Zd4()
        {
            InitializeComponent();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = dataGridView1.SelectedCells[0].RowIndex + 1;
                conn.Open();
                string sql = $"SELECT photoUrl FROM datatime WHERE Id = {id}";
                MySqlCommand command = new MySqlCommand(sql, conn);
                string picture = command.ExecuteScalar().ToString();
                pictureBox1.ImageLocation = picture;
            }
            finally
            {
                conn.Close();
            }
        }

        private void Zd4_Load(object sender, EventArgs e)
        {
            connect = new Class1();
            connect.Connectreturn();
            conn = new MySqlConnection(connect.connStr);

            string sql = "SELECT * FROM datatime";
            try
            {
                conn.Open();
                MySqlDataAdapter IDataAdapter = new MySqlDataAdapter(sql, conn);
                DataSet ds2 = new DataSet();
                IDataAdapter.Fill(ds2);
                dataGridView1.DataSource = ds2.Tables[0];
            }
            finally
            {
                conn.Close();
            }
        }
    }
}

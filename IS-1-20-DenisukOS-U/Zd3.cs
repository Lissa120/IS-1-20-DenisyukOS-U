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
        Connection Conn9;
        private MySqlDataAdapter MyDA = new MySqlDataAdapter();
        private BindingSource bSource = new BindingSource();
        private DataSet ds = new DataSet();
        private DataTable table = new DataTable();
        string id_selected_rows = "0";
        public Zd3()
        {
            InitializeComponent();
        }
        public void glu()
        {
            string commandStr = "SELECT Notification.id_notification, Notification.number, Notification.employee, Notification.people, Notification.type, Notification.where_from, Notification.weight, Notification.cost, Notification.date, Notification.delivery_address FROM Notification " +
                "JOIN Employee ON Employee.id_employee = Notification.employee JOIN Client ON Client.id_client = Notification.people JOIN Type ON Type.id_type_package = Notification.type JOIN From_where ON From_where.id_country_of_departure = Notification.where_from JOIN Price ON Price.id_price_list = Notification.cost " +
                "JOIN Arrival ON Arrival.id_arrival_address = Notification.delivery_address";
            Conn9.Open9();
            MyDA.SelectCommand = new MySqlCommand(commandStr, Conn9.Conn());
            try
            {
                MyDA.Fill(table);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            bSource.DataSource = table;
            dataGridView1.DataSource = bSource;
            Conn9.Close9();
            int count_rows = dataGridView1.RowCount - 1;
        }
        private void Zd3_Load(object sender, EventArgs e)
        {
            Conn9 = new Connection();
            Conn9.Conn();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            glu();
            dataGridView1.Columns.Add("id_notification","");
            dataGridView1.Columns.Add("number","");
            dataGridView1.Columns.Add("employee","");
            dataGridView1.Columns.Add("people","");
            dataGridView1.Columns.Add("type","");
            dataGridView1.Columns.Add("where_from","");
            dataGridView1.Columns.Add("weight","");
            dataGridView1.Columns.Add("cost","");
            dataGridView1.Columns.Add("date","");
            dataGridView1.Columns.Add("delivery_address","");
        }
    }
}

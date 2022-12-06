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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Zd1 a1 = new Zd1();
            a1.ShowDialog();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Zd2 a2 = new Zd2();
            a2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Zd3 a3 = new Zd3();
            a3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Zd4 a4 = new Zd4();
            a4.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}

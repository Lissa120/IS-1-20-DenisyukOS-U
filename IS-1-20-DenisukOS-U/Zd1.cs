using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace IS_1_20_DenisukOS_U
{
    public partial class Zd1 : Form
    {
       public class Compl<T>
        {
            public int price;
            public int sience;
            public T artic;
            public Compl(int price,int sience,T artic)
            {
                this.price = price;
                this.sience = sience;
                this.artic = artic;
            }
            public void Display()
            {
                MessageBox.Show($"Артикул:{artic},Цена:{price},Год выпуска:{sience}");
            }
        }
        public class HardDrive<T> : Compl<T>
        {
            public int numer { get; set; }
            public int interfac { get; set; }
            public int volume { get; set; }
            public HardDrive(int price, int sience, T artic, int numer, int interfac, int volume) : base(price, sience, artic)
            {
                this.numer = numer;
                this.interfac = interfac;
                this.volume = volume;
            }
            public void Display()
            {
                MessageBox.Show($"Артикул:{artic},Цена:{price},Год выпуска:{sience},Кол-во оборотов:{numer} Интерфейс:{interfac} Объем:{volume}");
            }
        }
        public class GPU<T> : Compl<T>
        {
            public int freq { get; set; }
            public string manufacturer { get; set; }
            public int memory { get; set; }
            public GPU(int price, int sience, T artic, int freq, string manufacturer, int memory) : base(price, sience, artic)
            {
                this.freq = freq;
                this.manufacturer = manufacturer;
                this.memory = memory;
            }
            public void Display(int a, int b, int c)
            {
                MessageBox.Show($"Артикул:{artic},Цена:{price},Год выпуска:{sience},Частота:{freq},Производитель:{manufacturer},Объем памяти:{memory}");
            }
        }

        [Obsolete]
        public Zd1()
        {
            InitializeComponent();
        }

        private void Zd1_Load(object sender, EventArgs e)
        {
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            HardDrive<int> D1 = new HardDrive<int>(Convert.ToInt32(metroTextBox1.Text), Convert.ToInt32(metroTextBox2.Text),
                Convert.ToInt32(metroTextBox3.Text), Convert.ToInt32(metroTextBox4.Text), Convert.ToInt32(metroTextBox5.Text), Convert.ToInt32(metroTextBox6.Text));
            listBox1.Items.Add($"Артикул: {metroTextBox1.Text}");
            listBox1.Items.Add($"Цена: {metroTextBox2.Text}");
            listBox1.Items.Add($"Год выпуска: {metroTextBox3.Text}");
            listBox1.Items.Add($"Частота оборотов: {metroTextBox4.Text}");
            listBox1.Items.Add($"Интерфейс: {metroTextBox5.Text}");
            listBox1.Items.Add($"Объем памяти: {metroTextBox6.Text}");
            D1.Display();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            GPU<int> G1 = new GPU<int>(Convert.ToInt32(metroTextBox1.Text), Convert.ToInt32(metroTextBox2.Text),
                Convert.ToInt32(metroTextBox3.Text), Convert.ToInt32(metroTextBox7.Text), metroTextBox8.Text, Convert.ToInt32(metroTextBox9.Text));
            listBox1.Items.Add($"Артикул: {metroTextBox1.Text}");
            listBox1.Items.Add($"Цена: {metroTextBox2.Text}");
            listBox1.Items.Add($"Год выпуска: {metroTextBox3.Text}");
            listBox1.Items.Add($"Частота оборотов: {metroTextBox4.Text}");
            listBox1.Items.Add($"Интерфейс: {metroTextBox5.Text}");
            listBox1.Items.Add($"Объем памяти: {metroTextBox6.Text}");
            G1.Display();
        }
    }
}

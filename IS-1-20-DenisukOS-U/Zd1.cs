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
        //Создаем абстрактный класс, который использует обобщенный тип
        public class Compl<T>
        {
            //Создание поля класса
            public int price;
            public int sience;
            //Создание обобщенного типа данных
            public T artic;
            //Конструктор, который принимает и инициализирует поля класса
            public Compl(int price,int sience,T artic)
            {
                this.price = price;
                this.sience = sience;
                this.artic = artic;
            }
            //Создание виртуального метода вывода полей класса
            public void Display()
            {
                MessageBox.Show($"Артикул:{artic},Цена:{price},Год выпуска:{sience}");
            }
        }
        //Наследуемый класс, использует обобщенный тип
        public class HardDrive<T> : Compl<T>
        {
            //Поля класса
            public int numer { get; set; }
            public int interfac { get; set; }
            public int volume { get; set; }
            //Инициализируем свойства
            public HardDrive(int price, int sience, T artic, int numer, int interfac, int volume) : base(price, sience, artic)
            {
                this.numer = numer;
                this.interfac = interfac;
                this.volume = volume;
            }
            //Переопределенный метод для вывода информации
            public void Display()
            {
                MessageBox.Show($"Артикул:{artic},Цена:{price},Год выпуска:{sience},Кол-во оборотов:{numer} Интерфейс:{interfac} Объем:{volume}");
            }
        }
        //Наследуемый класс, использует обобщенный тип
        public class GPU<T> : Compl<T>
        {
            //Поля класса
            public int freq { get; set; }
            public string manufacturer { get; set; }
            public int memory { get; set; }
            //Инициализируем свойства
            public GPU(int price, int sience, T artic, int freq, string manufacturer, int memory) : base(price, sience, artic)
            {
                this.freq = freq;
                this.manufacturer = manufacturer;
                this.memory = memory;
            }
            //Переопределенный метод для вывода информации
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
        //Выполняет вывод информации по ЖД
        private void button1_Click(object sender, EventArgs e)
        {
            //Очищение
            listBox1.Items.Clear();
            //Создание экземпляра класса, в котором нужные TextBox
            HardDrive<int> D1 = new HardDrive<int>(Convert.ToInt32(metroTextBox1.Text), Convert.ToInt32(metroTextBox2.Text),
                Convert.ToInt32(metroTextBox3.Text), Convert.ToInt32(metroTextBox4.Text), Convert.ToInt32(metroTextBox5.Text), Convert.ToInt32(metroTextBox6.Text));
            //listBox для нужной информации
            listBox1.Items.Add($"Артикул: {metroTextBox1.Text}");
            listBox1.Items.Add($"Цена: {metroTextBox2.Text}");
            listBox1.Items.Add($"Год выпуска: {metroTextBox3.Text}");
            listBox1.Items.Add($"Частота оборотов: {metroTextBox4.Text}");
            listBox1.Items.Add($"Интерфейс: {metroTextBox5.Text}");
            listBox1.Items.Add($"Объем памяти: {metroTextBox6.Text}");
            //Вызывание метода 
            D1.Display();
        }
        //Выполняет вывод информации по ВК
        private void button2_Click(object sender, EventArgs e)
        {
            //Очищение
            listBox1.Items.Clear();
            //Создание экземпляра класса, в котором нужные TextBox
            GPU<int> G1 = new GPU<int>(Convert.ToInt32(metroTextBox1.Text), Convert.ToInt32(metroTextBox2.Text),
                Convert.ToInt32(metroTextBox3.Text), Convert.ToInt32(metroTextBox7.Text), metroTextBox8.Text, Convert.ToInt32(metroTextBox9.Text));
            //listBox для нужной информации
            listBox1.Items.Add($"Артикул: {metroTextBox1.Text}");
            listBox1.Items.Add($"Цена: {metroTextBox2.Text}");
            listBox1.Items.Add($"Год выпуска: {metroTextBox3.Text}");
            listBox1.Items.Add($"Частота: {metroTextBox7.Text}");
            listBox1.Items.Add($"Производитель: {metroTextBox5.Text}");
            listBox1.Items.Add($"Объем памяти: {metroTextBox9.Text}");
            //Вызывание метода
            G1.Display();
        }
    }
}

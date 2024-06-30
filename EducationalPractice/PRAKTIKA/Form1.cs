using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PRAKTIKA
{
    public partial class Form1 : Form
    {
        int count;
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Text files(*.text)|* txt|All files(*.)|*.*";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!checkBox1.Checked && !checkBox2.Checked)
            {
                MessageBox.Show("Вы не выбрали статус билета!"); // Проверка стоит галка в поле "Продано" или "Забронировано"
                return;
            }
            if (tbR.Text == "")
            {
                MessageBox.Show("Вы не ввели номер рейса!"); // Проверка на присутствие текста в поле "Номер рейса"
                return;
            }
            if (comboBox3.SelectedItem == null)
            {
                MessageBox.Show("Вы не выбрали пункт назначения!"); // Проверка выбран ли пункт назначения 
                return;
            }
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Вы не выбрали категорию места!"); // Проверка выбрана ли категория места
                return;
            }
            if (comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Вы не выбрали признак рейса!"); // Проверка выбран ли признак рейса
                return;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Вы не ввели общее число мест!"); // Проверка введено ли общее число мест
                return;
            }
            if (checkBox1.Checked) // Если выбрано поле продано выводет всю информацию + Продано
            {
                count = count + 1;
                listBox1.Items.Add(count + ". Номер рейса: " + tbR.Text + ", Пункт назначения: "
                + comboBox3.Text + ", Категория места: " + comboBox1.Text + ", Дата отправления: "
                + dateTimePicker1.Text + ", Признак внутреннего рейса: " + comboBox2.Text + ", Общее число мест: "
                + textBox2.Text + ", Продано");
            }
            if (checkBox2.Checked) // Если выбрано поле забронировано выводет всю информацию + Забронировано 
            {
                count = count + 1;
                listBox1.Items.Add(count + ". Номер рейса: " + tbR.Text + ", Пункт назначения: "
                    + comboBox3.Text + ", Категория места: " + comboBox1.Text + ", Дата отправления: "
                    + dateTimePicker1.Text + ", Признак внутреннего рейса: " + comboBox2.Text + ", Общее число мест: "
                    + textBox2.Text + ", Забронировано");
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
            }
        }

        private void button2_Click(object sender, EventArgs e) 
        {
            if (openFileDialog1.ShowDialog()== DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;
                string[] text = File.ReadAllLines(filename);
                comboBox3.Items.AddRange(text);
            }
        }

        private void tbR_KeyPress(object sender, KeyPressEventArgs e) // Доступ к цифрам и backspace
        {
            char num = e.KeyChar; 
            if (!Char.IsDigit(num) && num!=8)
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e) // Доступ к цифрам и backspace
        {
            char num = e.KeyChar;
            if (!Char.IsDigit(num) && num != 8)
            {
                e.Handled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e) // Очистка listbox
        {
            listBox1.Items.Clear();
            count = 0;
        }
    }
}

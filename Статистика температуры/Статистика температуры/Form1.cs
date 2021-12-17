using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Статистика_температуры
{
    public partial class Form1 : Form
    {
        List<string> Temperature = new List<string>();
        List<string> Time = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nextTime = textBox1.Text.Replace(" ", "");
            string nextTemp = textBox2.Text.Replace(" ", "");

            //Проверка на нулёвость
            if (nextTime != "" && nextTemp != "")
            {
                //Проверка на правильность формата введённых температуры и времени
                if (double.TryParse(nextTemp, out _) == true && double.TryParse(nextTime.Replace(":",""), out _) == true)
                {
                    if (Time.Count == 0 || Time[Time.Count - 1] != nextTime)
                    {
                        Temperature.Add(nextTemp);
                        Time.Add(nextTime);
                    }
                    else
                        MessageBox.Show("Минимальный интервал измерения температуры - минута"); 
                }
                else
                {
                    var random = new Random();

                    string resultMsg = "";
                    if (double.TryParse(nextTemp, out _) == false)
                       resultMsg += "Температура должна быть числом!";
                    if (double.TryParse(nextTime.Replace(":", ""), out _) == false)
                        resultMsg += $"Неправильный формат даты.\nПравильный, например - {random.Next(10, 24)} : {random.Next(10, 60)}";
                }
            }
            else
            {
                //Оповещаем о недостаточности данных
                if (nextTime == "" && nextTemp == "")
                    MessageBox.Show("Введите время и температуру!");
                else if (nextTime == "")
                    MessageBox.Show("Введите время!");
                else
                    MessageBox.Show("Введите температуру!");
            }
        }

        //Просмотр / скрытие статистики
        private void button2_Click(object sender, EventArgs e)
        {
            if (this.Width == 1360)
            { 
                this.Size = new Size(675, 600);
                button2.Text = "просмотреть статистику";

                //отчётность о времени и температуре
                for (int i = 0; i < Temperature.Count; i++)
                {
                    textBox3.Text +=$"{Time[i]} // {Temperature[i]}";
                }
            }
            else
            {
                this.Size = new Size(1360, 660);
                button2.Text = "скрыть статистику";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //приведение формы к нужному размеру
            this.Size = new Size(675, 600);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Вы уверены, что хотите очистить результаты?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Time.Clear();
                Temperature.Clear();
                textBox3.Text = "";
                //обновляем отчётность о времени и температуре
                for (int i = 0; i < Temperature.Count; i++)
                {
                    textBox3.Text += $"{Time[i]} // {Temperature[i]}";
                }

                MessageBox.Show("Результаты успешно очищены!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            File.WriteAllText(textBox4.Text,"-Сводка данных о температуре Пользователя-" + textBox3.Text);
        }

        private void textBox4_MouseDown(object sender, MouseEventArgs e)
        {
            if (textBox4.Text == "директория")
                textBox4.Text = "";
        }
    }
}

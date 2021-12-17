using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Version_of_fight.Properties;

namespace Version_of_fight
{
    public partial class FormUpdates : Form
    {
        public static Random random = new Random();
        public FormUpdates()
        {
            InitializeComponent();
        }

        private void Textboxes_reload_Tick(object sender, EventArgs e)
        {
            textBox2.Text = UserStatistic.health.ToString();
            textBox1.Text = UserStatistic.streight.ToString();
            textBox6.Text = UserStatistic.shansOfHit.ToString() + " %";
            textBox5.Text = UserStatistic.updatePoints.ToString() + " $";
            textBox7.Text = UserStatistic.armor.ToString();
        }//Обновление данных,показывающихся игроку



        private void Updates_Load(object sender, EventArgs e)
        {
            Textboxes_reload.Start();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
        }

        #region Улучшения

        public int GetUpdateShans(string pre_up)
        {
            int.TryParse(pre_up.Replace(" ", "").Replace("шансудачногоулучшения:", "").Replace("%", ""), out int up);
            return up;
        }

        //Улучшение силы
        private async void Button4_Click(object sender, EventArgs e)
        {
            if (UserStatistic.updatePoints >= 1)
            {
                UserStatistic.updatePoints -= 1;
                if (random.Next(100) < GetUpdateShans(lb_up_1.Text))
                {
                    textBox1.BackColor = Color.LightGreen;

                    if (UserStatistic.streight < 29) UserStatistic.streight += 1;
                    else if (UserStatistic.streight < 50) UserStatistic.streight += 2;
                    else if (UserStatistic.streight < 100) UserStatistic.streight += 5;
                    else UserStatistic.streight += 10;

                    if (UserStatistic.streight == 29) button4.Text = "ап + 2";
                    if (UserStatistic.streight == 48) button4.Text = "ап + 5";
                    if (UserStatistic.streight == 95) button4.Text = "ап + 10";


                    await Task.Delay(1000);
                    textBox1.BackColor = Color.White;
                }
                else
                {
                    textBox1.BackColor = Color.Red;
                    await Task.Delay(1000);
                    textBox1.BackColor = Color.White;
                }
            }
            else
            {
                textBox5.BackColor = Color.Red;
                await Task.Delay(1000);
                textBox5.BackColor = Color.White;
            }
        }


        //Улучшение жизней
        private async void button5_Click(object sender, EventArgs e)
        {
            if (UserStatistic.updatePoints >= 1)
            {
                UserStatistic.updatePoints -= 1;
                if (random.Next(100) < GetUpdateShans(lb_up_2.Text))
                {
                    textBox2.BackColor = Color.LightGreen;

                    if (UserStatistic.health < 100) UserStatistic.health += 10;
                    else if (UserStatistic.health < 200) UserStatistic.health += 20;
                    else if (UserStatistic.health < 500) UserStatistic.health += 50;
                    else UserStatistic.health += 100;

                    if (UserStatistic.streight == 90) button5.Text = "ап + 20";
                    if (UserStatistic.streight == 180) button5.Text = "ап + 50";
                    if (UserStatistic.streight == 450) button5.Text = "ап + 100";


                    await Task.Delay(1000);
                    textBox2.BackColor = Color.White;
                }
                else
                {
                    textBox2.BackColor = Color.Red;
                    await Task.Delay(1000);
                    textBox2.BackColor = Color.White;
                }
            }
            else
            {
                textBox5.BackColor = Color.Red;
                await Task.Delay(1000);
                textBox5.BackColor = Color.White;
            }
        }


        //Улучшение шанса попадания
        private async void button7_Click(object sender, EventArgs e)
        {
            int powerUpdate = 5;//Сила улучшения
            int maxPower = 100;//Максимальное значение параметра
            int shansOfUpdate = GetUpdateShans(lb_up_3.Text);//Шанс улучшения

            if (UserStatistic.shansOfHit < maxPower)
            {
                if (UserStatistic.updatePoints >= 1)
                {
                    textBox6.BackColor = Color.LightGreen;

                    UserStatistic.updatePoints -= 1;
                    if (random.Next(100) < shansOfUpdate)
                    {
                        UserStatistic.shansOfHit += powerUpdate;

                        if (UserStatistic.shansOfHit > maxPower)
                            UserStatistic.shansOfHit = maxPower;


                        await Task.Delay(1000);
                        textBox6.BackColor = Color.White;
                    }
                    else
                    {
                        textBox6.BackColor = Color.Red;
                        await Task.Delay(1000);
                        textBox6.BackColor = Color.White;
                    }

                    if (UserStatistic.shansOfHit == maxPower)
                    {
                        //закрытие возм. улучшения из-за макс. уровня улучшения
                        button7.Text = "max";
                        button7.Enabled = false;
                    }
                }
                else
                {
                    textBox5.BackColor = Color.Red;
                    await Task.Delay(1000);
                    textBox5.BackColor = Color.White;
                }
            }
            else { MessageBox.Show($"Этот навык можно прокачать максимум до {maxPower}% !"); }

        }


        //Улучшение брони
        private async void button8_Click(object sender, EventArgs e)
        {
            if (UserStatistic.updatePoints >= 1)
            {
                UserStatistic.updatePoints -= 1;
                if (random.Next(100) < GetUpdateShans(lb_up_4.Text))
                {
                    textBox7.BackColor = Color.LightGreen;

                    UserStatistic.armor += 1;


                    await Task.Delay(1000);
                    textBox7.BackColor = Color.White;
                }
                else
                {
                    textBox7.BackColor = Color.Red;
                    await Task.Delay(1000);
                    textBox7.BackColor = Color.White;
                }
            }
            else
            {
                textBox5.BackColor = Color.Red;
                await Task.Delay(1000);
                textBox5.BackColor = Color.White;
            }
        }
        #endregion

        private void button1_Click_1(object sender, EventArgs e)
        {
            UserStatistic.updatePoints += 4;
        }
    }
}

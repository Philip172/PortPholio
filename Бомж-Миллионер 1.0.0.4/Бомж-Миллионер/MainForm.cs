using MyLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Бомж_Миллионер.Properties;

namespace Бомж_Миллионер
{
	public partial class MainForm : Form
	{
		public static Random random = new Random();
		public MainForm()
		{
			InitializeComponent();
		}

		#region Обновление данных

		private bool IsPlayerDying() //Проверка на смерть игрока
		{
			if (Player.mood <= 0 || Player.saturation <= 0 || Player.health <= 0)
			{
				if (Player.speedUpEnabled == false)
				{
					MessageBox.Show("Вы проиграли!");

					//Деактивация всех кнопок
					{
						//Деактивация здоровья+
						btn_plusHealth_1.Enabled =
							btn_plusHealth_2.Enabled =
							btn_plusHealth_3.Enabled =
							btn_plusHealth_4.Enabled =
							btn_plusHealth_5.Enabled =
							btn_plusHealth_6.Enabled =
							false;

						//Деактивация сытости+
						btn_plusSaturation_1.Enabled =
							btn_plusSaturation_2.Enabled =
							btn_plusSaturation_3.Enabled =
							btn_plusSaturation_4.Enabled =
							btn_plusSaturation_5.Enabled =
							btn_plusSaturation_6.Enabled =
							false;

						//Деактивация настроения+
						btn_plusMood_1.Enabled =
							btn_plusMood_2.Enabled =
							btn_plusMood_3.Enabled =
							btn_plusMood_4.Enabled =
							btn_plusMood_5.Enabled =
							btn_plusMood_6.Enabled =
							false;

						//Деактивация денег+
						btn_money_1.Enabled =
							false;

						//Деактивация бизнесса+
						btn_buizness_1.Enabled =
							false;
					}
					return true;
				}
				else
				{
					Player.health = Player.saturation = Player.mood = 100;
					MessageBox.Show("Вас спасло от сметри Ускорение усиления");
				}
			}
			return false;
		}

		private void ReloadData() //Обновление данных
		{
			//текстбоксы:
			tb_health.Text = Player.health.ToString();
			tb_saturation.Text = Player.saturation.ToString();
			tb_mood.Text = Player.mood.ToString();
			tb_money.Text = Player.money.ToString() + " $";
			tb_playerYearsOld.Text = MyStrings.GetRightWordForm(Player.TimeNow.year - Player.TimeNow.yearStarted, "лет", "год", "года");

			//прогрессбары:
			{
				//обновления максимума
				pb_health.Maximum = MyUniversal.VancedConvert.toInt(Player.MaxValues.maxHealth);
				pb_saturation.Maximum = MyUniversal.VancedConvert.toInt(Player.MaxValues.maxSaturation);
				pb_mood.Maximum = MyUniversal.VancedConvert.toInt(Player.MaxValues.maxMood);

				//обновления значений
				pb_health.Value = MyUniversal.VancedConvert.toInt(Player.health);
				pb_saturation.Value = MyUniversal.VancedConvert.toInt(Player.saturation);
				pb_mood.Value = MyUniversal.VancedConvert.toInt(Player.mood);
			}
		}

		private void ReloadPotential() //Обновление возможностей
		{
			//Возможности
			for (int i = 0; i < Player.level; i++)
			{
				//Обновление возможностей согласно уровню
				switch (Player.level)
				{
					case 1:
						// +Здоровье
						btn_plusHealth_1.Enabled = true;
						btn_plusHealth_2.Enabled = true;
						// +Сытость
						btn_plusSaturation_1.Enabled = true;
						btn_plusSaturation_2.Enabled = true;
						// +Настроение
						btn_plusMood_1.Enabled = true;
						btn_plusMood_2.Enabled = true;
						// +Деньги
						btn_money_1.Enabled = true;
						break;

					case 2:
						// +Здоровье
						btn_plusHealth_3.Enabled = true;
						btn_plusHealth_4.Enabled = true;
						// +Сытость
						btn_plusSaturation_3.Enabled = true;
						btn_plusSaturation_4.Enabled = true;
						// +Настроение
						btn_plusMood_3.Enabled = true;
						btn_plusMood_4.Enabled = true;
						// +Деньги
						Player.EnabledToBuyBuiznesses[0] = true;
						break;

					case 3:
						// +Здоровье
						btn_plusHealth_5.Enabled = true;
						btn_plusHealth_6.Enabled = true;
						// +Сытость
						btn_plusSaturation_5.Enabled = true;
						btn_plusSaturation_6.Enabled = true;
						// +Настроение
						btn_plusMood_5.Enabled = true;
						btn_plusMood_6.Enabled = true;
						// +Деньги
						btn_money_2.Enabled = true;
						break;
				}
			}

			//Бизнессы
			btn_buizness_1.Enabled = Player.EnabledToBuyBuiznesses[0];
		}



		private void TimeReload(int continueDays = 1)
		{
			//След. день
			Player.TimeNow.day += continueDays;

			//Смена дня
			while (Player.TimeNow.day >= 7)
			{
				Player.TimeNow.day -= 7;
				Player.TimeNow.week++; //след. неделя

				while (Player.TimeNow.week >= 4)
				{
					Player.TimeNow.week -= 4;
					Player.TimeNow.month++; //след. месяц

					while (Player.TimeNow.month >= 12)
					{
						Player.TimeNow.month -= 12;
						Player.TimeNow.year++; //след. год

						//Ежегодные действия
						Player.level++;
					}

					//Ежемесячные действия
					//-
				}

				//Еженедельные действия
				Player.money += Player.autoMoney;
				RandomActions.CallASituation();
			}
		}

		//Обновление параметров игрока
		public void ReloadAllPlayerCharactiristicsOnTB(
			bool isPlayerDying_Enable = true,
			bool timeReload_Enable = true, int continueDaysInTimeReload = 1,
			bool takeMoneyFromBuizness_Enable = true,
			bool reloadData_Enable = true,
			bool reloadPotential_Enable = true,
			bool callASituation = true
			)
		{
			//Проверка на смерть игрока
			if (isPlayerDying_Enable == true)
			{
				// При смерти игрока остальное уже не делаем, ибо игрок умер
				if (IsPlayerDying() == true)
				{
					autoReload.Stop();
					timeReload_Enable = takeMoneyFromBuizness_Enable = reloadPotential_Enable = false;
				}
			}

			//Контроль времени
			if (timeReload_Enable == true)
				TimeReload(continueDaysInTimeReload);

			//Получение денег с бизнессов
			if (takeMoneyFromBuizness_Enable == true)
				Player.money += Player.autoMoney;

			//Обновление данных
			if (reloadData_Enable == true)
				ReloadData();

			//Обновление возможностей
			if (reloadPotential_Enable == true)
				ReloadPotential();
		}

		#endregion

		//Поспать
		private void button1_Click(object sender, EventArgs e)
		{
			//Поспать

			Player.health += random.Next(4, 7);
			Player.saturation -= random.Next(1, 3);
			Player.mood -= random.Next(1, 2);

			ReloadAllPlayerCharactiristicsOnTB();
		}

		//Выпить протеину
		private void button2_Click(object sender, EventArgs e)
		{
			//Выпить протеину (40$)

			if (Player.money >= 40)
			{
				Player.money -= 40;

				Player.health += random.Next(5, 6);
				Player.saturation += 0;
				Player.mood += random.Next(2, 3);

				ReloadAllPlayerCharactiristicsOnTB();
			}
		}

		//Рыться в мусорках
		private void button3_Click(object sender, EventArgs e)
		{
			//Рыться в мусорках

			Player.health -= random.Next(1, 3);
			Player.saturation += random.Next(3, 5);
			Player.mood -= random.Next(2, 3);

			ReloadAllPlayerCharactiristicsOnTB();
		}

		//Попросить скидку
		private void button4_Click(object sender, EventArgs e)
		{
			//Попросить скидку (24$)

			if (Player.money >= 24)
			{
				Player.money -= 24;

				Player.health += 0;
				Player.saturation += random.Next(4, 6);
				Player.mood += random.Next(1, 2);

				ReloadAllPlayerCharactiristicsOnTB();
			}
		}

		//Порадоваться жизни
		private void button5_Click(object sender, EventArgs e)
		{
			//Порадоваться жизни

			Player.health += 0;
			Player.saturation -= random.Next(3, 5);
			Player.mood += random.Next(2, 3);

			ReloadAllPlayerCharactiristicsOnTB();
		}

		//Прогуляться
		private void button6_Click(object sender, EventArgs e)
		{
			//Прогуляться

			Player.health += random.Next(1, 2);
			Player.saturation -= random.Next(7, 10);
			Player.mood += random.Next(5, 7);

			ReloadAllPlayerCharactiristicsOnTB();
		}

		//Обнять подушку
		private void btn_plusHealth_3_Click(object sender, EventArgs e)
		{
			//Обнять подушку

			Player.health += random.Next(6, 8);
			Player.saturation -= random.Next(1, 2);
			Player.mood -= random.Next(1, 2);

			ReloadAllPlayerCharactiristicsOnTB();
		}

		//Попрыгать
		private void btn_plusHealth_4_Click(object sender, EventArgs e)
		{
			//Попрыгать

			Player.health += random.Next(9, 11);
			Player.saturation -= random.Next(2, 3);
			Player.mood -= random.Next(2, 3);

			ReloadAllPlayerCharactiristicsOnTB();
		}

		//Попрошайнячать
		private void btn_plusSaturation_3_Click(object sender, EventArgs e)
		{
			//Попрошайнячать

			Player.health -= random.Next(1, 2);
			Player.saturation += random.Next(10, 12);
			Player.mood -= random.Next(5, 6);

			ReloadAllPlayerCharactiristicsOnTB();
		}

		//Купить гамбургер
		private void btn_plusSaturation_4_Click(object sender, EventArgs e)
		{
			//Купить гамбургер (65 $)

			if (Player.money >= 65)
			{
				Player.money -= 65;

				Player.health += random.Next(1, 2);
				Player.saturation += random.Next(8, 10);
				Player.mood += random.Next(1, 2);

				ReloadAllPlayerCharactiristicsOnTB();
			}
		}

		//Купить вкусняшку
		private void btn_plusMood_3_Click(object sender, EventArgs e)
		{
			//Купить вкусняшку (42$)

			if (Player.money >= 42)
			{
				Player.money -= 42;

				Player.health += random.Next(1, 2);
				Player.saturation -= random.Next(7, 8);
				Player.mood += random.Next(5, 7);

				ReloadAllPlayerCharactiristicsOnTB();
			}
		}

		//Сходить на аттракционы (105$)
		private void btn_plusMood_4_Click(object sender, EventArgs e)
		{
			//Сходить на аттракционы (105$)

			if (Player.money >= 105)
			{
				Player.money -= 105;

				Player.health += random.Next(1, 2);
				Player.saturation -= random.Next(2,3 );
				Player.mood += random.Next(13, 16);

				ReloadAllPlayerCharactiristicsOnTB();
			}
		}

		//Подумать о пушистиках
		private void btn_plusHealth_5_Click(object sender, EventArgs e)
		{
			//Подумать о пушистиках

			Player.health += random.Next(14, 17);
			Player.saturation -= random.Next(3, 5);
			Player.mood -= random.Next(3,5);

			ReloadAllPlayerCharactiristicsOnTB();
		}

		//Украсть еду
		private void btn_plusSaturation_5_Click(object sender, EventArgs e)
		{
			//Украсть еду

			Player.health -= random.Next(2, 3);
			Player.saturation += random.Next(18, 20);
			Player.mood -= random.Next(2, 3);

			ReloadAllPlayerCharactiristicsOnTB();
		}

		//Отжаться 30 раз
		private void btn_plusMood_5_Click(object sender, EventArgs e)
		{
			//Отжаться 30 раз

			Player.health += random.Next(1, 2);
			Player.saturation -= random.Next(2,3 );
			Player.mood += random.Next(9, 11);

			ReloadAllPlayerCharactiristicsOnTB();
		}

		//Принять наркотики (2.000 $)
		private void btn_plusMood_6_Click(object sender, EventArgs e)
		{
			//Принять наркотики (2.000 $)

			if (Player.money >= 2000)
			{
				Player.money -= 2000;

				Player.health -= random.Next(70, 80);
				Player.saturation -= random.Next(35, 46);
				Player.mood += 240;

				ReloadAllPlayerCharactiristicsOnTB();
			}
		}

		//Сходить к врачу
		private void btn_plusHealth_6_Click(object sender, EventArgs e)
		{
			//Сходить к врачу (700$)

			if (Player.money >= 700)
			{
				Player.money -= 700;

				Player.health += random.Next(7, 9)*5;
				Player.saturation += 0;
				Player.mood += random.Next(2, 6);

				ReloadAllPlayerCharactiristicsOnTB();
			}
		}

		//Поесть в ресторане (640$)
		private void btn_plusSaturation_6_Click(object sender, EventArgs e)
		{
			//Поесть в ресторане (640$)

			if (Player.money >= 640)
			{
				Player.money -= 640;

				Player.health += random.Next(1, 3);
				Player.saturation += random.Next(30, 34);
				Player.mood += random.Next(2, 4);

				ReloadAllPlayerCharactiristicsOnTB();
			}
		}

		//Автоматическое обновление данных, показанных игроку
		private void autoReload_Tick(object sender, EventArgs e)
		{
			ReloadAllPlayerCharactiristicsOnTB(timeReload_Enable: false, takeMoneyFromBuizness_Enable: false, continueDaysInTimeReload: 0);
		}

		//Ускорить улучшение
		private void button1_Click_2(object sender, EventArgs e)
		{
			Player.speedUpEnabled = true;
			lb_updateIsSpeededUp.Visible = true;
			button1.Visible = false;
			MessageBox.Show("Улучшение ускорено!");
		}

		//Попрошайнячать деньги
		private void button1_Click_1(object sender, EventArgs e)
		{
			
		}

		//Организовать сбор бутылок
		private void button2_Click_1(object sender, EventArgs e)
		{
			//Организовать сбор бутылок

			if (Player.BuyedBuiznesses[0] == false && Player.money >= 620)
			{
				//Радость от организации бизнесса
				Player.mood += 18;

				//Организация бизнесса
				Player.money -= 620;
				Player.autoMoney += 3;
				Player.BuyedBuiznesses[0] = true;

				btn_buizness_1.Text = "[550 $]\nулучшить бизнесс по сбору бутылок\n(+2 $/ нед)";

				ReloadAllPlayerCharactiristicsOnTB();
			}
			else if (Player.BuyedBuiznesses[0] == true && Player.money >= 550)
			{
				Player.money -= 550;
				Player.autoMoney += 2;

				ReloadAllPlayerCharactiristicsOnTB();
			}
		}

		//Действия при загрузке формы
		private void MainForm_Load(object sender, EventArgs e)
		{
			ReloadAllPlayerCharactiristicsOnTB();
			ReloadPotential();
		}

		private void button2_Click_2(object sender, EventArgs e)
		{
			ReloadAllPlayerCharactiristicsOnTB();
		}

		private void label1_DoubleClick(object sender, EventArgs e)
		{
			button1.Visible = true;
			button2.Visible = true;
			MessageBox.Show("Читы включены! Пути назад уже нету!");
		}

		//Организовать сбор бутылок
		private void btn_buizness_1_Click(object sender, EventArgs e)
		{
			//Организовать сбор бутылок

			if (Player.BuyedBuiznesses[0] == false && Player.money >= 420)
			{
				//Радость от организации бизнесса
				Player.mood += 18;

				//Организация бизнесса
				Player.money -= 420;
				Player.autoMoney += 5;
				Player.BuyedBuiznesses[0] = true;

				btn_buizness_1.Text = "[360 $]\nулучшить бизнесс по сбору бутылок\n(+2 $/ нед)";

				ReloadAllPlayerCharactiristicsOnTB();
			}
			else if (Player.BuyedBuiznesses[0] == true && Player.money >= 360)
			{
				Player.money -= 360;
				Player.autoMoney += 2;

				ReloadAllPlayerCharactiristicsOnTB();
			}
		}

		// Попрошайнячать деньги
		private void btn_money_1_Click(object sender, EventArgs e)
		{
			// Попрошайнячать деньги

			Player.health -= 4;
			Player.saturation -= 8;
			Player.mood -= 10;

			if (Player.speedUpEnabled == true)
			{
				Player.money += random.Next(4, 8);

				Player.health += 2;
				Player.saturation += 4;
				Player.mood += 5;
			}

			Player.money += random.Next(2, 4);

			ReloadAllPlayerCharactiristicsOnTB();
		}

		// Подработать
		private void btn_money_2_Click(object sender, EventArgs e)
		{
			// Подработать

			Player.health -= 3;
			Player.saturation -= 24;
			Player.mood -= 9;

			if (Player.speedUpEnabled == true)
			{
				Player.money += random.Next(8, 14);

				Player.health += 2;
				Player.saturation += 12;
				Player.mood += 5;
			}

			Player.money += random.Next(4, 7);

			ReloadAllPlayerCharactiristicsOnTB();
		}
	}
}

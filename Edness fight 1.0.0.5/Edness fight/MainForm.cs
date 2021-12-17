using MyLib;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edness_fight
{
	public partial class MainForm : Form
	{
		public static Random random = new Random();

		const int addHealth_count = 105; // жизни, добавляемые аптечкой

		const int time_beforeFight = 15, // время, отведённое на перерыв в битвах
			time_forFight = 7; // время, отведённое на битву

		bool fight_started = false; // флажок, начался ли бой

		int watingFight, // время ожидания боя
			inFight; // время в бою

		//Помощь в получении стоимости покупки
		public static int GetCost(string str)
		{
			//Выделяем из значения только числа
			int.TryParse(Regex.Match(str, @"\d+", RegexOptions.RightToLeft).Value, out int value);

			//Возвращаем обработанную строку
			return value;
		}

		//Конструктор MainForm
		public MainForm()
		{
			InitializeComponent();
		}

		//Действия после загрузки MainForm
		private void MainForm_Load(object sender, EventArgs e)
		{
			#region Подготовка к игре

			//Записываем максимальное здоровье игрока и противника как максимальные значения progressbar-ов
			pB_player.Maximum = Player.MaxValues.MaxHealth;
			pB_enemy.Maximum = Enemy.MaxValues.MaxHealth;

			//Записываем время, отведённое на битву и перерывы между битвами
			watingFight = time_beforeFight;
			inFight = time_forFight;

			#endregion Подготовка к игре

		}

		//Смена: военное/мирное время
		private void WhenFight_Tick(object sender, EventArgs e)
		{
			//Проверяем начался ли бой
			if (fight_started == false)
			{
				//Ожидание битвы, уменьшаем таймер если он ещё есть
				if (watingFight > 1)
					watingFight--;
				else
				{
					//Меняем параметры на битву
					lb_time_fight_text.Text = "Битва:";
					fight_started = true; // смена режима
					watingFight = time_beforeFight; // обновление значения таймера ожидания битвы
				}


				//Меняем цвет индикатора времени до битвы/битвы в зависимости от оставшегося врмени
				if (watingFight <= 7)
					lb_time_fight_value.ForeColor = Color.Red;

			}
			else if (fight_started)
			{
				//Битва, уменьшаем таймер если он ещё есть
				if (inFight > 0)
					inFight--;
				else
				{
					lb_time_fight_text.Text = "Времени до сражения:";
					fight_started = false; // смена режима
					inFight = time_forFight; // обновление значения таймера ожидания битвы
					lb_time_fight_value.ForeColor = Color.Black; // возврат цвета индикатора к первоначальному (чёрному)
				}

			}
		}

		//Улучшение силы игрока
		private void update_streight_player_Click(object sender, EventArgs e)
		{
			//Вычисляем цену улучшения
			int cost = GetCost(buy_player_1.Text);

			//Если денег достаточно, покупаем улучшение
			if (Player.gold >= cost)
			{
				Player.gold -= cost;
				Player.streight += 1;
			}
		}

		//Улучшение макс. здоровья игрока
		private void update_maxHealth_player_Click(object sender, EventArgs e)
		{
			//Вычисляем цену улучшения
			int cost = GetCost(buy_player_2.Text);

			//Если денег достаточно, покупаем улучшение
			if (Player.gold >= cost)
			{
				Player.gold -= cost;
				Player.MaxValues.MaxHealth += 100;
				Player.health += 50;
			}
		}

		//Улучшение: покупка аптечки игрока
		private void update_buyFirstAidKit_player_Click(object sender, EventArgs e)
		{
			//Вычисляем цену улучшения
			int cost = GetCost(buy_player_3.Text);

			//Если денег достаточно, покупаем улучшение
			if (Player.gold >= cost)
			{
				Player.gold -= cost;

				if (Player.health + addHealth_count > 100)
					Player.health += Player.MaxValues.MaxHealth - Player.health;
				else
					Player.health += addHealth_count;
			}
		}

		//Улучшение силы противника
		private void update_streight_enemy_Click(object sender, EventArgs e)
		{
			//Вычисляем цену улучшения
			int cost = GetCost(buy_enemy_1.Text);

			//Если денег достаточно, покупаем улучшение
			if (Enemy.gold >= cost)
			{
				Enemy.gold -= cost;
				Enemy.streight += 1;
			}
		}

		//Улучшение макс. жизней противника
		private void update_maxHealth_enemy_Click(object sender, EventArgs e)
		{
			//Вычисляем цену улучшения
			int cost = GetCost(buy_enemy_1.Text);

			//Если денег достаточно, покупаем улучшение
			if (Enemy.gold >= cost)
			{
				Enemy.gold -= cost;
				Enemy.MaxValues.MaxHealth += 100;
				Enemy.health += 50;
			}
		}

		//Улучшение: покупка аптечки противника
		private void update_buyFirstAidKit_enemy_Click(object sender, EventArgs e)
		{
			//Вычисляем цену улучшения
			int cost = GetCost(buy_enemy_1.Text);

			//Если денег достаточно, покупаем улучшение
			if (Enemy.gold >= cost)
			{
				Enemy.gold -= cost;

				if (Enemy.health + addHealth_count > 100)
					Enemy.health += Enemy.MaxValues.MaxHealth - Enemy.health;
				else
					Enemy.health += addHealth_count;
			}
		}

		//ИИ противника
		private async void AI_Tick(object sender, EventArgs e)
		{

		linkGoToFight:
			//Битва
			while (fight_started)
			{
				// интервал действий бота
				await Task.Delay(1800);

				// вычисление урона
				int damage = Enemy.streight - Player.armor;

				// удар по игроку
				if (fight_started)
					Player.health -= damage;
			}


			//Добыча золота
			while (fight_started == false && Enemy.gold < GetCost(buy_enemy_1.Text) && random.Next(3) != 0)
			{
				//Добыча золота ботом

				// интервал действий бота
				await Task.Delay(1300);

				// клик бота на кнопку добычи золота
				btn_mineGold_enemy.PerformClick();
			}


			//Улучшения
			if (fight_started == false)
			{
				//Улучшения ботом

				//Покупка аптечки
				while (fight_started == false && Enemy.gold >= GetCost(buy_enemy_3.Text) && Enemy.health <= 90)
				{
					update_buyFirstAidKit_enemy.PerformClick();

					if (fight_started)
						goto linkGoToFight;
					if (random.Next(40) == 0)
						break;
				}

				//Покупка улучшения макс. здоровья
				while (fight_started == false && Enemy.gold >= GetCost(buy_enemy_2.Text) && Enemy.MaxValues.MaxHealth > Enemy.streight * 3)
				{
					update_maxHealth_enemy.PerformClick();

					if (fight_started)
						goto linkGoToFight;
					if (random.Next(5) == 0)
						break;
				}

				//Покупка улучшения силы
				while (fight_started == false && Enemy.gold >= GetCost(buy_enemy_1.Text))
				{
					update_streight_enemy.PerformClick();

					if (fight_started)
						goto linkGoToFight;
					if (random.Next(5) == 0)
						break;
				}
			}
			else
				goto linkGoToFight;
		}

		//Автоматическая регенерация
		private void Regeneration_Tick(object sender, EventArgs e)
		{
			//Проверка, идёт ли битва
			if (fight_started == false)
			{
				//Регенерация здоровья игрока и противника
				Player.health++;
				Enemy.health++;
			}
		}

		//Проверка на то, убит ли противник
		private void EnemyIsKilled_Tick(object sender, EventArgs e)
		{
			
		}

		//Проверка возможности купить
		private void CanBuy_Tick(object sender, EventArgs e)
		{
			//Получаем возможность покупки силы+1 всвязи с её стоимостью
			buy_player_1.ForeColor = Player.gold >= GetCost(buy_player_1.Text) ? Color.Green : Color.Red;

			//Получаем возможность покупки макс здоровья+100 всвязи с его стоимостью
			buy_player_2.ForeColor = Player.gold >= GetCost(buy_player_2.Text) ? Color.Green : Color.Red;

			//Получаем возможность покупки аптечки всвязи с её стоимостью
			buy_player_3.ForeColor = Player.gold >= GetCost(buy_player_3.Text) ? Color.Green : Color.Red;

		}

		//Удар игрока по противнику
		private void hitByPlayer_Click(object sender, EventArgs e)
		{
			//Вычисляем урон
			int damage = Player.streight - Enemy.armor;

			//Если урон есть, то наносим его
			if (damage > 0)
				Enemy.health -= damage;
		}

		//Удар противника по игроку
		private void hitByEnemy_Click(object sender, EventArgs e)
		{
			//Вычисляем урон
			int damage = Enemy.streight - Player.armor;

			//Если урон есть, то наносим его
			if (damage > 0)
				Player.health -= damage;
		}

		//Перезагрузка показываемых игроку данных
		private void Reload_Tick(object sender, EventArgs e)
		{
			//Игрок
			try
			{
				tb_player_armor.Text = MyStrings.DivideToGrades(Player.armor);
				tb_player_gold.Text = MyStrings.DivideToGrades(Player.gold);
				tb_player_health.Text = MyStrings.DivideToGrades(Player.health);
				tb_player_streight.Text = MyStrings.DivideToGrades(Player.streight);
				tb_player_miningPower.Text = MyStrings.DivideToGrades(Player.powerMining);
				pB_player.Value = Player.health;
			}
			catch { }

			//Противник
			try
			{
				tb_enemy_armor.Text = MyStrings.DivideToGrades(Enemy.armor);
				tb_enemy_gold.Text = MyStrings.DivideToGrades(Enemy.gold);
				tb_enemy_health.Text = MyStrings.DivideToGrades(Enemy.health);
				tb_enemy_streight.Text = MyStrings.DivideToGrades(Enemy.streight);
				tb_enemy_miningPower.Text = MyStrings.DivideToGrades(Enemy.powerMining);
				pB_enemy.Value = Enemy.health;
			}
			catch { }

			//label времени битвы и мирного времени
			if (fight_started == true)
			{
				// показ остатка времени в битве
				lb_time_fight_value.Text = inFight + " сек";

				// открытие возможности драться
				hitByPlayer.Enabled = true;
				hitByEnemy.Enabled = true;
			}
			else
			{
				// показ остатка времени до битвы
				lb_time_fight_value.Text = watingFight + " сек";

				// закрытие возможности драться
				hitByPlayer.Enabled = false;
				hitByEnemy.Enabled = false;
			}
		}

		//Проверка, убит ли кто-либо
		private void Isanyonekilled_Tick(object sender, EventArgs e)
		{
			//Смерть противника
			if (Enemy.health <= 0)
			{
				// остановка ИИ
				AI.Stop();

				// запрет на улучшение сокрытием этой возможности
				gb_enemyUpdate.Visible = false;
			}

			//Смерть игрока
			if (Player.health <= 0)
			{
				// запрет на улучшение сокрытием этой возможности
				gb_playerUpdate.Visible = false;
			}
		}

		//Добыча противником золота
		private void btn_mineGold_enemy_Click(object sender, EventArgs e)
		{
			// добыча золота игроком
			Enemy.gold += Enemy.powerMining;
		}

		//Добыча игроком золота
		private void btn_mineGold_player_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
				Player.gold += Player.powerMining;
		}
	}
}

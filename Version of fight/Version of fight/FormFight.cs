using MyLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Version_of_fight.Properties;

namespace Version_of_fight
{
    public partial class FormFight : Form
    {
        public static Random random = new Random();
        public FormFight()
        {
            InitializeComponent();
        }

        public Enemy enemy;

        //Бусты
        readonly int speedBoost = 10;//Ускорение в {speedBoost} раз (буст)
        readonly int slowingProcents = 60;//Замедление противника (буст)


        bool fightStarted = false;
        readonly int interval_enemySpeed = 20;//Интвервал скорости противника
        readonly int interval_playerSpeed = 5;//Интвервал скорости игрока



        //Генерация характеристик игрока
        private void GeneratePlayer()
        {
            UserStatistic.streight = 10;
            UserStatistic.health = 300;
        }

        //Подготовка к игре
        private void Form1_Load(object sender, EventArgs e)
        {
            //Запуск обновления текстбоксов
            Textboxes_reload.Start();

            //Обозначение интервалов
            {
                go_to_you.Interval = interval_enemySpeed;
                ToBottom.Interval = interval_playerSpeed;
                ToLeft.Interval = interval_playerSpeed;
                ToRight.Interval = interval_playerSpeed;
                ToUp.Interval = interval_playerSpeed;
            }

            //Генерация противника при входе в игру
            {
                GenerateEnemy(EnemiesStat.EnemyLevel);
            }

            //Генерация персоонажа при входе в игру
            if (Settings.Default.First_join_game == true)
            {
                Settings.Default.First_join_game = false;
                GeneratePlayer();
            }

            //Смещаем игрока и противника
            Player.Location = new Point(610 + random.Next(-10, 10), 563 + random.Next(-10, 10));
            atk.Location = new Point(568 + random.Next(-5, 5), 228 + random.Next(-5, 5));
        }

        //Функция создания противника
        private void GenerateEnemy(int level)
        {
            if (level >= EnemiesStat.Enemy_streight.Length - 1)
                level = EnemiesStat.Enemy_streight.Length - 2;

            Enemy.Health = EnemiesStat.Enemy_health[level];
            Enemy.Streight = EnemiesStat.Enemy_streight[level];
            Enemy.Armor = EnemiesStat.Enemy_armor[level];
        }

        int playerHealthInFight, enemyHealthInFight;
        private void button6_Click_1(object sender, EventArgs e)
        {
            new FormUpdates().ShowDialog();
        }


        #region Удары
        private void CommonEnd()
        {
            go_to_you.Stop();
            attack_you.Stop();
            btn_speed.Enabled = false;
            fightStarted = false;
            prBar_player.Value = prBar_player.Maximum;
            prBar_enemy.Value = prBar_enemy.Maximum;
            ToLeft.Stop();
            ToBottom.Stop();
            ToRight.Stop();
            ToUp.Stop();
            Player.Location = new Point(610 + random.Next(-60, 60), 563 + random.Next(-8, 8));
            atk.Location = new Point(568 + random.Next(-50, 50), 228 + random.Next(-4, 4));
            DamageZone.Location = new Point(499 + random.Next(-50, 50), 560 + random.Next(-15, 2));
        }

        //Ударяют игрока
        private void attack_you_Tick(object sender, EventArgs e)
        {
            if ((Player.Top <= atk.Bottom && Player.Bottom >= atk.Top) && (Player.Right >= atk.Left && Player.Left <= atk.Right))
            {
                playerHealthInFight -= Enemy.Streight - UserStatistic.armor;
                if (playerHealthInFight >= 0)
                {
                    prBar_player.Value = playerHealthInFight;
                }
                else if (Enemy.Health > 0)
                {
                    CommonEnd();


                    UserStatistic.updatePoints++;
                    UserStatistic.playerLevel++;
                    Settings.Default.No_Joined_battle = true;
                    btn_gotoMenu.Visible = true;
                    btn_updates.Visible = true;

                    MessageBox.Show("Вы повержены!");
                }//Поражение игроку

            }//Удар врага по игроку
        }


        //Ударает игрок
        #region
        private void atk_Click(object sender, EventArgs e)
        {
            if (Settings.Default.No_Joined_battle == true)
            {
                //Флаг входа в бой
                Settings.Default.No_Joined_battle = false;


                //Кнопки
                btn_gotoMenu.Visible = false;
                btn_updates.Visible = false;
                btn_speed.Enabled = true;
                btn_slow.Enabled = true;

                //Статистика
                playerHealthInFight = UserStatistic.health;
                enemyHealthInFight = Enemy.Health;
                prBar_player.Maximum = UserStatistic.health;
                prBar_player.Value = playerHealthInFight;
                prBar_enemy.Maximum = Enemy.Health;
                prBar_enemy.Value = enemyHealthInFight;

                //Начало боя
                MessageBox.Show("Бой начался!");
                fightStarted = true;
                attack_you.Start();
                go_to_you.Start();
            }

            //Удар
            if (playerHealthInFight > 0 && enemyHealthInFight > 0)
            {
                if ((Player.Top <= DamageZone.Bottom && Player.Bottom >= DamageZone.Top) && (Player.Right >= DamageZone.Left && Player.Left <= DamageZone.Right))
                {
                    //Удар игрока по врагу
                    if (new Random().Next(100) <= UserStatistic.shansOfHit)
                    {
                        if (UserStatistic.streight > Enemy.Armor)
                            enemyHealthInFight -= UserStatistic.streight - Enemy.Armor;
                        else
                            enemyHealthInFight -= 1;

                        if (enemyHealthInFight >= 0)
                            prBar_enemy.Value = enemyHealthInFight;
                    }

                    //Перемещение области нанесения удара
                    int nextLocationDamageZone_X = random.Next(WarZone.Location.X + 50, WarZone.Location.X - 150 + WarZone.Width);
                    int nextLocationDamageZone_Y = random.Next(WarZone.Location.Y + 20, WarZone.Location.Y - 60 + WarZone.Height);
                    DamageZone.Location = new Point(nextLocationDamageZone_X, nextLocationDamageZone_Y);
                }
            }
            else //Окончание боя
            {
                CommonEnd();

                if (enemyHealthInFight <= 0)
                {

                    UserStatistic.updatePoints++; UserStatistic.playerLevel++;
                    GenerateEnemy(EnemiesStat.EnemyLevel);


                    //Победа игрока
                    if (enemyHealthInFight <= 0 && playerHealthInFight > 0)
                    {



                        UserStatistic.updatePoints += 3; UserStatistic.playerLevel += 1;

                        if (EnemiesStat.EnemyLevel == EnemiesStat.Enemy_streight.Length)
                        {
                            //Сообщаем игроку, если побеждённый был последним противником
                            MessageBox.Show("Это был последний противник! Вы - победитель!");
                        }
                        else
                        {
                            //Сообщаем игроку об улучшении противника
                            MessageBox.Show("Ты победил! Но теперь противник улучшен");

                            //Улучшаем противника
                            EnemiesStat.EnemyLevel++;
                        }

                        GenerateEnemy(EnemiesStat.EnemyLevel);

                    }

                    //Ничья
                    else if (enemyHealthInFight <= 0 && playerHealthInFight <= 0)
                    {
                        MessageBox.Show("Ничья!");
                    }


                    MessageBox.Show("Бой окончен!");
                    Settings.Default.No_Joined_battle = true;
                    btn_gotoMenu.Visible = true;
                    btn_updates.Visible = true;
                }
            }
        }

        private void atk_KeyDown(object sender, KeyEventArgs e)
        {
            if (fightStarted)
                switch (e.KeyCode)
                {
                    case Keys.ShiftKey:
                        btn_speed.PerformClick();
                        break;

                    case Keys.F:
                        btn_slow.PerformClick();
                        break;

                    case Keys.A:
                        ToLeft.Start();
                        break;

                    case Keys.W:
                        ToUp.Start();
                        break;

                    case Keys.S:
                        ToBottom.Start();
                        break;

                    case Keys.D:
                        ToRight.Start();
                        break;
                }
        }

        private void atk_KeyUp(object sender, KeyEventArgs e)
        {
            if (fightStarted)
                switch (e.KeyCode)
                {
                    case Keys.ShiftKey:
                        btn_speed.PerformClick();
                        break;

                    case Keys.F:
                        btn_slow.PerformClick();
                        break;

                    case Keys.A:
                        ToLeft.Stop();
                        break;

                    case Keys.W:
                        ToUp.Stop();
                        break;

                    case Keys.S:
                        ToBottom.Stop();
                        break;

                    case Keys.D:
                        ToRight.Stop();
                        break;
                }
        }
        #endregion

        #endregion

        #region Контроль игрока
        int player_speed = 1;//Скорость игрока
        int shift = 1;
        private void ToLeft_Tick(object sender, EventArgs e)
        {
            if (Player.Left > 23)
                Player.Left -= player_speed * shift;
        }

        private void ToUp_Tick(object sender, EventArgs e)
        {
            if (Player.Top > 245)
                Player.Top -= player_speed * shift;
        }

        private void ToRight_Tick(object sender, EventArgs e)
        {
            if (Player.Left < 1090)
                Player.Left += player_speed * shift;
        }
        private void ToBottom_Tick(object sender, EventArgs e)
        {
            if (Player.Bottom < 622)
                Player.Top += player_speed * shift;
        }
        private async void btn_speed_Click(object sender, EventArgs e)
        {
            int was = shift;
            btn_speed.Enabled = false;

            //буст действует
            shift = speedBoost;
            await Task.Delay(80);

            //ускорение откатывается
            shift = was;

            //буст перезаряжается
            await Task.Delay(5000);

            //буст перезаряжен
            btn_speed.Enabled = true;
        }
        #endregion



        private void go_to_you_Tick(object sender, EventArgs e)
        {
            int shansOfDash = 1;
            int move_enemy_speed = 1;
            atk.Focus();


            if (random.Next(100) < shansOfDash)
                move_enemy_speed = 20;

            if (atk.Location.X > Player.Location.X)
                atk.Left -= move_enemy_speed;

            else if (atk.Location.X < Player.Location.X)
                atk.Left += move_enemy_speed;

            if (atk.Location.Y > Player.Location.Y)
                atk.Top -= move_enemy_speed;

            else if (atk.Location.Y < Player.Location.Y)
                atk.Top += move_enemy_speed;
        }

        private void Fight_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.No_Joined_battle = true;
            //Settings.Default.Save(); //Сейчас прогресс не сохраняется
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Settings.Default.Reset();
            Hide(); new FormFight().ShowDialog();
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            int was = go_to_you.Interval;
            btn_slow.Enabled = false;

            go_to_you.Interval = go_to_you.Interval * 100 / (100 - slowingProcents);

            //буст действует
            atk.BackColor = Color.Blue;
            await Task.Delay(1500);//время действия
            atk.BackColor = Color.Red;

            //замедление откатывается
            go_to_you.Interval = was;

            //буст перезаряжается
            await Task.Delay(10000);

            //буст перезаряжен
            btn_slow.Enabled = true;
        }

        //Переход в меню
        private void btn_gotoMenu_Click(object sender, EventArgs e)
        {
            Hide();
            new FormMainMenu().ShowDialog();
        }







        //Обновление данных,показывающихся игроку
        private void Textboxes_reload_Tick(object sender, EventArgs e)
        {
            if (Settings.Default.No_Joined_battle == false)
            {
                tb_enemy_health.Text = MyStrings.DivideToGrades(enemyHealthInFight) + " / " + MyStrings.DivideToGrades(Enemy.Health);
                tb_your_health.Text = MyStrings.DivideToGrades(playerHealthInFight) + " / " + MyStrings.DivideToGrades(UserStatistic.health);
            }
            else
            {
                tb_enemy_health.Text = MyStrings.DivideToGrades(Enemy.Health);
                tb_your_health.Text = MyStrings.DivideToGrades(UserStatistic.health);
                tb_your_armor.Text = MyStrings.DivideToGrades(UserStatistic.armor);
                tb_enemy_armor.Text = MyStrings.DivideToGrades(Enemy.Armor);
            }
            tb_your_streight.Text = UserStatistic.streight.ToString();
            tb_enemy_streight.Text = Enemy.Streight.ToString();
            tb_your_ShansOfHit.Text = UserStatistic.shansOfHit.ToString() + " %";
            tb_updatePoints.Text = UserStatistic.updatePoints.ToString()+" $";

            label10.Text = "Уровень: " + UserStatistic.playerLevel.ToString();
            label11.Text = "Уровень: " + EnemiesStat.EnemyLevel.ToString();

        }


    }
}


namespace Edness_fight
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.tb_player_gold = new System.Windows.Forms.TextBox();
			this.btn_player = new System.Windows.Forms.Button();
			this.btn_mineGold_player = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.tb_player_streight = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tb_player_health = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.tb_player_armor = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tb_player_miningPower = new System.Windows.Forms.TextBox();
			this.Reload = new System.Windows.Forms.Timer(this.components);
			this.label6 = new System.Windows.Forms.Label();
			this.tb_enemy_gold = new System.Windows.Forms.TextBox();
			this.btn_enemy = new System.Windows.Forms.Button();
			this.btn_mineGold_enemy = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.tb_enemy_streight = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.tb_enemy_health = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.tb_enemy_armor = new System.Windows.Forms.TextBox();
			this.tb_enemy_miningPower = new System.Windows.Forms.TextBox();
			this.hitByPlayer = new System.Windows.Forms.Button();
			this.hitByEnemy = new System.Windows.Forms.Button();
			this.WhenFight = new System.Windows.Forms.Timer(this.components);
			this.lb_time_fight_text = new System.Windows.Forms.Label();
			this.gb_playerUpdate = new System.Windows.Forms.GroupBox();
			this.update_buyFirstAidKit_player = new System.Windows.Forms.Button();
			this.update_maxHealth_player = new System.Windows.Forms.Button();
			this.update_streight_player = new System.Windows.Forms.Button();
			this.buy_player_3 = new System.Windows.Forms.Label();
			this.buy_player_2 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.buy_player_1 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.gb_enemyUpdate = new System.Windows.Forms.GroupBox();
			this.update_buyFirstAidKit_enemy = new System.Windows.Forms.Button();
			this.update_maxHealth_enemy = new System.Windows.Forms.Button();
			this.update_streight_enemy = new System.Windows.Forms.Button();
			this.buy_enemy_3 = new System.Windows.Forms.Label();
			this.buy_enemy_2 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.buy_enemy_1 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.label25 = new System.Windows.Forms.Label();
			this.label26 = new System.Windows.Forms.Label();
			this.label27 = new System.Windows.Forms.Label();
			this.AI = new System.Windows.Forms.Timer(this.components);
			this.Regeneration = new System.Windows.Forms.Timer(this.components);
			this.pB_player = new System.Windows.Forms.ProgressBar();
			this.pB_enemy = new System.Windows.Forms.ProgressBar();
			this.Isanyonekilled = new System.Windows.Forms.Timer(this.components);
			this.CanBuy = new System.Windows.Forms.Timer(this.components);
			this.lb_time_fight_value = new System.Windows.Forms.Label();
			this.gb_playerUpdate.SuspendLayout();
			this.gb_enemyUpdate.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(424, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(98, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "золото:";
			// 
			// tb_player_gold
			// 
			this.tb_player_gold.BackColor = System.Drawing.Color.White;
			this.tb_player_gold.ForeColor = System.Drawing.Color.Gold;
			this.tb_player_gold.Location = new System.Drawing.Point(516, 22);
			this.tb_player_gold.Name = "tb_player_gold";
			this.tb_player_gold.Size = new System.Drawing.Size(266, 33);
			this.tb_player_gold.TabIndex = 1;
			// 
			// btn_player
			// 
			this.btn_player.Location = new System.Drawing.Point(472, 61);
			this.btn_player.Name = "btn_player";
			this.btn_player.Size = new System.Drawing.Size(219, 205);
			this.btn_player.TabIndex = 2;
			this.btn_player.Text = "Игрок";
			this.btn_player.UseVisualStyleBackColor = true;
			// 
			// btn_mineGold_player
			// 
			this.btn_mineGold_player.Location = new System.Drawing.Point(420, 272);
			this.btn_mineGold_player.Name = "btn_mineGold_player";
			this.btn_mineGold_player.Size = new System.Drawing.Size(324, 47);
			this.btn_mineGold_player.TabIndex = 3;
			this.btn_mineGold_player.Text = "добыть золото";
			this.btn_mineGold_player.UseVisualStyleBackColor = true;
			this.btn_mineGold_player.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_mineGold_player_MouseClick);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 92);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(76, 29);
			this.label2.TabIndex = 4;
			this.label2.Text = "Сила:";
			// 
			// tb_player_streight
			// 
			this.tb_player_streight.BackColor = System.Drawing.Color.White;
			this.tb_player_streight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tb_player_streight.ForeColor = System.Drawing.Color.Red;
			this.tb_player_streight.Location = new System.Drawing.Point(144, 89);
			this.tb_player_streight.Name = "tb_player_streight";
			this.tb_player_streight.Size = new System.Drawing.Size(137, 38);
			this.tb_player_streight.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 131);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(131, 29);
			this.label3.TabIndex = 4;
			this.label3.Text = "Здоровье:";
			// 
			// tb_player_health
			// 
			this.tb_player_health.BackColor = System.Drawing.Color.White;
			this.tb_player_health.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tb_player_health.ForeColor = System.Drawing.Color.Lime;
			this.tb_player_health.Location = new System.Drawing.Point(144, 133);
			this.tb_player_health.Name = "tb_player_health";
			this.tb_player_health.Size = new System.Drawing.Size(137, 38);
			this.tb_player_health.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 170);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(89, 29);
			this.label4.TabIndex = 4;
			this.label4.Text = "Броня:";
			// 
			// tb_player_armor
			// 
			this.tb_player_armor.BackColor = System.Drawing.Color.White;
			this.tb_player_armor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tb_player_armor.ForeColor = System.Drawing.Color.Silver;
			this.tb_player_armor.Location = new System.Drawing.Point(144, 177);
			this.tb_player_armor.Name = "tb_player_armor";
			this.tb_player_armor.Size = new System.Drawing.Size(137, 38);
			this.tb_player_armor.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 220);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(167, 29);
			this.label5.TabIndex = 4;
			this.label5.Text = "Сила добычи:";
			this.label5.Visible = false;
			// 
			// tb_player_miningPower
			// 
			this.tb_player_miningPower.BackColor = System.Drawing.Color.White;
			this.tb_player_miningPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tb_player_miningPower.ForeColor = System.Drawing.Color.Gold;
			this.tb_player_miningPower.Location = new System.Drawing.Point(144, 251);
			this.tb_player_miningPower.Name = "tb_player_miningPower";
			this.tb_player_miningPower.Size = new System.Drawing.Size(137, 38);
			this.tb_player_miningPower.TabIndex = 5;
			this.tb_player_miningPower.Visible = false;
			// 
			// Reload
			// 
			this.Reload.Enabled = true;
			this.Reload.Interval = 30;
			this.Reload.Tick += new System.EventHandler(this.Reload_Tick);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(1125, 25);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(98, 29);
			this.label6.TabIndex = 0;
			this.label6.Text = "золото:";
			// 
			// tb_enemy_gold
			// 
			this.tb_enemy_gold.BackColor = System.Drawing.Color.White;
			this.tb_enemy_gold.ForeColor = System.Drawing.Color.Gold;
			this.tb_enemy_gold.Location = new System.Drawing.Point(1217, 22);
			this.tb_enemy_gold.Name = "tb_enemy_gold";
			this.tb_enemy_gold.Size = new System.Drawing.Size(266, 33);
			this.tb_enemy_gold.TabIndex = 1;
			// 
			// btn_enemy
			// 
			this.btn_enemy.Location = new System.Drawing.Point(1173, 61);
			this.btn_enemy.Name = "btn_enemy";
			this.btn_enemy.Size = new System.Drawing.Size(219, 205);
			this.btn_enemy.TabIndex = 2;
			this.btn_enemy.Text = "Противник";
			this.btn_enemy.UseVisualStyleBackColor = true;
			// 
			// btn_mineGold_enemy
			// 
			this.btn_mineGold_enemy.Location = new System.Drawing.Point(1130, 272);
			this.btn_mineGold_enemy.Name = "btn_mineGold_enemy";
			this.btn_mineGold_enemy.Size = new System.Drawing.Size(324, 47);
			this.btn_mineGold_enemy.TabIndex = 3;
			this.btn_mineGold_enemy.Text = "добыть золото";
			this.btn_mineGold_enemy.UseVisualStyleBackColor = true;
			this.btn_mineGold_enemy.Click += new System.EventHandler(this.btn_mineGold_enemy_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(1398, 91);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(76, 29);
			this.label7.TabIndex = 4;
			this.label7.Text = "Сила:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(1398, 130);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(131, 29);
			this.label8.TabIndex = 4;
			this.label8.Text = "Здоровье:";
			// 
			// tb_enemy_streight
			// 
			this.tb_enemy_streight.BackColor = System.Drawing.Color.White;
			this.tb_enemy_streight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tb_enemy_streight.ForeColor = System.Drawing.Color.Red;
			this.tb_enemy_streight.Location = new System.Drawing.Point(1530, 88);
			this.tb_enemy_streight.Name = "tb_enemy_streight";
			this.tb_enemy_streight.Size = new System.Drawing.Size(137, 38);
			this.tb_enemy_streight.TabIndex = 5;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(1398, 169);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(89, 29);
			this.label9.TabIndex = 4;
			this.label9.Text = "Броня:";
			// 
			// tb_enemy_health
			// 
			this.tb_enemy_health.BackColor = System.Drawing.Color.White;
			this.tb_enemy_health.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tb_enemy_health.ForeColor = System.Drawing.Color.Lime;
			this.tb_enemy_health.Location = new System.Drawing.Point(1530, 132);
			this.tb_enemy_health.Name = "tb_enemy_health";
			this.tb_enemy_health.Size = new System.Drawing.Size(137, 38);
			this.tb_enemy_health.TabIndex = 5;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(1398, 219);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(167, 29);
			this.label10.TabIndex = 4;
			this.label10.Text = "Сила добычи:";
			this.label10.Visible = false;
			// 
			// tb_enemy_armor
			// 
			this.tb_enemy_armor.BackColor = System.Drawing.Color.White;
			this.tb_enemy_armor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tb_enemy_armor.ForeColor = System.Drawing.Color.Silver;
			this.tb_enemy_armor.Location = new System.Drawing.Point(1530, 176);
			this.tb_enemy_armor.Name = "tb_enemy_armor";
			this.tb_enemy_armor.Size = new System.Drawing.Size(137, 38);
			this.tb_enemy_armor.TabIndex = 5;
			// 
			// tb_enemy_miningPower
			// 
			this.tb_enemy_miningPower.BackColor = System.Drawing.Color.White;
			this.tb_enemy_miningPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tb_enemy_miningPower.ForeColor = System.Drawing.Color.Gold;
			this.tb_enemy_miningPower.Location = new System.Drawing.Point(1530, 251);
			this.tb_enemy_miningPower.Name = "tb_enemy_miningPower";
			this.tb_enemy_miningPower.Size = new System.Drawing.Size(137, 38);
			this.tb_enemy_miningPower.TabIndex = 5;
			this.tb_enemy_miningPower.Visible = false;
			// 
			// hitByPlayer
			// 
			this.hitByPlayer.Location = new System.Drawing.Point(719, 61);
			this.hitByPlayer.Name = "hitByPlayer";
			this.hitByPlayer.Size = new System.Drawing.Size(272, 47);
			this.hitByPlayer.TabIndex = 6;
			this.hitByPlayer.Text = "ударить противника";
			this.hitByPlayer.UseVisualStyleBackColor = true;
			this.hitByPlayer.Click += new System.EventHandler(this.hitByPlayer_Click);
			// 
			// hitByEnemy
			// 
			this.hitByEnemy.Location = new System.Drawing.Point(883, 219);
			this.hitByEnemy.Name = "hitByEnemy";
			this.hitByEnemy.Size = new System.Drawing.Size(272, 47);
			this.hitByEnemy.TabIndex = 6;
			this.hitByEnemy.Text = "ударить игрока";
			this.hitByEnemy.UseVisualStyleBackColor = true;
			this.hitByEnemy.Click += new System.EventHandler(this.hitByEnemy_Click);
			// 
			// WhenFight
			// 
			this.WhenFight.Enabled = true;
			this.WhenFight.Interval = 1000;
			this.WhenFight.Tick += new System.EventHandler(this.WhenFight_Tick);
			// 
			// lb_time_fight_text
			// 
			this.lb_time_fight_text.AutoSize = true;
			this.lb_time_fight_text.ForeColor = System.Drawing.Color.Black;
			this.lb_time_fight_text.Location = new System.Drawing.Point(734, 451);
			this.lb_time_fight_text.Name = "lb_time_fight_text";
			this.lb_time_fight_text.Size = new System.Drawing.Size(277, 29);
			this.lb_time_fight_text.TabIndex = 7;
			this.lb_time_fight_text.Text = "Времени до сражения:";
			// 
			// gb_playerUpdate
			// 
			this.gb_playerUpdate.Controls.Add(this.update_buyFirstAidKit_player);
			this.gb_playerUpdate.Controls.Add(this.update_maxHealth_player);
			this.gb_playerUpdate.Controls.Add(this.update_streight_player);
			this.gb_playerUpdate.Controls.Add(this.buy_player_3);
			this.gb_playerUpdate.Controls.Add(this.buy_player_2);
			this.gb_playerUpdate.Controls.Add(this.label18);
			this.gb_playerUpdate.Controls.Add(this.buy_player_1);
			this.gb_playerUpdate.Controls.Add(this.label16);
			this.gb_playerUpdate.Controls.Add(this.label13);
			this.gb_playerUpdate.Controls.Add(this.label12);
			this.gb_playerUpdate.Controls.Add(this.label11);
			this.gb_playerUpdate.Location = new System.Drawing.Point(12, 346);
			this.gb_playerUpdate.Name = "gb_playerUpdate";
			this.gb_playerUpdate.Size = new System.Drawing.Size(716, 382);
			this.gb_playerUpdate.TabIndex = 8;
			this.gb_playerUpdate.TabStop = false;
			this.gb_playerUpdate.Text = "прокачка";
			// 
			// update_buyFirstAidKit_player
			// 
			this.update_buyFirstAidKit_player.Location = new System.Drawing.Point(460, 197);
			this.update_buyFirstAidKit_player.Name = "update_buyFirstAidKit_player";
			this.update_buyFirstAidKit_player.Size = new System.Drawing.Size(250, 39);
			this.update_buyFirstAidKit_player.TabIndex = 2;
			this.update_buyFirstAidKit_player.Text = "купить";
			this.update_buyFirstAidKit_player.UseVisualStyleBackColor = true;
			this.update_buyFirstAidKit_player.Click += new System.EventHandler(this.update_buyFirstAidKit_player_Click);
			// 
			// update_maxHealth_player
			// 
			this.update_maxHealth_player.Location = new System.Drawing.Point(460, 144);
			this.update_maxHealth_player.Name = "update_maxHealth_player";
			this.update_maxHealth_player.Size = new System.Drawing.Size(250, 39);
			this.update_maxHealth_player.TabIndex = 2;
			this.update_maxHealth_player.Text = "купить";
			this.update_maxHealth_player.UseVisualStyleBackColor = true;
			this.update_maxHealth_player.Click += new System.EventHandler(this.update_maxHealth_player_Click);
			// 
			// update_streight_player
			// 
			this.update_streight_player.Location = new System.Drawing.Point(460, 90);
			this.update_streight_player.Name = "update_streight_player";
			this.update_streight_player.Size = new System.Drawing.Size(250, 39);
			this.update_streight_player.TabIndex = 2;
			this.update_streight_player.Text = "купить";
			this.update_streight_player.UseVisualStyleBackColor = true;
			this.update_streight_player.Click += new System.EventHandler(this.update_streight_player_Click);
			// 
			// buy_player_3
			// 
			this.buy_player_3.AutoSize = true;
			this.buy_player_3.ForeColor = System.Drawing.Color.Red;
			this.buy_player_3.Location = new System.Drawing.Point(341, 202);
			this.buy_player_3.Name = "buy_player_3";
			this.buy_player_3.Size = new System.Drawing.Size(71, 29);
			this.buy_player_3.TabIndex = 1;
			this.buy_player_3.Text = "180 $";
			// 
			// buy_player_2
			// 
			this.buy_player_2.AutoSize = true;
			this.buy_player_2.ForeColor = System.Drawing.Color.Red;
			this.buy_player_2.Location = new System.Drawing.Point(341, 149);
			this.buy_player_2.Name = "buy_player_2";
			this.buy_player_2.Size = new System.Drawing.Size(71, 29);
			this.buy_player_2.TabIndex = 1;
			this.buy_player_2.Text = "160 $";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(39, 202);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(103, 29);
			this.label18.TabIndex = 1;
			this.label18.Text = "аптечка";
			// 
			// buy_player_1
			// 
			this.buy_player_1.AutoSize = true;
			this.buy_player_1.ForeColor = System.Drawing.Color.Red;
			this.buy_player_1.Location = new System.Drawing.Point(341, 95);
			this.buy_player_1.Name = "buy_player_1";
			this.buy_player_1.Size = new System.Drawing.Size(71, 29);
			this.buy_player_1.TabIndex = 1;
			this.buy_player_1.Text = "140 $";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(39, 149);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(242, 29);
			this.label16.TabIndex = 1;
			this.label16.Text = "макс здоровье +100";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(39, 95);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(98, 29);
			this.label13.TabIndex = 1;
			this.label13.Text = "сила +1";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label12.Location = new System.Drawing.Point(309, 49);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(140, 29);
			this.label12.TabIndex = 0;
			this.label12.Text = "Стоимость";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label11.Location = new System.Drawing.Point(36, 49);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(131, 29);
			this.label11.TabIndex = 0;
			this.label11.Text = "Описание";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(788, 25);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(26, 29);
			this.label15.TabIndex = 0;
			this.label15.Text = "$";
			// 
			// gb_enemyUpdate
			// 
			this.gb_enemyUpdate.Controls.Add(this.update_buyFirstAidKit_enemy);
			this.gb_enemyUpdate.Controls.Add(this.update_maxHealth_enemy);
			this.gb_enemyUpdate.Controls.Add(this.update_streight_enemy);
			this.gb_enemyUpdate.Controls.Add(this.buy_enemy_3);
			this.gb_enemyUpdate.Controls.Add(this.buy_enemy_2);
			this.gb_enemyUpdate.Controls.Add(this.label22);
			this.gb_enemyUpdate.Controls.Add(this.buy_enemy_1);
			this.gb_enemyUpdate.Controls.Add(this.label24);
			this.gb_enemyUpdate.Controls.Add(this.label25);
			this.gb_enemyUpdate.Controls.Add(this.label26);
			this.gb_enemyUpdate.Controls.Add(this.label27);
			this.gb_enemyUpdate.Location = new System.Drawing.Point(1049, 346);
			this.gb_enemyUpdate.Name = "gb_enemyUpdate";
			this.gb_enemyUpdate.Size = new System.Drawing.Size(716, 382);
			this.gb_enemyUpdate.TabIndex = 8;
			this.gb_enemyUpdate.TabStop = false;
			this.gb_enemyUpdate.Text = "прокачка";
			// 
			// update_buyFirstAidKit_enemy
			// 
			this.update_buyFirstAidKit_enemy.Location = new System.Drawing.Point(460, 197);
			this.update_buyFirstAidKit_enemy.Name = "update_buyFirstAidKit_enemy";
			this.update_buyFirstAidKit_enemy.Size = new System.Drawing.Size(250, 39);
			this.update_buyFirstAidKit_enemy.TabIndex = 2;
			this.update_buyFirstAidKit_enemy.Text = "купить";
			this.update_buyFirstAidKit_enemy.UseVisualStyleBackColor = true;
			this.update_buyFirstAidKit_enemy.Click += new System.EventHandler(this.update_buyFirstAidKit_enemy_Click);
			// 
			// update_maxHealth_enemy
			// 
			this.update_maxHealth_enemy.Location = new System.Drawing.Point(460, 144);
			this.update_maxHealth_enemy.Name = "update_maxHealth_enemy";
			this.update_maxHealth_enemy.Size = new System.Drawing.Size(250, 39);
			this.update_maxHealth_enemy.TabIndex = 2;
			this.update_maxHealth_enemy.Text = "купить";
			this.update_maxHealth_enemy.UseVisualStyleBackColor = true;
			this.update_maxHealth_enemy.Click += new System.EventHandler(this.update_maxHealth_enemy_Click);
			// 
			// update_streight_enemy
			// 
			this.update_streight_enemy.Location = new System.Drawing.Point(460, 90);
			this.update_streight_enemy.Name = "update_streight_enemy";
			this.update_streight_enemy.Size = new System.Drawing.Size(250, 39);
			this.update_streight_enemy.TabIndex = 2;
			this.update_streight_enemy.Text = "купить";
			this.update_streight_enemy.UseVisualStyleBackColor = true;
			this.update_streight_enemy.Click += new System.EventHandler(this.update_streight_enemy_Click);
			// 
			// buy_enemy_3
			// 
			this.buy_enemy_3.AutoSize = true;
			this.buy_enemy_3.ForeColor = System.Drawing.Color.Red;
			this.buy_enemy_3.Location = new System.Drawing.Point(341, 202);
			this.buy_enemy_3.Name = "buy_enemy_3";
			this.buy_enemy_3.Size = new System.Drawing.Size(71, 29);
			this.buy_enemy_3.TabIndex = 1;
			this.buy_enemy_3.Text = "180 $";
			// 
			// buy_enemy_2
			// 
			this.buy_enemy_2.AutoSize = true;
			this.buy_enemy_2.ForeColor = System.Drawing.Color.Red;
			this.buy_enemy_2.Location = new System.Drawing.Point(341, 149);
			this.buy_enemy_2.Name = "buy_enemy_2";
			this.buy_enemy_2.Size = new System.Drawing.Size(71, 29);
			this.buy_enemy_2.TabIndex = 1;
			this.buy_enemy_2.Text = "160 $";
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Location = new System.Drawing.Point(39, 202);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(103, 29);
			this.label22.TabIndex = 1;
			this.label22.Text = "аптечка";
			// 
			// buy_enemy_1
			// 
			this.buy_enemy_1.AutoSize = true;
			this.buy_enemy_1.ForeColor = System.Drawing.Color.Red;
			this.buy_enemy_1.Location = new System.Drawing.Point(341, 95);
			this.buy_enemy_1.Name = "buy_enemy_1";
			this.buy_enemy_1.Size = new System.Drawing.Size(71, 29);
			this.buy_enemy_1.TabIndex = 1;
			this.buy_enemy_1.Text = "140 $";
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.Location = new System.Drawing.Point(39, 149);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(242, 29);
			this.label24.TabIndex = 1;
			this.label24.Text = "макс здоровье +100";
			// 
			// label25
			// 
			this.label25.AutoSize = true;
			this.label25.Location = new System.Drawing.Point(39, 95);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(98, 29);
			this.label25.TabIndex = 1;
			this.label25.Text = "сила +1";
			// 
			// label26
			// 
			this.label26.AutoSize = true;
			this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label26.Location = new System.Drawing.Point(309, 49);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(140, 29);
			this.label26.TabIndex = 0;
			this.label26.Text = "Стоимость";
			// 
			// label27
			// 
			this.label27.AutoSize = true;
			this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label27.Location = new System.Drawing.Point(36, 49);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(131, 29);
			this.label27.TabIndex = 0;
			this.label27.Text = "Описание";
			// 
			// AI
			// 
			this.AI.Enabled = true;
			this.AI.Interval = 500;
			this.AI.Tick += new System.EventHandler(this.AI_Tick);
			// 
			// Regeneration
			// 
			this.Regeneration.Enabled = true;
			this.Regeneration.Interval = 1200;
			this.Regeneration.Tick += new System.EventHandler(this.Regeneration_Tick);
			// 
			// pB_player
			// 
			this.pB_player.Location = new System.Drawing.Point(472, 231);
			this.pB_player.Maximum = 10000;
			this.pB_player.Name = "pB_player";
			this.pB_player.Size = new System.Drawing.Size(219, 34);
			this.pB_player.TabIndex = 9;
			this.pB_player.Value = 10000;
			// 
			// pB_enemy
			// 
			this.pB_enemy.Location = new System.Drawing.Point(1173, 231);
			this.pB_enemy.Maximum = 10000;
			this.pB_enemy.Name = "pB_enemy";
			this.pB_enemy.Size = new System.Drawing.Size(219, 34);
			this.pB_enemy.TabIndex = 9;
			this.pB_enemy.Value = 1000;
			// 
			// Isanyonekilled
			// 
			this.Isanyonekilled.Interval = 80;
			this.Isanyonekilled.Tick += new System.EventHandler(this.Isanyonekilled_Tick);
			// 
			// CanBuy
			// 
			this.CanBuy.Enabled = true;
			this.CanBuy.Interval = 400;
			this.CanBuy.Tick += new System.EventHandler(this.CanBuy_Tick);
			// 
			// lb_time_fight_value
			// 
			this.lb_time_fight_value.AutoSize = true;
			this.lb_time_fight_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lb_time_fight_value.ForeColor = System.Drawing.Color.Black;
			this.lb_time_fight_value.Location = new System.Drawing.Point(842, 480);
			this.lb_time_fight_value.Name = "lb_time_fight_value";
			this.lb_time_fight_value.Size = new System.Drawing.Size(49, 36);
			this.lb_time_fight_value.TabIndex = 7;
			this.lb_time_fight_value.Text = "25";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1784, 781);
			this.Controls.Add(this.pB_enemy);
			this.Controls.Add(this.pB_player);
			this.Controls.Add(this.gb_enemyUpdate);
			this.Controls.Add(this.gb_playerUpdate);
			this.Controls.Add(this.lb_time_fight_value);
			this.Controls.Add(this.lb_time_fight_text);
			this.Controls.Add(this.hitByEnemy);
			this.Controls.Add(this.hitByPlayer);
			this.Controls.Add(this.tb_enemy_miningPower);
			this.Controls.Add(this.tb_player_miningPower);
			this.Controls.Add(this.tb_enemy_armor);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.tb_player_armor);
			this.Controls.Add(this.tb_enemy_health);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.tb_player_health);
			this.Controls.Add(this.tb_enemy_streight);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.tb_player_streight);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btn_mineGold_enemy);
			this.Controls.Add(this.btn_mineGold_player);
			this.Controls.Add(this.btn_enemy);
			this.Controls.Add(this.tb_enemy_gold);
			this.Controls.Add(this.btn_player);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.tb_player_gold);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Margin = new System.Windows.Forms.Padding(7);
			this.Name = "MainForm";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.gb_playerUpdate.ResumeLayout(false);
			this.gb_playerUpdate.PerformLayout();
			this.gb_enemyUpdate.ResumeLayout(false);
			this.gb_enemyUpdate.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_player_gold;
        private System.Windows.Forms.Button btn_player;
        private System.Windows.Forms.Button btn_mineGold_player;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_player_streight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_player_health;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_player_armor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_player_miningPower;
        private System.Windows.Forms.Timer Reload;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_enemy_gold;
        private System.Windows.Forms.Button btn_enemy;
        private System.Windows.Forms.Button btn_mineGold_enemy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_enemy_streight;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_enemy_health;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_enemy_armor;
        private System.Windows.Forms.TextBox tb_enemy_miningPower;
        private System.Windows.Forms.Button hitByPlayer;
        private System.Windows.Forms.Button hitByEnemy;
        private System.Windows.Forms.Timer WhenFight;
        private System.Windows.Forms.Label lb_time_fight_text;
        private System.Windows.Forms.GroupBox gb_playerUpdate;
        private System.Windows.Forms.Button update_buyFirstAidKit_player;
        private System.Windows.Forms.Button update_maxHealth_player;
        private System.Windows.Forms.Button update_streight_player;
        private System.Windows.Forms.Label buy_player_3;
        private System.Windows.Forms.Label buy_player_2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label buy_player_1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox gb_enemyUpdate;
        private System.Windows.Forms.Button update_buyFirstAidKit_enemy;
        private System.Windows.Forms.Button update_maxHealth_enemy;
        private System.Windows.Forms.Button update_streight_enemy;
        private System.Windows.Forms.Label buy_enemy_3;
        private System.Windows.Forms.Label buy_enemy_2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label buy_enemy_1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Timer AI;
        private System.Windows.Forms.Timer Regeneration;
        private System.Windows.Forms.ProgressBar pB_player;
        private System.Windows.Forms.ProgressBar pB_enemy;
        private System.Windows.Forms.Timer Isanyonekilled;
        private System.Windows.Forms.Timer CanBuy;
        private System.Windows.Forms.Label lb_time_fight_value;
    }
}


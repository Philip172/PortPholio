
namespace EnemyClicker
{
	partial class GameForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
			this.btn_enemyFight = new System.Windows.Forms.Button();
			this.Timer_reload = new System.Windows.Forms.Timer(this.components);
			this.tb_enemyHealth = new System.Windows.Forms.TextBox();
			this.Timer_if_enemy_killed = new System.Windows.Forms.Timer(this.components);
			this.tb_money = new System.Windows.Forms.TextBox();
			this.Lb_Money = new System.Windows.Forms.Label();
			this.Lb_currentLevel = new System.Windows.Forms.Label();
			this.btn_GoToPrevousLevel = new System.Windows.Forms.Button();
			this.btn_GoToNextLevel = new System.Windows.Forms.Button();
			this.Lb_enable_Updates = new System.Windows.Forms.Label();
			this.Timer_btn_enemy_back = new System.Windows.Forms.Timer(this.components);
			this.Timer_can_buy = new System.Windows.Forms.Timer(this.components);
			this.Timer_helpers = new System.Windows.Forms.Timer(this.components);
			this.EndPunchToPlayer = new System.Windows.Forms.Timer(this.components);
			this.Lb_Health = new System.Windows.Forms.Label();
			this.healthIsNull = new System.Windows.Forms.Timer(this.components);
			this.Timer_waitingForNewFirstAidKit = new System.Windows.Forms.Timer(this.components);
			this.tb_health = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btn_buyTheHelper = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.cB_chooseHelper = new System.Windows.Forms.ComboBox();
			this.cB_chooseArmor = new System.Windows.Forms.ComboBox();
			this.cB_chooseWeapons = new System.Windows.Forms.ComboBox();
			this.btn_buyFirstAidKit = new System.Windows.Forms.Button();
			this.btn_buyTheArmor = new System.Windows.Forms.Button();
			this.btn_buyTheWeapon = new System.Windows.Forms.Button();
			this.Timer_Player_has_won = new System.Windows.Forms.Timer(this.components);
			this.tb_brackets = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.laser_attack = new System.Windows.Forms.Timer(this.components);
			this.fireWeaponDamage = new System.Windows.Forms.Timer(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.tb_armor = new System.Windows.Forms.TextBox();
			this.healArmorHealing = new System.Windows.Forms.Timer(this.components);
			this.StartForm = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.pb_play = new System.Windows.Forms.ProgressBar();
			this.btn_play = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.StartForm.SuspendLayout();
			this.SuspendLayout();
			// 
			// btn_enemyFight
			// 
			this.btn_enemyFight.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_enemyFight.Location = new System.Drawing.Point(797, 207);
			this.btn_enemyFight.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
			this.btn_enemyFight.Name = "btn_enemyFight";
			this.btn_enemyFight.Size = new System.Drawing.Size(240, 240);
			this.btn_enemyFight.TabIndex = 0;
			this.btn_enemyFight.Text = "enemy";
			this.btn_enemyFight.UseVisualStyleBackColor = true;
			this.btn_enemyFight.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_enemyFight_KeyDown);
			this.btn_enemyFight.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_enemyFight_MouseClick);
			this.btn_enemyFight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_enemyFight_MouseDown);
			this.btn_enemyFight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_enemyFight_MouseUp);
			// 
			// Timer_reload
			// 
			this.Timer_reload.Tick += new System.EventHandler(this.Timer_reload_Tick);
			// 
			// tb_enemyHealth
			// 
			this.tb_enemyHealth.BackColor = System.Drawing.Color.White;
			this.tb_enemyHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tb_enemyHealth.ForeColor = System.Drawing.Color.Black;
			this.tb_enemyHealth.Location = new System.Drawing.Point(723, 461);
			this.tb_enemyHealth.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
			this.tb_enemyHealth.Name = "tb_enemyHealth";
			this.tb_enemyHealth.ReadOnly = true;
			this.tb_enemyHealth.Size = new System.Drawing.Size(416, 35);
			this.tb_enemyHealth.TabIndex = 1;
			// 
			// Timer_if_enemy_killed
			// 
			this.Timer_if_enemy_killed.Tick += new System.EventHandler(this.Timer_if_enemy_killed_Tick);
			// 
			// tb_money
			// 
			this.tb_money.BackColor = System.Drawing.Color.White;
			this.tb_money.ForeColor = System.Drawing.Color.Black;
			this.tb_money.Location = new System.Drawing.Point(898, 89);
			this.tb_money.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
			this.tb_money.Name = "tb_money";
			this.tb_money.ReadOnly = true;
			this.tb_money.Size = new System.Drawing.Size(228, 33);
			this.tb_money.TabIndex = 2;
			this.tb_money.Text = "0 $";
			// 
			// Lb_Money
			// 
			this.Lb_Money.AutoSize = true;
			this.Lb_Money.Location = new System.Drawing.Point(792, 92);
			this.Lb_Money.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
			this.Lb_Money.Name = "Lb_Money";
			this.Lb_Money.Size = new System.Drawing.Size(91, 29);
			this.Lb_Money.TabIndex = 3;
			this.Lb_Money.Text = "Money:";
			// 
			// Lb_currentLevel
			// 
			this.Lb_currentLevel.AutoSize = true;
			this.Lb_currentLevel.Location = new System.Drawing.Point(893, 161);
			this.Lb_currentLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Lb_currentLevel.Name = "Lb_currentLevel";
			this.Lb_currentLevel.Size = new System.Drawing.Size(55, 29);
			this.Lb_currentLevel.TabIndex = 4;
			this.Lb_currentLevel.Text = "1 lvl";
			// 
			// btn_GoToPrevousLevel
			// 
			this.btn_GoToPrevousLevel.Enabled = false;
			this.btn_GoToPrevousLevel.Location = new System.Drawing.Point(820, 156);
			this.btn_GoToPrevousLevel.Margin = new System.Windows.Forms.Padding(4);
			this.btn_GoToPrevousLevel.Name = "btn_GoToPrevousLevel";
			this.btn_GoToPrevousLevel.Size = new System.Drawing.Size(66, 40);
			this.btn_GoToPrevousLevel.TabIndex = 5;
			this.btn_GoToPrevousLevel.Text = "<";
			this.btn_GoToPrevousLevel.UseVisualStyleBackColor = true;
			this.btn_GoToPrevousLevel.Click += new System.EventHandler(this.btn_GoToPrevousLevel_Click);
			// 
			// btn_GoToNextLevel
			// 
			this.btn_GoToNextLevel.Location = new System.Drawing.Point(954, 156);
			this.btn_GoToNextLevel.Margin = new System.Windows.Forms.Padding(4);
			this.btn_GoToNextLevel.Name = "btn_GoToNextLevel";
			this.btn_GoToNextLevel.Size = new System.Drawing.Size(66, 40);
			this.btn_GoToNextLevel.TabIndex = 5;
			this.btn_GoToNextLevel.Text = ">";
			this.btn_GoToNextLevel.UseVisualStyleBackColor = true;
			this.btn_GoToNextLevel.Click += new System.EventHandler(this.btn_GoToNextLevel_Click);
			// 
			// Lb_enable_Updates
			// 
			this.Lb_enable_Updates.AutoSize = true;
			this.Lb_enable_Updates.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Lb_enable_Updates.Location = new System.Drawing.Point(403, 117);
			this.Lb_enable_Updates.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Lb_enable_Updates.Name = "Lb_enable_Updates";
			this.Lb_enable_Updates.Size = new System.Drawing.Size(89, 26);
			this.Lb_enable_Updates.TabIndex = 8;
			this.Lb_enable_Updates.Text = "updates";
			this.Lb_enable_Updates.Click += new System.EventHandler(this.enable_Updates_Click);
			// 
			// Timer_btn_enemy_back
			// 
			this.Timer_btn_enemy_back.Interval = 700;
			this.Timer_btn_enemy_back.Tick += new System.EventHandler(this.btn_enemy_back_Tick);
			// 
			// Timer_can_buy
			// 
			this.Timer_can_buy.Interval = 1;
			this.Timer_can_buy.Tick += new System.EventHandler(this.can_buy_Tick);
			// 
			// Timer_helpers
			// 
			this.Timer_helpers.Interval = 1000;
			this.Timer_helpers.Tick += new System.EventHandler(this.helpers_Tick);
			// 
			// EndPunchToPlayer
			// 
			this.EndPunchToPlayer.Interval = 800;
			this.EndPunchToPlayer.Tick += new System.EventHandler(this.punch_to_player_Tick);
			// 
			// Lb_Health
			// 
			this.Lb_Health.AutoSize = true;
			this.Lb_Health.Location = new System.Drawing.Point(33, 28);
			this.Lb_Health.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Lb_Health.Name = "Lb_Health";
			this.Lb_Health.Size = new System.Drawing.Size(88, 29);
			this.Lb_Health.TabIndex = 12;
			this.Lb_Health.Text = "Health:";
			// 
			// healthIsNull
			// 
			this.healthIsNull.Enabled = true;
			this.healthIsNull.Interval = 1;
			this.healthIsNull.Tick += new System.EventHandler(this.healthIsNull_Tick);
			// 
			// Timer_waitingForNewFirstAidKit
			// 
			this.Timer_waitingForNewFirstAidKit.Interval = 5000;
			this.Timer_waitingForNewFirstAidKit.Tick += new System.EventHandler(this.waiting_for_new_first_aid_kit_Tick);
			// 
			// tb_health
			// 
			this.tb_health.BackColor = System.Drawing.Color.White;
			this.tb_health.ForeColor = System.Drawing.Color.Black;
			this.tb_health.Location = new System.Drawing.Point(139, 25);
			this.tb_health.Margin = new System.Windows.Forms.Padding(4);
			this.tb_health.Name = "tb_health";
			this.tb_health.Size = new System.Drawing.Size(228, 33);
			this.tb_health.TabIndex = 13;
			this.tb_health.Text = "100";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btn_buyTheHelper);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.cB_chooseHelper);
			this.groupBox1.Controls.Add(this.cB_chooseArmor);
			this.groupBox1.Controls.Add(this.cB_chooseWeapons);
			this.groupBox1.Controls.Add(this.btn_buyFirstAidKit);
			this.groupBox1.Controls.Add(this.btn_buyTheArmor);
			this.groupBox1.Controls.Add(this.btn_buyTheWeapon);
			this.groupBox1.ForeColor = System.Drawing.Color.Red;
			this.groupBox1.Location = new System.Drawing.Point(13, 147);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox1.Size = new System.Drawing.Size(650, 448);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			// 
			// btn_buyTheHelper
			// 
			this.btn_buyTheHelper.Location = new System.Drawing.Point(10, 223);
			this.btn_buyTheHelper.Name = "btn_buyTheHelper";
			this.btn_buyTheHelper.Size = new System.Drawing.Size(629, 51);
			this.btn_buyTheHelper.TabIndex = 14;
			this.btn_buyTheHelper.Text = "buy the helper (??? $)";
			this.btn_buyTheHelper.UseVisualStyleBackColor = true;
			this.btn_buyTheHelper.Click += new System.EventHandler(this.btn_buyTheHealper_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Location = new System.Drawing.Point(2, 287);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(139, 29);
			this.label6.TabIndex = 13;
			this.label6.Text = "помощник:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(3, 409);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(87, 29);
			this.label5.TabIndex = 13;
			this.label5.Text = "броня:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(7, 38);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(106, 29);
			this.label4.TabIndex = 13;
			this.label4.Text = "оружие:";
			// 
			// cB_chooseHelper
			// 
			this.cB_chooseHelper.FormattingEnabled = true;
			this.cB_chooseHelper.Location = new System.Drawing.Point(147, 284);
			this.cB_chooseHelper.Name = "cB_chooseHelper";
			this.cB_chooseHelper.Size = new System.Drawing.Size(491, 37);
			this.cB_chooseHelper.TabIndex = 12;
			this.cB_chooseHelper.Text = "<Лист помощников>";
			this.cB_chooseHelper.SelectedIndexChanged += new System.EventHandler(this.cB_chooseHealper_SelectedIndexChanged);
			// 
			// cB_chooseArmor
			// 
			this.cB_chooseArmor.FormattingEnabled = true;
			this.cB_chooseArmor.Location = new System.Drawing.Point(119, 406);
			this.cB_chooseArmor.Name = "cB_chooseArmor";
			this.cB_chooseArmor.Size = new System.Drawing.Size(520, 37);
			this.cB_chooseArmor.TabIndex = 12;
			this.cB_chooseArmor.Text = "<Лист брони>";
			this.cB_chooseArmor.SelectedIndexChanged += new System.EventHandler(this.cB_chooseArmor_SelectedIndexChanged);
			// 
			// cB_chooseWeapons
			// 
			this.cB_chooseWeapons.BackColor = System.Drawing.Color.White;
			this.cB_chooseWeapons.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cB_chooseWeapons.ForeColor = System.Drawing.Color.Black;
			this.cB_chooseWeapons.FormattingEnabled = true;
			this.cB_chooseWeapons.Location = new System.Drawing.Point(119, 32);
			this.cB_chooseWeapons.Name = "cB_chooseWeapons";
			this.cB_chooseWeapons.Size = new System.Drawing.Size(520, 39);
			this.cB_chooseWeapons.TabIndex = 11;
			this.cB_chooseWeapons.Text = "<Лист оружий>";
			this.cB_chooseWeapons.SelectedIndexChanged += new System.EventHandler(this.cB_chooseWeapons_SelectedIndexChanged);
			// 
			// btn_buyFirstAidKit
			// 
			this.btn_buyFirstAidKit.Location = new System.Drawing.Point(10, 137);
			this.btn_buyFirstAidKit.Margin = new System.Windows.Forms.Padding(4);
			this.btn_buyFirstAidKit.Name = "btn_buyFirstAidKit";
			this.btn_buyFirstAidKit.Size = new System.Drawing.Size(318, 51);
			this.btn_buyFirstAidKit.TabIndex = 10;
			this.btn_buyFirstAidKit.Text = "buy first-aid kit (500 $)";
			this.btn_buyFirstAidKit.UseVisualStyleBackColor = true;
			this.btn_buyFirstAidKit.Click += new System.EventHandler(this.buy_4_Click);
			// 
			// btn_buyTheArmor
			// 
			this.btn_buyTheArmor.ForeColor = System.Drawing.Color.Red;
			this.btn_buyTheArmor.Location = new System.Drawing.Point(10, 346);
			this.btn_buyTheArmor.Margin = new System.Windows.Forms.Padding(4);
			this.btn_buyTheArmor.Name = "btn_buyTheArmor";
			this.btn_buyTheArmor.Size = new System.Drawing.Size(629, 51);
			this.btn_buyTheArmor.TabIndex = 7;
			this.btn_buyTheArmor.Text = "buy the armor (??? $)";
			this.btn_buyTheArmor.UseVisualStyleBackColor = true;
			this.btn_buyTheArmor.Click += new System.EventHandler(this.btn_buyTheArmor_Click);
			// 
			// btn_buyTheWeapon
			// 
			this.btn_buyTheWeapon.ForeColor = System.Drawing.Color.Red;
			this.btn_buyTheWeapon.Location = new System.Drawing.Point(10, 78);
			this.btn_buyTheWeapon.Margin = new System.Windows.Forms.Padding(4);
			this.btn_buyTheWeapon.Name = "btn_buyTheWeapon";
			this.btn_buyTheWeapon.Size = new System.Drawing.Size(629, 51);
			this.btn_buyTheWeapon.TabIndex = 7;
			this.btn_buyTheWeapon.Text = "buy the weapon (??? $)";
			this.btn_buyTheWeapon.UseVisualStyleBackColor = true;
			this.btn_buyTheWeapon.Click += new System.EventHandler(this.btn_buyTheWeapon_Click);
			// 
			// Timer_Player_has_won
			// 
			this.Timer_Player_has_won.Interval = 1000;
			this.Timer_Player_has_won.Tick += new System.EventHandler(this.Player_has_won_Tick);
			// 
			// tb_brackets
			// 
			this.tb_brackets.BackColor = System.Drawing.Color.White;
			this.tb_brackets.ForeColor = System.Drawing.Color.Black;
			this.tb_brackets.Location = new System.Drawing.Point(383, 68);
			this.tb_brackets.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
			this.tb_brackets.Name = "tb_brackets";
			this.tb_brackets.ReadOnly = true;
			this.tb_brackets.Size = new System.Drawing.Size(228, 33);
			this.tb_brackets.TabIndex = 2;
			this.tb_brackets.Text = "0 </>";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(1302, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(320, 70);
			this.button1.TabIndex = 14;
			this.button1.Text = "Open Console";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// laser_attack
			// 
			this.laser_attack.Interval = 40;
			this.laser_attack.Tick += new System.EventHandler(this.laser_attack_Tick);
			// 
			// fireWeaponDamage
			// 
			this.fireWeaponDamage.Interval = 1000;
			this.fireWeaponDamage.Tick += new System.EventHandler(this.fireWeaponDamage_Tick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(37, 72);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(84, 29);
			this.label1.TabIndex = 15;
			this.label1.Text = "Armor:";
			// 
			// tb_armor
			// 
			this.tb_armor.Location = new System.Drawing.Point(139, 69);
			this.tb_armor.Name = "tb_armor";
			this.tb_armor.Size = new System.Drawing.Size(228, 33);
			this.tb_armor.TabIndex = 16;
			this.tb_armor.Text = "0";
			// 
			// healArmorHealing
			// 
			this.healArmorHealing.Interval = 900;
			this.healArmorHealing.Tick += new System.EventHandler(this.healArmorHealing_Tick);
			// 
			// StartForm
			// 
			this.StartForm.Controls.Add(this.label3);
			this.StartForm.Controls.Add(this.pb_play);
			this.StartForm.Controls.Add(this.btn_play);
			this.StartForm.Controls.Add(this.label2);
			this.StartForm.Location = new System.Drawing.Point(1438, 553);
			this.StartForm.Name = "StartForm";
			this.StartForm.Size = new System.Drawing.Size(1550, 1080);
			this.StartForm.TabIndex = 17;
			this.StartForm.TabStop = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(23, 29);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(133, 29);
			this.label3.TabIndex = 3;
			this.label3.Text = "//StartForm";
			this.label3.Visible = false;
			// 
			// pb_play
			// 
			this.pb_play.Location = new System.Drawing.Point(725, 201);
			this.pb_play.Maximum = 10;
			this.pb_play.Name = "pb_play";
			this.pb_play.Size = new System.Drawing.Size(222, 15);
			this.pb_play.TabIndex = 2;
			this.pb_play.Visible = false;
			// 
			// btn_play
			// 
			this.btn_play.Location = new System.Drawing.Point(563, 145);
			this.btn_play.Name = "btn_play";
			this.btn_play.Size = new System.Drawing.Size(384, 73);
			this.btn_play.TabIndex = 1;
			this.btn_play.Text = "Играть";
			this.btn_play.UseVisualStyleBackColor = true;
			this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(601, 29);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(301, 51);
			this.label2.TabIndex = 0;
			this.label2.Text = "Enemy Clicker";
			// 
			// GameForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1682, 636);
			this.Controls.Add(this.StartForm);
			this.Controls.Add(this.tb_armor);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.tb_health);
			this.Controls.Add(this.Lb_Health);
			this.Controls.Add(this.Lb_enable_Updates);
			this.Controls.Add(this.btn_GoToNextLevel);
			this.Controls.Add(this.btn_GoToPrevousLevel);
			this.Controls.Add(this.Lb_currentLevel);
			this.Controls.Add(this.Lb_Money);
			this.Controls.Add(this.tb_brackets);
			this.Controls.Add(this.tb_money);
			this.Controls.Add(this.tb_enemyHealth);
			this.Controls.Add(this.btn_enemyFight);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
			this.Name = "GameForm";
			this.Text = "EnemyClicker";
			this.Load += new System.EventHandler(this.GameForm_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.StartForm.ResumeLayout(false);
			this.StartForm.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_enemyFight;
		private System.Windows.Forms.Timer Timer_reload;
		private System.Windows.Forms.TextBox tb_enemyHealth;
		private System.Windows.Forms.Timer Timer_if_enemy_killed;
		private System.Windows.Forms.TextBox tb_money;
		private System.Windows.Forms.Label Lb_Money;
		private System.Windows.Forms.Label Lb_currentLevel;
		private System.Windows.Forms.Button btn_GoToPrevousLevel;
		private System.Windows.Forms.Button btn_GoToNextLevel;
		private System.Windows.Forms.Label Lb_enable_Updates;
		private System.Windows.Forms.Timer Timer_btn_enemy_back;
		private System.Windows.Forms.Timer Timer_can_buy;
		private System.Windows.Forms.Timer Timer_helpers;
		private System.Windows.Forms.Timer EndPunchToPlayer;
		private System.Windows.Forms.Label Lb_Health;
		private System.Windows.Forms.Timer healthIsNull;
		private System.Windows.Forms.Timer Timer_waitingForNewFirstAidKit;
        private System.Windows.Forms.TextBox tb_health;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_buyTheWeapon;
        private System.Windows.Forms.ComboBox cB_chooseWeapons;
        private System.Windows.Forms.Button btn_buyFirstAidKit;
        private System.Windows.Forms.Timer Timer_Player_has_won;
        private System.Windows.Forms.TextBox tb_brackets;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer laser_attack;
        private System.Windows.Forms.Timer fireWeaponDamage;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tb_armor;
		private System.Windows.Forms.ComboBox cB_chooseArmor;
		private System.Windows.Forms.Button btn_buyTheArmor;
		private System.Windows.Forms.Timer healArmorHealing;
		private System.Windows.Forms.GroupBox StartForm;
		private System.Windows.Forms.ProgressBar pb_play;
		private System.Windows.Forms.Button btn_play;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btn_buyTheHelper;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cB_chooseHelper;
	}
}


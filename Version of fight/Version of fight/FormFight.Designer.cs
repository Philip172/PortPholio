namespace Version_of_fight
{
    partial class FormFight
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFight));
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tb_enemy_streight = new System.Windows.Forms.TextBox();
            this.tb_enemy_health = new System.Windows.Forms.TextBox();
            this.tb_your_streight = new System.Windows.Forms.TextBox();
            this.tb_your_health = new System.Windows.Forms.TextBox();
            this.tb_updatePoints = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_your_ShansOfHit = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Textboxes_reload = new System.Windows.Forms.Timer(this.components);
            this.tb_your_armor = new System.Windows.Forms.TextBox();
            this.prBar_player = new System.Windows.Forms.ProgressBar();
            this.prBar_enemy = new System.Windows.Forms.ProgressBar();
            this.tb_enemy_armor = new System.Windows.Forms.TextBox();
            this.btn_updates = new System.Windows.Forms.Button();
            this.btn_gotoMenu = new System.Windows.Forms.Button();
            this.attack_you = new System.Windows.Forms.Timer(this.components);
            this.atk = new System.Windows.Forms.Button();
            this.Player = new System.Windows.Forms.PictureBox();
            this.ToLeft = new System.Windows.Forms.Timer(this.components);
            this.ToUp = new System.Windows.Forms.Timer(this.components);
            this.ToBottom = new System.Windows.Forms.Timer(this.components);
            this.ToRight = new System.Windows.Forms.Timer(this.components);
            this.go_to_you = new System.Windows.Forms.Timer(this.components);
            this.DamageZone = new System.Windows.Forms.PictureBox();
            this.btn_speed = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.WarZone = new System.Windows.Forms.PictureBox();
            this.btn_slow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DamageZone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WarZone)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Blue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(499, 667);
            this.button2.Margin = new System.Windows.Forms.Padding(6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 107);
            this.button2.TabIndex = 1;
            this.button2.Text = "Ты";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Blue;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(499, 103);
            this.button3.Margin = new System.Windows.Forms.Padding(6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(157, 107);
            this.button3.TabIndex = 2;
            this.button3.Text = "Противник";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // tb_enemy_streight
            // 
            this.tb_enemy_streight.BackColor = System.Drawing.Color.White;
            this.tb_enemy_streight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_enemy_streight.ForeColor = System.Drawing.Color.Red;
            this.tb_enemy_streight.Location = new System.Drawing.Point(737, 44);
            this.tb_enemy_streight.Margin = new System.Windows.Forms.Padding(6);
            this.tb_enemy_streight.Name = "tb_enemy_streight";
            this.tb_enemy_streight.ReadOnly = true;
            this.tb_enemy_streight.Size = new System.Drawing.Size(220, 38);
            this.tb_enemy_streight.TabIndex = 9;
            this.tb_enemy_streight.Text = "1";
            // 
            // tb_enemy_health
            // 
            this.tb_enemy_health.BackColor = System.Drawing.Color.White;
            this.tb_enemy_health.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_enemy_health.ForeColor = System.Drawing.Color.Green;
            this.tb_enemy_health.Location = new System.Drawing.Point(737, 94);
            this.tb_enemy_health.Margin = new System.Windows.Forms.Padding(6);
            this.tb_enemy_health.Name = "tb_enemy_health";
            this.tb_enemy_health.ReadOnly = true;
            this.tb_enemy_health.Size = new System.Drawing.Size(220, 38);
            this.tb_enemy_health.TabIndex = 10;
            this.tb_enemy_health.Text = "10";
            // 
            // tb_your_streight
            // 
            this.tb_your_streight.BackColor = System.Drawing.Color.White;
            this.tb_your_streight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_your_streight.ForeColor = System.Drawing.Color.Red;
            this.tb_your_streight.Location = new System.Drawing.Point(252, 676);
            this.tb_your_streight.Margin = new System.Windows.Forms.Padding(6);
            this.tb_your_streight.Name = "tb_your_streight";
            this.tb_your_streight.ReadOnly = true;
            this.tb_your_streight.Size = new System.Drawing.Size(220, 38);
            this.tb_your_streight.TabIndex = 9;
            this.tb_your_streight.Text = "1";
            // 
            // tb_your_health
            // 
            this.tb_your_health.BackColor = System.Drawing.Color.White;
            this.tb_your_health.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_your_health.ForeColor = System.Drawing.Color.Green;
            this.tb_your_health.Location = new System.Drawing.Point(252, 726);
            this.tb_your_health.Margin = new System.Windows.Forms.Padding(6);
            this.tb_your_health.Name = "tb_your_health";
            this.tb_your_health.ReadOnly = true;
            this.tb_your_health.Size = new System.Drawing.Size(220, 38);
            this.tb_your_health.TabIndex = 10;
            this.tb_your_health.Text = "10";
            // 
            // tb_updatePoints
            // 
            this.tb_updatePoints.BackColor = System.Drawing.Color.White;
            this.tb_updatePoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_updatePoints.ForeColor = System.Drawing.Color.Gold;
            this.tb_updatePoints.Location = new System.Drawing.Point(825, 691);
            this.tb_updatePoints.Margin = new System.Windows.Forms.Padding(6);
            this.tb_updatePoints.Name = "tb_updatePoints";
            this.tb_updatePoints.ReadOnly = true;
            this.tb_updatePoints.Size = new System.Drawing.Size(220, 38);
            this.tb_updatePoints.TabIndex = 13;
            this.tb_updatePoints.Text = "15 $";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(835, 656);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(194, 29);
            this.label8.TabIndex = 14;
            this.label8.Text = "Очки апгрейда:";
            // 
            // tb_your_ShansOfHit
            // 
            this.tb_your_ShansOfHit.BackColor = System.Drawing.Color.White;
            this.tb_your_ShansOfHit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_your_ShansOfHit.ForeColor = System.Drawing.Color.Aqua;
            this.tb_your_ShansOfHit.Location = new System.Drawing.Point(252, 776);
            this.tb_your_ShansOfHit.Margin = new System.Windows.Forms.Padding(6);
            this.tb_your_ShansOfHit.Name = "tb_your_ShansOfHit";
            this.tb_your_ShansOfHit.ReadOnly = true;
            this.tb_your_ShansOfHit.Size = new System.Drawing.Size(220, 38);
            this.tb_your_ShansOfHit.TabIndex = 36;
            this.tb_your_ShansOfHit.Text = "20";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(277, 641);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 29);
            this.label10.TabIndex = 38;
            this.label10.Text = "Уровень: 1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(726, 9);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 29);
            this.label11.TabIndex = 39;
            this.label11.Text = "Уровень: 1";
            // 
            // Textboxes_reload
            // 
            this.Textboxes_reload.Enabled = true;
            this.Textboxes_reload.Tick += new System.EventHandler(this.Textboxes_reload_Tick);
            // 
            // tb_your_armor
            // 
            this.tb_your_armor.BackColor = System.Drawing.Color.White;
            this.tb_your_armor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_your_armor.ForeColor = System.Drawing.Color.DarkGray;
            this.tb_your_armor.Location = new System.Drawing.Point(252, 826);
            this.tb_your_armor.Margin = new System.Windows.Forms.Padding(6);
            this.tb_your_armor.Name = "tb_your_armor";
            this.tb_your_armor.ReadOnly = true;
            this.tb_your_armor.Size = new System.Drawing.Size(220, 38);
            this.tb_your_armor.TabIndex = 36;
            this.tb_your_armor.Text = "30";
            // 
            // prBar_player
            // 
            this.prBar_player.Location = new System.Drawing.Point(499, 648);
            this.prBar_player.Name = "prBar_player";
            this.prBar_player.Size = new System.Drawing.Size(157, 27);
            this.prBar_player.TabIndex = 43;
            // 
            // prBar_enemy
            // 
            this.prBar_enemy.Location = new System.Drawing.Point(499, 183);
            this.prBar_enemy.Name = "prBar_enemy";
            this.prBar_enemy.Size = new System.Drawing.Size(157, 27);
            this.prBar_enemy.TabIndex = 43;
            // 
            // tb_enemy_armor
            // 
            this.tb_enemy_armor.BackColor = System.Drawing.Color.White;
            this.tb_enemy_armor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_enemy_armor.ForeColor = System.Drawing.Color.DarkGray;
            this.tb_enemy_armor.Location = new System.Drawing.Point(737, 144);
            this.tb_enemy_armor.Margin = new System.Windows.Forms.Padding(6);
            this.tb_enemy_armor.Name = "tb_enemy_armor";
            this.tb_enemy_armor.ReadOnly = true;
            this.tb_enemy_armor.Size = new System.Drawing.Size(220, 38);
            this.tb_enemy_armor.TabIndex = 36;
            this.tb_enemy_armor.Text = "1";
            // 
            // btn_updates
            // 
            this.btn_updates.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_updates.Location = new System.Drawing.Point(12, 65);
            this.btn_updates.Name = "btn_updates";
            this.btn_updates.Size = new System.Drawing.Size(209, 47);
            this.btn_updates.TabIndex = 44;
            this.btn_updates.Text = "Улучшения";
            this.btn_updates.UseVisualStyleBackColor = true;
            this.btn_updates.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // btn_gotoMenu
            // 
            this.btn_gotoMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_gotoMenu.Location = new System.Drawing.Point(12, 12);
            this.btn_gotoMenu.Name = "btn_gotoMenu";
            this.btn_gotoMenu.Size = new System.Drawing.Size(209, 47);
            this.btn_gotoMenu.TabIndex = 44;
            this.btn_gotoMenu.Text = "В меню";
            this.btn_gotoMenu.UseVisualStyleBackColor = true;
            this.btn_gotoMenu.Click += new System.EventHandler(this.btn_gotoMenu_Click);
            // 
            // attack_you
            // 
            this.attack_you.Interval = 200;
            this.attack_you.Tick += new System.EventHandler(this.attack_you_Tick);
            // 
            // atk
            // 
            this.atk.BackColor = System.Drawing.Color.Red;
            this.atk.Location = new System.Drawing.Point(568, 288);
            this.atk.Name = "atk";
            this.atk.Size = new System.Drawing.Size(40, 40);
            this.atk.TabIndex = 46;
            this.atk.UseVisualStyleBackColor = false;
            this.atk.Click += new System.EventHandler(this.atk_Click);
            this.atk.KeyDown += new System.Windows.Forms.KeyEventHandler(this.atk_KeyDown);
            this.atk.KeyUp += new System.Windows.Forms.KeyEventHandler(this.atk_KeyUp);
            // 
            // Player
            // 
            this.Player.Image = ((System.Drawing.Image)(resources.GetObject("Player.Image")));
            this.Player.Location = new System.Drawing.Point(610, 563);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(20, 20);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player.TabIndex = 47;
            this.Player.TabStop = false;
            // 
            // ToLeft
            // 
            this.ToLeft.Interval = 4;
            this.ToLeft.Tick += new System.EventHandler(this.ToLeft_Tick);
            // 
            // ToUp
            // 
            this.ToUp.Interval = 4;
            this.ToUp.Tick += new System.EventHandler(this.ToUp_Tick);
            // 
            // ToBottom
            // 
            this.ToBottom.Interval = 4;
            this.ToBottom.Tick += new System.EventHandler(this.ToBottom_Tick);
            // 
            // ToRight
            // 
            this.ToRight.Interval = 4;
            this.ToRight.Tick += new System.EventHandler(this.ToRight_Tick);
            // 
            // go_to_you
            // 
            this.go_to_you.Interval = 13;
            this.go_to_you.Tick += new System.EventHandler(this.go_to_you_Tick);
            // 
            // DamageZone
            // 
            this.DamageZone.BackColor = System.Drawing.Color.Lime;
            this.DamageZone.Location = new System.Drawing.Point(499, 560);
            this.DamageZone.Name = "DamageZone";
            this.DamageZone.Size = new System.Drawing.Size(80, 30);
            this.DamageZone.TabIndex = 48;
            this.DamageZone.TabStop = false;
            // 
            // btn_speed
            // 
            this.btn_speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_speed.Location = new System.Drawing.Point(525, 783);
            this.btn_speed.Name = "btn_speed";
            this.btn_speed.Size = new System.Drawing.Size(302, 43);
            this.btn_speed.TabIndex = 49;
            this.btn_speed.Text = "Ускориться! [SHIFT]";
            this.btn_speed.UseVisualStyleBackColor = true;
            this.btn_speed.Click += new System.EventHandler(this.btn_speed_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(966, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 42);
            this.button1.TabIndex = 50;
            this.button1.Text = "reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(206, 726);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 38);
            this.pictureBox2.TabIndex = 51;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(206, 826);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(37, 38);
            this.pictureBox3.TabIndex = 52;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(206, 776);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(37, 38);
            this.pictureBox4.TabIndex = 52;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(206, 676);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(37, 38);
            this.pictureBox5.TabIndex = 52;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(691, 44);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(37, 38);
            this.pictureBox6.TabIndex = 54;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox7.BackgroundImage")));
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.Location = new System.Drawing.Point(691, 94);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(37, 38);
            this.pictureBox7.TabIndex = 53;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox8.BackgroundImage")));
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox8.Location = new System.Drawing.Point(691, 144);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(37, 38);
            this.pictureBox8.TabIndex = 55;
            this.pictureBox8.TabStop = false;
            // 
            // WarZone
            // 
            this.WarZone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("WarZone.BackgroundImage")));
            this.WarZone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.WarZone.Location = new System.Drawing.Point(-18, 227);
            this.WarZone.Name = "WarZone";
            this.WarZone.Size = new System.Drawing.Size(1200, 405);
            this.WarZone.TabIndex = 56;
            this.WarZone.TabStop = false;
            // 
            // btn_slow
            // 
            this.btn_slow.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_slow.Location = new System.Drawing.Point(525, 832);
            this.btn_slow.Name = "btn_slow";
            this.btn_slow.Size = new System.Drawing.Size(350, 43);
            this.btn_slow.TabIndex = 49;
            this.btn_slow.Text = "Замедлить противника! [F]";
            this.btn_slow.UseVisualStyleBackColor = true;
            this.btn_slow.Click += new System.EventHandler(this.button4_Click);
            // 
            // FormFight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 961);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_slow);
            this.Controls.Add(this.btn_speed);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.atk);
            this.Controls.Add(this.DamageZone);
            this.Controls.Add(this.btn_gotoMenu);
            this.Controls.Add(this.btn_updates);
            this.Controls.Add(this.prBar_enemy);
            this.Controls.Add(this.prBar_player);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_enemy_armor);
            this.Controls.Add(this.tb_your_armor);
            this.Controls.Add(this.tb_your_ShansOfHit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_updatePoints);
            this.Controls.Add(this.tb_your_health);
            this.Controls.Add(this.tb_enemy_health);
            this.Controls.Add(this.tb_your_streight);
            this.Controls.Add(this.tb_enemy_streight);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.WarZone);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormFight";
            this.Text = "Version of fight";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Fight_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DamageZone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WarZone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tb_enemy_streight;
        private System.Windows.Forms.TextBox tb_enemy_health;
        private System.Windows.Forms.TextBox tb_your_streight;
        private System.Windows.Forms.TextBox tb_your_health;
        private System.Windows.Forms.TextBox tb_updatePoints;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_your_ShansOfHit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Timer Textboxes_reload;
        private System.Windows.Forms.TextBox tb_your_armor;
        private System.Windows.Forms.ProgressBar prBar_player;
        private System.Windows.Forms.ProgressBar prBar_enemy;
        private System.Windows.Forms.TextBox tb_enemy_armor;
        private System.Windows.Forms.Button btn_updates;
        private System.Windows.Forms.Button btn_gotoMenu;
        private System.Windows.Forms.Timer attack_you;
        private System.Windows.Forms.Button atk;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Timer ToLeft;
        private System.Windows.Forms.Timer ToUp;
        private System.Windows.Forms.Timer ToBottom;
        private System.Windows.Forms.Timer ToRight;
        private System.Windows.Forms.Timer go_to_you;
        private System.Windows.Forms.PictureBox DamageZone;
        private System.Windows.Forms.Button btn_speed;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox WarZone;
        private System.Windows.Forms.Button btn_slow;
    }
}


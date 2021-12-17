namespace Learning_values_of_trigonometer
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.value_top = new System.Windows.Forms.Button();
			this.value_left = new System.Windows.Forms.Button();
			this.value_bottom = new System.Windows.Forms.Button();
			this.value_right = new System.Windows.Forms.Button();
			this.lb_title = new System.Windows.Forms.Label();
			this.tb_warning = new System.Windows.Forms.Label();
			this.tb_top = new System.Windows.Forms.ComboBox();
			this.tb_left = new System.Windows.Forms.ComboBox();
			this.tb_bottom = new System.Windows.Forms.ComboBox();
			this.tb_right = new System.Windows.Forms.ComboBox();
			this.btn_toExam = new System.Windows.Forms.Button();
			this.MainStart = new System.Windows.Forms.GroupBox();
			this.btn_resetAllSettingsInStart = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.pB_changeLang = new System.Windows.Forms.GroupBox();
			this.btn_exit = new System.Windows.Forms.Button();
			this.cB_languages = new System.Windows.Forms.ComboBox();
			this.btn_changeLangOn = new System.Windows.Forms.Button();
			this.pB_startProgress = new System.Windows.Forms.ProgressBar();
			this.btn_changeLang = new System.Windows.Forms.Button();
			this.btn_start = new System.Windows.Forms.Button();
			this.lb_titleStart = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.btn_resetAllSettings = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.MainStart.SuspendLayout();
			this.pB_changeLang.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox1.Location = new System.Drawing.Point(197, 181);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(476, 474);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// value_top
			// 
			this.value_top.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.value_top.Location = new System.Drawing.Point(396, 123);
			this.value_top.Name = "value_top";
			this.value_top.Size = new System.Drawing.Size(87, 64);
			this.value_top.TabIndex = 1;
			this.value_top.Text = "?";
			this.value_top.UseVisualStyleBackColor = true;
			this.value_top.MouseClick += new System.Windows.Forms.MouseEventHandler(this.value_top_MouseClick);
			// 
			// value_left
			// 
			this.value_left.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.value_left.Location = new System.Drawing.Point(111, 381);
			this.value_left.Name = "value_left";
			this.value_left.Size = new System.Drawing.Size(87, 64);
			this.value_left.TabIndex = 1;
			this.value_left.Text = "?";
			this.value_left.UseVisualStyleBackColor = true;
			this.value_left.MouseClick += new System.Windows.Forms.MouseEventHandler(this.value_left_MouseClick);
			// 
			// value_bottom
			// 
			this.value_bottom.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.value_bottom.Location = new System.Drawing.Point(396, 647);
			this.value_bottom.Name = "value_bottom";
			this.value_bottom.Size = new System.Drawing.Size(87, 64);
			this.value_bottom.TabIndex = 1;
			this.value_bottom.Text = "?";
			this.value_bottom.UseVisualStyleBackColor = true;
			this.value_bottom.MouseClick += new System.Windows.Forms.MouseEventHandler(this.value_bottom_MouseClick);
			// 
			// value_right
			// 
			this.value_right.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.value_right.Location = new System.Drawing.Point(672, 381);
			this.value_right.Name = "value_right";
			this.value_right.Size = new System.Drawing.Size(87, 64);
			this.value_right.TabIndex = 1;
			this.value_right.Text = "?";
			this.value_right.UseVisualStyleBackColor = true;
			this.value_right.MouseClick += new System.Windows.Forms.MouseEventHandler(this.value_right_MouseClick);
			// 
			// lb_title
			// 
			this.lb_title.AutoSize = true;
			this.lb_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lb_title.Location = new System.Drawing.Point(163, 9);
			this.lb_title.Name = "lb_title";
			this.lb_title.Size = new System.Drawing.Size(495, 51);
			this.lb_title.TabIndex = 3;
			this.lb_title.Text = "Углы четвертей радиан";
			// 
			// tb_warning
			// 
			this.tb_warning.AutoSize = true;
			this.tb_warning.BackColor = System.Drawing.Color.Lime;
			this.tb_warning.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tb_warning.ForeColor = System.Drawing.Color.Red;
			this.tb_warning.Location = new System.Drawing.Point(265, 371);
			this.tb_warning.Name = "tb_warning";
			this.tb_warning.Size = new System.Drawing.Size(353, 59);
			this.tb_warning.TabIndex = 5;
			this.tb_warning.Text = "<выше/ниже>";
			this.tb_warning.Visible = false;
			// 
			// tb_top
			// 
			this.tb_top.FormattingEnabled = true;
			this.tb_top.Items.AddRange(new object[] {
            "0",
            "1,57",
            "3,14",
            "4,71"});
			this.tb_top.Location = new System.Drawing.Point(383, 95);
			this.tb_top.Name = "tb_top";
			this.tb_top.Size = new System.Drawing.Size(115, 33);
			this.tb_top.TabIndex = 6;
			this.tb_top.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_top_KeyDown);
			// 
			// tb_left
			// 
			this.tb_left.FormattingEnabled = true;
			this.tb_left.Items.AddRange(new object[] {
            "0",
            "1,57",
            "3,14",
            "4,71"});
			this.tb_left.Location = new System.Drawing.Point(36, 396);
			this.tb_left.Name = "tb_left";
			this.tb_left.Size = new System.Drawing.Size(115, 33);
			this.tb_left.TabIndex = 6;
			this.tb_left.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_left_KeyDown);
			// 
			// tb_bottom
			// 
			this.tb_bottom.FormattingEnabled = true;
			this.tb_bottom.Items.AddRange(new object[] {
            "0",
            "1,57",
            "3,14",
            "4,71"});
			this.tb_bottom.Location = new System.Drawing.Point(383, 697);
			this.tb_bottom.Name = "tb_bottom";
			this.tb_bottom.Size = new System.Drawing.Size(115, 33);
			this.tb_bottom.TabIndex = 6;
			this.tb_bottom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_bottom_KeyDown);
			// 
			// tb_right
			// 
			this.tb_right.FormattingEnabled = true;
			this.tb_right.Items.AddRange(new object[] {
            "0",
            "1,57",
            "3,14",
            "4,71"});
			this.tb_right.Location = new System.Drawing.Point(734, 396);
			this.tb_right.Name = "tb_right";
			this.tb_right.Size = new System.Drawing.Size(115, 33);
			this.tb_right.TabIndex = 6;
			this.tb_right.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_right_KeyDown);
			// 
			// btn_toExam
			// 
			this.btn_toExam.Location = new System.Drawing.Point(12, 74);
			this.btn_toExam.Name = "btn_toExam";
			this.btn_toExam.Size = new System.Drawing.Size(171, 42);
			this.btn_toExam.TabIndex = 7;
			this.btn_toExam.Text = "экзаменовать!";
			this.btn_toExam.UseVisualStyleBackColor = true;
			this.btn_toExam.Click += new System.EventHandler(this.btn_toExam_Click);
			// 
			// MainStart
			// 
			this.MainStart.BackColor = System.Drawing.Color.Aqua;
			this.MainStart.Controls.Add(this.btn_resetAllSettingsInStart);
			this.MainStart.Controls.Add(this.label1);
			this.MainStart.Controls.Add(this.pB_changeLang);
			this.MainStart.Controls.Add(this.pB_startProgress);
			this.MainStart.Controls.Add(this.btn_changeLang);
			this.MainStart.Controls.Add(this.btn_start);
			this.MainStart.Controls.Add(this.lb_titleStart);
			this.MainStart.Controls.Add(this.pictureBox2);
			this.MainStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.MainStart.Location = new System.Drawing.Point(693, 721);
			this.MainStart.Name = "MainStart";
			this.MainStart.Size = new System.Drawing.Size(920, 830);
			this.MainStart.TabIndex = 9;
			this.MainStart.TabStop = false;
			// 
			// btn_resetAllSettingsInStart
			// 
			this.btn_resetAllSettingsInStart.Location = new System.Drawing.Point(12, 704);
			this.btn_resetAllSettingsInStart.Name = "btn_resetAllSettingsInStart";
			this.btn_resetAllSettingsInStart.Size = new System.Drawing.Size(352, 76);
			this.btn_resetAllSettingsInStart.TabIndex = 6;
			this.btn_resetAllSettingsInStart.Text = "RESET ALL SETTINGS\r\n";
			this.btn_resetAllSettingsInStart.UseVisualStyleBackColor = true;
			this.btn_resetAllSettingsInStart.Click += new System.EventHandler(this.btn_resetAllSettingsInStart_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.Green;
			this.label1.Location = new System.Drawing.Point(6, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(197, 29);
			this.label1.TabIndex = 5;
			this.label1.Text = "//Form: MainStart";
			this.label1.Visible = false;
			// 
			// pB_changeLang
			// 
			this.pB_changeLang.Controls.Add(this.btn_exit);
			this.pB_changeLang.Controls.Add(this.cB_languages);
			this.pB_changeLang.Controls.Add(this.btn_changeLangOn);
			this.pB_changeLang.Location = new System.Drawing.Point(396, 644);
			this.pB_changeLang.Name = "pB_changeLang";
			this.pB_changeLang.Size = new System.Drawing.Size(492, 123);
			this.pB_changeLang.TabIndex = 4;
			this.pB_changeLang.TabStop = false;
			this.pB_changeLang.Visible = false;
			// 
			// btn_exit
			// 
			this.btn_exit.Location = new System.Drawing.Point(263, 78);
			this.btn_exit.Name = "btn_exit";
			this.btn_exit.Size = new System.Drawing.Size(207, 40);
			this.btn_exit.TabIndex = 5;
			this.btn_exit.Text = "выход";
			this.btn_exit.UseVisualStyleBackColor = true;
			this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
			// 
			// cB_languages
			// 
			this.cB_languages.FormattingEnabled = true;
			this.cB_languages.Items.AddRange(new object[] {
            "-",
            "Русский",
            "English",
            "Francais"});
			this.cB_languages.Location = new System.Drawing.Point(6, 32);
			this.cB_languages.Name = "cB_languages";
			this.cB_languages.Size = new System.Drawing.Size(464, 37);
			this.cB_languages.TabIndex = 4;
			this.cB_languages.Text = "-";
			// 
			// btn_changeLangOn
			// 
			this.btn_changeLangOn.Location = new System.Drawing.Point(6, 78);
			this.btn_changeLangOn.Name = "btn_changeLangOn";
			this.btn_changeLangOn.Size = new System.Drawing.Size(251, 40);
			this.btn_changeLangOn.TabIndex = 3;
			this.btn_changeLangOn.Text = "сменить язык!";
			this.btn_changeLangOn.UseVisualStyleBackColor = true;
			this.btn_changeLangOn.Click += new System.EventHandler(this.btn_changeLangOn_Click);
			// 
			// pB_startProgress
			// 
			this.pB_startProgress.Location = new System.Drawing.Point(168, 353);
			this.pB_startProgress.Maximum = 5;
			this.pB_startProgress.Name = "pB_startProgress";
			this.pB_startProgress.Size = new System.Drawing.Size(498, 23);
			this.pB_startProgress.TabIndex = 2;
			this.pB_startProgress.Value = 1;
			this.pB_startProgress.Visible = false;
			// 
			// btn_changeLang
			// 
			this.btn_changeLang.Location = new System.Drawing.Point(170, 416);
			this.btn_changeLang.Name = "btn_changeLang";
			this.btn_changeLang.Size = new System.Drawing.Size(496, 54);
			this.btn_changeLang.TabIndex = 1;
			this.btn_changeLang.Text = "Сменить язык";
			this.btn_changeLang.UseVisualStyleBackColor = true;
			this.btn_changeLang.Click += new System.EventHandler(this.btn_changeLang_Click);
			// 
			// btn_start
			// 
			this.btn_start.Location = new System.Drawing.Point(170, 308);
			this.btn_start.Name = "btn_start";
			this.btn_start.Size = new System.Drawing.Size(496, 68);
			this.btn_start.TabIndex = 1;
			this.btn_start.Text = "Старт";
			this.btn_start.UseVisualStyleBackColor = true;
			this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
			// 
			// lb_titleStart
			// 
			this.lb_titleStart.AutoSize = true;
			this.lb_titleStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lb_titleStart.Location = new System.Drawing.Point(55, 79);
			this.lb_titleStart.Name = "lb_titleStart";
			this.lb_titleStart.Size = new System.Drawing.Size(767, 76);
			this.lb_titleStart.TabIndex = 0;
			this.lb_titleStart.Text = "Углы четвертей радиан";
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
			this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox2.Location = new System.Drawing.Point(180, 161);
			this.pictureBox2.Margin = new System.Windows.Forms.Padding(6);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(476, 474);
			this.pictureBox2.TabIndex = 7;
			this.pictureBox2.TabStop = false;
			// 
			// btn_resetAllSettings
			// 
			this.btn_resetAllSettings.Location = new System.Drawing.Point(12, 703);
			this.btn_resetAllSettings.Name = "btn_resetAllSettings";
			this.btn_resetAllSettings.Size = new System.Drawing.Size(352, 76);
			this.btn_resetAllSettings.TabIndex = 6;
			this.btn_resetAllSettings.Text = "RESET ALL SETTINGS\r\n";
			this.btn_resetAllSettings.UseVisualStyleBackColor = true;
			this.btn_resetAllSettings.Click += new System.EventHandler(this.btn_resetAllSettings_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(904, 791);
			this.Controls.Add(this.btn_resetAllSettings);
			this.Controls.Add(this.MainStart);
			this.Controls.Add(this.btn_toExam);
			this.Controls.Add(this.tb_right);
			this.Controls.Add(this.tb_bottom);
			this.Controls.Add(this.tb_left);
			this.Controls.Add(this.tb_top);
			this.Controls.Add(this.tb_warning);
			this.Controls.Add(this.lb_title);
			this.Controls.Add(this.value_right);
			this.Controls.Add(this.value_bottom);
			this.Controls.Add(this.value_left);
			this.Controls.Add(this.value_top);
			this.Controls.Add(this.pictureBox1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "MainForm";
			this.Text = "Learning values of trigonometr";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.Shown += new System.EventHandler(this.MainForm_Shown);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.MainStart.ResumeLayout(false);
			this.MainStart.PerformLayout();
			this.pB_changeLang.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button value_top;
		private System.Windows.Forms.Button value_left;
		private System.Windows.Forms.Button value_bottom;
		private System.Windows.Forms.Button value_right;
		private System.Windows.Forms.Label lb_title;
		private System.Windows.Forms.Label tb_warning;
		private System.Windows.Forms.ComboBox tb_top;
		private System.Windows.Forms.ComboBox tb_left;
		private System.Windows.Forms.ComboBox tb_bottom;
		private System.Windows.Forms.ComboBox tb_right;
		private System.Windows.Forms.Button btn_toExam;
		private System.Windows.Forms.GroupBox MainStart;
		private System.Windows.Forms.Button btn_changeLang;
		private System.Windows.Forms.Button btn_start;
		private System.Windows.Forms.Label lb_titleStart;
		private System.Windows.Forms.ProgressBar pB_startProgress;
		private System.Windows.Forms.GroupBox pB_changeLang;
		private System.Windows.Forms.Button btn_changeLangOn;
		private System.Windows.Forms.ComboBox cB_languages;
		private System.Windows.Forms.Button btn_exit;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_resetAllSettingsInStart;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Button btn_resetAllSettings;
	}
}


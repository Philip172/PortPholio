using Learning_values_of_trigonometer.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learning_values_of_trigonometer
{
	public partial class MainForm : Form
	{
		// Универсальный рандом
		public static Random random = new Random();

		// Конструктор
		public MainForm()
		{
			InitializeComponent();
		}

		// Действия при загрузке формы
		private void MainForm_Load(object sender, EventArgs e)
		{
			// Подготовка формы
			MainStart.Location = new Point(0, 0);
			MainStart.Size = this.Size;

			// Запрет на изменение текста самостоятельно в comboBox-е смены языка
			cB_languages.DropDownStyle = ComboBoxStyle.DropDownList;

			// Подготовка текста
			switch (Settings.Default.Language)
			{
				case "ru":
					btn_changeLangOn.Text = AllLanguageModesTexts.Controls.ru.btn_changeLangOn;
					btn_exit.Text = AllLanguageModesTexts.Controls.ru.btn_exit;
					btn_start.Text = AllLanguageModesTexts.Controls.ru.btn_start;
					btn_changeLang.Text = AllLanguageModesTexts.Controls.ru.btn_changeLang;
					lb_titleStart.Text = AllLanguageModesTexts.Controls.ru.lb_titleStart;
					break;
				case "en":
					btn_changeLangOn.Text = AllLanguageModesTexts.Controls.en.btn_changeLangOn;
					btn_exit.Text = AllLanguageModesTexts.Controls.en.btn_exit;
					btn_start.Text = AllLanguageModesTexts.Controls.en.btn_start;
					btn_changeLang.Text = AllLanguageModesTexts.Controls.en.btn_changeLang;
					lb_titleStart.Text = AllLanguageModesTexts.Controls.en.lb_titleStart;
					break;
				case "fr":
					btn_changeLangOn.Text = AllLanguageModesTexts.Controls.fr.btn_changeLangOn;
					btn_exit.Text = AllLanguageModesTexts.Controls.fr.btn_exit;
					btn_start.Text = AllLanguageModesTexts.Controls.fr.btn_start;
					btn_changeLang.Text = AllLanguageModesTexts.Controls.fr.btn_changeLang;
					lb_titleStart.Text = AllLanguageModesTexts.Controls.fr.lb_titleStart;
					break;
			}
		}

		// Действия при показе формы
		private void MainForm_Shown(object sender, EventArgs e)
		{

		}

		// Помощник проверки угла
		public static class CornerHelper
		{
			// Значения угла для сверки
			public static double cornerValue;
		}

		// Проверка в моде экзамена
		public void CheckInExamMode(int step, string textValue)
		{
			step = step < 8 ? step + 1 : -1;

			switch (step)
			{
				case 1:
				case 7:
					Check(textValue, 1);
					break;

				case 2:
				case 8:
					if (step != -1)
						Check(textValue, 2);
					else
					{
						GameModeParams.isExamModeNow = false;

						switch (Settings.Default.Language)
						{
							case "ru":
								MessageBox.Show(AllLanguageModesTexts.Messageboxes.ru[0]);
								break;
							case "en":
								MessageBox.Show(AllLanguageModesTexts.Messageboxes.en[0]);
								break;
							case "fr":
								MessageBox.Show(AllLanguageModesTexts.Messageboxes.fr[0]);
								break;
						}

					}
					break;

				case 3:
				case 5:
					Check(textValue, 3);
					break;

				case 4:
				case 6:
					Check(textValue, 4);
					break;
			}
		}

		// Проверка в обычном моде
		public async void Check(string textValue, int lastWas)
		{
			// Получаем нужный формат значения
			double.TryParse(textValue.Replace(".", "").Replace(",", ""), out double value);

			// Проверка правильнсти значения
			if (value == CornerHelper.cornerValue)
			{
				// Если значение верно, оповещаем об этом...

				switch (Settings.Default.Language)
				{
					case "ru":
						MessageBox.Show(AllLanguageModesTexts.Messageboxes.ru[2]);
						break;
					case "en":
						MessageBox.Show(AllLanguageModesTexts.Messageboxes.en[2]);
						break;
					case "fr":
						MessageBox.Show(AllLanguageModesTexts.Messageboxes.fr[2]);
						break;
				}

				NewRound(lastWas: lastWas); //...и показываем следующее значение
			}
			else
			{
				// Если значение неверно

				// Если режим экзаменирования включен, то оповещаем о провале
				if (GameModeParams.isExamModeNow == true)
				{
					switch (Settings.Default.Language)
					{
						case "ru":
							MessageBox.Show(AllLanguageModesTexts.Messageboxes.ru[1]);
							break;
						case "en":
							MessageBox.Show(AllLanguageModesTexts.Messageboxes.en[1]);
							break;
						case "fr":
							MessageBox.Show(AllLanguageModesTexts.Messageboxes.fr[1]);
							break;
					}
				}
				else
				{
					// Иначе оповещаем, ниже нужного значение или выше

					if (value < CornerHelper.cornerValue)
					{
						// Ниже нужного, оповещаем об этом

						// Определяем сообщение
						switch (Settings.Default.Language)
						{
							case "ru":
								tb_warning.Text = AllLanguageModesTexts.Messageboxes.ru[3];
								break;
							case "en":
								tb_warning.Text = AllLanguageModesTexts.Messageboxes.en[3];
								break;
							case "fr":
								tb_warning.Text = AllLanguageModesTexts.Messageboxes.fr[3];
								break;
						}

						// Показываем сообщение
						tb_warning.Visible = true;
						await Task.Delay(1000);
						tb_warning.Visible = false;
					}
					else if (value > CornerHelper.cornerValue)
					{
						// Выше нужного, оповещаем об этом

						// Определяем сообщение
						switch (Settings.Default.Language)
						{
							case "ru":
								tb_warning.Text = AllLanguageModesTexts.Messageboxes.ru[4];
								break;
							case "en":
								tb_warning.Text = AllLanguageModesTexts.Messageboxes.en[4];
								break;
							case "fr":
								tb_warning.Text = AllLanguageModesTexts.Messageboxes.fr[4];
								break;
						}

						// Показываем сообщение
						tb_warning.Visible = true;
						await Task.Delay(1000);
						tb_warning.Visible = false;
					}
				}
			}
		}

		// Смена раунда
		public void NewRound(int mode_1isStandart_2isMakeAllInvisible_3isMakeAllVisible = 1, int lastWas = -1)
		{
			// Скрываем все кнопки
			{
				value_top.Visible =
			  value_left.Visible =
			  value_bottom.Visible =
			  value_right.Visible = false;

				tb_top.Visible =
				tb_left.Visible =
				tb_bottom.Visible =
				tb_right.Visible = false;

				tb_top.Text =
				tb_left.Text =
				tb_bottom.Text =
				tb_right.Text = "";
			}

			// Регулируем видимость кнопок
			if (mode_1isStandart_2isMakeAllInvisible_3isMakeAllVisible == 1)
			{
				// Получаем значение кнопки
				int valueNextRound = random.Next(1, 5);

				// Если то же самое, то сменяем кнопку
				if (random.Next(5) > 1 && lastWas == valueNextRound)
				{
					if (valueNextRound < 4) // если след кнопка > 4, то инвертируем прибавление значения
						valueNextRound++;
					else
						valueNextRound--;
				}

				// Показ нужной кнопки
				switch (valueNextRound)
				{
					case 1:
						value_top.Visible = true;
						tb_top.Visible = true;
						tb_top.Focus();
						CornerHelper.cornerValue = 157;
						break;

					case 2:
						value_left.Visible = true;
						tb_left.Visible = true;
						tb_left.Focus();
						CornerHelper.cornerValue = 314;
						break;

					case 3:
						value_bottom.Visible = true;
						tb_bottom.Visible = true;
						tb_bottom.Focus();
						CornerHelper.cornerValue = 471;
						break;

					case 4:
						value_right.Visible = true;
						tb_right.Visible = true;
						tb_right.Focus();
						CornerHelper.cornerValue = 0;
						break;
				}
			} // Показываем нужную кнопку, символизирующую число
			else if (mode_1isStandart_2isMakeAllInvisible_3isMakeAllVisible == 2)
			{
				value_top.Visible =
				value_left.Visible =
				value_bottom.Visible =
				value_right.Visible = false;

				tb_top.Visible =
				tb_left.Visible =
				tb_bottom.Visible =
				tb_right.Visible = false;

			} // Делаем все кнопки невидимыми
			else if (mode_1isStandart_2isMakeAllInvisible_3isMakeAllVisible == 3)
			{
				value_top.Visible =
				value_left.Visible =
				value_bottom.Visible =
				value_right.Visible = true;

				tb_top.Visible =
				tb_left.Visible =
				tb_bottom.Visible =
				tb_right.Visible = true;

			} // Делаем все кнопки видимыми
		}

		// Проверка верхнего текста (enter)
		private void tb_top_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				if (GameModeParams.isExamModeNow == false)
					Check(tb_top.Text, lastWas: 1);
				else
					CheckInExamMode(GameModeParams.step, tb_top.Text);
			}
		}

		// Проверка нижнего текста (enter)
		private void tb_bottom_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				if (GameModeParams.isExamModeNow == false)
					Check(tb_bottom.Text, lastWas: 2);
				else
					CheckInExamMode(GameModeParams.step, tb_top.Text);
			}
		}

		// Проверка левого текста (enter)
		private void tb_left_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				if (GameModeParams.isExamModeNow == false)
					Check(tb_top.Text, lastWas: 2);
				else
					CheckInExamMode(GameModeParams.step, tb_top.Text);
			}
		}

		// Проверка правого текста (enter)
		private void tb_right_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				if (GameModeParams.isExamModeNow == false)
					Check(tb_top.Text, lastWas: 2);
				else
					CheckInExamMode(GameModeParams.step, tb_top.Text);
			}
		}

		// Старт формы
		private async void btn_start_Click(object sender, EventArgs e)
		{
			// Подготовка текста
			switch (Settings.Default.Language)
			{
				case "ru":
					btn_toExam.Text = AllLanguageModesTexts.Controls.ru.btn_toExam;
					lb_title.Text = AllLanguageModesTexts.Controls.ru.lb_title;
					break;
				case "en":
					btn_toExam.Text = AllLanguageModesTexts.Controls.en.btn_toExam;
					lb_title.Text = AllLanguageModesTexts.Controls.en.lb_title;
					break;
				case "fr":
					btn_toExam.Text = AllLanguageModesTexts.Controls.fr.btn_toExam;
					lb_title.Text = AllLanguageModesTexts.Controls.fr.lb_title;
					break;
			}
			pB_startProgress.Value += 2;

			// Включение раунда
			NewRound();
			pB_startProgress.Visible = true;
			pB_startProgress.Value++;

			// Задержка перед финальным сокрытием groupBox-а и доведение шкалы прогресса groupBox-а до максимума
			pB_startProgress.Value = pB_startProgress.Maximum;
			await Task.Delay(1000);

			// Скрытие подготовочого groupBox-а
			MainStart.Visible = false;
		}

		// Включение возможности сменить язык
		private void btn_changeLang_Click(object sender, EventArgs e)
		{
			btn_start.Enabled = false;
			btn_changeLang.Enabled = false;
			btn_resetAllSettingsInStart.Visible = false;

			pB_changeLang.Visible = true;
		}

		// Включить смену языка
		private void btn_changeLangOn_Click(object sender, EventArgs e)
		{
			// Смена языка
			switch (cB_languages.Text)
			{
				case "Русский":
					Settings.Default.Language = "ru";
					break;

				case "English":
					Settings.Default.Language = "en";
					break;

				case "Francais":
					Settings.Default.Language = "fr";
					break;

				default:
					switch (Settings.Default.Language)
					{
						case "ru":
							MessageBox.Show(AllLanguageModesTexts.Messageboxes.ru[5]);
							break;
						case "en":
							MessageBox.Show(AllLanguageModesTexts.Messageboxes.en[5]);
							break;
						case "fr":
							MessageBox.Show(AllLanguageModesTexts.Messageboxes.fr[5]);
							break;
					}
					goto linkLangIsNotChanged;
			}

			//Локальная смена языка
			switch (Settings.Default.Language)
			{
				case "ru":
					btn_changeLangOn.Text = AllLanguageModesTexts.Controls.ru.btn_changeLangOn;
					btn_exit.Text = AllLanguageModesTexts.Controls.ru.btn_exit;
					btn_start.Text = AllLanguageModesTexts.Controls.ru.btn_start;
					btn_changeLang.Text = AllLanguageModesTexts.Controls.ru.btn_changeLang;
					lb_titleStart.Text = AllLanguageModesTexts.Controls.ru.lb_titleStart;
					break;
				case "en":
					btn_changeLangOn.Text = AllLanguageModesTexts.Controls.en.btn_changeLangOn;
					btn_exit.Text = AllLanguageModesTexts.Controls.en.btn_exit;
					btn_start.Text = AllLanguageModesTexts.Controls.en.btn_start;
					btn_changeLang.Text = AllLanguageModesTexts.Controls.en.btn_changeLang;
					lb_titleStart.Text = AllLanguageModesTexts.Controls.en.lb_titleStart;
					break;
				case "fr":
					btn_changeLangOn.Text = AllLanguageModesTexts.Controls.fr.btn_changeLangOn;
					btn_exit.Text = AllLanguageModesTexts.Controls.fr.btn_exit;
					btn_start.Text = AllLanguageModesTexts.Controls.fr.btn_start;
					btn_changeLang.Text = AllLanguageModesTexts.Controls.fr.btn_changeLang;
					lb_titleStart.Text = AllLanguageModesTexts.Controls.fr.lb_titleStart;
					break;
			}

			// Сохранение данных
			Settings.Default.Save();

			// Оповещение о том, что язык сменён
			switch (Settings.Default.Language)
			{
				case "ru":
					MessageBox.Show(AllLanguageModesTexts.Messageboxes.ru[6]);
					break;
				case "en":
					MessageBox.Show(AllLanguageModesTexts.Messageboxes.en[6]);
					break;
				case "fr":
					MessageBox.Show(AllLanguageModesTexts.Messageboxes.fr[6]);
					break;
			}

		// Если язык не изменён, просто идём сюда
		linkLangIsNotChanged:;
		}

		// Выход из смены языка
		private void btn_exit_Click(object sender, EventArgs e)
		{
			btn_start.Enabled = true;
			btn_changeLang.Enabled = true;
			btn_resetAllSettingsInStart.Visible = true;

			pB_changeLang.Visible = false;
		}

		// Обнуление всех найстроек (только для разработчиков)
		private void btn_resetAllSettings_Click(object sender, EventArgs e)
		{
			// Обычное обнуление настроек
			Settings.Default.Reset();

			// Локальная смена языка
			btn_toExam.Text = AllLanguageModesTexts.Controls.ru.btn_toExam;
			lb_title.Text = AllLanguageModesTexts.Controls.ru.lb_title;

			// Сохранение данных
			Settings.Default.Save();
		}

		// Закрытие формы
		private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			// Сохранение настроек
			Settings.Default.Save();
		}

		// Проверка правого текста
		private void value_right_MouseClick(object sender, MouseEventArgs e)
		{
			if (GameModeParams.isExamModeNow == false)
				Check(tb_top.Text, lastWas: 2);
			else
				CheckInExamMode(GameModeParams.step, tb_top.Text);
		}

		// Проверка верхнего текста (enter)
		private void value_top_MouseClick(object sender, MouseEventArgs e)
		{
			if (GameModeParams.isExamModeNow == false)
				Check(tb_top.Text, lastWas: 1);
			else
				CheckInExamMode(GameModeParams.step, tb_top.Text);
		}

		// Проверка левого текста (enter)
		private void value_left_MouseClick(object sender, MouseEventArgs e)
		{
			if (GameModeParams.isExamModeNow == false)
				Check(tb_top.Text, lastWas: 2);
			else
				CheckInExamMode(GameModeParams.step, tb_top.Text);
		}

		// Проверка нижнего текста (enter)
		private void value_bottom_MouseClick(object sender, MouseEventArgs e)
		{
			if (GameModeParams.isExamModeNow == false)
				Check(tb_bottom.Text, lastWas: 2);
			else
				CheckInExamMode(GameModeParams.step, tb_top.Text);
		}

		// Экзаменация
		private void btn_toExam_Click(object sender, EventArgs e)
		{
			switch (Settings.Default.Language)
			{
				case "ru":
					MessageBox.Show(AllLanguageModesTexts.Messageboxes.ru[7]);
					break;
				case "en":
					MessageBox.Show(AllLanguageModesTexts.Messageboxes.en[7]);
					break;
				case "fr":
					MessageBox.Show(AllLanguageModesTexts.Messageboxes.fr[7]);
					break;
			}
		}

		// Обнуление всех настроек
		private void btn_resetAllSettingsInStart_Click(object sender, EventArgs e)
		{
			// Обычное обнуление настроек
			Settings.Default.Reset();

			// Локальная смена языка
			btn_changeLangOn.Text = AllLanguageModesTexts.Controls.ru.btn_changeLangOn;
			btn_exit.Text = AllLanguageModesTexts.Controls.ru.btn_exit;
			btn_start.Text = AllLanguageModesTexts.Controls.ru.btn_start;
			btn_changeLang.Text = AllLanguageModesTexts.Controls.ru.btn_changeLang;
			lb_titleStart.Text = AllLanguageModesTexts.Controls.ru.lb_titleStart;

			// Сохранение данных
			Settings.Default.Save();
		}
	}
}

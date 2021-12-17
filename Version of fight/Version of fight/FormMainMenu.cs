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
    public partial class FormMainMenu : Form
    {
        //Конструктор
        public FormMainMenu()
        {
            InitializeComponent();
        }

        //Переход на форму игры
        private void Button1_Click(object sender, EventArgs e)
        {
            Hide(); new FormFight().ShowDialog();
        }
    }
}

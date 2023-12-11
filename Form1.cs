using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GuessNumberGame.Game;
using GuessNumberGame.Player;
using GuessNumberGame.SettingsGame;

namespace GuessNumberGame
{
    public partial class Form1 : Form
    {
        RandomValue randomValue;
        NumberAttempt numberAttempt;
        int count;
        int rnd;
        StringBuilder substring = new StringBuilder();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSpecify_Click(object sender, EventArgs e)
        {
            if (txtAttempt.Text != string.Empty && txtFrom.Text != string.Empty && txtTo.Text != string.Empty)
            {


                numberAttempt = new NumberAttempt(txtAttempt.Text);

                if (!numberAttempt.isDataCorrect())
                {
                    MessageBox.Show("Введите число больше 0", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                randomValue = new RandomValue(new RandomNumber(txtFrom.Text, txtTo.Text));                    
                rnd = (int)randomValue.Rand();
                
                btnSpecify.Enabled = false;

                MessageBox.Show("Введите число", " Игра началась", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Введите все данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnResponse_Click(object sender, EventArgs e)
        {
            if (txtResponse.Text != string.Empty)
            {
                count++;
                substring.Append($"Попытка №{count}: ");
                PlayerNumber player = new PlayerNumber(txtResponse.Text);
                CalculateNumber calculate = new CalculateNumber(player, rnd);

                if (calculate.isMaxValue())
                {
                    MessageBox.Show("Задуманное число больше", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    substring.Append($"Задуманное число больше, чем {player.getValue()}. \r\n ");
                }
                else if (calculate.isMinValue())
                {
                    MessageBox.Show("Задуманное число меньше", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    substring.Append($"Задуманное число меньше, чем {player.getValue()}. \r\n ");
                }
                else if (calculate.isEqual())
                {
                    MessageBox.Show($"Вы угадали с {count} попытки", "Выигрыш", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    substring.Append($"Вы угадали с {count} попытки. \r\n ");
                }

                if (numberAttempt.isAttemptOver(count))
                {
                    MessageBox.Show($"Вы проиграли", "Проигрыш", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    substring.Append($"Вы проиграли. \r\n ");
                }

                rTB.Text = string.Empty;
                rTB.Text = substring.ToString();
            }
            else
            {
                MessageBox.Show("Введите значение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            btnSpecify.Enabled = true;
            txtAttempt.Text = string.Empty;
            txtFrom.Text = string.Empty;
            txtTo.Text = string.Empty;
            txtResponse.Text = string.Empty;
            rTB.Text = string.Empty;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Это игра с угадыванием.Вы задаете диапазон чисел и количество попыток и угадываете число, которые загадал компьютер из этого диапазона. Игра идет до конца введеных попыток", "Правила", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

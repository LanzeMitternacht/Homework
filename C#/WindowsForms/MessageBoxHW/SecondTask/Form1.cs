using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void GuessNumber()
        {
            Random random = new Random();
            int minnum = 1; int maxnum = 2000; int trynum = 0;
            DialogResult dialogResult = DialogResult.None;
            while (dialogResult != DialogResult.OK)
            {
                int number = random.Next(minnum, maxnum);
                trynum++;
                dialogResult = MessageBox.Show($"Ваше число: {number}?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes || maxnum - minnum == 0)
                {
                    dialogResult = MessageBox.Show($"Программа угадала ваше число с {trynum}", "Поздравдение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LUserN.Text = $"Ваше число: {number}";
                    LTry.Text = $"Число попыток: {trynum}";
                }
                else
                {
                    trynum++;
                    dialogResult = MessageBox.Show($"Ваше число больше {number}?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        minnum = number;
                    }
                    else
                    {
                        maxnum = number;
                    }
                }
            }
        }
        private void BStart_Click(object sender, EventArgs e)
        {
            GuessNumber();
            DialogResult dialogResult = DialogResult.None;
            while (dialogResult != DialogResult.No)
            {
                dialogResult = MessageBox.Show("Хотите сыграть ещё раз?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    GuessNumber();
                }
            }
        }

        private void BExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

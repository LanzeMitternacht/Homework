using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace TicTacToe
{
    public partial class WinForm : Form
    {
        public WinForm(string Player, bool win)
        {
            InitializeComponent();
            if (win)
            {
                LWinPlayer.Text = $"Победил: {Player}. Введите имя игрока:";
            }
            else
            {
                LWinPlayer.Text = $"Ничья.";
                TBWin.Hide();
            }
            
        }
        private void SavePlayer(string name)
        {
            List<string> lines = new List<string>();

            if (File.Exists("leaderboard.txt"))
            {
                using (StreamReader sr = new StreamReader("leaderboard.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');

                        if (parts[0] == name)
                        {
                            int score = int.Parse(parts[1]);
                            score++;
                            line = $"{name}, {score}";
                        }
                        lines.Add(line);
                    }
                    sr.Close();
                }

                bool playerExists = false;
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts[0] == name)
                    {
                        playerExists = true;
                        break;
                    }
                }
                if (!playerExists)
                {
                    lines.Add($"{name}, 1");
                }

                using (StreamWriter sw = new StreamWriter("leaderboard.txt"))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line);
                    }
                    sw.Close();
                }
            }
            else
            {
                using (StreamWriter sw = new StreamWriter("leaderboard.txt"))
                {
                    sw.WriteLine($"{name}, 1");
                    sw.Close();
                }
            }
        }
        private void BNewGame_Click(object sender, EventArgs e)
        {
            if(TBWin.Text.Length > 0) SavePlayer(TBWin.Text);
            DialogResult = DialogResult.OK;
        }

        private void BEndGame_Click(object sender, EventArgs e)
        {
            if (TBWin.Text.Length > 0) SavePlayer(TBWin.Text);
            DialogResult = DialogResult.Cancel;
        }
    }
}

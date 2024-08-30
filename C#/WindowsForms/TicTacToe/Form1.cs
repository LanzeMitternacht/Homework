using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        string Player = "X";
        private Button[] arrButton;
        WinForm winForm;
        public Form1()
        {
            InitializeComponent();
            LPlayer.Text = $"Ходит: {Player}";
            arrButton = new Button[] { Btn1, Btn2, Btn3, Btn4, Btn5, Btn6, Btn7, Btn8, Btn9};
        }

        private void Bnt_Click(object sender, EventArgs e)
        {
                ((Button)sender).Text = Player;
                ((Button)sender).Enabled = false;

            if (IsWin()) {
                winForm = new WinForm(Player, true); 
                if(DialogResult.OK == winForm.ShowDialog())
                {
                    BNewGame_Click(sender, e);
                }
                else
                {
                    Close();
                }
            }
            Player = (Player == "X") ? "0" : "X";
            LPlayer.Text = $"Ходит: {Player}";
        }

        private void BNewGame_Click(object sender, EventArgs e)
        {
            foreach (Button button in arrButton)
            {
                button.Enabled = true;
                button.Text = "";
            }
        }

        private bool IsWin()
        {
            if (arrButton[0].Text == arrButton[1].Text && arrButton[0].Text == arrButton[2].Text && arrButton[0].Text != "")
                return true;
            else if (arrButton[0].Text == arrButton[4].Text && arrButton[0].Text == arrButton[8].Text && arrButton[0].Text != "")
                return true;
            else if (arrButton[0].Text == arrButton[3].Text && arrButton[0].Text == arrButton[6].Text && arrButton[0].Text != "")
                return true;
            else if (arrButton[1].Text == arrButton[4].Text && arrButton[1].Text == arrButton[7].Text && arrButton[1].Text != "")
                return true;
            else if (arrButton[2].Text == arrButton[5].Text && arrButton[2].Text == arrButton[8].Text && arrButton[2].Text != "")
                return true;
            else if (arrButton[2].Text == arrButton[4].Text && arrButton[2].Text == arrButton[6].Text && arrButton[2].Text != "")
                return true;
            else if (arrButton[8].Text == arrButton[7].Text && arrButton[8].Text == arrButton[6].Text && arrButton[8].Text != "")
                return true;
            else if (arrButton[3].Text == arrButton[4].Text && arrButton[3].Text == arrButton[5].Text && arrButton[3].Text != "")
                return true;

            bool isDraw = true;
            foreach (Button button in arrButton)
            {
                if (button.Text == "")
                {
                    isDraw = false;
                    break;
                }
            }

            if (isDraw)
            {
                winForm = new WinForm(null, false);
                if (DialogResult.OK == winForm.ShowDialog())
                {
                    BNewGame_Click(null, null);
                }
                else
                {
                    Close();
                }
            }

            return false;
        }

        private void BLeader_Click(object sender, EventArgs e)
        {
            LeaderTable leaderTable = new LeaderTable();
            leaderTable.ShowDialog();
        }
    }
}

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

namespace TicTacToe
{
    public partial class LeaderTable : Form
    {
        public LeaderTable()
        {
            InitializeComponent();
            UpdateLeaderboard();
        }
        private void UpdateLeaderboard()
        {
            DataGrid.Columns.Clear();

            DataGridViewTextBoxColumn columnLogin = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn columnScore = new DataGridViewTextBoxColumn();
            columnLogin.HeaderText = "Логин";
            columnScore.HeaderText = "Очки";

            DataGrid.Columns.Add(columnLogin);
            DataGrid.Columns.Add(columnScore);

            using (StreamReader sr = new StreamReader("leaderboard.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');

                    DataGridViewRow row = new DataGridViewRow();
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = parts[0] });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = parts[1] });

                    DataGrid.Rows.Add(row);
                }
            }
        }
        private void BClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

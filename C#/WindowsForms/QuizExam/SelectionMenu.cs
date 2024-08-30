using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizExam
{
    public partial class SelectionMenu : Form
    {
        private string userLogin;
        public SelectionMenu(string login)
        {
            InitializeComponent();
            userLogin = login;
        }

        private void BHistory_Click(object sender, EventArgs e)
        {
            Quiz quiz = new Quiz(userLogin);
            quiz.Show();
            Close();
        }

        private void BExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace QuizExam
{
    public partial class PersonalAcc : Form
    {
        private string userLogin;
        private bool admin;
        ContextMenuStrip menuStrip;
        public PersonalAcc(string login, bool IsAdmin)
        {
            InitializeComponent();
            this.userLogin = login;
            this.admin = IsAdmin;
            menuStrip = new ContextMenuStrip();
            menuStrip.ItemClicked += new ToolStripItemClickedEventHandler(CMSetting_ItemClicked);
        }

    

    private void BStartQuiz_Click(object sender, EventArgs e)
        {
            SelectionMenu selectionMenu = new SelectionMenu(userLogin);
            selectionMenu.ShowDialog();
        }

        private void BAdmin_Click(object sender, EventArgs e)
        {
            if(admin)
            {
                BAdmin.Visible = true;
                AddQuestion addQuestion = new AddQuestion();
                addQuestion.ShowDialog();
            }
            else
            {
                BAdmin.Visible = false;
            }
        }
        
        private void CMSetting_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if(e.ClickedItem.Text == "Выход")
            {
                Authorization authorization = new Authorization();
                authorization.Show();
                Close();
            }
        }

        private void BSetting_Click(object sender, EventArgs e)
        {
            menuStrip.Items.Clear();
            menuStrip.Items.Add("Выход");

            menuStrip.Show(BSetting, new Point(0, BSetting.Height));
        }
    }
}

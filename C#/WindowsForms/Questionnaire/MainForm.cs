using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BACreate_Click(object sender, EventArgs e)
        {
            Questionnaire questionnaire = new Questionnaire();
            questionnaire.ShowDialog();   
            MessageBox.Show("Файл был создан","Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void BExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

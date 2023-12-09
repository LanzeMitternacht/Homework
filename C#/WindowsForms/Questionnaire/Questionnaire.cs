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

namespace WindowsFormsApp1
{
    public partial class Questionnaire : Form
    {
        public Questionnaire()
        {
            InitializeComponent();
        }

        private void BCreate_Click(object sender, EventArgs e)
        {
                var result = MessageBox.Show("Создать анкету?", "Подтверждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter("D:\\VS Studio\\WindowsFormsApp1\\QuestFinal.txt");
                    sw.WriteLine("Наименование должности: " + TBNameV.Text);
                    sw.WriteLine("\tЛичная информация");
                    sw.WriteLine("ФИО: " + TBFio.Text);
                    sw.WriteLine("День рождения:" + TBBirth.Text);
                    sw.WriteLine("\tКонтактная информация");
                    sw.WriteLine("Номер телефона: " + TBNumber.Text);
                    sw.WriteLine("E-mail: " + TBEmail.Text);
                    sw.WriteLine("\tИнформация о учёбе");
                    sw.WriteLine("Первая информация: " + TBStudyF.Text);
                    sw.WriteLine("Вторая информация: " + TBStudyS.Text);
                    sw.WriteLine("\tИнформация об прошлой работе");
                    sw.WriteLine("Дата работы: " + TBWhenW.Text);
                    sw.WriteLine("Наименование компании: " + TBNameW.Text);
                    sw.WriteLine("Наименование должности: " + TBPost.Text);
                    sw.Close();
                    Close();
                }
        }
    }
}

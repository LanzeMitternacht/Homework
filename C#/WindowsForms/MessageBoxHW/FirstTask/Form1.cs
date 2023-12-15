using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int resultMesBox = 0;    
        Dictionary<int, string> nameMan = new Dictionary<int, string>() {
                {1,"Андрей" },
                {2,"Александр" },
                {3,"Владимир" },
                {4,"Даниил" },
                {5, "Олег"}
        };
        Dictionary<int, string> nameGirl = new Dictionary<int, string>() {
                {1,"Александра" },
                {2,"Жанна" },
                {3,"Эмилия" },
                {4,"Августина" },
                {5, "Герда"}
        };
        Dictionary<int, string> nameWork = new Dictionary<int, string>()
        {
            {1,"Программиста" },
            {2,"Дизайнера"},
            {3,"3d-моделлера" },
            {4,"Продавца" },
            {5,"Врача" },
            {6,"Учителя" },
            {7,"Переводчика" },
            {8,"Актера" },
            {9,"Музыканта" },
            {10,"Повара" }
        };
        private void MessageBoxName()
        {
            Random randomName = new Random();
            int name = randomName.Next(1,5);

            DialogResult dialogResult = MessageBox.Show("Вы девушка?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                while (TBName.Text == "")
                {
                    resultMesBox++;
                    dialogResult = MessageBox.Show($"Вас зовут {nameGirl[name]}?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        TBName.Text = nameGirl[name];
                    }
                    else
                    {
                        name = randomName.Next(1, 5);
                    }

                }
            }
            else
            {
                while (TBName.Text == "")
                {
                    resultMesBox++;
                    dialogResult = MessageBox.Show($"Вас зовут {nameMan[name]}?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        TBName.Text = nameMan[name];
                    }
                    else
                    {
                        name = randomName.Next(1, nameMan.Count);
                    }
                }
            }
            
        }
        private void MessageBoxAge()
        {
            Random randomAge = new Random();
            int age = randomAge.Next(18, 65);
            while(TBAge.Text == "")
            {
                resultMesBox++;
               DialogResult dialogResult = MessageBox.Show($"Вам {age} лет?", "Подтверждение", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if(dialogResult == DialogResult.Yes)
                {
                    TBAge.Text = age.ToString();
                }
                else
                {
                    age = randomAge.Next(18, 65);
                }
            }
        }
        private void MessageBoxStudy()
        {
            resultMesBox++;
           DialogResult dialogResult = MessageBox.Show("У вас высшее образование?","Подтверждение",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialogResult == DialogResult.Yes)
            {
                TBStudy.Text = "Высшее профессиональное";
            }
            else if(dialogResult == DialogResult.No)
            {
                resultMesBox++;
                dialogResult = MessageBox.Show("У вас среднее образование?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dialogResult == DialogResult.Yes)
                {
                    TBStudy.Text = "Среднее профессиональное";
                }
                else
                {
                    TBStudy.Text = "Нет";
                }
            }
        }
        private void MessageBoxWork()
        {
            if (TBStudy.Text == "Нет")
            {
                TBWork.Text = "Нет";
            }
            else
            {
                while (TBWork.Text == "")
                {
                    resultMesBox++;
                    Random random = new Random();
                    int work = random.Next(1, 10);
                    DialogResult dialogResult = MessageBox.Show($"Вы учились на {nameWork[work]}?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(dialogResult == DialogResult.Yes)
                    {
                        TBWork.Text = nameWork[work];
                    }
                }
            }
        }
        private void MessageBoxWorkExp()
        {
            if( TBWork.Text == "")
            {
                TBWorkExp.Text = "Нет";
            }
            else
            {
                resultMesBox++;
                DialogResult dialogResult = MessageBox.Show("У вас есть опыт работы?", "Подтрвеждение",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if( dialogResult == DialogResult.No)
                {
                    TBWorkExp.Text = "Нет";
                }
                else
                {
                    resultMesBox++;
                    dialogResult = MessageBox.Show("У вас опыт работы больше 5ти лет?", "Подтрвеждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        TBWorkExp.Text = "Опыт работы больше 5ти лет";
                    }
                    else
                    {
                        resultMesBox++;
                        dialogResult = MessageBox.Show("У вас опыт работы больше года?", "Подтрвеждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if(dialogResult == DialogResult.Yes)
                        {
                            TBWorkExp.Text = "Опыт работы больше года, но меньше 5ти лет";
                        }
                        else
                        {
                            TBWorkExp.Text = "Опыт работы меньше года";
                        }
                    }
                }
            }
        }
        private void BStart_Click(object sender, EventArgs e)
        {
            MessageBoxName();
            MessageBoxAge();
            MessageBoxStudy();
            MessageBoxWork();
            MessageBoxWorkExp();
            int resultWords = TBName.TextLength + TBAge.TextLength + TBStudy.TextLength + TBWork.TextLength;
            MessageBox.Show("Ваше резюме готово",$"{resultWords}/{resultMesBox}",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private void BExit_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}

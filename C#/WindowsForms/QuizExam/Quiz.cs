using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace QuizExam
{
    public partial class Quiz : Form
    {
        private List<QuizQuestion> questions;
        private int currentQueIndex = 0;
        private int correctAnswers = 0;
        private string filePath = "D:\\VS Studio\\QuizExam\\QuizFolder\\question.json";
        private string userLogin;
        Dictionary<int, List<string>> selectAnswersD = new Dictionary<int, List<string>>();


        public Quiz(string login)
        {
            InitializeComponent();
            LoadQuestions();
            DisplayQuestion();
            UpdateNavigationButtons();
            userLogin = login;
        }

        private void LoadQuestions()
        {
            try
            {
                string json = File.ReadAllText(filePath);
                questions = JsonConvert.DeserializeObject<List<QuizQuestion>>(json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке вопросов: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
        private void SaveQuizResult()
        {
            QuizResult result = new QuizResult
            {
                DateTime = DateTime.Now,
                UserLogin = userLogin,
                CorrectAnswers = correctAnswers,
                TotalQuestions = questions.Count,
                Percentage = (double)correctAnswers / questions.Count * 100,
                UserSelectedAnswers = new List<List<string>>()
            };

            foreach (var questionIndex in selectAnswersD.Keys.OrderBy(index => index))
            {
                result.UserSelectedAnswers.Add(selectAnswersD[questionIndex]);
            }

            string resultJson = JsonConvert.SerializeObject(result, Formatting.Indented);

            File.WriteAllText($"D:\\VS Studio\\QuizExam\\QuizFolder\\quiz_results.json", resultJson);
        }

        private void DisplayQuestion()
        {
            if (currentQueIndex >= 0 && currentQueIndex < questions.Count)
            {
                QuizQuestion currentQuestion = questions[currentQueIndex];
                CLBAnswer.ClearSelected();

                if (currentQuestion != null && currentQuestion.Answers != null)
                {
                    LQuestion.Text = currentQuestion.Question;
                    CLBAnswer.Items.Clear();

                    foreach (string answer in currentQuestion.Answers)
                    {
                        if (answer != null)
                        {
                            CLBAnswer.Items.Add(answer);
                        }
                    }

                    if (selectAnswersD.ContainsKey(currentQueIndex))
                    {
                        List<string> selectedAnswers = selectAnswersD[currentQueIndex];
                        foreach (string selectedAnswer in selectedAnswers)
                        {
                            int index = CLBAnswer.Items.IndexOf(selectedAnswer);
                            if (index >= 0)
                            {
                                CLBAnswer.SetItemChecked(index, true);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ошибка: Вопрос или список ответов не инициализирован.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                double percentage = (double)correctAnswers / questions.Count * 100;
                MessageBox.Show($"Вы завершили викторину.\nПравильных ответов: {correctAnswers} из {questions.Count}\nПроцент правильных ответов: {percentage:F2}%", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SaveQuizResult();
                Close();
            }

            UpdateNavigationButtons();
        }

        private void UpdateNavigationButtons()
        {
            BBack.Enabled = currentQueIndex > 0;
            BNext.Text = (currentQueIndex == questions.Count - 1) ? "Финиш" : "Вперед";
        }

        private void CLBAnswer_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (currentQueIndex >= 0)
            {
                string selectedAnswer = CLBAnswer.Items[e.Index].ToString();

                if (e.NewValue == CheckState.Checked)
                {
                    if (!selectAnswersD.ContainsKey(currentQueIndex))
                    {
                        selectAnswersD[currentQueIndex] = new List<string>();
                    }

                    if (!selectAnswersD[currentQueIndex].Contains(selectedAnswer))
                    {
                        selectAnswersD[currentQueIndex].Add(selectedAnswer);
                    }
                }
                else if (e.NewValue == CheckState.Unchecked && selectAnswersD.ContainsKey(currentQueIndex))
                {
                    selectAnswersD[currentQueIndex].Remove(selectedAnswer);
                }
            }
        }

        private void SaveCheckboxState()
        {
            if (currentQueIndex >= 0)
            {
                if (CLBAnswer.CheckedIndices.Count > 0)
                {
                    if (selectAnswersD.ContainsKey(currentQueIndex))
                    {
                        selectAnswersD[currentQueIndex].Clear();
                    }
                    else
                    {
                        selectAnswersD[currentQueIndex] = new List<string>();
                    }

                    foreach (int checkedIndex in CLBAnswer.CheckedIndices)
                    {
                        selectAnswersD[currentQueIndex].Add(CLBAnswer.Items[checkedIndex].ToString());
                    }
                }
                else
                {
                    selectAnswersD.Remove(currentQueIndex);
                }
            }
        }

        private void BNext_Click(object sender, EventArgs e)
        {
            if (currentQueIndex < questions.Count)
            {
                SaveCheckboxState();

                QuizQuestion currentQuestion = questions[currentQueIndex];

                bool userAnswered = selectAnswersD.ContainsKey(currentQueIndex) && selectAnswersD[currentQueIndex].Count > 0;

                if (userAnswered && currentQuestion.CorrectAnswers != null &&
                    currentQuestion.CorrectAnswers.SequenceEqual(selectAnswersD[currentQueIndex]?.OrderBy(ans => ans)))
                {
                    correctAnswers++;
                }

                if (currentQueIndex < questions.Count - 1)
                {
                    currentQueIndex++;
                    DisplayQuestion();
                }
                else
                {
                    double percentage = (double)correctAnswers / questions.Count * 100;
                    MessageBox.Show($"Вы завершили викторину.\nПравильных ответов: {correctAnswers} из {questions.Count}\nПроцент правильных ответов: {percentage:F2}%", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SaveQuizResult();
                    Dispose();
                }
            }
        }

        private void BBack_Click(object sender, EventArgs e)
        {
            if (currentQueIndex > 0)
            {
                currentQueIndex--;
                DisplayQuestion();
            }
        }
    }
}
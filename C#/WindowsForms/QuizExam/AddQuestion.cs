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
using Newtonsoft.Json;
using System.Security.Cryptography;
using Newtonsoft.Json.Linq;

namespace QuizExam
{
    public partial class AddQuestion : Form
    {
        private List<Question> questions;
        private string filePath = "D:\\VS Studio\\QuizExam\\QuizFolder\\question.json";

        public AddQuestion()
        {
            InitializeComponent();
            LoadDataGridView();
            LoadQuestions();

            this.AutoSize = true;
        }

        private void LoadDataGridView()
        {
            DataGridView.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn questionTextColumn = new DataGridViewTextBoxColumn();
            questionTextColumn.DataPropertyName = "QuestionText";
            questionTextColumn.HeaderText = "Вопросы";


            DataGridViewTextBoxColumn answersColumn = new DataGridViewTextBoxColumn();
            answersColumn.DataPropertyName = "Answers";
            answersColumn.HeaderText = "Ответы";


            DataGridViewTextBoxColumn correctAnswersColumn = new DataGridViewTextBoxColumn();
            correctAnswersColumn.DataPropertyName = "CorrectAnswers";
            correctAnswersColumn.HeaderText = "Правильные ответы";


            DataGridView.Columns.Add(questionTextColumn);
            DataGridView.Columns.Add(answersColumn);
            DataGridView.Columns.Add(correctAnswersColumn);

            DataGridView.CellFormatting += DataGridView_CellFormatting;
            questionTextColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            answersColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            correctAnswersColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DataGridView.AutoSize = false;
            DataGridView.ScrollBars = ScrollBars.Both;
        }

        private void LoadQuestions()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);

                try
                {
                    JArray jsonArray = JArray.Parse(json);
                    questions = new List<Question>();

                    foreach (JToken item in jsonArray)
                    {
                        Question newQuestion = new Question
                        {
                            QuestionText = item["question"].ToString(),
                            Answers = item["answers"].ToObject<string[]>(),
                            CorrectAnswers = item["correct_answers"].ToObject<string[]>()
                        };

                        questions.Add(newQuestion);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при загрузке вопросов: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    questions = new List<Question>();
                }

                DataGridView.DataSource = questions;
                DataGridView.Refresh();
            }
            else
            {
                questions = new List<Question>();
            }
        }
        private void DataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value is string[] array)
            {
                e.Value = string.Join(", ", array);
                e.FormattingApplied = true;
            }
        }

        private void BAddQue_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TBAnswer.Text) && !string.IsNullOrEmpty(TBQuestion.Text))
            {
                Question newQuestion = new Question
                {
                    QuestionText = TBQuestion.Text,
                    Answers = TBAnswer.Text.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToArray(),
                    CorrectAnswers = TBCorQue.Text.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToArray()
                };

               BindingList<Question> bindingList = new BindingList<Question>(questions){ newQuestion };

                TBAnswer.Clear();
                TBQuestion.Clear();
                TBCorQue.Clear();

                DataGridView.DataSource = bindingList;
                DataGridView.Refresh();

                SaveQuestions();
            }
            else
            {
                MessageBox.Show("Введите вопрос и хотя бы один ответ.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BDeleteQue_Click(object sender, EventArgs e)
        {
            if (DataGridView.SelectedRows.Count > 0)
            {
                int selectedIndex = DataGridView.SelectedCells[0].RowIndex;
                questions.RemoveAt(selectedIndex);

                SaveQuestions();
                LoadQuestions();
            }
        }

        private void BEditQue_Click(object sender, EventArgs e)
        {
            if (DataGridView.SelectedRows.Count > 0)
            {
                int selectedIndex = DataGridView.SelectedRows[0].Index;

                if (!string.IsNullOrWhiteSpace(TBAnswer.Text) && TBQuestion.Text.Split(new[] { "\n", "\r" }, StringSplitOptions.RemoveEmptyEntries).Length > 0)
                {
                    questions[selectedIndex].QuestionText = TBAnswer.Text;
                    questions[selectedIndex].Answers = TBQuestion.Text.Split(new[] { ", "}, StringSplitOptions.RemoveEmptyEntries);
                    questions[selectedIndex].CorrectAnswers = TBCorQue.Text.Split(new[] { ", "}, StringSplitOptions.RemoveEmptyEntries);

                    TBAnswer.Clear();
                    TBQuestion.Clear();
                    TBCorQue.Clear();

                    SaveQuestions();
                    DataGridView.Refresh();
                }
                else
                {
                    MessageBox.Show("Введите вопрос и хотя бы один ответ.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SaveQuestions()
        {
            string json = JsonConvert.SerializeObject(questions, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        private void BSaveQue_Click(object sender, EventArgs e)
        {
            SaveQuestions();
            MessageBox.Show("Вопросы сохранены в файл.");
        }
    }
}
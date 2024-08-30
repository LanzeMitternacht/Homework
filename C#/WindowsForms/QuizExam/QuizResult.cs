using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizExam
{
    internal class QuizResult
    {
        public DateTime DateTime { get; set; }
        public string UserLogin { get; set; }
        public int CorrectAnswers { get; set; }
        public int TotalQuestions { get; set; }
        public double Percentage { get; set; }
        public List<List<string>> UserSelectedAnswers { get; set; }
    }
}

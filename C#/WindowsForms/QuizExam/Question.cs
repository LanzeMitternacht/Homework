using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizExam
{
    internal class Question
    {
        [JsonProperty("question")]
        public string QuestionText { get; set; }
        [JsonProperty("answers")]
        public string[] Answers { get; set; }
        [JsonProperty("correct_answers")]
        public string[] CorrectAnswers { get; set; }
    }
}

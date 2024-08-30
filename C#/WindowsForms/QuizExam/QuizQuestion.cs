using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizExam
{
    internal class QuizQuestion
    {
        [JsonProperty("question")]
        public string Question { get; set; }
        [JsonProperty("answers")]
        public List<string> Answers { get; set; }
        [JsonProperty("correct_answers")]
        public List<string> CorrectAnswers { get; set; }
        public List<string> UserSelectedCorrectAnswers { get; set; } = new List<string>();

    }
}

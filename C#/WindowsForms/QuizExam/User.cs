using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizExam
{
    internal class User
    {
            public string Username { get; set; }
            public string PasswordHash { get; set; }
            public string Salt { get; set; }
            public DateTime Birthday { get; set; }
            public bool IsAdmin { get; set; }
    }
}

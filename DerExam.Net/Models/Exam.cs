using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DerExam.Net.Models
{
    public class Exam
    {
        public Exam()
        {
            questionAndAnswers = new List<QuestionAndAnswer>();
        }
        public string ExamId { get; set; }
        public string ExamName { get; set; }
        public List<QuestionAndAnswer> questionAndAnswers { get; set; }
    }
}

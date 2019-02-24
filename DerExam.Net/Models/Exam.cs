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
            grades = new List<Grade>();
        }
        public string ExamId { get; set; }
        public string ExamName { get; set; }
        public List<QuestionAndAnswer> questionAndAnswers { get; set; }
        public List<Grade> grades { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DerExam.Net.Models
{
    public class Grade
    {
        public string GradeId { get; set; }
        public string ExamId { get; set; }
        public string ExamName { get; set; }
        public double GradeResult { get; set; }
    }
}

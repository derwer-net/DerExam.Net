using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DerExam.Net.Models
{
    public class Grade
    {
        public int GradeId { get; set; }
        public int ExamId { get; set; }
        public int UserID { get; set; }
        public double GradeResult { get; set; }
    }
}

using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace DerExam.Net.Models
{
    public class UserExt:IdentityUser
    {
        public UserExt()
        {
            courses = new List<Course>();
            exams = new List<Exam>();
            grades = new List<Grade>();
        }
        public string ClassId { get; set; }
        public string CourseId { get; set; }
        public List<Course> courses { get; set; }
        public List<Exam> exams { get; set; }
        public List<Grade> grades { get; set; }
    }
}

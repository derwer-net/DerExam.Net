using System.Collections.Generic;

namespace DerExam.Net.Models
{
    public class Course
    {
        public Course()
        {
            classes = new List<Class>();
            exams = new List<Exam>();
        }

        public string CourseId { get; set; }
        public string CourseName { get; set; }
        public List<Class> classes { get; set; }
        public List<Exam> exams { get; set; }
    }
}
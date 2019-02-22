using System.Collections.Generic;

namespace DerExam.Net.Models
{
    public class Course
    {
        public Course()
        {
            Classes = new List<Class>();
        }

        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public List<Class> Classes{ get; set; }
    }
}
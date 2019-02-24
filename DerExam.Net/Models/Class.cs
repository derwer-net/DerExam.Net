using System.Collections.Generic;

namespace DerExam.Net.Models
{
    public class Class
    {
        public Class()
        {
            userExts = new List<UserExt>();
        }
        public string ClassId { get; set; }
        public string ClassName { get; set; }
        public string CourseId { get; set; }
        public Course Course { get; set; }
        public List<UserExt> userExts { get; set; }
    }
}

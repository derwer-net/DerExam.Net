using System.Collections.Generic;

namespace DerExam.Net.Models
{
    public class Class
    {
        public Class()
        {
            userExts = new List<UserExt>();
        }
        public int ClassesId { get; set; }
        public string ClassName { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public string IdentityUserId { get; set; }
        public List<UserExt> userExts { get; set; }
    }
}

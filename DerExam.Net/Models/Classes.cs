using System.Collections.Generic;

namespace DerExam.Net.Models
{
    public class Classes
    {
        public int ClassesId { get; set; }
        public int CoursesId{ get; set; }
        public IEnumerable<UserExt> MyProperty { get; set; }
    }
}
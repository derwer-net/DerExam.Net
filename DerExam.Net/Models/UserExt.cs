using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DerExam.Net.Models
{
    public class UserExt:IdentityUser
    {
        public string UserClass { get; set; }
        public IEnumerable<Exam> UserExams { get; set; }
        public IEnumerable<Course> UserCourse { get; set; }
    }
}

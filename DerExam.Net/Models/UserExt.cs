using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace DerExam.Net.Models
{
    public class UserExt:IdentityUser
    {
        public UserExt()
        {
            courses = new List<Course>();
        }
        public int ClassId { get; set; }
        public string CourseId { get; set; }
        public List<Course> courses { get; set; }
    }
}

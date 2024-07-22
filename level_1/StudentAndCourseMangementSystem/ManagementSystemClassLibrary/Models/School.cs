using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystemClassLibrary.Models
{
    public class School
    {
        public List<Student> Students { get; set; } 
        public List<Course> Courses { get; set; }

        public School() 
        {
            this.Students = new List<Student>();
            this.Courses = new List<Course>();
        }
    }
}

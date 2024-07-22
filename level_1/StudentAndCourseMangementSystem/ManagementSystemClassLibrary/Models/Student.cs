using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManagementSystemClassLibrary.Models;

namespace ManagementSystemClassLibrary
{
    public class Student
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public List<Course> EnrolledCourses { get; set; } = new List<Course>();

        public Student(string Name, int Id)
        {
            this.Name = Name;   
            this.Id = Id;
        }

    }
}

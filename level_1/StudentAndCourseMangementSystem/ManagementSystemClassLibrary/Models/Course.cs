using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystemClassLibrary.Models
{
    public class Course
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public Course(string Name, int Id)
        {
            this.Name = Name;
            this.Id = Id;
        }

    }
}

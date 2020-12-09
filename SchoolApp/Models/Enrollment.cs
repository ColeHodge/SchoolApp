using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SchoolApp.Models
{
    public class Enrollment
    {
        [Key] public int enrollment_id { get; set; }
        public int student_id { get; set; }
        public int course_id { get; set; }

        public Courses Course { get; set; }
        public Students Student { get; set; }
    }
}

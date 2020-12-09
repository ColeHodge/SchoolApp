using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SchoolApp.Models
{
    public class Courses
    {
        
        [Key] public int course_id { get; set; }
        public int course_number { get; set; }
        public string course_name { get; set; }
        public string course_description { get; set; }
    }
}

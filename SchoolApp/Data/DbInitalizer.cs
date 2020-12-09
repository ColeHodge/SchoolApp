using SchoolApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolApp.Data
{
    public static class DbInitalizer
    {
        public static void Initalizer(SchoolContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students
            if (context.Students.Any())
            {
                return; // DB has been seeded
            }

            var students = new Students[]
            {
                new Students{student_id=1,
                    first_name="Alexander",
                    last_name="O'neil",
                    email="Aoneil@gmail.com",
                    phone_number=123123124
                },
                new Students{student_id = 2,
                    first_name = "Bill",
                    last_name = "Kenedy",
                    email = "Bk@gmail.com",
                    phone_number = 89236149
                },
                new Students{student_id = 3,
                    first_name = "John",
                    last_name = "Doe",
                    email = "JohnDoe@gmail.com",
                    phone_number = 9125340
                },
            };
            foreach (Students s in students)
            {
                context.Students.Add(s);
            }
            context.SaveChanges();


            var courses = new Courses[]
            {
                new Courses{course_id=1,
                    course_number=3201,
                    course_description="Math"
                },
                new Courses{course_id=2,
                    course_number=3201,
                    course_description="Chemistry"
                },
                new Courses{course_id=3,
                    course_number=3201,
                    course_description="Physics"
                },
            };
            foreach (Courses c in courses)
            {
                context.Courses.Add(c);
            }
            context.SaveChanges();


            var instructors = new Instructors[]
            {
                new Instructors{instructor_id = 1,
                    first_name = "Mandy",
                    last_name = "Hart",
                    email = "ManH@gmail.com",
                    course_id = 2
                },
                new Instructors{instructor_id = 2,
                    first_name = "August",
                    last_name = "Fitzpatrick",
                    email = "AuFitz@gmail.com",
                    course_id = 3
                },
                new Instructors{instructor_id = 3,
                    first_name = "Christen",
                    last_name = "Edwards",
                    email = "ChristenEd@gmail.com",
                    course_id = 1
                },
            };
            foreach (Instructors i in instructors)
            {
                context.Instructors.Add(i);
            }
            context.SaveChanges();

            var enrollment = new Enrollment[]
            {
                new Enrollment{enrollment_id = 1,
                    student_id = 3,
                    course_id = 2
                },
                new Enrollment{enrollment_id = 2,
                    student_id = 1,
                    course_id = 3
                },
                new Enrollment{enrollment_id = 3,
                    student_id = 2,
                    course_id = 2
                },
            };
            foreach (Enrollment e in enrollment)
            {
                context.Enrollment.Add(e);
            }
            context.SaveChanges();
        }
    }
}

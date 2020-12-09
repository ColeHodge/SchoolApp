using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolApp.Models;
using System.Runtime.InteropServices.ComTypes;
using Microsoft.EntityFrameworkCore.Internal;

namespace SchoolApp.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {

        }

        public DbSet<Courses> Courses { get; set; }
        public DbSet<Students> Students { get; set; }
        public DbSet<Instructors> Instructors { get; set; }
        public DbSet<Enrollment> Enrollment { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Courses>().ToTable("Courses");
            modelBuilder.Entity<Students>().ToTable("Students");
            modelBuilder.Entity<Instructors>().ToTable("Instructors");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
        }
    }
}

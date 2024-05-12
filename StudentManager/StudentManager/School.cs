using System;
using System.Data.Entity;
using System.Linq;

namespace StudentManager
{
    public class School : DbContext
    {
        public School()
            : base("name=School")
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Attendance> Attendance { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Grade> Grades { get; set; }
    }
}
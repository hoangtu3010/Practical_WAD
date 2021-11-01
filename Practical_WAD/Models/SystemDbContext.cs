using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Practical_WAD.Models
{
    public class SystemDbContext : DbContext
    {
        public SystemDbContext() : base("practical") { }

        public DbSet<ExamSubject> ExamSubjects { get; set; }

        public DbSet<ClassRoom> ClassRooms { get; set; }

        public DbSet<Faculty> Faculties { get; set; }

        public DbSet<Exam> Exams { get; set; }

    }
}
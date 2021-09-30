using Microsoft.EntityFrameworkCore;
using MsfConsulting.Lausa.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsfConsulting.Lausa.Data.Repository
{
    public class LausaContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Unenrollment> Unenrollments { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Student> Students { get; set; }

        public LausaContext(DbContextOptions<LausaContext> options)
            : base(options)
        {
        }

       protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}

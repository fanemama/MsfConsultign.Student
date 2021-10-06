using Microsoft.EntityFrameworkCore;
using MsfConsulting.Lausa.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsfConsulting.Lausa.Domain.Repository
{
    public class LausaDbContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Unenrollment> Unenrollments { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Student> Students { get; set; }

        public LausaDbContext(DbContextOptions<LausaDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().HasData(
            new Course { Id = 1, Code = "Physic", Label = "Physic" },
            new Course { Id = 2, Code = "Mathematic", Label = "Mathematic" },
            new Course { Id = 3, Code = "Biologic", Label = "Biologic" },
            new Course { Id = 4, Code = "Geographic", Label = "Geographic" }
            );


            modelBuilder.Entity<Grade>().HasData(
              new Grade { Id = 1, Code = "A", Label = "A" },
              new Grade { Id = 2, Code = "B", Label = "B" },
              new Grade { Id = 3, Code = "C", Label = "C" },
              new Grade { Id = 4, Code = "D", Label = "D" },
              new Grade { Id = 5, Code = "F", Label = "F" }
              );

            base.OnModelCreating(modelBuilder);
        }
    }
}

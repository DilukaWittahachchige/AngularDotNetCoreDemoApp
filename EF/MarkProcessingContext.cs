using EF.Models;
using Microsoft.EntityFrameworkCore;

namespace EF
{
    public class MarkProcessingContext : DbContext
    {
        public MarkProcessingContext(DbContextOptions<MarkProcessingContext> options) : base(options)
        {
        }

        public DbSet<Class> Classes { get; set; }
        public DbSet<Code> Codes { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Class>().ToTable("Class");
            modelBuilder.Entity<Code>().ToTable("Code");
            modelBuilder.Entity<Exam>().ToTable("Exam");
            modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Entity<Subject>().ToTable("Subject");
            modelBuilder.Entity<User>().ToTable("User");
        }
    }
}

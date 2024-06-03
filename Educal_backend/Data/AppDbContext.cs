using Educal_backend.Models;
using Microsoft.EntityFrameworkCore;
using System.Composition;
using System.Reflection.Metadata;

namespace Educal_backend.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseImage> CourseImages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<Course>().HasQueryFilter(m => !m.SoftDeleted);
        }
    }
}

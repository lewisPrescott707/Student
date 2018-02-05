using Microsoft.EntityFrameworkCore;

namespace Student.Models
{
    public class StudentContext : DbContext
    {
        /// <inheritdoc />
        /// <summary>
        /// Student DbContext
        /// </summary>
        /// <param name="options"></param>
        public StudentContext(DbContextOptions options) : base(options) { }

        public DbSet<Student> Students { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// ModelBuilder used with EnityFrameworkCore's Fluent API = DbModelBuilder in .Net Framework
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // StudentName Is Required
            //one-to-many
            // Standard has many Students
            // Foreign Key = StandardId
            modelBuilder.Entity<Student>().Property(s => s.StudentName)
                .IsRequired();
            modelBuilder.Entity<Standard>()
                .HasMany(s => s.Students)
                .WithOne().HasForeignKey(s => s.StandardId);
        }
    }
}

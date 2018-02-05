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
            //one-to-many
            // Foreign Key = StandardId
            // Standard Is Required
            modelBuilder.Entity<Student>().Property(s => s.StudentName)
                .IsRequired();
            modelBuilder.Entity<Standard>()
                .HasMany(s => s.Students)
                .WithOne().HasForeignKey(s => s.StandardId);
        }
    }
}

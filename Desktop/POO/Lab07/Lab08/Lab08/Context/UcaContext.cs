using Lab08.Entities.Students;
using Microsoft.EntityFrameworkCore;

namespace Lab08.Context
{
    public class UcaContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
            options.UseSqlServer("Server=DESKTOP-1NERIJQ;Database=ucadb;Trusted_Connection=True;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .Property(s => s.Id)
                .ValueGeneratedOnAdd();
             
        }

    }
}
using Microsoft.EntityFrameworkCore;

namespace one_to_one
{
    public class WindowDbContext : DbContext
    {
        public DbSet<Card> Cards { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=OneToOneDB;Encrypt=False;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new StudentConfiguration().Configure(modelBuilder.Entity<Student>());
            new CardConfiguration().Configure(modelBuilder.Entity<Card>());
        }
    }
}

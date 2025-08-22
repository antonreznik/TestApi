using Domain;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class UsersDbContext : DbContext
    {
        public DbSet<UserEntity> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql(@"Host=localhost;Username=postgres;Password=12345;Database=users");
    }
}

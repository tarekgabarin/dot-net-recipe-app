using Microsoft.EntityFrameworkCore;

namespace DotNetRecipesApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) {}
        public DbSet<Entities.AppUser> AppUsers { get; set; }
        public DbSet<Entities.Recipe> Recipes { get; set; }
        public DbSet<Entities.Tag> Tags { get; set; }
    }
}

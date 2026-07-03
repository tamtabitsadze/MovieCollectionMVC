using Microsoft.EntityFrameworkCore;
using MovieCollectionMVC.Models;

namespace MovieCollectionMVC.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
    }
}
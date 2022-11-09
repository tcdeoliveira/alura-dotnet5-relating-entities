using MoviesAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MoviesAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base (opt)
        {

        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
    }
}

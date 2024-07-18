using Microsoft.EntityFrameworkCore;

namespace MVCPelicula.Models
{
    public class PeliculasDBContext : DbContext
    {
        public PeliculasDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Película> Peliculas { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;

namespace AltaPiloto.Models
{
    public class PilotoContext : DbContext
    {
        public PilotoContext(DbContextOptions<PilotoContext> options) : base(options) { }

        public DbSet<Piloto> pilotos { get; set; }
        public DbSet<Nacionalidad> nacionalidades { get; set; }
        public DbSet<Usuario> usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}


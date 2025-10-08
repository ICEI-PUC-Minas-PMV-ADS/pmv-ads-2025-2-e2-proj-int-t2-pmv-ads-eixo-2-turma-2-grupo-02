using AgrInov.Models;
using Microsoft.EntityFrameworkCore;

namespace AgrInov.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){ }

        public DbSet<Cultura> Culturas { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Insumos> Insumos { get; set; }
    }
}

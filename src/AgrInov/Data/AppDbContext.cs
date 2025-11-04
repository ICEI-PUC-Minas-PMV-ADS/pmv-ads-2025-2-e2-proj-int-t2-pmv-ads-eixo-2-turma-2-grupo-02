using System.Drawing;
using AgrInov.Models;
using Microsoft.EntityFrameworkCore;

namespace AgrInov.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){ }
        public DbSet<Cultura> Culturas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Insumo> Insumos { get; set; }
        public DbSet<AreaDePlantio> AreasDePlantio { get; set; }
        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<PropriedadeAgricula> PropriedadeAgricula { get; set; }
        public DbSet<Imagem> Imagem { get; set; }
    }
}

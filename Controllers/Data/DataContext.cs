using Microsoft.EntityFrameworkCore;
using Nutri.Data;
using Nutri.Data.Map;
using Nutri.Models;
namespace Nutri.Data
{
    public class DataContext : DbContext
    {

        public DbSet<FichaTecnica> FichaTecnicas { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=Express.;database=FichaTecnicaDb;trusted_connection=true;");
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new FichaTecnicaMap());
            builder.ApplyConfiguration(new CategoriaMap());
            builder.ApplyConfiguration(new UsuarioMap());



        }
    }
}



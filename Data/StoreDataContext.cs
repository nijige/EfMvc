using Microsoft.EntityFrameworkCore;
using Nutri.Models;
namespace Nutri.Data
{
    public class StoreDataContext : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<FichaTecnica> FichaTecnicas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost,1433;Database=nutri;User ID=SA;Password=123");

        }


    }

}
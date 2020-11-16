using Microsoft.EntityFrameworkCore;
using Nutri.Data.Maps;
using Nutri.Models;

namespace Nutri.Data
{
    
    public class StoreDataContext : DbContext
    {
        public StoreDataContext(DbContextOptions<StoreDataContext> options)
            : base(options)
        {
        }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<FichaTecnica> FichaTecnicas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Integrated Security=true");

        // }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new FichaTecnicaMap());
            builder.ApplyConfiguration(new CategoriaMap());



        }


    }

}
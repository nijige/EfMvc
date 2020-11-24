using Microsoft.EntityFrameworkCore;
using Nutri.Mvc.Models;

namespace Nutri.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<FichaTecnica> FichaTecnicas { get; set; }
        public DbSet<Dieta> Dietas { get; set; }
        public DbSet<Produto> Produtos { get; set; }

    }
}
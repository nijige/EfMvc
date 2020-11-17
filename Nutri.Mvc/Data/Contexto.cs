using Microsoft.EntityFrameworkCore;
using Nutri.Mvc.Models;

namespace Nutri.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<FichaTecnica> FichaTecnica { get; set; }



    }
}
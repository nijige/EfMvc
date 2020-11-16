using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nutri.Models;

namespace Nutri.Data.Maps
 
 
 {
     public class CategoriaMap : IEntityTypeConfiguration<Categoria>
     {
         public void Configure(EntityTypeBuilder<Categoria> builder)
         {
             builder.ToTable("Categoria");
             builder.HasKey(x => x.Id);








         }

     }

 }

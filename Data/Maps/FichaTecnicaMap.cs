using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nutri.Models;

namespace Nutri.Data.Maps
{
    public class FichaTecnicaMap : IEntityTypeConfiguration<FichaTecnica>
     
    {
       
     
         public void Configure(EntityTypeBuilder<FichaTecnica> builder)
         {
             builder.ToTable("FichaTecnica");
             builder.HasKey(x => x.Id);
             builder.HasOne(x => x.Categoria).WithMany(x => x.FichaTecnicas);





         }

     }
 }


        
    

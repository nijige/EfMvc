using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nutri.Models;

namespace Nutri.Data.Map
{
    public class FichaTecnicaMap : IEntityTypeConfiguration<FichaTecnica>
    {
        public void Configure(EntityTypeBuilder<FichaTecnica> builder)
        {
            builder.ToTable("FichaTecnica");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Ingredientes).IsRequired();
            builder.Property(x => x.Descricao).IsRequired().HasMaxLength(1024).HasColumnType("varchar(1024)");
            builder.Property(x => x.Image).IsRequired().HasMaxLength(1024).HasColumnType("varchar(1024)");
            builder.Property(x => x.Quantidade).IsRequired();
            builder.Property(x => x.ModoPreparo).IsRequired().HasMaxLength(1024).HasColumnType("varchar(1024)");
            builder.Property(x => x.Rendimento).IsRequired().HasColumnType("money");
            builder.Property(x => x.CustoTotal).IsRequired().HasColumnType("money");
            builder.Property(x => x.CustoPorcao).IsRequired().HasColumnType("money");
        }
    }
}



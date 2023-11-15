using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoPizzariaDominio.ModuloSabor;

namespace PizzariaDoZe.Infra.Orm.ModuloSabor
{
    public class MapeadorSaborOrm : IEntityTypeConfiguration<Sabor> {
        public void Configure(EntityTypeBuilder<Sabor> builder) {
            builder.ToTable("TBSabor");

            builder.Property(c => c.id).IsRequired().ValueGeneratedNever();

            builder.Property(c => c.Tipo).HasConversion<int>().IsRequired();

            builder.Property(c => c.Descricao).HasColumnType("varchar(100)").IsRequired();

            builder.Property(c => c.Categoria).HasConversion<int>().IsRequired();

            builder.HasMany(c => c.SaborIngredientes).WithMany().UsingEntity(x => x.ToTable("TBSabor_TBIngrediente"));
        }
    }
}

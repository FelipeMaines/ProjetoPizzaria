using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoPizzariaDominio.ModuloIgrediente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPizzaria.Infra.Orm.ModuloIngrediente {
    internal class MapeadorIngredienteOrm : IEntityTypeConfiguration<Ingrediente> {
        public void Configure(EntityTypeBuilder<Ingrediente> ingredienteBuilder) {

            ingredienteBuilder.ToTable("TBIngrediente");

            ingredienteBuilder.Property(p => p.id).IsRequired().ValueGeneratedNever();

            ingredienteBuilder.Property(p => p.nome).HasColumnType("varchar(50)").IsRequired();
        }
    }
}

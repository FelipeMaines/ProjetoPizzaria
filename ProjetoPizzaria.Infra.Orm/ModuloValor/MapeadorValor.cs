using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoPizzariaDominio.ModuloValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPizzaria.Infra.Orm.ModuloValor
{
    public class MapeadorValor : IEntityTypeConfiguration<Valor>
    {
        public void Configure(EntityTypeBuilder<Valor> builder)
        {
            builder.ToTable("TBValor");

            builder.Property(x => x.id).ValueGeneratedNever();
        }
    }
}

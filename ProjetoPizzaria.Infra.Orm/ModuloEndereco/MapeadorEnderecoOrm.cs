using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoPizzariaDominio.ModuloEndereco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPizzaria.Infra.Orm.ModuloEndereco {
    internal class MapeadorEnderecoOrm : IEntityTypeConfiguration<Endereco> {
        public void Configure(EntityTypeBuilder<Endereco> builder) {

            builder.ToTable("TBEndereco");
        
        }
    }
}

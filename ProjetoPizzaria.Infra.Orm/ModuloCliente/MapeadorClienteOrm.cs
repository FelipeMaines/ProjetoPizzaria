using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoPizzariaDominio.ModuloCliente;

namespace ProjetoPizzaria.Infra.Orm.ModuloCliente {
    public class MapeadorClienteOrm : IEntityTypeConfiguration<Cliente> {
        public void Configure(EntityTypeBuilder<Cliente> clienteBuilder) {

            clienteBuilder.ToTable("TBCliente");

            clienteBuilder.Property(c => c.id).IsRequired().ValueGeneratedNever();

            clienteBuilder.Property(c => c.Nome).HasColumnType("varchar(20)").IsRequired();

            clienteBuilder.Property(c => c.Cpf).HasColumnType("varchar(20)").IsRequired();

            clienteBuilder.Property(c => c.Telefone).HasColumnType("varchar(20)").IsRequired();

            clienteBuilder.Property(c => c.Email).HasColumnType("varchar(50)").IsRequired();

            clienteBuilder.Property(c => c.Complemento).HasColumnType("varchar(100)").IsRequired();

            clienteBuilder.HasOne(c => c.Endereco).WithMany().IsRequired().HasConstraintName("FK_TBCliente_TBEndereco").OnDelete(DeleteBehavior.NoAction);

            clienteBuilder.Property(c => c.Numero).HasColumnType("varchar(10)").IsRequired();


        }
    }
}

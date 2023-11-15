using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ProjetoPizzariaDominio.ModuloFuncionario;

namespace PizzariaDoZe.Infra.Orm.ModuloFuncionario
{
    public class MapeadorFuncionarioOrm : IEntityTypeConfiguration<Funcionario> {
        public void Configure(EntityTypeBuilder<Funcionario> builder) {

            builder.ToTable("TBFuncionario");

            builder.Property(c => c.id).IsRequired().ValueGeneratedNever();

            builder.Property(c => c.Email).HasColumnType("varchar(100)").IsRequired();

            builder.Property(c => c.Complemento).HasColumnType("varchar(100)").IsRequired();

            builder.Property(c => c.Cpf).HasColumnType("varchar(100)").IsRequired();

            builder.Property(c => c.Telefone).HasColumnType("varchar(100)").IsRequired();

            builder.Property(c => c.Matricula).HasColumnType("varchar(100)").IsRequired();

            builder.Property(c => c.Senha).HasColumnType("varchar(100)").IsRequired();

            builder.Property(c => c.Nome).HasColumnType("varchar(100)").IsRequired();

            builder.Property(c => c.Numero).HasColumnType("varchar(10)").IsRequired();

            builder.HasOne(c => c.endereco).WithMany().IsRequired().HasConstraintName("FK_TBFuncionario_TBEndereco").OnDelete(DeleteBehavior.NoAction);




        }
    }
}

﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoPizzaria.Infra.Orm.Compartilhado;

#nullable disable

namespace ProjetoPizzaria.Infra.Orm.Migrations
{
    [DbContext(typeof(PizzariaDbContext))]
    partial class PizzariaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("IngredienteSabor", b =>
                {
                    b.Property<Guid>("SaborIngredientesid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Saborid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("SaborIngredientesid", "Saborid");

                    b.HasIndex("Saborid");

                    b.ToTable("TBSabor_TBIngrediente", (string)null);
                });

            modelBuilder.Entity("ProjetoPizzariaDominio.ModuloCliente.Cliente", b =>
                {
                    b.Property<Guid>("id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Complemento")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<Guid>("Enderecoid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.HasKey("id");

                    b.HasIndex("Enderecoid");

                    b.ToTable("TBCliente", (string)null);
                });

            modelBuilder.Entity("ProjetoPizzariaDominio.ModuloEndereco.Endereco", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pais")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("TBEndereco", (string)null);
                });

            modelBuilder.Entity("ProjetoPizzariaDominio.ModuloFuncionario.Funcionario", b =>
                {
                    b.Property<Guid>("id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Complemento")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Grupo")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Matricula")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Motorista")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Observacao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("Validade")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("enderecoid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("id");

                    b.HasIndex("enderecoid");

                    b.ToTable("TBFuncionario", (string)null);
                });

            modelBuilder.Entity("ProjetoPizzariaDominio.ModuloIgrediente.Ingrediente", b =>
                {
                    b.Property<Guid>("id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("id");

                    b.ToTable("TBIngrediente", (string)null);
                });

            modelBuilder.Entity("ProjetoPizzariaDominio.ModuloProduto.Produto", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ML")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("id");

                    b.ToTable("TBProduto", (string)null);
                });

            modelBuilder.Entity("ProjetoPizzariaDominio.ModuloSabor.Sabor", b =>
                {
                    b.Property<Guid>("id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Categoria")
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<byte[]>("Foto")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("TBSabor", (string)null);
                });

            modelBuilder.Entity("ProjetoPizzariaDominio.ModuloValor.Valor", b =>
                {
                    b.Property<Guid>("id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Categoria")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Tamanho")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<decimal>("ValorBorda")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ValorPizza")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("id");

                    b.ToTable("TBValor", (string)null);
                });

            modelBuilder.Entity("IngredienteSabor", b =>
                {
                    b.HasOne("ProjetoPizzariaDominio.ModuloIgrediente.Ingrediente", null)
                        .WithMany()
                        .HasForeignKey("SaborIngredientesid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjetoPizzariaDominio.ModuloSabor.Sabor", null)
                        .WithMany()
                        .HasForeignKey("Saborid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProjetoPizzariaDominio.ModuloCliente.Cliente", b =>
                {
                    b.HasOne("ProjetoPizzariaDominio.ModuloEndereco.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("Enderecoid")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_TBCliente_TBEndereco");

                    b.Navigation("Endereco");
                });

            modelBuilder.Entity("ProjetoPizzariaDominio.ModuloFuncionario.Funcionario", b =>
                {
                    b.HasOne("ProjetoPizzariaDominio.ModuloEndereco.Endereco", "endereco")
                        .WithMany()
                        .HasForeignKey("enderecoid")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_TBFuncionario_TBEndereco");

                    b.Navigation("endereco");
                });
#pragma warning restore 612, 618
        }
    }
}

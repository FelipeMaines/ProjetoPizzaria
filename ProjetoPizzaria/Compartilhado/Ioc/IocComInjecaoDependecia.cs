using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PizzariaDoZe.Infra.Orm.ModuloIngrediente;
using ProjetoPizzaria.infra.ModuloCliente;
using ProjetoPizzaria.infra.ModuloValor;
using ProjetoPizzaria.Infra.Orm.Compartilhado;
using ProjetoPizzaria.Infra.Orm.ModuloCliente;
using ProjetoPizzaria.Infra.Orm.ModuloEndereco;
using ProjetoPizzaria.Infra.Orm.ModuloFuncionario;
using ProjetoPizzaria.ModuloCep;
using ProjetoPizzaria.ModuloCliente;
using ProjetoPizzaria.ModuloFuncionario;
using ProjetoPizzaria.ModuloIgrediente;
using ProjetoPizzaria.ModuloValores;
using ProjetoPizzariaDominio.ModuloCliente;
using ProjetoPizzariaDominio.ModuloEndereco;
using ProjetoPizzariaDominio.ModuloFuncionario;
using ProjetoPizzariaDominio.ModuloIgrediente;
using ProjetoPizzariaDominio.ModuloValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPizzaria.Compartilhado.Ioc
{
    public class IocComInjecaoDependecia : Ioc
    {
        private ServiceProvider container;

        public IocComInjecaoDependecia()
        {
            var configuracao = new ConfigurationBuilder()
              .SetBasePath(Directory.GetCurrentDirectory())
              .AddJsonFile("appsettings.json")
              .Build();

            var connectionString = configuracao.GetConnectionString("SqlServer");

            var servicos = new ServiceCollection();

            servicos.AddDbContext<PizzariaDbContext>(optionsBuilder =>
            {
                optionsBuilder.UseSqlServer(connectionString);
            });

            servicos.AddTransient<ControladorCliente>();
            servicos.AddTransient<IRepositorioClienteOrm, RepositorioClienteOrm>();

            servicos.AddTransient<ControladorCep>();
            servicos.AddTransient<IRepositorioEnderecoOrm, RepositorioEnderecoOrm>();

            servicos.AddTransient<ControladorFuncionario>();
            servicos.AddTransient<IRepositorioFuncionarioOrm, RepositorioFuncionarioOrm>();

            servicos.AddTransient<ControladorIgrediente>();
            servicos.AddTransient<IRepositorioIngredienteOrm, RepositorioIngredienteOrm>();

            servicos.AddTransient<ControladorValores>();
            servicos.AddTransient<IRepositorioValorOrm, RepositorioValorOrm>();

            container = servicos.BuildServiceProvider();

        }
        public T Get<T>()
        {
            return container.GetService<T>();
        }
    }
}

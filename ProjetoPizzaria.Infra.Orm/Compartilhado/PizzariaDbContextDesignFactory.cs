using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPizzaria.Infra.Orm.Compartilhado
{
    public class PizzariaDbContextDesignFactory : IDesignTimeDbContextFactory<PizzariaDbContext>
    {
        public PizzariaDbContext CreateDbContext(string[] args)
        {
            var configuracao = new ConfigurationBuilder()
           .SetBasePath(Directory.GetCurrentDirectory())
           .AddJsonFile("appsettings.json")
           .Build();

            var connectionString = configuracao.GetConnectionString("SqlServer");

            var optionsBuilder = new DbContextOptionsBuilder<PizzariaDbContext>();

            optionsBuilder.UseSqlServer(connectionString);

            return new PizzariaDbContext(optionsBuilder.Options);
        }
    }
}

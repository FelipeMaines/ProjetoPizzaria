using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPizzaria.Infra.Orm.Compartilhado
{
    public class PizzariaDbContext : DbContext
    {
        public PizzariaDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Type tipo = typeof(PizzariaDbContext);

            Assembly dllConfiguracoes = tipo.Assembly;

            modelBuilder.ApplyConfigurationsFromAssembly(dllConfiguracoes);

            base.OnModelCreating(modelBuilder);
        }
    }
}

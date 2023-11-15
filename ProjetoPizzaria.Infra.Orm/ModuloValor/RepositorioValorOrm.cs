using ProjetoPizzaria.Infra.Orm.Compartilhado;
using ProjetoPizzariaDominio.ModuloValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPizzaria.infra.ModuloValor
{
    public class RepositorioValorOrm : RepositorioBaseOrm<Valor>, IRepositorioValorOrm
    {
        public RepositorioValorOrm(PizzariaDbContext dbContext) : base(dbContext)
        {
        }
    }
}

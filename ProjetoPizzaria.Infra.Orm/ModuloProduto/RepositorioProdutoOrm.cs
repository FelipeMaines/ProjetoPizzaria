using ProjetoPizzaria.Infra.Orm.Compartilhado;
using ProjetoPizzariaDominio.ModuloProduto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPizzaria.Infra.Orm.ModuloProduto
{
    public class RepositorioProdutoOrm : RepositorioBaseOrm<Produto>, IRepositorioProdutoOrm
    {
        public RepositorioProdutoOrm(PizzariaDbContext dbContext) : base(dbContext)
        {
        }
    }
}

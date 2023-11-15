using Microsoft.EntityFrameworkCore;
using ProjetoPizzaria.Infra.Orm.Compartilhado;
using ProjetoPizzariaDominio.ModuloSabor;

namespace ProjetoPizzaria.Infra.Orm.ModuloSabor
{
    public class RepositorioSaborOrm : RepositorioBaseOrm<Sabor>, IRepositorioSaborOrm {
        public RepositorioSaborOrm(PizzariaDbContext dbContext) : base(dbContext) {
        }

        public Sabor SelecionarPorNome(string descricao) {

            return registros.FirstOrDefault(x => x.Descricao == descricao);
        }

        public List<Sabor> SelecionarTodos() {
            return registros.Include(x => x.SaborIngredientes).ToList();
        }
    }
}

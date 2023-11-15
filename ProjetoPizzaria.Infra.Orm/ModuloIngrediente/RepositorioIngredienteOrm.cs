using ProjetoPizzaria.Infra.Orm.Compartilhado;
using ProjetoPizzariaDominio.ModuloIgrediente;

namespace PizzariaDoZe.Infra.Orm.ModuloIngrediente
{
    public class RepositorioIngredienteOrm : RepositorioBaseOrm<Ingrediente>, IRepositorioIngredienteOrm {

        public RepositorioIngredienteOrm(PizzariaDbContext dbContext) : base(dbContext) { }

        public Ingrediente SelecionarPorNome(string nome) {

            return registros.FirstOrDefault(x => x.nome == nome);
        }
    }
}

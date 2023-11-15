using Microsoft.EntityFrameworkCore;
using ProjetoPizzaria.Infra.Orm.Compartilhado;
using ProjetoPizzariaDominio.ModuloCliente;

namespace ProjetoPizzaria.Infra.Orm.ModuloCliente
{
    public class RepositorioClienteOrm : RepositorioBaseOrm<Cliente>, IRepositorioClienteOrm {
        public RepositorioClienteOrm(PizzariaDbContext dbContext) : base(dbContext) {
        }

        public Cliente SelecionarPorNome(string nome) {

            return registros.FirstOrDefault(x => x.Nome == nome);
        }

        public List<Cliente> SelecionarTodos() {
            return registros.Include(x => x.Endereco).ToList();
        }
    }
}

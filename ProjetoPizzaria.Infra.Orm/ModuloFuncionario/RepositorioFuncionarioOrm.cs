using Microsoft.EntityFrameworkCore;
using ProjetoPizzaria.Infra.Orm.Compartilhado;
using ProjetoPizzariaDominio.ModuloFuncionario;

namespace ProjetoPizzaria.Infra.Orm.ModuloFuncionario
{
    public class RepositorioFuncionarioOrm : RepositorioBaseOrm<Funcionario>, IRepositorioFuncionarioOrm {
        public RepositorioFuncionarioOrm(PizzariaDbContext dbContext) : base(dbContext) {
        }
        public Funcionario SelecionarPorNome(string nome) {

            return registros.FirstOrDefault(x => x.Nome == nome);
        }

        public List<Funcionario> SelecionarTodos() {
            return registros.Include(x => x.endereco).ToList();
        }
    }
}

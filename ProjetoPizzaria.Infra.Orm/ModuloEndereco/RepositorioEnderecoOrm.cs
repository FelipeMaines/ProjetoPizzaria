using Microsoft.EntityFrameworkCore;
using ProjetoPizzaria.Infra.Orm.Compartilhado;
using ProjetoPizzariaDominio.ModuloEndereco;

namespace ProjetoPizzaria.Infra.Orm.ModuloEndereco
{
    public class RepositorioEnderecoOrm: RepositorioBaseOrm<Endereco>, IRepositorioEnderecoOrm 
    {
        public RepositorioEnderecoOrm(PizzariaDbContext dbContext) : base(dbContext) { }

        public Endereco SelecionarPorCep(string cep) {

            return registros.FirstOrDefault(x => x.Cep == cep);
        }
    }
}

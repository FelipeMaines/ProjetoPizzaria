using Microsoft.EntityFrameworkCore;
using ProjetoPizzariaDominio.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPizzaria.Infra.Orm.Compartilhado
{
    public class RepositorioBaseOrm<T> : IRepositorioBaseOrm<T> where T : EntidadeBase<T>
    {
        protected readonly PizzariaDbContext dbContext;
        protected DbSet<T> registros;

        public RepositorioBaseOrm(PizzariaDbContext dbContext)
        {
            this.dbContext = dbContext;
            registros = dbContext.Set<T>();
        }
        public virtual void Editar(T registro)
        {
            registros.Update(registro);

            dbContext.SaveChanges();
        }

        public virtual void Excluir(T registro)
        {
            registros.Remove(registro);

            dbContext.SaveChanges();
        }

        public virtual void Inserir(T novoRegistro)
        {
            registros.Add(novoRegistro);

            dbContext.SaveChanges();
        }

        public virtual List<T> Pesquisar(string registro)
        {
            return registros.ToList();
        }

        public virtual T SelecionarPorId(int id)
        {
            return registros.FirstOrDefault(x => x.id == id);
        }

        public virtual List<T> SelecionarTodos()
        {
            return registros.ToList();
        }
    }
}

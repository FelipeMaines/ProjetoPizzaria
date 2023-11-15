using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPizzariaDominio.Compartilhado
{
    public interface IRepositorioBaseOrm<T> where T : EntidadeBase<T>
    {
        void Inserir(T novoRegistro);

        void Editar(T registro);

        void Excluir(T registro);

        List<T> Pesquisar(string registros);

        List<T> SelecionarTodos();

        T SelecionarPorId(Guid id);
    }
}

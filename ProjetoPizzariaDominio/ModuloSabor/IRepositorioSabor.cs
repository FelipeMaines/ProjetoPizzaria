using ProjetoPizzariaDominio.Compartilhado;
using ProjetoPizzariaDominio.ModuloIgrediente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPizzariaDominio.ModuloSabor
{
    public interface IRepositorioSabor : IRepositorioBase<Sabor>
    {
        List<Ingrediente> SelecionarIgredientesDoSabor(int id);
    }
}

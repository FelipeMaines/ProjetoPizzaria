using ProjetoPizzariaDominio.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPizzariaDominio.ModuloEndereco
{
    public class Pais : EntidadeBase<Pais>
    {
        public string nome { get; set; }

        public Pais(int idPais, string? nomePais)
        {
            this.nome = nomePais;
            this.id = idPais;
        }

    }
}

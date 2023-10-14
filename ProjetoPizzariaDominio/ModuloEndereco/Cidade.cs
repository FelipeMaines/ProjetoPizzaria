using ProjetoPizzariaDominio.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPizzariaDominio.ModuloEndereco
{
    public class Cidade : EntidadeBase<Cidade>
    {
        public string nome { get; set; }


        public Cidade(int idCidade, string? nomeCidade)
        {
            this.id = idCidade;
            this.nome = nomeCidade;
        }

    }
}

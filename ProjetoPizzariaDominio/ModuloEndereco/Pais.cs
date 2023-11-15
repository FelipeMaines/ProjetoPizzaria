using ProjetoPizzariaDominio.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPizzariaDominio.ModuloEndereco
{
    public class Pais : EntidadeBase<Pais>
    {
        public List<Uf> estados;
        public string nome { get; set; }

        public Pais()
        {
            estados = new List<Uf>();
        }
        public Pais(int idPais, string? nomePais)
        {
            this.nome = nomePais;
            this.id = idPais;
        }

    }
}

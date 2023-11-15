using ProjetoPizzariaDominio.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPizzariaDominio.ModuloEndereco
{
    public class Uf : EntidadeBase<Uf>
    {
        public string nome { get; set; }
        public List<Cidade> cidades { get; set; }
        public Pais pais { get; set; }

        public Uf()
        {
            cidades = new List<Cidade>();
        }

        public Uf(Guid idUf, string nomeUf)
        {
            this.id = idUf;
            this.nome = nomeUf;
        }
    }
}

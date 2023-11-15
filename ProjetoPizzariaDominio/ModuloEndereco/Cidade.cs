using ProjetoPizzariaDominio.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPizzariaDominio.ModuloEndereco
{
    public class Cidade : EntidadeBase<Cidade>
    {
        public string nome { get; set; }
        public List<Endereco> enderecos { get; set; }

        public Uf Estado { get; set; }  
        public Cidade()
        {
            enderecos = new List<Endereco>();
        }
        public Cidade(Guid idCidade, string? nomeCidade)
        {
            this.id = idCidade;
            this.nome = nomeCidade;
        }

    }
}

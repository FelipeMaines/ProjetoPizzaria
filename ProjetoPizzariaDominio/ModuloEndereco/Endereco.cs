using ProjetoPizzariaDominio.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPizzariaDominio.ModuloEndereco
{
    public class Endereco : EntidadeBase<Endereco>
    {
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public int IdCidade { get; set; }
        public Cidade Cidade { get; set; }
        public int IdUf { get; set; }
        public Uf Uf { get; set; }
        public int IdPais { get; set; }
        public Pais Pais { get; set; }
        public Endereco(int id, string cep, string logradouro, string bairro,
         int idCidade, Cidade cidade,
         int idUf, Uf uf, int idPais, Pais pais)
        {
            this.id = id;
            IdCidade = idCidade;
            Cep = cep;
            Logradouro = logradouro;
            Bairro = bairro;
            Cidade = cidade;
            IdUf = idUf;
            Uf = uf;
            IdPais = idPais;
            Pais = pais;
        }
    }
}

using ProjetoPizzariaDominio.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPizzariaDominio.ModuloProduto
{
    public class Produto : EntidadeBase<Produto>
    {
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public char Tipo { get; set; }
        public string ML { get; set; }

        public Produto()
        {
            
        }

        public Produto(string descricao, decimal valor, char tipo, string mL)
        {
            Descricao = descricao;
            Valor = valor;
            Tipo = tipo;
            ML = mL;
        }
    }
}

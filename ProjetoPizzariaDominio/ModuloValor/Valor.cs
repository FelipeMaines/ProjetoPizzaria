using ProjetoPizzariaDominio.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPizzariaDominio.ModuloValor
{
    public class Valor : EntidadeBase<Valor>
    {
        public char Tamanho { get; set; }
        public char Categoria { get; set; }
        public decimal ValorPizza { get; set; }
        public decimal ValorBorda { get; set; }

        public Valor()
        {
            
        }
        public Valor(char tamanho = ' ', char categoria = ' ', decimal valorPizza = 0, decimal valorBorda = 0)
        {
            Tamanho = tamanho;
            Categoria = categoria;
            ValorPizza = valorPizza;
            ValorBorda = valorBorda;
        }

        public Valor(int id = 0, char tamanho = ' ', char categoria = ' ', decimal valorPizza = 0, decimal valorBorda = 0)
        {
            this.id = id;
            Tamanho = tamanho;
            Categoria = categoria;
            ValorPizza = valorPizza;
            ValorBorda = valorBorda;
        }
    }
}

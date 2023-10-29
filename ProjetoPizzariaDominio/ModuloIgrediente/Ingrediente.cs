using ProjetoPizzariaDominio.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPizzariaDominio.ModuloIgrediente
{
    public class Ingrediente : EntidadeBase<Ingrediente>
    {
        public string nome { get; set; }

        public Ingrediente()
        {
            
        }

        public Ingrediente(string Nome)
        {
            this.nome = Nome;
        }

        public Ingrediente(string Nome, int Id) 
        {
            this.nome = Nome;
            this.id = Id;
        }

        public override string ToString()
        {
            return nome;
        }
    }
}

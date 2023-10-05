using ProjetoPizzariaDominio.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPizzariaDominio.ModuloIgrediente
{
    public class Igrediente : EntidadeBase<Igrediente>
    {
        public string nome { get; set; }

        public Igrediente()
        {
            
        }

        public Igrediente(string Nome)
        {
            this.nome = Nome;
        }

        public Igrediente(string Nome, int Id) 
        {
            this.nome = Nome;
            this.id = Id;
        }
    }
}

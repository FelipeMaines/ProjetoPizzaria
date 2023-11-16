using ProjetoPizzariaDominio.Compartilhado;
using ProjetoPizzariaDominio.ModuloIgrediente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPizzariaDominio.ModuloSabor
{
    public class Sabor : EntidadeBase<Sabor>
    {
        public string Descricao { get; set; }
        public byte[] Foto { get; set; }
        public char Categoria { get; set; }
        public char Tipo { get; set; }
        public List<Ingrediente> SaborIngredientes { get; set; }

        public Sabor()
        {
            SaborIngredientes = new List<Ingrediente>();
        }

        public Sabor(Guid id, string descricao, byte[] foto, char categoria, char tipo, List<Ingrediente> saborIngredientes)
        {
            this.id = id;
            Descricao = descricao;
            Foto = foto;
            Categoria = categoria;
            Tipo = tipo;
            SaborIngredientes = saborIngredientes;
        }

        public Sabor(string descricao, byte[] foto, char categoria, char tipo, List<Ingrediente> saborIngredientes)
        {
            Descricao = descricao;
            Foto = foto;
            Categoria = categoria;
            Tipo = tipo;
            SaborIngredientes = saborIngredientes;
        }
        public override string ToString()
        {
            return $"{Categoria} - {Tipo} - {Descricao}";
        }
    }
}

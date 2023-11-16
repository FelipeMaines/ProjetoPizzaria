using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPizzariaDominio.ModuloProduto
{
    public enum EnumProdutoTipo
    {
        [Description("Refrigerante")]
        Refrigerante = 'R',
        [Description("Cerveja")]
        Cerveja = 'C',
        [Description("Suco")]
        Suco = 'S',
        [Description("Água")]
        Agua = 'A',
        [Description("Outros")]
        Outros = 'O'
    }
}

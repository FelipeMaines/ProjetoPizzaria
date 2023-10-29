using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPizzariaDominio.ModuloSabor
{
    public enum EnumSaborCategoria
    {
        [Description("Tradicional")]
        Tradicional = 'T',
        [Description("Especial")]
        Especial = 'E'
    }
    public enum EnumSaborTipo
    {
        [Description("Doce")]
        Doce = 'D',
        [Description("Salgada")]
        Salgada = 'S'
    }


}

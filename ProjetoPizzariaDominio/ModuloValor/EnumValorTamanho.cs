using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPizzaria.ModuloValores
{
    public enum EnumValorTamanho
    {
        [Description("Pequena")]
        Pequena = 'P',
        [Description("Média")]
        Media = 'M',
        [Description("Grande")]
        Grande = 'G',
        [Description("Família")]
        Familia = 'F'
    }
}

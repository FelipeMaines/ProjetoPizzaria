using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPizzaria.Compartilhado.Ioc
{
    public interface Ioc
    {
        T Get<T>();
    }
}

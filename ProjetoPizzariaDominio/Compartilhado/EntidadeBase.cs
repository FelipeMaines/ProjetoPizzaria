using SequentialGuid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPizzariaDominio.Compartilhado
{
    public class EntidadeBase<T>
    {
        public Guid id { get; set; }

        public EntidadeBase()
        {
            id = SequentialGuidGenerator.Instance.NewGuid();

        }
    }
}

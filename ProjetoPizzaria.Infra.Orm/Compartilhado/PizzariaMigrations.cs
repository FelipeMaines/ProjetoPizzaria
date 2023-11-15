using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPizzaria.Infra.Orm.Compartilhado
{
    public static class PizzariaMigrations
    {
        public static bool AtualizarBanco(DbContext db)
        {
            var qtdMigracoesPendentes = db.Database.GetPendingMigrations().Count();

            if (qtdMigracoesPendentes == 0)
                return false;

            db.Database.Migrate();

            return true;
        }
    }
}

using Microsoft.Data.SqlClient;
using ProjetoPizzaria.infra.Compartilhado;
using ProjetoPizzariaDominio.ModuloIgrediente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPizzaria.infra.ModuloIgrediente
{
    public class MapeadorIgrediente : MapeadorBase<Igrediente>
    {
        public override void ConfigurarParametros(SqlCommand comando, Igrediente registro)
        {
            comando.Parameters.AddWithValue("id", registro.id);
            comando.Parameters.AddWithValue("NOME_IGREDIENTE", registro.nome);
        }

        public override Igrediente ConverterRegistro(SqlDataReader leitorRegistros)
        {
            int id = Convert.ToInt32(leitorRegistros["ID_IGREDIENTE"]);

            string nome = Convert.ToString(leitorRegistros["NOME_IGREDIENTE"]);

            return new Igrediente(nome, id);
        }
    }
}

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
    public class MapeadorIgrediente : MapeadorBase<Ingrediente>
    {
        public override void ConfigurarParametros(SqlCommand comando, Ingrediente registro)
        {
            comando.Parameters.AddWithValue("id", registro.id);
            comando.Parameters.AddWithValue("NOME_IGREDIENTE", registro.nome);
        }

        public override Ingrediente ConverterRegistro(SqlDataReader leitorRegistros)
        {
            

            int id = Convert.ToInt32(leitorRegistros["ID_IGREDIENTE"]);

            string nome = Convert.ToString(leitorRegistros["NOME_IGREDIENTE"]);

            return new Ingrediente(nome, id);
        }
    }
}

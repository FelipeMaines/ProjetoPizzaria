using Microsoft.Data.SqlClient;
using ProjetoPizzaria.infra.Compartilhado;
using ProjetoPizzariaDominio.ModuloIgrediente;
using ProjetoPizzariaDominio.ModuloSabor;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPizzaria.infra.ModuloSabor
{
    public class MapeadorSabor : MapeadorBase<Sabor>
    {
        private byte[] ConvertToByteArray(SqlBinary varbinary)
        {
            if (varbinary == null)
                return new byte[0];
            // Obtém o tamanho do varbinary.
            int length = varbinary.Length;

            // Cria um array de bytes do tamanho do varbinary.
            byte[] bytes = new byte[length];

            // Copia os dados do varbinary para o array de bytes.
            for (int i = 0; i < length; i++)
            {
                bytes[i] = varbinary[i];
            }

            return bytes;
        }
        public override void ConfigurarParametros(SqlCommand comando, Sabor registro)
        {
            //@"INSERT INTO tb_sabores (descricao_sabor, foto, categoria, tipo) VALUES (@descricao, @foto, @categoria, @tipo) SELECT SCOPE_IDENTITY()";
            comando.Parameters.AddWithValue("id", registro.id);
            comando.Parameters.AddWithValue("descricao", registro.Descricao);
            comando.Parameters.AddWithValue("foto", registro.Foto);
            comando.Parameters.AddWithValue("categoria", registro.Categoria);
            comando.Parameters.AddWithValue("tipo", registro.Tipo);
        }

        public override Sabor ConverterRegistro(SqlDataReader leitorRegistros)
        {
            
            int id = Convert.ToInt32(leitorRegistros["id"]);
            string descricao = Convert.ToString(leitorRegistros["nome"]);
            Byte[] fotoSql = (Byte[])leitorRegistros["foto"];
            byte[] foto = ConvertToByteArray(fotoSql);
            char categoria = Convert.ToChar(leitorRegistros["categoria"]);
            char tipo = Convert.ToChar(leitorRegistros["tipo"]);

            var igre = new List<Ingrediente>();

            return new Sabor(id, descricao, foto, categoria, tipo, igre);
        }
    }
}

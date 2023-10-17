using Microsoft.Data.SqlClient;
using Microsoft.Win32;
using ProjetoPizzaria.infra.Compartilhado;
using ProjetoPizzariaDominio.ModuloCliente;

namespace ProjetoPizzaria.infra.ModuloCliente
{
    public class MapeadorCliente : MapeadorBase<Cliente>
    {
        public override void ConfigurarParametros(SqlCommand comando, Cliente registro)
        {
            comando.Parameters.AddWithValue("@nome", registro.Nome);
            comando.Parameters.AddWithValue("@cpf", registro.Cpf);
            comando.Parameters.AddWithValue("@telefone", registro.Telefone);
            comando.Parameters.AddWithValue("@email", registro.Email);
            comando.Parameters.AddWithValue("@endereco_id", registro.EnderecoId);
            comando.Parameters.AddWithValue("@numero", registro.Numero);
            comando.Parameters.AddWithValue("@complemento", registro.Complemento);
            comando.Parameters.AddWithValue("@id", registro.id);
        }

        public override Cliente ConverterRegistro(SqlDataReader leitorRegistros)
        {
            /*@"SELECT
                cc.id_cliente AS ID,
                cc.nome_cliente AS Nome,
                cc.cpf AS CPF,
                cc.telefone AS Telefone,
                cc.email AS EMail,
                e.id_endereco AS ID,
                e.cep AS CEP,
                e.logradouro AS Logradouro,
                e.bairro AS Bairro,
                c.id_cidade AS IDCidade,
                c.nome_cidade AS Cidade,
                u.id_uf AS IDUF,
                u.nome_uf AS UF,
                p.id_pais AS IDPais,
                p.nome_pais AS Pais,
                cc.numero AS Número,
                cc.complemento AS Complemento
            FROM tb_clientes cc
            JOIN tb_enderecos e ON e.id_endereco = cc.endereco_id
            JOIN cad_cidades c ON c.id_cidade = e.cidade_id
            JOIN cad_uf u ON u.id_uf = c.uf_id
            JOIN cad_paises p ON p.id_pais = u.pais_id
            WHERE
                auxSqlFiltro
            ORDER BY cc.nome_cliente;";*/

            var registro = new Cliente();

            registro.id = Convert.ToInt32(leitorRegistros["ID"]);
            registro.Nome = Convert.ToString(leitorRegistros["Nome"]);
            registro.Cpf = Convert.ToString(leitorRegistros["CPF"]);
            registro.Telefone = Convert.ToString(leitorRegistros["Telefone"]);
            registro.Email = Convert.ToString(leitorRegistros["EMail"]);
            registro.EnderecoId = Convert.ToInt32(leitorRegistros["EnderecoId"]);
            registro.Numero = Convert.ToString(leitorRegistros["Numero"]);
            registro.Complemento = Convert.ToString(leitorRegistros["Complemento"]);

            return registro;
        }
    }
}

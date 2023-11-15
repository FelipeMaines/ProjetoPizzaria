using Microsoft.Data.SqlClient;
using ProjetoPizzaria.infra.Compartilhado;
using ProjetoPizzariaDominio.ModuloEndereco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPizzaria.infra.ModuloEndereco
{
    public class MapeadorEndereco : MapeadorBase<Endereco>
    {
        public override void ConfigurarParametros(SqlCommand comando, Endereco registro)
        {
            comando.Parameters.AddWithValue("ENDERECO_CEP", registro.Cep);

            comando.Parameters.AddWithValue("ENDERECO_ID", registro.id);

        }

        public override Endereco ConverterRegistro(SqlDataReader leitorRegistros)
        {
            throw new NotImplementedException();
        }

        //public override Endereco ConverterRegistro(SqlDataReader leitorRegistros)
        //{
        //    // e.id_endereco AS ID,
        //    //e.cep AS CEP,
        //    //e.logradouro AS Logradouro,
        //    //e.bairro AS Bairro,
        //    //c.id_cidade AS IDCidade,
        //    //c.nome_cidade AS Cidade,
        //    //u.id_uf AS IDUF,
        //    //u.nome_uf AS UF,
        //    //p.id_pais AS IDPais,
        //    //p.nome_pais AS Pais

        //    int id = Convert.ToInt32(leitorRegistros["ID"]);

        //    string cep = Convert.ToString(leitorRegistros["CEP"]);

        //    string logradouro = Convert.ToString(leitorRegistros["Logradouro"]);

        //    string bairro = Convert.ToString(leitorRegistros["Bairro"]);

        //    int idCidade = Convert.ToInt32(leitorRegistros["IDCidade"]);

        //    string nomeCidade = Convert.ToString(leitorRegistros["Cidade"]);

        //    var cidade = new Cidade(idCidade, nomeCidade);

        //    //uf

        //    int idUf = Convert.ToInt32(leitorRegistros["IDUF"]);

        //    string nomeUf = Convert.ToString(leitorRegistros["UF"]);

        //    var uf = new Uf(idUf, nomeUf);

        //    //pais

        //    int idPais = Convert.ToInt32(leitorRegistros["IDPais"]);

        //    string nomePais = Convert.ToString(leitorRegistros["Pais"]);

        //    var pais = new Pais(idCidade, nomeCidade);

        //endereco

        //return new Endereco(id, cep, logradouro, bairro, cidade);
    }
    
}

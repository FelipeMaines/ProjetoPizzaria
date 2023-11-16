using Microsoft.Data.SqlClient;
using ProjetoPizzaria.infra.Compartilhado;
using ProjetoPizzariaDominio.ModuloEndereco;
using ProjetoPizzariaDominio.ModuloFuncionario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPizzaria.infra.ModuloFuncionario
{
    public class MapeadorFuncionario : MapeadorBase<Funcionario>
    {
        public override void ConfigurarParametros(SqlCommand comando, Funcionario registro)
        {
            /*
             *  VALUES (@nome, @cpf, @matricula, @senha, @grupo, @motorista, @validade_motorista,
                         @observacao, @telefone, @email, @endereco_id, @numero, @complemento)";
             */

            comando.Parameters.AddWithValue("nome", registro.Nome);
            comando.Parameters.AddWithValue("cpf", registro.Cpf);
            comando.Parameters.AddWithValue("matricula", registro.Matricula);
            comando.Parameters.AddWithValue("senha", registro.Senha);
            comando.Parameters.AddWithValue("grupo", registro.Grupo);
            comando.Parameters.AddWithValue("motorista", registro.Motorista);
            comando.Parameters.AddWithValue("validade_motorista", registro.Validade);
            comando.Parameters.AddWithValue("observacao", registro.Observacao);
            comando.Parameters.AddWithValue("telefone", registro.Telefone);
            comando.Parameters.AddWithValue("email", registro.Email);
            comando.Parameters.AddWithValue("endereco_id", registro.Endereco.id);
            comando.Parameters.AddWithValue("numero", registro.Numero);
            comando.Parameters.AddWithValue("complemento", registro.Complemento);
            comando.Parameters.AddWithValue("id", registro.id);

        }

        public override Funcionario ConverterRegistro(SqlDataReader leitorRegistros)
        {
            throw new NotImplementedException();
        }

        //public override Funcionario ConverterRegistro(SqlDataReader leitorRegistros)
        //{
        //    /*SELECT
        //                                                    f.id_funcionario AS ID,
        //                                                    f.nome_funcionario AS Nome,
        //                                                    f.cpf AS CPF,
        //                                                    f.matricula AS Matrícula,
        //                                                    f.senha AS Senha,
        //                                                    f.grupo AS Grupo,
        //                                                    f.motorista AS Carteira,
        //                                                    f.validade_motorista AS Validade,
        //                                                    f.observacao AS Observacao,
        //                                                    f.telefone AS Telefone,
        //                                                    f.email AS 'E-Mail',

        //                                                    e.id_endereco AS ID,
        //                                                    e.cep AS CEP,
        //                                                    e.logradouro AS Logradouro,
        //                                                    e.bairro AS Bairro,
        //                                                    c.id_cidade AS IDCidade,
        //                                                    c.nome_cidade AS Cidade,
        //                                                    u.id_uf AS IDUF,
        //                                                    u.nome_uf AS UF,
        //                                                    p.id_pais AS IDPais,
        //                                                    p.nome_pais AS IDPais,
        //                                                    f.numero AS Numero,
        //                                                    f.complemento AS Complemento
        //                                                FROM
        //                                                    tb_funcionarios AS f
        //                                                INNER JOIN
        //                                                    tb_enderecos AS e ON e.id_endereco = f.endereco_id
        //                                                INNER JOIN
        //                                                    cad_cidades AS c ON c.id_cidade = e.cidade_id
        //                                                INNER JOIN
        //                                                    cad_uf AS u ON u.id_uf = c.uf_id
        //                                                INNER JOIN
        //                                                    cad_paises AS p ON p.id_pais = u.pais_id
        //                                                ORDER BY
        //                                                    f.nome_funcionario*/

        //    string nome = Convert.ToString(leitorRegistros["Nome"]);
        //    int id = Convert.ToInt32(leitorRegistros["ID"]);
        //    string cpf = Convert.ToString(leitorRegistros["CPF"]);
        //    string matricula = Convert.ToString(leitorRegistros["Matricula"]);
        //    string senha = Convert.ToString(leitorRegistros["Senha"]);
        //    char grupo = Convert.ToChar(leitorRegistros["Grupo"]);
        //    string carteira = Convert.ToString(leitorRegistros["Carteira"]);
        //    DateTime validade = Convert.ToDateTime(leitorRegistros["Validade"]);
        //    string observacao = Convert.ToString(leitorRegistros["Observacao"]);
        //    string telefone = Convert.ToString(leitorRegistros["Telefone"]);
        //    string email = Convert.ToString(leitorRegistros["E-mail"]);
        //    string numero = Convert.ToString(leitorRegistros["Numero"]);
        //    string complemento = Convert.ToString(leitorRegistros["Complemento"]);
        //    int cepid = Convert.ToInt32(leitorRegistros["ID_CEP"]);
        //    string cep = Convert.ToString(leitorRegistros["CEP"]);
        //    string logradouro = Convert.ToString(leitorRegistros["Logradouro"]);
        //    string bairro = Convert.ToString(leitorRegistros["Bairro"]);

        //    int IdCidade = Convert.ToInt32(leitorRegistros["IdCidade"]);
        //    string NomeCidade = Convert.ToString(leitorRegistros["Cidade"]);

        //    var cidade = new Cidade(IdCidade, NomeCidade);

        //    int idUf = Convert.ToInt32(leitorRegistros["IDUF"]);
        //    string nomeUf = Convert.ToString(leitorRegistros["UF"]);

        //    var uf = new Uf(idUf, nomeUf);

        //    int idPais = Convert.ToInt32(leitorRegistros["IDPais"]);
        //    string nomePais= Convert.ToString(leitorRegistros["IDPais"]);

        //    Pais pais = new Pais(idPais, nomePais);

        //    //var endereco = new Endereco(cepid, cep, logradouro, bairro, cidade);

        //    //return new Funcionario(endereco, id, nome, cpf, matricula, senha, grupo, carteira, validade, observacao, telefone, email, cepid, numero, complemento);
        //}
    }
}

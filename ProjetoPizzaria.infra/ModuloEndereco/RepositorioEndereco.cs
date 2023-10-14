using ProjetoPizzaria.infra.Compartilhado;
using ProjetoPizzariaDominio.ModuloEndereco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPizzaria.infra.ModuloEndereco
{
    public class RepositorioEndereco : RepositorioBaseSql<Endereco, MapeadorEndereco>, IRepositorioEndereco
    {
        protected override string sqlInserir => throw new NotImplementedException();

        protected override string sqlEditar => throw new NotImplementedException();

        protected override string sqlExcluir => throw new NotImplementedException();

        protected override string sqlSelecionarTodos => @"
                                                            SELECT
                                                              e.id_endereco AS ID,
                                                              e.cep AS CEP,
                                                              e.logradouro AS Logradouro,
                                                              e.bairro AS Bairro,
                                                              c.id_cidade AS IDCidade,
                                                              c.nome_cidade AS Cidade,
                                                              u.id_uf AS IDUF,
                                                              u.nome_uf AS UF,
                                                              p.id_pais AS IDPais,
                                                              p.nome_pais AS Pais
                                                            FROM
                                                              tb_enderecos AS e
                                                            INNER JOIN
                                                              cad_cidades AS c ON c.id_cidade = e.cidade_id
                                                            INNER JOIN
                                                              cad_uf AS u ON u.id_uf = c.uf_id
                                                            INNER JOIN
                                                              cad_paises AS p ON p.id_pais = u.pais_id
                                                            ORDER BY
                                                              e.cep;";

        protected override string sqlSelecionarPorId => @"
                                                        SELECT
                                                            e.id_endereco AS ID,
                                                            e.cep AS CEP,
                                                            e.logradouro AS Logradouro,
                                                            e.bairro AS Bairro,
                                                            c.id_cidade AS IDCidade,
                                                            c.nome_cidade AS Cidade,
                                                            u.id_uf AS IDUF,
                                                            u.nome_uf AS UF,
                                                            p.id_pais AS IDPais,
                                                            p.nome_pais AS Pais
                                                        FROM
                                                            tb_enderecos AS e
                                                        INNER JOIN
                                                            cad_cidades AS c ON c.id_cidade = e.cidade_id
                                                        INNER JOIN
                                                            cad_uf AS u ON u.id_uf = c.uf_id
                                                        INNER JOIN
                                                            cad_paises AS p ON p.id_pais = u.pais_id
                                                            Where e.cep = @ENDERECO_ID
                                                        ORDER BY
                                                            e.cep";

        protected string sqlSelecionarPorCep = @"
                                                SELECT
                                                    e.id_endereco AS ID,
                                                    e.cep AS CEP,
                                                    e.logradouro AS Logradouro,
                                                    e.bairro AS Bairro,
                                                    c.id_cidade AS IDCidade,
                                                    c.nome_cidade AS Cidade,
                                                    u.id_uf AS IDUF,
                                                    u.nome_uf AS UF,
                                                    p.id_pais AS IDPais,
                                                    p.nome_pais AS Pais
                                                FROM
                                                    tb_enderecos AS e
                                                INNER JOIN
                                                    cad_cidades AS c ON c.id_cidade = e.cidade_id
                                                INNER JOIN
                                                    cad_uf AS u ON u.id_uf = c.uf_id
                                                INNER JOIN
                                                    cad_paises AS p ON p.id_pais = u.pais_id
                                                    Where e.cep = @ENDERECO_CEP
                                                ORDER BY
                                                    e.cep";
        protected override string sqlPesquisar => @"SELECT
                                                    e.id_endereco AS ID,
                                                    e.cep AS CEP,
                                                    e.logradouro AS Logradouro,
                                                    e.bairro AS Bairro,
                                                    c.id_cidade AS IDCidade,
                                                    c.nome_cidade AS Cidade,
                                                    u.id_uf AS IDUF,
                                                    u.nome_uf AS UF,
                                                    p.id_pais AS IDPais,
                                                    p.nome_pais AS Pais
                                                FROM
                                                    tb_enderecos AS e
                                                INNER JOIN
                                                    cad_cidades AS c ON c.id_cidade = e.cidade_id
                                                INNER JOIN
                                                    cad_uf AS u ON u.id_uf = c.uf_id
                                                INNER JOIN
                                                    cad_paises AS p ON p.id_pais = u.pais_id
                                                    Where e.cep = @ENDERECO_CEP
                                                ORDER BY
                                                    e.cep";
    }
}

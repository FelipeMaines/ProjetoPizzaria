using ProjetoPizzaria.infra.Compartilhado;
using ProjetoPizzariaDominio.ModuloCliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPizzaria.infra.ModuloCliente
{
    public class RepositorioCliente : RepositorioBaseSql<Cliente, MapeadorCliente>, IRepositorioCliente
    {
        protected override string sqlInserir => @"INSERT INTO tb_clientes
                                                    (nome_cliente, cpf, telefone, email, endereco_id, numero, complemento)
                                                VALUES
                                                    (@nome, @cpf, @telefone, @email, @endereco_id, @numero, @complemento);";

        protected override string sqlEditar => @"UPDATE tb_clientes
                                                    SET
                                                        nome_cliente = @nome,
                                                        cpf = @cpf,
                                                        telefone = @telefone,
                                                        email = @email,
                                                        endereco_id = @endereco_id,
                                                        numero = @numero,
                                                        complemento = @complemento
                                                    WHERE id_cliente = @id;";

        protected override string sqlExcluir => @"DELETE FROM tb_clientes WHERE id_cliente = @id;";

        protected override string sqlSelecionarTodos => @"SELECT
                                                            cc.id_cliente AS ID,
                                                            cc.nome_cliente AS Nome,
                                                            cc.cpf AS CPF,
                                                            cc.telefone AS Telefone,
                                                            cc.email AS EMail,
                                                            e.id_endereco AS EnderecoId,
                                                            e.cep AS CEP,
                                                            e.logradouro AS Logradouro,
                                                            e.bairro AS Bairro,
                                                            c.id_cidade AS IDCidade,
                                                            c.nome_cidade AS Cidade,
                                                            u.id_uf AS IDUF,
                                                            u.nome_uf AS UF,
                                                            p.id_pais AS IDPais,
                                                            p.nome_pais AS Pais,
                                                            cc.numero AS Numero,
                                                            cc.complemento AS Complemento
                                                        FROM tb_clientes cc
                                                        JOIN tb_enderecos e ON e.id_endereco = cc.endereco_id
                                                        JOIN cad_cidades c ON c.id_cidade = e.cidade_id
                                                        JOIN cad_uf u ON u.id_uf = c.uf_id
                                                        JOIN cad_paises p ON p.id_pais = u.pais_id
                                                        ORDER BY cc.nome_cliente;";

        protected override string sqlSelecionarPorId => @"SELECT
                                                            cc.id_cliente AS ID,
                                                            cc.nome_cliente AS Nome,
                                                            cc.cpf AS CPF,
                                                            cc.telefone AS Telefone,
                                                            cc.email AS EMail,
                                                            e.id_endereco AS EnderecoId,
                                                            e.cep AS CEP,
                                                            e.logradouro AS Logradouro,
                                                            e.bairro AS Bairro,
                                                            c.id_cidade AS IDCidade,
                                                            c.nome_cidade AS Cidade,
                                                            u.id_uf AS IDUF,
                                                            u.nome_uf AS UF,
                                                            p.id_pais AS IDPais,
                                                            p.nome_pais AS Pais,
                                                            cc.numero AS Numero,
                                                            cc.complemento AS Complemento
                                                        FROM tb_clientes cc
                                                        JOIN tb_enderecos e ON e.id_endereco = cc.endereco_id
                                                        JOIN cad_cidades c ON c.id_cidade = e.cidade_id
                                                        JOIN cad_uf u ON u.id_uf = c.uf_id
                                                        JOIN cad_paises p ON p.id_pais = u.pais_id
                                                        WHERE
                                                            cc.id_cliente = @id
                                                        ORDER BY cc.nome_cliente;";

        protected override string sqlPesquisar => @"SELECT
                                                    cc.id_cliente AS ID,
                                                    cc.nome_cliente AS Nome,
                                                    cc.cpf AS CPF,
                                                    cc.telefone AS Telefone,
                                                    cc.email AS EMail,
                                                    e.id_endereco AS EnderecoId,
                                                    e.cep AS CEP,
                                                    e.logradouro AS Logradouro,
                                                    e.bairro AS Bairro,
                                                    c.id_cidade AS IDCidade,
                                                    c.nome_cidade AS Cidade,
                                                    u.id_uf AS IDUF,
                                                    u.nome_uf AS UF,
                                                    p.id_pais AS IDPais,
                                                    p.nome_pais AS Pais,
                                                    cc.numero AS Numero,
                                                    cc.complemento AS Complemento
                                                FROM tb_clientes cc
                                                JOIN tb_enderecos e ON e.id_endereco = cc.endereco_id
                                                JOIN cad_cidades c ON c.id_cidade = e.cidade_id
                                                JOIN cad_uf u ON u.id_uf = c.uf_id
                                                JOIN cad_paises p ON p.id_pais = u.pais_id
                                                WHERE
	                                                cc.nome_cliente LIKE '%' + @nome + '%'
    
                                                ORDER BY cc.nome_cliente;";
    }
}

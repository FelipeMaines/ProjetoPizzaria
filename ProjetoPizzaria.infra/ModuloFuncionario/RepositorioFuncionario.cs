using ProjetoPizzaria.infra.Compartilhado;
using ProjetoPizzariaDominio.Compartilhado;
using ProjetoPizzariaDominio.ModuloFuncionario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPizzaria.infra.ModuloFuncionario
{
    public class RepositorioFuncionario : RepositorioBaseSql<Funcionario, MapeadorFuncionario>, IRepositorioFuncionario
    {
        protected override string sqlInserir => @"INSERT INTO tb_funcionarios (
                                                                nome_funcionario,
                                                                cpf,
                                                                matricula,
                                                                senha,
                                                                grupo,
                                                                motorista,
                                                                validade_motorista,
                                                                observacao,
                                                                telefone,
                                                                email,
                                                                endereco_id,
                                                                numero,
                                                                complemento
                                                            )
                                                     VALUES (@nome, @cpf, @matricula, @senha, @grupo, @motorista, @validade_motorista,
                                                            @observacao, @telefone, @email, @endereco_id, @numero, @complemento)";

        protected override string sqlEditar => @"UPDATE tb_funcionarios
                                                    SET
                                                        nome_funcionario = @nome,
                                                        cpf = @cpf,
                                                        matricula = @matricula,
                                                        senha = @senha,
                                                        grupo = @grupo,
                                                        motorista = @motorista,
                                                        validade_motorista = @validade_motorista,
                                                        observacao = @observacao,
                                                        telefone = @telefone,
                                                        email = @email,
                                                        endereco_id = @endereco_id,
                                                        numero = @numero,
                                                        complemento = @complemento
                                                    WHERE
                                                        id_funcionario = @id;";

        protected override string sqlExcluir => @"DELETE FROM tb_funcionarios WHERE id_funcionario = @ID;";

        protected override string sqlSelecionarTodos => @"
                                                        SELECT
                                                            f.id_funcionario AS ID,
                                                            f.nome_funcionario AS Nome,
                                                            f.cpf AS CPF,
                                                            f.matricula AS Matricula,
                                                            f.senha AS Senha,
                                                            f.grupo AS Grupo,
                                                            f.motorista AS Carteira,
                                                            f.validade_motorista AS Validade,
                                                            f.observacao AS Observacao,
                                                            f.telefone AS Telefone,
                                                            f.email AS 'E-Mail',

                                                            e.id_endereco AS ID_CEP,
                                                            e.cep AS CEP,
                                                            e.logradouro AS Logradouro,
                                                            e.bairro AS Bairro,
                                                            c.id_cidade AS IDCidade,
                                                            c.nome_cidade AS Cidade,
                                                            u.id_uf AS IDUF,
                                                            u.nome_uf AS UF,
                                                            p.id_pais AS IDPais,
                                                            p.nome_pais AS Pais,
                                                            f.numero AS Numero,
                                                            f.complemento AS Complemento
                                                        FROM
                                                            tb_funcionarios AS f
                                                        INNER JOIN
                                                            tb_enderecos AS e ON e.id_endereco = f.endereco_id
                                                        INNER JOIN
                                                            cad_cidades AS c ON c.id_cidade = e.cidade_id
                                                        INNER JOIN
                                                            cad_uf AS u ON u.id_uf = c.uf_id
                                                        INNER JOIN
                                                            cad_paises AS p ON p.id_pais = u.pais_id
                                                        ORDER BY
                                                            f.nome_funcionario";

        protected override string sqlSelecionarPorId => @"
                                                        SELECT
                                                            f.id_funcionario AS ID,
                                                            f.nome_funcionario AS Nome,
                                                            f.cpf AS CPF,
                                                            f.matricula AS Matricula,
                                                            f.senha AS Senha,
                                                            f.grupo AS Grupo,
                                                            f.motorista AS Carteira,
                                                            f.validade_motorista AS Validade,
                                                            f.observacao AS Observacao,
                                                            f.telefone AS Telefone,
                                                            f.email AS 'E-Mail',

                                                            e.id_endereco AS ID_CEP,
                                                            e.cep AS CEP,
                                                            e.logradouro AS Logradouro,
                                                            e.bairro AS Bairro,
                                                            c.id_cidade AS IDCidade,
                                                            c.nome_cidade AS Cidade,
                                                            u.id_uf AS IDUF,
                                                            u.nome_uf AS UF,
                                                            p.id_pais AS IDPais,
                                                            p.nome_pais AS Pais,
                                                            f.numero AS Numero,
                                                            f.complemento AS Complemento
                                                        FROM
                                                            tb_funcionarios AS f
                                                        INNER JOIN
                                                            tb_enderecos AS e ON e.id_endereco = f.endereco_id
                                                        INNER JOIN
                                                            cad_cidades AS c ON c.id_cidade = e.cidade_id
                                                        INNER JOIN
                                                            cad_uf AS u ON u.id_uf = c.uf_id
                                                        INNER JOIN
                                                            cad_paises AS p ON p.id_pais = u.pais_id
                                                        WHERE
                                                             f.id_funcionario = @ID
                                                        ORDER BY
                                                            f.nome_funcionario";

        public string sqlPesquisarPorNome = @"
                                                        SELECT
                                                            f.id_funcionario AS ID,
                                                            f.nome_funcionario AS Nome,
                                                            f.cpf AS CPF,
                                                            f.matricula AS Matricula,
                                                            f.senha AS Senha,
                                                            f.grupo AS Grupo,
                                                            f.motorista AS Carteira,
                                                            f.validade_motorista AS Validade,
                                                            f.observacao AS Observacao,
                                                            f.telefone AS Telefone,
                                                            f.email AS 'E-Mail',

                                                            e.id_endereco AS ID_CEP,
                                                            e.cep AS CEP,
                                                            e.logradouro AS Logradouro,
                                                            e.bairro AS Bairro,
                                                            c.id_cidade AS IDCidade,
                                                            c.nome_cidade AS Cidade,
                                                            u.id_uf AS IDUF,
                                                            u.nome_uf AS UF,
                                                            p.id_pais AS IDPais,
                                                            p.nome_pais AS Pais,
                                                            f.numero AS Numero,
                                                            f.complemento AS Complemento
                                                        FROM
                                                            tb_funcionarios AS f
                                                        INNER JOIN
                                                            tb_enderecos AS e ON e.id_endereco = f.endereco_id
                                                        INNER JOIN
                                                            cad_cidades AS c ON c.id_cidade = e.cidade_id
                                                        INNER JOIN
                                                            cad_uf AS u ON u.id_uf = c.uf_id
                                                        INNER JOIN
                                                            cad_paises AS p ON p.id_pais = u.pais_id
                                                        WHERE
                                                            f.Nome = @NOME_FUNCIONARIO
                                                        ORDER BY
                                                            f.nome_funcionario";

        protected override string sqlPesquisar => @"
                                                        SELECT
                                                            f.id_funcionario AS ID,
                                                            f.nome_funcionario AS Nome,
                                                            f.cpf AS CPF,
                                                            f.matricula AS Matricula,
                                                            f.senha AS Senha,
                                                            f.grupo AS Grupo,
                                                            f.motorista AS Carteira,
                                                            f.validade_motorista AS Validade,
                                                            f.observacao AS Observacao,
                                                            f.telefone AS Telefone,
                                                            f.email AS 'E-Mail',

                                                            e.id_endereco AS ID_CEP,
                                                            e.cep AS CEP,
                                                            e.logradouro AS Logradouro,
                                                            e.bairro AS Bairro,
                                                            c.id_cidade AS IDCidade,
                                                            c.nome_cidade AS Cidade,
                                                            u.id_uf AS IDUF,
                                                            u.nome_uf AS UF,
                                                            p.id_pais AS IDPais,
                                                            p.nome_pais AS Pais,
                                                            f.numero AS Numero,
                                                            f.complemento AS Complemento
                                                        FROM
                                                            tb_funcionarios AS f
                                                        INNER JOIN
                                                            tb_enderecos AS e ON e.id_endereco = f.endereco_id
                                                        INNER JOIN
                                                            cad_cidades AS c ON c.id_cidade = e.cidade_id
                                                        INNER JOIN
                                                            cad_uf AS u ON u.id_uf = c.uf_id
                                                        INNER JOIN
                                                            cad_paises AS p ON p.id_pais = u.pais_id
                                                        WHERE
                                                            f.Nome = @NOME_FUNCIONARIO
                                                        ORDER BY
                                                            f.nome_funcionario";
    }
}

using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Win32;
using Org.BouncyCastle.Utilities.Collections;
using ProjetoPizzaria.infra.Compartilhado;
using ProjetoPizzaria.infra.ModuloIgrediente;
using ProjetoPizzariaDominio.ModuloIgrediente;
using ProjetoPizzariaDominio.ModuloSabor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPizzaria.infra.ModuloSabor
{
    public class RepositorioSabor : RepositorioBaseSql<Sabor, MapeadorSabor>
    {
        protected override string sqlInserir => 
            @"INSERT INTO tb_sabores (descricao_sabor, foto, categoria, tipo) VALUES (@descricao, @foto, @categoria, @tipo) SELECT SCOPE_IDENTITY()";

        private string sqlInserirIgredientesNoSabor = @"INSERT INTO itens_sabores(sabor_id, igrediente_id) VALUES(@sabor_id, @id)";

        protected override string sqlEditar => @"UPDATE tb_sabores SET descricao_sabor = @descricao, foto = @foto, categoria = @categoria, tipo = @tipo WHERE id_sabor = @id;";

        protected override string sqlExcluir => @"delete from tb_sabores where id_sabor = @ID";

        public string sqlExcluirItensTabelaNxN = @"delete from itens_sabores where sabor_id = @ID";

        protected override string sqlSelecionarTodos => @"
	                                                    SELECT
                                                                    s.id_sabor AS id,
                                                                    s.descricao_sabor AS nome,
                                                                    s.foto AS foto,
                                                                    s.categoria AS categoria,
                                                                    s.tipo AS tipo
                                                                FROM tb_sabores AS s
                                                               ";

        private string sqlSelecionarIgredinetesSabor = @"select 
	                                                        i.id_igrediente as ID_IGREDIENTE,
	                                                        i.nome as NOME_IGREDIENTE
                                                        FROM
	                                                        igredientes as i
                                                        inner join itens_sabores as iss 
                                                        on
	                                                        iss.igrediente_id = i.id_igrediente
                                                        inner join
	                                                        tb_sabores as s
                                                        on 
	                                                        s.id_sabor = iss.sabor_id
                                                        where
	                                                        s.id_sabor = @ID_SABOR";

        protected override string sqlSelecionarPorId => @"
	                                                        SELECT
                                                                    s.id_sabor AS id,
                                                                    s.descricao_sabor AS nome,
                                                                    s.foto AS foto,
                                                                    s.categoria AS categoria,
                                                                    s.tipo AS tipo
                                                                FROM tb_sabores AS s
                                                                    where s.id_sabor = @ID
                                                               ";

        protected override string sqlPesquisar => throw new NotImplementedException();


        public override void Inserir(Sabor registro)
        {
            base.Inserir(registro);

            foreach (var item in registro.SaborIngredientes)
            {
                adicionarIngredienteNoSabor(item, registro.id);
            }
        }

        private void adicionarIngredienteNoSabor(Ingrediente ingrediente, Guid idSabor)
        {
            SqlConnection conexaoBanco = new SqlConnection(enderecoBanco);
            conexaoBanco.Open();

            SqlCommand comandoInserir = conexaoBanco.CreateCommand();
            comandoInserir.CommandText = sqlInserirIgredientesNoSabor;

            MapeadorIgrediente mapeador = new MapeadorIgrediente();

            comandoInserir.Parameters.AddWithValue("sabor_id", idSabor);

            mapeador.ConfigurarParametros(comandoInserir, ingrediente);

            var id = comandoInserir.ExecuteScalar();

            //ingrediente.id = Convert.ToInt32(id);

            conexaoBanco.Close();
        }

        public override void Editar(Sabor registro)
        {
            base.Editar(registro);

            excluirIgredientesSabor(registro.id);

            foreach (var item in registro.SaborIngredientes)
            {
                adicionarIngredienteNoSabor(item, registro.id);
            }
        }

        public override void Excluir(Sabor registroSelecionado)
        {
            excluirIgredientesSabor(registroSelecionado.id);

            base.Excluir(registroSelecionado);
        }

        private void excluirIgredientesSabor(Guid id)
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);
            conexaoComBanco.Open();

            SqlCommand comandoExcluir = conexaoComBanco.CreateCommand();
            comandoExcluir.CommandText = sqlExcluirItensTabelaNxN;

            comandoExcluir.Parameters.AddWithValue("ID", id);

            comandoExcluir.ExecuteNonQuery();

            conexaoComBanco.Close();
        }


        public override List<Sabor> SelecionarTodos()
        {
            var listaSabores = new List<Sabor>();

            foreach(var sabor in base.SelecionarTodos())
            {
                sabor.SaborIngredientes = SelecionarIgredientesDoSabor(sabor.id);
                listaSabores.Add(sabor);
            }

            return listaSabores;
        }

        public List<Ingrediente> SelecionarIgredientesDoSabor(Guid id)
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);
            conexaoComBanco.Open();

            SqlCommand comandoSelecionarAlternativas = conexaoComBanco.CreateCommand();
            comandoSelecionarAlternativas.CommandText = sqlSelecionarIgredinetesSabor;

            comandoSelecionarAlternativas.Parameters.AddWithValue("ID_SABOR", id);

            MapeadorIgrediente mapeador = new MapeadorIgrediente();

            SqlDataReader leitorItem = comandoSelecionarAlternativas.ExecuteReader();

            List<Ingrediente> igredientes = new List<Ingrediente>();

            while (leitorItem.Read())
            {
                Ingrediente igrediente = mapeador.ConverterRegistro(leitorItem);

                igredientes.Add(igrediente);
            }

            conexaoComBanco.Close();

            return igredientes;
        }
    }
}

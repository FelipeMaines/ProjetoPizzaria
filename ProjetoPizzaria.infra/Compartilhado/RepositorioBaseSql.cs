using Microsoft.Data.SqlClient;
using ProjetoPizzariaDominio.Compartilhado;
using System.Configuration;
using System.Data.Common;
using System.Net;

namespace ProjetoPizzaria.infra.Compartilhado
{
    public abstract class RepositorioBaseSql<TEntidade, TMapeador>
        : IRepositorioBase<TEntidade> where TEntidade : EntidadeBase<TEntidade>
        where TMapeador : MapeadorBase<TEntidade>,  new()
    {
        protected string enderecoBanco = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;

        protected abstract string sqlInserir { get; }
        protected abstract string sqlEditar { get; }
        protected abstract string sqlExcluir { get; }
        protected abstract string sqlSelecionarTodos { get; }
        protected abstract string sqlSelecionarPorId { get; }
        protected abstract string sqlPesquisar { get; }

        public virtual void Inserir(TEntidade registro)
        {
            SqlConnection conexaoBanco = new SqlConnection(enderecoBanco);
            conexaoBanco.Open();

            SqlCommand comandoInserir = conexaoBanco.CreateCommand();
            comandoInserir.CommandText = sqlInserir;

            TMapeador mapeador = new TMapeador();

            mapeador.ConfigurarParametros(comandoInserir, registro);

            var id = comandoInserir.ExecuteScalar();

            //registro.id = Convert.ToInt32(id);

            conexaoBanco.Close();
        }

        public virtual void Editar(TEntidade registro)
        {
            var conexaoBanco = new SqlConnection(enderecoBanco);
            conexaoBanco.Open();

            SqlCommand comandoEditar = conexaoBanco.CreateCommand();
            comandoEditar.CommandText = sqlEditar;

            TMapeador mapeador = new TMapeador();

            mapeador.ConfigurarParametros(comandoEditar, registro);

            comandoEditar.ExecuteNonQuery();

            conexaoBanco.Close();
        }

        public virtual void Excluir(TEntidade registroSelecionado)
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);
            conexaoComBanco.Open();

            SqlCommand comandoExcluir = conexaoComBanco.CreateCommand();
            comandoExcluir.CommandText = sqlExcluir;

            comandoExcluir.Parameters.AddWithValue("ID", registroSelecionado.id);

            comandoExcluir.ExecuteNonQuery();

            conexaoComBanco.Close();
        }

        public virtual TEntidade SelecionarPorId(int id)
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);
            conexaoComBanco.Open();

            SqlCommand comandoSelecionarPorId = conexaoComBanco.CreateCommand();
            comandoSelecionarPorId.CommandText = sqlSelecionarPorId;


            comandoSelecionarPorId.Parameters.AddWithValue("ID", id);

            SqlDataReader leitorItems = comandoSelecionarPorId.ExecuteReader();

            TMapeador mapeador = new TMapeador();
            TEntidade registro = null;


            if (leitorItems.Read())
                registro = mapeador.ConverterRegistro(leitorItems);

            conexaoComBanco.Close();

            return registro;
        }

        public virtual List<TEntidade> SelecionarTodos()
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);
            conexaoComBanco.Open();

            SqlCommand comandoSelecionarTodos = conexaoComBanco.CreateCommand();
            comandoSelecionarTodos.CommandText = sqlSelecionarTodos;

            SqlDataReader leitorItens = comandoSelecionarTodos.ExecuteReader();

            List<TEntidade> registros = new List<TEntidade>();

            TMapeador mapeador = new TMapeador();

            while (leitorItens.Read())
            {
                TEntidade registro = mapeador.ConverterRegistro(leitorItens);

                registros.Add(registro);
            }

            conexaoComBanco.Close();

            return registros;
        }

        public virtual List<TEntidade> Pesquisar(string texto)
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);
            conexaoComBanco.Open();

            SqlCommand comandoPesquisarSql = conexaoComBanco.CreateCommand();
            comandoPesquisarSql.CommandText = sqlPesquisar;

            comandoPesquisarSql.Parameters.AddWithValue("NOME", texto);

            SqlDataReader leitorItens = comandoPesquisarSql.ExecuteReader();

            List<TEntidade> registros = new List<TEntidade>();

            TMapeador mapeador = new TMapeador();

            while (leitorItens.Read())
            {
                TEntidade registro = mapeador.ConverterRegistro(leitorItens);

                registros.Add(registro);
            }

            conexaoComBanco.Close();

            return registros;
        }
    }
}

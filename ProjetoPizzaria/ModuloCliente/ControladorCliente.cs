using ProjetoPizzaria.Compartilhado;
using ProjetoPizzaria.infra.ModuloFuncionario;
using ProjetoPizzaria.ModuloFuncionario;
using ProjetoPizzariaDominio.ModuloCliente;
using ProjetoPizzariaDominio.ModuloEndereco;
using ProjetoPizzariaDominio.ModuloFuncionario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPizzaria.ModuloCliente
{
    public class ControladorCliente : ControladorBase
    {
        private TabelaCliente tabelaCliente;
        private IRepositorioEnderecoOrm repositorioEndereco;
        private IRepositorioClienteOrm repositorioCliente;

        public ControladorCliente(IRepositorioEnderecoOrm repositorioEndereco, IRepositorioClienteOrm repositorioCliente)
        {
            this.tabelaCliente = new TabelaCliente();
            this.repositorioCliente = repositorioCliente;
            this.repositorioEndereco = repositorioEndereco;
            CarregarItens();
        }
        public override string ToolTipInserir => "Cadastrar Cliente";

        public override string ToolTipEditar => "Editar Cliente";

        public override string ToolTipExcluir => "Excluir Cliente";

        public override void CarregarItens()
        {
            tabelaCliente.AtualizarRegistros(repositorioCliente.SelecionarTodos());
        }

        public override void Editar()
        {
            int idSelecionado = tabelaCliente.ObterIdSelecionado();

            var cliente = repositorioCliente.SelecionarPorId(idSelecionado);

            var telaCliente = new TelaClienteForm(repositorioEndereco, cliente);

            var result = telaCliente.ShowDialog();

            if (result == DialogResult.OK)
            {
                repositorioCliente.Editar(telaCliente.cliente);
                CarregarItens();
            }
        }

        public override void Excluir()
        {
            int idSelecionado = tabelaCliente.ObterIdSelecionado();

            var cliente = repositorioCliente.SelecionarPorId(idSelecionado);

            repositorioCliente.Excluir(cliente);

            CarregarItens();
        }

        public override void Inserir()
        {
            TelaClienteForm telaCliente = new TelaClienteForm(repositorioEndereco);

            var result = telaCliente.ShowDialog();

            if(result == DialogResult.OK)
            {
                repositorioCliente.Inserir(telaCliente.cliente);
                CarregarItens();
            }
        }

        public override UserControl ObterTabela()
        {
            if (tabelaCliente == null)
                this.tabelaCliente = new TabelaCliente();

            return tabelaCliente;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Clientes";
        }

        public override void Pesquisar(string texto)
        {
            if (texto.Length > 0)
                tabelaCliente.AtualizarRegistros(repositorioCliente.Pesquisar(texto));
            else
                return;
        }
    }
}

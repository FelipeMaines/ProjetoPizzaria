using ProjetoPizzaria.Compartilhado;
using ProjetoPizzaria.infra.ModuloValor;
using ProjetoPizzaria.ModuloValores;
using ProjetoPizzariaDominio.ModuloProduto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPizzaria.ModuloProduto
{
    public class ControladorProduto : ControladorBase
    {
        private TabelaProduto tabelaProduto;
        private IRepositorioProdutoOrm repositorioProdutoOrm;

        public ControladorProduto(IRepositorioProdutoOrm repositorioProdutoOrm)
        {
            this.repositorioProdutoOrm = repositorioProdutoOrm;
            tabelaProduto = new TabelaProduto();
        }

        public override string ToolTipInserir => "Inserir Produto";

        public override string ToolTipEditar => "Editar Produto";

        public override string ToolTipExcluir => "Excluir Produto";

        public override void CarregarItens()
        {
            tabelaProduto.AtualizarRegistros(repositorioProdutoOrm.SelecionarTodos());
        }

        public override void Editar()
        {
            var id = tabelaProduto.ObterIdSelecionado();

            var produto = repositorioProdutoOrm.SelecionarPorId(id);

            var telaProduto = new TelaProdutoForm(produto);

            var resultado = telaProduto.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                repositorioProdutoOrm.Editar(telaProduto.produto);

                CarregarItens();
            }
        }

        public override void Excluir()
        {
            Guid id = tabelaProduto.ObterIdSelecionado();

            var produto = repositorioProdutoOrm.SelecionarPorId(id);

            var result = MessageBox.Show("Deseja Excluir o item {i}", produto.id.ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            repositorioProdutoOrm.Excluir(produto);

            CarregarItens();
        }

        public override void Inserir()
        {
            var telaProduto = new TelaProdutoForm();

            var resultado = telaProduto.ShowDialog();

            if(resultado == DialogResult.OK)
            {
                repositorioProdutoOrm.Inserir(telaProduto.produto);

                CarregarItens();
            }
        }

        public override UserControl ObterTabela()
        {
            if (tabelaProduto == null)
                tabelaProduto = new TabelaProduto();

            return tabelaProduto;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadatro de produto!";
        }

        public override void Pesquisar(string texto)
        {
            MessageBox.Show("Nao implementado!");
        }
    }
}

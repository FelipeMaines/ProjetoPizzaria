using MySqlX.XDevAPI.Common;
using ProjetoPizzaria.Compartilhado;
using ProjetoPizzariaDominio.ModuloValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPizzaria.ModuloValores
{
    public class ControladorValores : ControladorBase
    {
        IRepositorioValorOrm repositorioValorOrm;
        private TabelaValores tabelaValores;

        public ControladorValores(IRepositorioValorOrm repositorioValorOrm)
        {
            this.repositorioValorOrm = repositorioValorOrm;
            this.tabelaValores = new TabelaValores();
        }

        public override string ToolTipInserir => "Cadastrar Valores";

        public override string ToolTipEditar => "Editar Valores";

        public override string ToolTipExcluir => "Excluir Valores";

        public override void CarregarItens()
        {
            var lista = repositorioValorOrm.SelecionarTodos();

            tabelaValores.AtualizarRegistros(lista);
        }

        public override void Editar()
        {
            var id = tabelaValores.ObterIdSelecionado();

            var valor = repositorioValorOrm.SelecionarPorId(id);

            var telaValor = new TelaValorForm(valor);

            var result = telaValor.ShowDialog();

            if (result == DialogResult.OK)
            {
                repositorioValorOrm.Editar(telaValor.valor);

                CarregarItens();
            }
        }

        public override void Excluir()
        {
            Guid id = tabelaValores.ObterIdSelecionado();

            var valor = repositorioValorOrm.SelecionarPorId(id);

            var result = MessageBox.Show("Deseja Excluir o item {i}", valor.id.ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            repositorioValorOrm.Excluir(valor);

            CarregarItens();
        }

        public override void Inserir()
        {
            TelaValorForm telaValoresForm = new TelaValorForm();

            var result = telaValoresForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                repositorioValorOrm.Inserir(telaValoresForm.valor);

                CarregarItens();
            }
        }

        public override UserControl ObterTabela()
        {
            if (tabelaValores == null)
                tabelaValores = new TabelaValores();

            return tabelaValores;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Valores";
        }

        public override void Pesquisar(string texto)
        {
            throw new NotImplementedException();
        }
    }
}

using ProjetoPizzaria.Compartilhado;
using ProjetoPizzaria.ModuloProdutos;
using ProjetoPizzaria.ModuloSabor;
using ProjetoPizzariaDominio.ModuloIgrediente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPizzaria.ModuloIgrediente
{
    public class ControladorIgrediente : ControladorBase
    {
        IRepositorioIgrediente repositorioIgrediente;
        private TabelaIgredientes tabelaIgredientes;
        public ControladorIgrediente(IRepositorioIgrediente repositorioIgrediente)
        {
            this.tabelaIgredientes = new TabelaIgredientes();
            this.repositorioIgrediente = repositorioIgrediente;
            CarregarItens();
        }

        public override string ToolTipInserir => "Cadastrar Igrediente";

        public override string ToolTipEditar => "Editar Igrediente";

        public override string ToolTipExcluir => "Excluir Igrediente";

        public override void CarregarItens()
        {
            tabelaIgredientes.AtualizarRegistros(repositorioIgrediente.SelecionarTodos());
        }

        public override void Editar()
        {
            int idIgrediente = tabelaIgredientes.ObterIdSelecionado();

            var igrediente = repositorioIgrediente.SelecionarPorId(idIgrediente);

            var telaIgrediente = new TelaIgredienteForm(igrediente);

            if(telaIgrediente.ShowDialog() == DialogResult.OK)
            {
                repositorioIgrediente.Editar(telaIgrediente.PegarIgrendiente(true));
            }

            tabelaIgredientes.AtualizarRegistros(repositorioIgrediente.SelecionarTodos());
        }

        public override void Excluir()
        {
            int idIgrediente = tabelaIgredientes.ObterIdSelecionado();

            var igrediente = repositorioIgrediente.SelecionarPorId(idIgrediente);

            var resultado = MessageBox.Show($"Deseja Realmente excluir o item {igrediente.nome}", "Excluir", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if(resultado == DialogResult.OK)
            {
                repositorioIgrediente.Excluir(igrediente);
                tabelaIgredientes.AtualizarRegistros(repositorioIgrediente.SelecionarTodos());
            }
            else
                return;
        }

        public override void Inserir()
        {
            var telaIgrediente = new TelaIgredienteForm();

            if(telaIgrediente.ShowDialog() == DialogResult.OK)
            {
                repositorioIgrediente.Inserir(telaIgrediente.igrediente);
            }

            tabelaIgredientes.AtualizarRegistros(repositorioIgrediente.SelecionarTodos());
        }

        public override UserControl ObterTabela()
        {
            if (tabelaIgredientes == null)
                tabelaIgredientes = new TabelaIgredientes();

            return tabelaIgredientes;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Igredientes";
        }

        public override void Pesquisar(string texto)
        {
            var lista = repositorioIgrediente.Pesquisar(texto);

            tabelaIgredientes.AtualizarRegistros(lista);
        }
    }
}

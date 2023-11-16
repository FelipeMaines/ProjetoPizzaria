using ProjetoPizzaria.Compartilhado;
using ProjetoPizzaria.infra.ModuloEndereco;
using ProjetoPizzaria.infra.ModuloFuncionario;
using ProjetoPizzaria.ModuloFuncionario;
using ProjetoPizzaria.ModuloIgrediente;
using ProjetoPizzaria.ModuloValores;
using ProjetoPizzariaDominio.ModuloIgrediente;
using ProjetoPizzariaDominio.ModuloSabor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPizzaria.ModuloSabor
{
    public class ControladorSabores : ControladorBase
    {
        private IRepositorioSaborOrm repositorioSabor;
        private IRepositorioIngredienteOrm repositorioIgrediente;
        private TabelaSabores tabelaSabores;

        public ControladorSabores(IRepositorioSaborOrm repositorioSabor, IRepositorioIngredienteOrm repositorioIgrediente)
        {
            this.repositorioSabor = repositorioSabor;
            this.repositorioIgrediente = repositorioIgrediente;
            this.tabelaSabores = new TabelaSabores();

            CarregarItens();
        }
        public override string ToolTipInserir => "Cadastrar Sabores";

        public override string ToolTipEditar => "Editar Sabores";

        public override string ToolTipExcluir => "Excluir Sabores";

        public override void CarregarItens()
        {
            tabelaSabores.AtualizarRegistros(repositorioSabor.SelecionarTodos());
        }

        public override void Editar()
        {
            Guid idSelecionado = tabelaSabores.ObterIdSelecionado();

            var sabor = repositorioSabor.SelecionarPorId(idSelecionado);

            var telaSabor = new TelaSaborForm(repositorioIgrediente);

            telaSabor.SetarTela(sabor);

            var result = telaSabor.ShowDialog();

            if (result == DialogResult.OK)
            {
                repositorioSabor.Editar(telaSabor.sabor);
                CarregarItens();
            }
        }

        public override void Excluir()
        {
            Guid idIgrediente = tabelaSabores.ObterIdSelecionado();

            var sabor = repositorioSabor.SelecionarPorId(idIgrediente);

            var resultado = MessageBox.Show($"Deseja Realmente excluir o item {sabor.Descricao}", "Excluir", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (resultado == DialogResult.OK)
            {
                repositorioSabor.Excluir(sabor);
                tabelaSabores.AtualizarRegistros(repositorioSabor.SelecionarTodos());
            }
            else
                return;
        }

        public override void Inserir()
        {
            var telaValoresForm = new TelaSaborForm(repositorioIgrediente);

            telaValoresForm.SetarTela(new Sabor());

            var result = telaValoresForm.ShowDialog();

            if(result == DialogResult.OK)
            {
                repositorioSabor.Inserir(telaValoresForm.sabor);
                CarregarItens();
            }
        }

        public override UserControl ObterTabela()
        {
            if(tabelaSabores == null)
                tabelaSabores = new TabelaSabores();

            return tabelaSabores;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Sabores";
        }

        public override void Pesquisar(string texto)
        {
            throw new NotImplementedException();
        }
    }
}

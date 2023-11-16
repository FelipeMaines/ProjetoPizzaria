using ProjetoPizzaria.Compartilhado;
using ProjetoPizzariaDominio.ModuloEndereco;
using ProjetoPizzariaDominio.ModuloFuncionario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPizzaria.ModuloFuncionario
{
    public class ControladorFuncionario : ControladorBase
    {
        private TabelaFuncionario tabelaFuncionario;
        private IRepositorioFuncionarioOrm repositorioFuncionario;

        private IRepositorioEnderecoOrm repositorioEndereco;
        public override string ToolTipInserir => "Cadastrar Funcionario";

        public override string ToolTipEditar => "Editar Funcionario";

        public override string ToolTipExcluir => "Excluir Funcionario";

        public ControladorFuncionario(IRepositorioEnderecoOrm repositorioEndereco, IRepositorioFuncionarioOrm repositorioFuncionario)
        {
            tabelaFuncionario = new TabelaFuncionario();
            this.repositorioEndereco = repositorioEndereco;
            this.repositorioFuncionario = repositorioFuncionario;
            CarregarItens();
        }

        public override void CarregarItens()
        {
            var funcionarios = new List<Funcionario>();
            var enderecos = new List<Endereco>();

            

            tabelaFuncionario.AtualizarRegistros(repositorioFuncionario.SelecionarTodos());
        }

        public override void Editar()
        {
            Guid idSelecionado = tabelaFuncionario.ObterIdSelecionado();

            var funcionario = repositorioFuncionario.SelecionarPorId(idSelecionado);

            var telaFuncionario = new TelaFuncionarioForm(repositorioEndereco);

            telaFuncionario.SetarTela(funcionario);

            var result = telaFuncionario.ShowDialog();

            if(result == DialogResult.OK)
            {
                repositorioFuncionario.Editar(telaFuncionario.funcionario);
                CarregarItens();
            }
        }

        public override void Excluir()
        {
            Guid idSelecionado = tabelaFuncionario.ObterIdSelecionado();

            var funcionario = repositorioFuncionario.SelecionarPorId(idSelecionado);

            repositorioFuncionario.Excluir(funcionario);

            CarregarItens();
        }

        public override void Inserir()
        {
            TelaFuncionarioForm telaFuncionarioForm = new TelaFuncionarioForm(repositorioEndereco);

            telaFuncionarioForm.SetarTela(new Funcionario());

            var result = telaFuncionarioForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                repositorioFuncionario.Inserir(telaFuncionarioForm.funcionario);
                CarregarItens();
            }
        }

        public override UserControl ObterTabela()
        {
            if(this.tabelaFuncionario == null)
                tabelaFuncionario = new TabelaFuncionario();

            CarregarItens();

            return tabelaFuncionario;
        }

        public override string ObterTipoCadastro() => "Cadastro de Funcionario";

        public override void Pesquisar(string texto)
        {
            throw new NotImplementedException();
        }
    }
}

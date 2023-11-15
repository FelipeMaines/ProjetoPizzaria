using ProjetoPizzaria.Compartilhado;
using ProjetoPizzaria.ModuloCliente;
using ProjetoPizzariaDominio.ModuloEndereco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPizzaria.ModuloCep
{
    public class ControladorCep : ControladorBase
    {
        private TabelaCep tabelaCep;
        private IRepositorioEnderecoOrm repositorioEndereco;

        public ControladorCep(IRepositorioEnderecoOrm repositorioEndereco)
        {
            this.tabelaCep = new TabelaCep();
            this.repositorioEndereco = repositorioEndereco;
            CarregarItens();
        }
        public override string ToolTipInserir => "Cadastrar de Cep";

        public override string ToolTipEditar => "Editar Cep";

        public override string ToolTipExcluir => "Excluir Cep";

        public override void CarregarItens()
        {
            this.tabelaCep.AtualizarRegistros(repositorioEndereco.SelecionarTodos());
        }

        public override void Editar()
        {
            throw new NotImplementedException();
        }

        public override void Excluir()
        {
            throw new NotImplementedException();
        }

        public override void Inserir()
        {
            TelaCepForm telaCepForm = new TelaCepForm();

            var result = telaCepForm.ShowDialog();

            if(result == DialogResult.OK)
            {
                repositorioEndereco.Inserir(telaCepForm.enderco);
            }
        }

        public override UserControl ObterTabela()
        {
            if (tabelaCep == null)
                tabelaCep = new TabelaCep();

            return tabelaCep;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Cep";
        }

        public override void Pesquisar(string texto)
        {
            throw new NotImplementedException();
        }
    }
}

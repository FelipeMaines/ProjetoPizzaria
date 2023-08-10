using ProjetoPizzaria.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPizzaria.ModuloFuncionario
{
    public class ControladorFuncionario : ControladorBase
    {
        TabelaFuncionario tabelaFuncionario;
        public override string ToolTipInserir => "Cadastrar Funcionario";

        public override string ToolTipEditar => "Editar Funcionario";

        public override string ToolTipExcluir => "Excluir Funcionario";

        public ControladorFuncionario()
        {
            
        }

        public override void CarregarItens()
        {
            MessageBox.Show("Nao implementado");
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
            TelaFuncionarioForm telaFuncionarioForm = new TelaFuncionarioForm();

            telaFuncionarioForm.ShowDialog();
        }

        public override UserControl ObterTabela()
        {
            if(this.tabelaFuncionario == null)
                tabelaFuncionario = new TabelaFuncionario();

            CarregarItens();

            return tabelaFuncionario;
        }

        public override string ObterTipoCadastro() => "Cadastro de Funcionario";
        
    }
}

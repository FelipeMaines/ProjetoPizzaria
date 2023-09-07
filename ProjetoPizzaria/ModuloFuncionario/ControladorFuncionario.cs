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
        /// <summary>
        ///     override da classe ControladorBase, onde correga os itens cadastrados no sistema
        /// </summary>
        public override void CarregarItens()
        {
            MessageBox.Show("Nao implementado");
        }
        /// <summary>
        ///     override da classe ControladorBase, método para editar os itens já cadastrados no sistema
        /// </summary>
        public override void Editar()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        ///     override da classe ControladorBase, método para excluir os itens já cadastrados no sistema
        /// </summary>
        public override void Excluir()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        ///     override da classe ControladorBase, método para inseriros itens no sistema
        /// </summary>
        public override void Inserir()
        {
            TelaFuncionarioForm telaFuncionarioForm = new TelaFuncionarioForm();

            telaFuncionarioForm.ShowDialog();
        }
        /// <summary>
        ///     override da classe ControladorBase, método para pegar a tebela/grid atual
        /// </summary>
        public override UserControl ObterTabela()
        {
            if(this.tabelaFuncionario == null)
                tabelaFuncionario = new TabelaFuncionario();

            CarregarItens();

            return tabelaFuncionario;
        }
        /// <summary>
        ///     override da classe ControladorBase, método para pegar qual sera o item a ser cadastado/editado/excluido de cadastro
        /// </summary>
        public override string ObterTipoCadastro() => "Cadastro de Funcionario";
        
    }
}
